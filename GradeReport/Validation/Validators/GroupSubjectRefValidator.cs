using GradeReport.Common.NotificationNS;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Validation.Validators
{
    public class GroupSubjectRefValidator : Validator
    {
        protected override void CanChangeRefsHandler(Project project, List<Entity> refs, NotificationFormBuilder builder, object[] args)
        {
            var gsRefs = refs.Cast<GroupSubjectRef>();

        }
    }
}
