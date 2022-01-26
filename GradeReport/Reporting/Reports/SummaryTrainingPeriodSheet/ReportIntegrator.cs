using GradeReport.ProjectModel.Entities;
using GradeReport.Reporting.TableModel;
using NPOI.HSSF.Util;
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
        private Table _summaryTable;
        private Table _coursesTable;
        private XSSFSheet _summarySheet;
        private XSSFSheet _coursesSheet;


        protected override void DoIntegrate(BaseOutputModel baseOutputModel, Document document)
        {
            _model = (OutputModel)baseOutputModel;
            _summaryTable = _model.SummaryTable;
            _coursesTable = _model.CoursesTable;
            _summarySheet = (XSSFSheet)document.Workbook.GetSheetAt(0);
            _coursesSheet = (XSSFSheet)document.Workbook.GetSheetAt(1);

            InsertSummaryRowsAndColumns();
            InsertCoursesRowsAndColumns();


            FillSummarySubjects();
            FillCoursesSubjects();

            FillSummaryStudents();
            FillCoursesStudents();

            FillSummaryGrades();
            FillCoursesGrades();

            Parametrize(_summarySheet, baseOutputModel.Params);
        }

        private void FillSummaryGrades()
        {
            foreach (var row in _summaryTable.Rows)
            {
                foreach (var srcCell in row.Cells)
                {
                    var cell = _summarySheet.GetRow(7 + row.Index).GetCell(2 + srcCell.Column.Index);
                    cell.SetCellValue(PrepareGrade(srcCell.Value));
                }
            }
        }

        private void FillCoursesGrades()
        {
            foreach (var row in _coursesTable.Rows)
            {
                foreach (var srcCell in row.Cells)
                {
                    var cell = _coursesSheet.GetRow(3 + row.Index).GetCell(2 + srcCell.Column.Index);
                    cell.SetCellValue(PrepareGrade(srcCell.Value));
                }
            }
        }

        private string PrepareGrade(object grade)
        {
            if (grade == null) return "err";
            if ((int)grade > 10) return "!" + grade;
            return GradeValue.GetByValue((int)grade).DisplayAs;
        }

        private void FillSummaryStudents()
        {
            for (int i = 0; i < _summaryTable.Rows.Count; i++)
            {
                var srcRow = _summaryTable.Rows[i];
                var row = _summarySheet.GetRow(7 + i);
                row.GetCell(0).SetCellValue(srcRow.Params["Number"].ToString());

                var nameCell = (XSSFCell)row.GetCell(1);
                nameCell.SetCellValue(srcRow.Name);
                if ((bool)srcRow.Params["HasRedDiploma"])
                {
                    var newStyle = (XSSFCellStyle)_summarySheet.Workbook.CreateCellStyle();
                    newStyle.CloneStyleFrom(nameCell.CellStyle);
                    newStyle.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;
                    newStyle.FillForegroundColor = NPOI.SS.UserModel.IndexedColors.Grey25Percent.Index;
                    nameCell.CellStyle = newStyle;
                }
            }
        }

        private void FillCoursesStudents()
        {
            for (int i = 0; i < _coursesTable.Rows.Count; i++)
            {
                var srcRow = _coursesTable.Rows[i];
                var row = _coursesSheet.GetRow(3 + i);
                row.GetCell(0).SetCellValue(srcRow.Params["Number"].ToString());
                row.GetCell(1).SetCellValue(srcRow.Name);
            }
        }

        private void FillSummarySubjects()
        {
            var subjectsRow = _summarySheet.GetRow(6);
            for (int i = 0; i < _summaryTable.Columns.Count; i++)
            {
                subjectsRow.GetCell(2 + i).SetCellValue(_summaryTable.Columns[i].Name);
            }
        }

        private void FillCoursesSubjects()
        {
            var subjectsRow = _coursesSheet.GetRow(2);
            for (int i = 0; i < _coursesTable.Columns.Count; i++)
            {
                subjectsRow.GetCell(2 + i).SetCellValue(_coursesTable.Columns[i].Name);
            }
        }

        private void InsertSummaryRowsAndColumns()
        {
            var colCount = _summaryTable.Columns.Count;
            if (colCount > 38)
            {
                DocumentUtils.InsertColumns(_summarySheet, 39, colCount - 38, Direction.Start);
            }

            var rowCount = _summaryTable.Rows.Count;
            DocumentUtils.InsertRows(_summarySheet, 7, rowCount - 1);
        }

        private void InsertCoursesRowsAndColumns()
        {
            var colCount = _coursesTable.Columns.Count;
            if (colCount > 1)
            {
                DocumentUtils.InsertColumns(_coursesSheet, 2, colCount - 1, Direction.Start);
            }

            var rowCount = _coursesTable.Rows.Count;
            DocumentUtils.InsertRows(_coursesSheet, 3, rowCount - 1);
        }
    }
}
