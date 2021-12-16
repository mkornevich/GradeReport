using GradeReport.ReportNS.ControlWorksAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ReportNS
{
    public class ReportsLoader
    {
        private readonly Report[] _reports = {
            new ControlWorksAnalyzerReport(),
        };

        public void LoadToMenuItem(ToolStripMenuItem item)
        {
            foreach (var report in _reports)
            {
                var reportItem = new ToolStripMenuItem(report.Name, null, (s, e) => report.Run());
                item.DropDownItems.Add(reportItem);
            }
        }
    }
}
