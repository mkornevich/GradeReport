using GradeReport.Common.NotificationNS;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Validation
{
    public class Validator
    {
        private bool DoValidationResult(NotificationFormBuilder builder)
        {
            if (builder.MessageCount == 0) return true;

            if (builder.ErrorCount != 0)
            {
                builder.BuildForm().Show();
                return false;
            }

            return builder.BuildForm().ShowForResult() == DialogResult.OK;
        }

        public bool CanCreate(Project project)
        {
            var builder = new NotificationFormBuilder();
            CanCreateHandler(project, builder);
            return DoValidationResult(builder);
        }

        public bool CanRemove(Project project, Entity entity)
        {
            var builder = new NotificationFormBuilder();
            CanRemoveHandler(project, entity, builder);
            return DoValidationResult(builder);
        }

        public bool CanChangeRefs(Project project, List<Entity> refs)
        {
            var builder = new NotificationFormBuilder();
            CanChangeRefsHandler(project, refs, builder);
            return DoValidationResult(builder);
        }

        public bool Validate(Project project, Entity entity)
        {
            var builder = new NotificationFormBuilder();
            ValidateHandler(project, entity, builder);
            return DoValidationResult(builder);
        }

        protected virtual void CanCreateHandler(Project project, NotificationFormBuilder builder)
        {

        }

        protected virtual void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder)
        {

        }

        protected virtual void CanChangeRefsHandler(Project project, List<Entity> refs, NotificationFormBuilder builder)
        {

        }

        protected virtual void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder)
        {

        }
    }
}
