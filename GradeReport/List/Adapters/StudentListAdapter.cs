using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.List.Adapters
{
    public class StudentListAdapter : ListAdapter
    {
        public override object[] EntityToRow(object entity)
        {
            var student = (Student)entity;
            return new object[] {
                student.Guid,
                student.Name,
            };
        }

        public override void CreateColumns(DataGridViewColumnCollection columns)
        {
            AddCol(columns, "Идентификатор", false);
            AddCol(columns, "ФИО");
        }

        public override bool IsRowBelongEntity(DataGridViewRow row, object entity)
        {
            var student = (Student)entity;
            return (Guid)row.Cells[1].Value == student.Guid;
        }

        public override string EntityToString(object entity)
        {
            return ((Student)entity).Name;
        }
    }
}
