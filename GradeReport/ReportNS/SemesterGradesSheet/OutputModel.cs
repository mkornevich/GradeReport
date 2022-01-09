using GradeReport.ReportNS.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.SemesterGradesSheet
{
    public class OutputModel : BaseOutputModel
    {
        public List<Dictionary<string, object>> Table { get; private set; } = new List<Dictionary<string, object>>();
    }
}
