using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.SemesterGradesSheet
{
    public class ReportBuilder : BaseReportBuilder
    {
        public ReportBuilder(Project project) : base(project)
        {
        }

        protected override BaseOutputModel DoBuild(BaseInputModel input)
        {
            throw new NotImplementedException();
        }
    }
}
