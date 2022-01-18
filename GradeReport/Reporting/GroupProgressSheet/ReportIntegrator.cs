using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using NPOI.XSSF.UserModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.GroupProgressSheet
{
    public class ReportIntegrator : BaseReportIntegrator
    {
        private XSSFSheet sheet;

        protected override void DoIntegrate(BaseOutputModel baseOutputModel, Document document)
        {
            var model = (OutputModel)baseOutputModel;
            var table = model.Table;

            var tableSheet = (XSSFSheet)document.Workbook.GetSheetAt(0);
            var paramsSheet = (XSSFSheet)document.Workbook.GetSheetAt(1);

            sheet = tableSheet;

            var studentRows = table.Rows;
            var subjectCols = table.Columns.FindAllByGroup("Subject");
            var examSubjectCols = subjectCols.FindAll(col =>  (bool)col.Params["IsExam"]);
            var semesterSubjectCols = subjectCols.FindAll(col =>  !(bool)col.Params["IsExam"]);


            

            var startCol = 3;



            //DocumentUtils.InsertColumns(sheet, startCol, 5, Direction.Left);

            DocumentUtils.LeftShiftColumns(sheet, startCol, 3);


        }
    }
}
