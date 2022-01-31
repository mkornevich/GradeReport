using GradeReport.ProjectModel.Entities;
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

            DocumentUtils.InsertRows(sheet, FirstRow, rows.Count - 1);

            for (int i = 0; i < rows.Count; i++)
            {
                var srcRow = rows[i];
                srcRow["SemesterGrade"] = GradeValue.ToString(srcRow["SemesterGrade"], "  v (d)");
                srcRow["CourseGrade"] = GradeValue.ToString(srcRow["CourseGrade"]);
                var row = sheet.GetRow(FirstRow + i);
                Parametrize(row, srcRow);
            }

            Parametrize(sheet, model.Params);
        }
    }
}
