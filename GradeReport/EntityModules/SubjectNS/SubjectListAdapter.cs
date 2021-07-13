using GradeReport.Core.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.SubjectNS
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
                subject.Include ? "Да" : "Нет",
            };
        }

        public override void CreateColumns(DataGridViewColumnCollection columns)
        {
            AddCol(columns, "Идентификатор", false);
            AddCol(columns, "Название");
            AddCol(columns, "Короткое название");
            AddCol(columns, "Учитывать");
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
