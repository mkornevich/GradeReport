using GradeReport.Reporting.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.SemesterGradesSheet
{
    public class OutputModel : BaseOutputModel
    {
        public List<Dictionary<string, object>> TableRows { get; private set; } = new List<Dictionary<string, object>>();
    }
}
