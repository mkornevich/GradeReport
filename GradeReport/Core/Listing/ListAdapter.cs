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

        protected DataGridViewTextBoxColumn AddCol(DataGridViewColumnCollection columns, string text, bool visible = true)
        {
            var column = new DataGridViewTextBoxColumn() { HeaderText = text, Visible = visible };
            columns.Add(column);
            return column;
        }

        public abstract object[] EntityToRow(object entity);

        public abstract void CreateColumns(DataGridViewColumnCollection columns);

        public abstract bool IsRowBelongEntity(DataGridViewRow row, object entity);
    }
}
