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

            

            var sheet = document.Workbook.GetSheetAt(0);


            var value = (XSSFRichTextString)sheet.GetRow(0).GetCell(0).RichStringCellValue;

            var rst = value.GetCTRst();

            rst.r.ForEach(it => it.t = it.t.Replace("БРЕСТС", "ПИНС"));

            //rst.

            var xml = rst.XmlText.Replace("БРЕСТС", "ПИНС");

            

            //rst.XmlText = xml;

            value.GetCTRst().Set(rst);

            

            sheet.ShiftRows(11, sheet.LastRowNum, output.Table.Count - 1, true, false);

            for (int i = 0; i < output.Table.Count - 1; i++)
            {
                sheet.CopyRow(10, 11 + i);
            }

            for (int i = 0; i < rows.Count; i++)
            {
                var row = rows[i];
                var outRow = sheet.GetRow(FirstRow + i);

                outRow.GetCell(0).SetCellValue(row["StudentIndex"].ToString());
                outRow.GetCell(1).SetCellValue(row["StudentName"].ToString());
                outRow.GetCell(2).SetCellValue(row["OKRAvg"].ToString());
                outRow.GetCell(3).SetCellValue(row["LPR"].ToString());
                outRow.GetCell(4).SetCellValue(row["CourseGrade"].ToString());
                outRow.GetCell(5).SetCellValue(row["SemesterGrade"].ToString() + " (" + row["SemesterGradeText"].ToString() + ")");
            }
        }
    }
}
