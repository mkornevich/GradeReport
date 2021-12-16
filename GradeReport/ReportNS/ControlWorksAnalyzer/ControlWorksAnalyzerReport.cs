using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.ControlWorksAnalyzer
{
    public class ControlWorksAnalyzerReport : Report
    {
        public override string CodeName => "ControlWorksAnalyzer";

        public override string Name => "Анализ результатов ОКР и ДКР";

        public override void Run()
        {
            new ReportForm().Show();
        }
    }
}
