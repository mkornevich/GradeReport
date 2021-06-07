using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Listing
{
    public partial class ListForm : Form
    {
        private DialogResult _dialogResult = DialogResult.Cancel;

        private ListAdapter _adapter;

        public ListAdapter Adapter
        {
            get => _adapter;
            set
            {
                if (_adapter != null) _adapter.Form = null;
                _adapter = value;
                _adapter.Form = this;
            }
        }

        public SelectMode SelectMode { get; set; } = SelectMode.Multiple;

        private List<object> _entities;

        public List<object> Entities
        {
            get => _entities;
            set
            {
                _entities = value;
                EntitiesToTable();
                UpdateTableSelection();
                UpdateSelectionInfo();
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

                    foreach (DataGridViewRow row in Table.Rows)
                    {
                        if (_adapter.IsRowBelongEntity(row, entity) && (bool)row.Cells[0].Value == true)
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
                UpdateSelectionInfo();
            }
        }

        public event Action SelectionChanged;

        public ListForm()
        {
            InitializeComponent();

            actionStrip.OkAction.Click += OkAct;
            actionStrip.CancelAction.Click += CancelAct;
        }

        private void CancelAct(object sender, EventArgs e)
        {
            _dialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkAct(object sender, EventArgs e)
        {
            _dialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateTableSelection()
        {
            foreach (DataGridViewRow row in Table.Rows)
            {
                if (_selectedEntities == null)
                {
                    row.Cells[0].Value = false;
                    continue;
                }

                row.Cells[0].Value = _selectedEntities.Exists(e => _adapter.IsRowBelongEntity(row, e));
            }
        }

        private void EntitiesToTable()
        {
            Table.Columns.Clear();
            // selection column
            Table.Columns.Add(new DataGridViewCheckBoxColumn() { Width = 20 });
            _adapter.CreateColumns(Table.Columns);

            Table.Rows.Clear();
            foreach (var entity in _entities)
            {
                var cells = _adapter.EntityToRow(entity);
                cells = new object[] { false }.Concat(cells).ToArray();
                Table.Rows.Add(cells);
            }
        }

        private void OnSelectionChanged() => SelectionChanged?.Invoke();

        private void CellContentClickAct(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (SelectMode == SelectMode.Multiple)
                {
                    foreach (DataGridViewRow row in Table.Rows)
                    {
                        if (row.Index != e.RowIndex)
                            row.Cells[0].Value = false;
                    }
                }

                Table.Rows[e.RowIndex].Cells[0].Value = !(bool)Table.Rows[e.RowIndex].Cells[0].Value;

                UpdateSelectionInfo();
                OnSelectionChanged();
            }
        }

        private void UpdateSelectionInfo() => selectionInfoTB.Text = "Выделено " + SelectedEntities.Count + " из " + Entities.Count;

        public DialogResult ShowForResult()
        {
            actionStrip.Visible = true;
            ShowDialog();
            actionStrip.Visible = false;
            return _dialogResult;
        }
    }
}
