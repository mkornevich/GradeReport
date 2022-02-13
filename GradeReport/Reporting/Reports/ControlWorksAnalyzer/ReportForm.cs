using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Reporting.Reports.ControlWorksAnalyzer
{
    public partial class ReportForm : BaseReportForm
    {
        private ISheet _sheet;

        private IWorkbook _workbook;

        public ReportForm()
        {
            InitializeComponent();
            var template = App.AppDataPath + "\\Reports\\ControlWorksAnalyzer\\Template.xlsx";
            _workbook = new XSSFWorkbook(new FileStream(template, FileMode.Open));
            _sheet = _workbook.GetSheetAt(0);
        }

        protected override void BuildAct(object sender, EventArgs e)
        {
            saveFileDialog.FileName = DateTime.Now.ToString("dd-MM-yy_HH-mm-ss") + "_" +
                Text.ToLower().Replace(' ', '-');

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _sheet.GetRow(2).GetCell(3).SetCellValue(educationalTB.Text);
                _sheet.GetRow(3).GetCell(3).SetCellValue(groupTB.Text);
                _sheet.GetRow(4).GetCell(3).SetCellValue(teacherTB.Text);
                _sheet.GetRow(5).GetCell(3).SetCellValue(checkerTB.Text);
                _sheet.GetRow(6).GetCell(3).SetCellValue(allStudentCountNUD.Value.ToString());
                _sheet.GetRow(7).GetCell(3).SetCellValue(subjectTB.Text);
                _sheet.GetRow(8).GetCell(3).SetCellValue(professionTB.Text);
                _sheet.GetRow(9).GetCell(3).SetCellValue(dateDTP.Value.ToString("«dd» MMMM yyyy г."));
                _sheet.GetRow(10).GetCell(3).SetCellValue(numberControlWorkNUD.Value.ToString());
                _sheet.GetRow(11).GetCell(3).SetCellValue(numberPivotSemesterNUD.Value.ToString());

                _sheet.GetRow(13).GetCell(3).SetCellValue(gradesControlWorkTB.Text);
                _sheet.GetRow(14).GetCell(3).SetCellValue(gradesPivotSemesterTB.Text);

                XSSFFormulaEvaluator.EvaluateAllFormulaCells(_workbook);

                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        _workbook.Write(stream);
                    }

                    var process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = saveFileDialog.FileName;
                    process.StartInfo.UseShellExecute = true;
                    process.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("При попытке записать отчет в фаил произошла следующая ошибка: " + ex.Message);
                }
            }
        }

        protected override void ValidateAct(object sender, EventArgs e)
        {
            MessageBox.Show("Данная функция не поддерживается");
        }

        private void GradesChangedAct(object sender, EventArgs e)
        {
            gradesControlWorkCountLbl.Text = gradesControlWorkTB.Text.Length.ToString();
            gradesPivotSemesterCountLbl.Text = gradesPivotSemesterTB.Text.Length.ToString();
        }
    }
}
