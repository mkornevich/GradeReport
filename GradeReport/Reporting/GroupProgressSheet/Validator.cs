using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.GroupProgressSheet
{
    public class Validator : BaseValidator
    {
        public override void DoValidate(BaseInputModel baseInputModel)
        {
            var input = (InputModel)baseInputModel;

            Notes.ErrorIf(input.Group == null, "Не выбрана группа");
            Notes.ErrorIf(input.Semester == null, "Не выбран семестр");
        }
    }
}
