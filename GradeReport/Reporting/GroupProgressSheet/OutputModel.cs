using GradeReport.Reporting.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.GroupProgressSheet
{
    public class OutputModel : BaseOutputModel
    {
        public Table Table { get; private set; } = new Table();
    }
}
