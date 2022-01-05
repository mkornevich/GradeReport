using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.SemesterGradesSheet
{
    public class Validator : BaseValidator
    {
        public Validator(Project project) : base(project)
        {
        }

        public override void DoValidate(BaseInputModel inputModel)
        {
            var input = (InputModel)inputModel;

            Notes.ErrorIf(input.Group == null, "Не выбрана группа");
            Notes.ErrorIf(input.Semester == null, "Не выбран семестр");
            Notes.ErrorIf(input.Subject == null, "Не выбран предмет");
        }
    }
}
