using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS
{
    public class BaseOutputModel
    {
        public Dictionary<string, string> Params { get; } = new Dictionary<string, string>();
    }
}
