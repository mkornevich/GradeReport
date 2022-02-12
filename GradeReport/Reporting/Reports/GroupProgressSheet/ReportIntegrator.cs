using GradeReport.ProjectModel.Entities;
using GradeReport.Reporting.TableModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.GroupProgressSheet
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
            _table = _model.Table;
            _tableSheet = (XSSFSheet)document.Workbook.GetSheetAt(0);
            _paramsSheet = (XSSFSheet)document.Workbook.GetSheetAt(1);
            _studentRows = _table.Rows;

            _subjectCols = _table.Columns.FindAllByGroup("Subject");
            _examSubjectCols = _subjectCols.FindAll(col =>  (bool)col.Params["IsExam"]);
            _semesterSubjectCols = _subjectCols.FindAll(col =>  !(bool)col.Params["IsExam"]);
            _subjectCols = _examSubjectCols.Concat(_semesterSubjectCols).ToList();

            InsertColumnsAndRows();

            FillStudents();
            FillSubjects();
            FillSemesterGrades();
            FillSubjectsAvg();

            FillHeader();

            Parametrize(_tableSheet, baseOutputModel.Params);
            Parametrize(_paramsSheet, baseOutputModel.Params);
        }

        private void FillHeader()
        {
            var examCount = _examSubjectCols.Count;
            var fullCount = _subjectCols.Count > 15 ? _subjectCols.Count : 15;

            if (examCount > 0)
            {
                var examRange = new CellRangeAddress(0, 0, 2, 2 + examCount - 1);
                var examCell = (XSSFCell)_tableSheet.GetRow(0).GetCell(examRange.FirstColumn);
                examCell.SetCellValue("Экзамен");
                examCell.CellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                examCell.CellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;

                if (examCount > 1)
                {
                    _tableSheet.AddMergedRegion(examRange);
                }
            }

            var titleRange = new CellRangeAddress(0, 0, 2 + examCount, 2 + fullCount - 1);
            var titleCell = (XSSFCell)_tableSheet.GetRow(0).GetCell(titleRange.FirstColumn);
            titleCell.SetCellValue(Parametrize(Title, _model.Params));
            titleCell.CellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            titleCell.CellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;

            var font = titleCell.CellStyle.GetFont(_tableSheet.Workbook);
            var newFont = _tableSheet.Workbook.CreateFont();
            newFont.IsBold = true;
            newFont.FontHeightInPoints = 12;
            newFont.FontName = font.FontName;

            titleCell.CellStyle.SetFont(newFont);

            _tableSheet.AddMergedRegion(titleRange);
        }

        private void FillSubjectsAvg()
        {
            var avgCol = _table.Columns.FindByName("SubjectsAvg");
            var colPos = _subjectCols.Count > 15 ? _subjectCols.Count : 15;
            colPos += 3;
            for (int rowIndex = 0; rowIndex < _studentRows.Count; rowIndex++)
            {
                var cell = _table[_table.Rows[rowIndex], avgCol];
                var val = Math.Round((double)cell.Value, 2);
                _tableSheet.GetRow(2 + rowIndex).GetCell(colPos).SetCellValue(val);
            }
        }

        private void FillSemesterGrades()
        {
            for (int rowIndex = 0; rowIndex < _studentRows.Count; rowIndex++)
            {
                for (int colIndex = 0; colIndex < _subjectCols.Count; colIndex++)
                {
                    var gradeValue = (int)_table[_studentRows[rowIndex], _subjectCols[colIndex]].Value;
                    var cell = _tableSheet.GetRow(2 + rowIndex).GetCell(2 + colIndex);

                    if (gradeValue < 0)
                    {
                        cell.SetCellValue(GradeValue.GetByValue(gradeValue).StringValue);
                    }
                    else
                    {
                        cell.SetCellValue(gradeValue);
                    }
                }
            }
        }

        private void FillSubjects()
        {
            for (int i = 0; i < _subjectCols.Count; i++)
            {
                var row = _subjectCols[i];
                var xssfRow = _tableSheet.GetRow(1);
                xssfRow.GetCell(2 + i).SetCellValue(row.Name);
            }
        }

        private void FillStudents()
        {
            for (int i = 0; i < _studentRows.Count; i++)
            {
                var row = _studentRows[i];
                var xssfRow = _tableSheet.GetRow(2 + i);
                xssfRow.GetCell(0).SetCellValue(i + 1);
                xssfRow.GetCell(1).SetCellValue(row.Name);
            }
        }

        private void InsertColumnsAndRows()
        {
            if (_subjectCols.Count > 15)
            {
                DocumentUtils.InsertColumns(_tableSheet, 3, _subjectCols.Count - 15, Direction.Start);
            }

            DocumentUtils.InsertRows(_tableSheet, 2, _studentRows.Count - 1);
        }
    }
}
