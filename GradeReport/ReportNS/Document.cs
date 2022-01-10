using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ReportNS
{
    public class Document
    {
        public XSSFWorkbook Workbook { get; private set; }

        public void Load(string fileName)
        {
            Workbook = new XSSFWorkbook(new FileStream(fileName, FileMode.Open));
        }

        public void Store(string fileName, bool needOpen = false)
        {
            XSSFFormulaEvaluator.EvaluateAllFormulaCells(Workbook);
            try
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    Workbook.Write(stream);
                }

                if (needOpen)
                {
                    var process = new System.Diagnostics.Process();
                    process.StartInfo.FileName = fileName;
                    process.StartInfo.UseShellExecute = true;
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При попытке записать документ в фаил произошла следующая ошибка: " + ex.Message);
            }
        }

        public void StoreWithDialog(bool needOpen = false)
        {
            var dialog = new SaveFileDialog()
            {
                FileName = "report.xlsx",
                OverwritePrompt = false,
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Store(dialog.FileName, needOpen);
            }
        }
    }
}
