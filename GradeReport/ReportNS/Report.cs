using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS
{
    public abstract class Report
    {
        public abstract string CodeName { get; }

        public abstract string Name { get; }

        public abstract void Run();
    }
}
