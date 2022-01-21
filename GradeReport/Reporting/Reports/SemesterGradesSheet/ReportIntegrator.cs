using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Reporting.Reports.SemesterGradesSheet
{
    public class ReportIntegrator : BaseReportIntegrator
    {
        private const int FirstRow = 10;
        protected override void DoIntegrate(BaseOutputModel baseOutputModel, Document document)
        {
            var model = (OutputModel)baseOutputModel;
            var rows = model.TableRows;
            var sheet = (XSSFSheet)document.Workbook.GetSheetAt(0);

            sheet.ShiftRows(FirstRow + 1, sheet.LastRowNum, rows.Count - 1, true, false);

            for (int i = 0; i < rows.Count - 1; i++)
            {
                sheet.CopyRow(FirstRow, FirstRow + 1 + i);
            }

            for (int i = 0; i < rows.Count; i++)
            {
                var rowParams = rows[i];
                var row = sheet.GetRow(FirstRow + i);
                Parametrize(row, rowParams);
            }

            Parametrize(sheet, model.Params);
        }
    }
}
