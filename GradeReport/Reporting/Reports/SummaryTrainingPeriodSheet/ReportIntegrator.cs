using GradeReport.Reporting.TableModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.SummaryTrainingPeriodSheet
{
    public class ReportIntegrator : BaseReportIntegrator
    {
        private const string Title = "Итоговые оценки и зачеты за {SemesterNumber} семестр";

        private OutputModel _model;
        private Table _table;
        private XSSFSheet _tableSheet;
        private XSSFSheet _paramsSheet;
        private List<Row> _studentRows;
        private List<Column> _subjectCols;
        private List<Column> _examSubjectCols;
        private List<Column> _semesterSubjectCols;

        protected override void DoIntegrate(BaseOutputModel baseOutputModel, Document document)
        {
            _model = (OutputModel)baseOutputModel;
            //_table = _model.Table;
            //_tableSheet = (XSSFSheet)document.Workbook.GetSheetAt(0);
            //_paramsSheet = (XSSFSheet)document.Workbook.GetSheetAt(1);
            //_studentRows = _table.Rows;

            //_subjectCols = _table.Columns.FindAllByGroup("Subject");
            //_examSubjectCols = _subjectCols.FindAll(col => (bool)col.Params["IsExam"]);
            //_semesterSubjectCols = _subjectCols.FindAll(col => !(bool)col.Params["IsExam"]);
            //_subjectCols = _examSubjectCols.Concat(_semesterSubjectCols).ToList();

            //InsertColumnsAndRows();

            //FillStudents();
            //FillSubjects();
            //FillSemesterGrades();
            //FillSubjectsAvg();



            // Parametrize(_tableSheet, baseOutputModel.Params);
        }
    }
}
