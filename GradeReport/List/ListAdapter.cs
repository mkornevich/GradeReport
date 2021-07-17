using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.List
{
    public abstract class ListAdapter
    {
        public ListForm Form { get; set; }

        protected DataGridViewTextBoxColumn AddCol(DataGridViewColumnCollection columns, string text, bool visible = true)
        {
            var column = new DataGridViewTextBoxColumn() { HeaderText = text, Visible = visible };
            columns.Add(column);
            return column;
        }

        public virtual string GetChooserText()
        {
            var selected = Form.SelectedEntities;

            if (selected.Count == 0)
            {
                return "Не выбрано";
            } 
            else if (selected.Count > 0 && selected.Count < 6)
            {
                return string.Join(", ", selected.Select(e => EntityToString(e)));
            } 
            else
            {
                return "Выбрано " + selected.Count + " из " + Form.Entities.Count;
            }
        }

        public abstract string EntityToString(object entity);

        public abstract object[] EntityToRow(object entity);

        public abstract void CreateColumns(DataGridViewColumnCollection columns);

        public abstract bool IsRowBelongEntity(DataGridViewRow row, object entity);
    }
}
