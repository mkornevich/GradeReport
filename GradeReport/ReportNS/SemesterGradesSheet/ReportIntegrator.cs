using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ReportNS.SemesterGradesSheet
{
    public class ReportIntegrator : BaseReportIntegrator
    {
        private const int FirstRow = 10;
        protected override void DoIntegrate(BaseOutputModel model, Document document)
        {
            var output = (OutputModel)model;
            var rows = output.Table;

            var sheet = (XSSFSheet)document.Workbook.GetSheetAt(0);

            sheet.ShiftRows(11, sheet.LastRowNum, output.Table.Count - 1, true, false);

            for (int i = 0; i < output.Table.Count - 1; i++)
            {
                sheet.CopyRow(10, 11 + i);
            }

            for (int i = 0; i < rows.Count; i++)
            {
                var rowParams = rows[i];
                rowParams["SemesterGrade"] = rowParams["SemesterGrade"] + " (" + rowParams["SemesterGradeText"] + ")";
                var row = sheet.GetRow(FirstRow + i);
                Parametrize(row, rowParams);
            }

            Parametrize(sheet, output.Params);
        }
    }
}
