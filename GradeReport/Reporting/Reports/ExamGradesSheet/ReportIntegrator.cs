using GradeReport.ProjectModel.Entities;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.ExamGradesSheet
{
    public class ReportIntegrator : BaseReportIntegrator
    {
        private const int FirstRow = 7;
        protected override void DoIntegrate(BaseOutputModel baseOutputModel, Document document)
        {
            var model = (OutputModel)baseOutputModel;
            var rows = model.TableRows;
            var sheet = (XSSFSheet)document.Workbook.GetSheetAt(0);

            DocumentUtils.InsertRows(sheet, FirstRow, rows.Count - 1);

            for (int i = 0; i < rows.Count; i++)
            {
                var srcRow = rows[i];
                srcRow["SemesterGrade"] = GradeValue.ToString(srcRow["SemesterGrade"]);
                srcRow["ExamGrade"] = GradeValue.ToString(srcRow["ExamGrade"], "v (d)");
                var row = sheet.GetRow(FirstRow + i);
                Parametrize(row, srcRow);
            }

            Parametrize(sheet, model.Params);
        }
    }
}
