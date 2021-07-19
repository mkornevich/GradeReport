using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.List.Adapters
{
    public class SubjectListAdapter : ListAdapter
    {
        public override object[] EntityToRow(object entity)
        {
            var subject = (Subject)entity;
            return new object[] {
                subject.Guid,
                subject.Name,
                subject.ShortName,
            };
        }

        public override void CreateColumns(DataGridViewColumnCollection columns)
        {
            AddCol(columns, "Идентификатор", false);
            AddCol(columns, "Название");
            AddCol(columns, "Короткое название");
        }

        public override bool IsRowBelongEntity(DataGridViewRow row, object entity)
        {
            var subject = (Subject)entity;
            return (Guid)row.Cells[1].Value == subject.Guid;
        }

        public override string EntityToString(object entity)
        {
            return ((Subject)entity).Name;
        }
    }
}
