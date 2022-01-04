using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS
{
    public abstract class BaseReportBuilder
    {
        protected Project Project { get; private set; }

        public BaseReportBuilder(Project project)
        {
            Project = project;
        }

        public abstract BaseOutputModel Build(BaseInputModel input);
    }
}
