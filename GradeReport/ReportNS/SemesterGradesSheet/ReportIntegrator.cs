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

            

            //var rowParams = rows[0];
            //rowParams["SemesterGrade"] = rowParams["SemesterGrade"] + " (" + rowParams["SemesterGradeText"] + ")";
            //var row = sheet.GetRow(FirstRow);
            //Parametrize(row, rowParams);

            //var cell_1 = sheet.GetRow(FirstRow + 1).GetCell(0);
            //var cell_2 = sheet.GetRow(FirstRow + 2).GetCell(1);



            //var rts_1 = (XSSFRichTextString)sheet.GetRow(FirstRow + 1).GetCell(0).RichStringCellValue;
            //var rts_2 = (XSSFRichTextString)sheet.GetRow(FirstRow + 2).GetCell(1).RichStringCellValue;

            //rts_2.Append("---", new XSSFFont());

            //var n = new CT_Rst();



            //var rst_1 = rts_1.GetCTRst();
            //var rst_2 = rts_2.GetCTRst();


            //var d = new CT_Rst();
            //d.Set(rst_2);
            //d.r = rst_2.r.Select(relt => new CT_RElt() { rPr = relt.rPr, t = relt.t }).ToList();

            //d.r[1].t = "dddd";

            //cell_2.SetCellValue(new XSSFRichTextString(d));






            //rst_2.();

            //rst_2.XmlText

            for (int i = 0; i < rows.Count; i++)
            {
                var rowParams = rows[i];
                rowParams["SemesterGrade"] = rowParams["SemesterGrade"] + " (" + rowParams["SemesterGradeText"] + ")";
                var row = sheet.GetRow(FirstRow + i);
                Parametrize(row, rowParams);

                //outRow.GetCell(0).SetCellValue(row["StudentIndex"].ToString());
                //outRow.GetCell(1).SetCellValue(row["StudentName"].ToString());
                //outRow.GetCell(2).SetCellValue(row["OKRAvg"].ToString());
                //outRow.GetCell(3).SetCellValue(row["LPR"].ToString());
                //outRow.GetCell(4).SetCellValue(row["CourseGrade"].ToString());
                //outRow.GetCell(5).SetCellValue(row["SemesterGrade"].ToString() + " (" + row["SemesterGradeText"].ToString() + ")");
            }

            // Parametrize(sheet, output.Params);
        }
    }
}
