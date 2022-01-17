using GradeReport.Properties;
using GradeReport.Reporting.ControlWorksAnalyzer;
using GradeReport.Reporting.ExamGradesSheet;
using GradeReport.Reporting.GroupProgressSheet;
using GradeReport.Reporting.SemesterGradesSheet;
using GradeReport.Reporting.SummaryTrainingPeriodSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Reporting
{
    public class ReportsLoader
    {
        private readonly BaseReportForm[] _reports = {
            new ControlWorksAnalyzer.ReportForm(),
            new SemesterGradesSheet.ReportForm(),
            new ExamGradesSheet.ReportForm(),
            new GroupProgressSheet.ReportForm(),
            new SummaryTrainingPeriodSheet.ReportForm(),
        };

        public ReportsLoader()
        {
            foreach (var reportForm in _reports)
            {
                reportForm.InitGUI();
            }
        }

        public void LoadToMenuItem(ToolStripMenuItem item)
        {
            foreach (var report in _reports)
            {
                var reportItem = new ToolStripMenuItem(
                    report.Text, 
                    Resources.report_16, 
                    (s, e) => report.ShowReportForm(App.ProjectContainer.Project));
                item.DropDownItems.Add(reportItem);
            }
        }
    }
}
