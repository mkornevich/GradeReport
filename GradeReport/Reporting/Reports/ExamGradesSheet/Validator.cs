using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.ExamGradesSheet
{
    public class Validator : BaseValidator
    {
        public override void DoValidate(BaseInputModel baseInputModel)
        {
            var input = (InputModel)baseInputModel;

            Notes.ErrorIf(input.Group == null, "Не выбрана группа");
            Notes.ErrorIf(input.Semester == null, "Не выбран семестр");
            Notes.ErrorIf(input.Subject == null, "Не выбран предмет");
        }
    }
}
