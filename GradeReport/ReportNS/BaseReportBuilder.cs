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

        public BaseOutputModel Build(Project project, BaseInputModel input)
        {
            Project = project;
            return DoBuild(input);
        }

        protected abstract BaseOutputModel DoBuild(BaseInputModel input);
    }
}
