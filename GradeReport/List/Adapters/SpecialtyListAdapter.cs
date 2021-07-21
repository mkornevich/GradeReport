using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.List.Adapters
{
    public class SpecialtyListAdapter : ListAdapter
    {
        public override object[] EntityToRow(object entity)
        {
            var specialty = (Specialty)entity;
            return new object[] {
                specialty.Guid,
                specialty.Qualification.Name,
                specialty.Name,
                specialty.Code,
            };
        }

        public override void CreateColumns(DataGridViewColumnCollection columns)
        {
            AddCol(columns, "Идентификатор", false);
            AddCol(columns, "Квалификация");
            AddCol(columns, "Специальность");
            AddCol(columns, "Шифр специальности");
        }

        public override bool IsRowBelongEntity(DataGridViewRow row, object entity)
        {
            var specialty = (Specialty)entity;
            return (Guid)row.Cells[1].Value == specialty.Guid;
        }

        public override string EntityToString(object entity)
        {
            var specialty = (Specialty)entity;
            return $"{specialty.Qualification.Name} > {specialty.Name}, {specialty.Code}";
        }
    }
}
