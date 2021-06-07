using GradeReport.EntityModules.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Listing
{
    public abstract class ListAdapter
    {
        public ListForm Form { get; set; }

        public bool IsSingleSelection { get; set; } = true;

        public event Action SelectionChanged;

        private List<object> _entities;

        public List<object> Entities
        {
            get => _entities;
            set
            {
                _entities = value;
                EntitiesToTable();
                UpdateTableSelection();
            }
        }

        private List<object> _selectedEntities;

        public List<object> SelectedEntities
        {
            get
            {
                return Entities.FindAll(entity =>
                {
                    bool isSelected = false;

                    foreach (DataGridViewRow row in Form.table.Rows)
                    {
                        if (IsRowBelongEntity(row, entity) && (bool)row.Cells[0].Value == true)
                        {
                            isSelected = true;
                            break;
                        }
                    }

                    return isSelected;
                });
            }
            set
            {
                _selectedEntities = value;
                UpdateTableSelection();
            }
        }

        internal void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (IsSingleSelection)
                {
                    foreach(DataGridViewRow row in Form.table.Rows)
                    {
                        row.Cells[0].Value = false;
                    }
                }
                
                Form.table.Rows[e.RowIndex].Cells[0].Value = !(bool)Form.table.Rows[e.RowIndex].Cells[0].Value;
                OnSelectionChanged();
            }
            
        }

        private void UpdateTableSelection()
        {
            foreach (DataGridViewRow row in Form.table.Rows)
            {
                if (_selectedEntities == null)
                {
                    row.Cells[0].Value = false;
                    continue;
                }

                row.Cells[0].Value = _selectedEntities.Exists(e => IsRowBelongEntity(row, e));
            }
        }

        private void EntitiesToTable()
        {
            Form.table.Columns.Clear();
            Form.table.Columns.Add(new DataGridViewCheckBoxColumn() { Width = 20 });
            CreateColumns(Form.table.Columns);

            Form.table.Rows.Clear();
            foreach (var entity in _entities)
            {
                var cells = EntityToObjectArray(entity);
                cells = new object[] { false }.Concat(cells).ToArray();
                Form.table.Rows.Add(cells);
            }
        }

        private void OnSelectionChanged() => SelectionChanged?.Invoke();

        protected virtual object[] EntityToObjectArray(object entity)
        {
            var subject = (Subject)entity;
            return new object[] {subject.Guid, subject.Name, subject.ShortName, subject.Include ? "Да" : "Нет" };
        }

        protected virtual void CreateColumns(DataGridViewColumnCollection columns)
        {
            columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Идентификатор", Visible = false });
            columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Название" });
            columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Короткое название" });
            columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Включен ли" });
        }

        protected virtual bool IsRowBelongEntity(DataGridViewRow row, object entity)
        {
            var subject = (Subject)entity;
            return (Guid)row.Cells[1].Value == subject.Guid;
        }
    }
}
