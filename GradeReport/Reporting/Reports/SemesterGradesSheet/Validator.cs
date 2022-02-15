using GradeReport.ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.SemesterGradesSheet
{
    public class Validator : BaseValidator
    {
        public override void DoValidate(BaseInputModel baseInputModel)
        {
            var input = (InputModel)baseInputModel;

            Notes.ErrorIf(input.Group == null, "Не выбрана группа");
            Notes.ErrorIf(input.Semester == null, "Не выбран семестр");
            Notes.ErrorIf(input.Subject == null, "Не выбран предмет");

            if (Notes.ErrorCount > 0) return;

            Notes.ErrorIf(
                !HasStudents(input), 
                "Кол-во студентов должно быть больше нуля", 
                "Возможно вам стоит указать ваших студентов.");
        }

        private bool HasStudents(InputModel input)
        {
            IEnumerable<Student> students;

            if (input.IsOnlyMyStudents)
            {
                students = Project.MyStudentRefs
                    .FindAll(msr => msr.SubjectGuid == input.Subject.Guid && msr.Semester.Guid == input.Semester.Guid)
                    .Select(msr => msr.Student);
            }
            else
            {
                students = Project.SemesterStudentRefs
                    .FindAll(ssr => ssr.SemesterGuid == input.Semester.Guid)
                    .Select(ssr => ssr.Student);
            }

            return students.Count() > 0;
        }
    }
}
