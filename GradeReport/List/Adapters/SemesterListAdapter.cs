using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.List.Adapters
{
    public class SemesterListAdapter : ListAdapter
    {
        public override void CreateColumns(DataGridViewColumnCollection columns)
        {
            AddCol(columns, "Идентификатор", false);
            AddCol(columns, "Группа");
            AddCol(columns, "Курс");
            AddCol(columns, "Семестр");
        }

        public override object[] EntityToRow(object entity)
        {
            var semester = (Semester)entity;
            var course = semester.Course;
            var group = course.Group;
            return new object[] {
                semester.Guid,
                group.Name,
                course.Number,
                semester.CourseHalf,
            };
        }

        public override string EntityToString(object entity)
        {
            var semester = (Semester)entity;
            var course = semester.Course;
            var group = course.Group;
            return $"группа {group.Name} > курс {course.Number} > семестр {semester.CourseHalf}";
        }

        public override bool IsRowBelongEntity(DataGridViewRow row, object entity)
        {
            var semester = (Semester)entity;
            return (Guid)row.Cells[1].Value == semester.Guid;
        }
    }
}
