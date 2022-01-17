using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.GroupProgressSheet
{
    public class ReportIntegrator : BaseReportIntegrator
    {
        protected override void DoIntegrate(BaseOutputModel baseOutputModel, Document document)
        {
            var model = (OutputModel)baseOutputModel;

            var sheet = (XSSFSheet)document.Workbook.GetSheetAt(0);




            Parametrize(sheet, model.Params);
        }
    }
}
