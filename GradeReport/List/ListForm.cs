using GradeReport.Common;
using GradeReport.Common.ActionNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.List
{
    public partial class ListForm : ActionForm
    {
        private ListAdapter _adapter;

        public ListAdapter Adapter => _adapter;

        public SelectMode SelectMode { get; set; } = SelectMode.Multiple;

        private List<object> _entities = new List<object>();

        public List<object> Entities
        {
            get => _entities;
            set
            {
                _entities = value;
                InstallEntitiesToTable();
                InstallSelectionToTable();
                UpdateSelectionTextInfo();
            }
        }

        private List<object> _selectedEntities = new List<object>();

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
                InstallSelectionToTable();
                OnSelectionChangedExternally();
            }
        }

        private Chooser _chooser;

        public Chooser Chooser
        {
            get => _chooser;
            set
            {
                if (_chooser != null)
                {
                    _chooser.ChooseClick -= ChooserClickAct;
                }
                _chooser = value;
                _chooser.ChooseClick += ChooserClickAct;
                _chooser.ChooseText = Adapter.GetChooserText();
            }
        }

        public event Action SelectionChangedInternally;

        public event Action SelectionChangedExternally;

        public event Action SelectionChanged
        {
            add
            {
                SelectionChangedInternally += value;
                SelectionChangedExternally += value;
            }
            remove
            {
                SelectionChangedInternally -= value;
                SelectionChangedExternally -= value;
            }
        }

        public ListForm(ListAdapter adapter)
        {
            InitializeComponent();

            _adapter = adapter;
            _adapter.Form = this;

            SelectionChanged += () =>
            {
                UpdateSelectionTextInfo();
                if (Chooser != null)
                    Chooser.ChooseText = _adapter.GetChooserText();
            };
        }

        private void ChooserClickAct(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void InstallSelectionToTable()
        {
            foreach (DataGridViewRow row in Table.Rows)
            {
                row.Cells[0].Value = _selectedEntities.Exists(e => _adapter.IsRowBelongEntity(row, e));
            }
        }

        private void InstallEntitiesToTable()
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

        private void OnSelectionChangedInternally() => SelectionChangedInternally?.Invoke();
        private void OnSelectionChangedExternally() => SelectionChangedExternally?.Invoke();

        private void CellContentClickAct(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (SelectMode == SelectMode.Single)
                {
                    foreach (DataGridViewRow row in Table.Rows)
                    {
                        if (row.Index != e.RowIndex)
                            row.Cells[0].Value = false;
                    }
                }

                Table.Rows[e.RowIndex].Cells[0].Value = !(bool)Table.Rows[e.RowIndex].Cells[0].Value;

                OnSelectionChangedInternally();
            }
        }

        private void UpdateSelectionTextInfo() => selectionInfoTB.Text = "Выделено " + SelectedEntities.Count + " из " + Entities.Count;

    }
}
