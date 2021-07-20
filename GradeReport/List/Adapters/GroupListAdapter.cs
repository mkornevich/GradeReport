using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.List.Adapters
{
    public class GroupListAdapter : ListAdapter
    {
        public override void CreateColumns(DataGridViewColumnCollection columns)
        {
            AddCol(columns, "Идентификатор", false);
            AddCol(columns, "Название");
        }

        public override object[] EntityToRow(object entity)
        {
            var group = (Group)entity;
            return new object[] {
                group.Guid,
                group.Name,
            };
        }

        public override string EntityToString(object entity)
        {
            return ((Group)entity).Name;
        }

        public override bool IsRowBelongEntity(DataGridViewRow row, object entity)
        {
            var group = (Group)entity;
            return (Guid)row.Cells[1].Value == group.Guid;
        }
    }
}
