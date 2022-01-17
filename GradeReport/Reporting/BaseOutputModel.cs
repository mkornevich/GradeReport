using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting
{
    public class BaseOutputModel
    {
        public Dictionary<string, object> Params { get; } = new Dictionary<string, object>();
    }
}
