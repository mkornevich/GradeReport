using GradeReport.Common.NotificationNS;
using GradeReport.ProjectModel;
using GradeReport.ProjectModel.Entities;
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

        public bool CanCreate(Project project, params object[] args)
        {
            var builder = new NotificationFormBuilder();
            CanCreateHandler(project, builder, args);
            return DoValidationResult(builder);
        }

        public bool CanRemove(Project project, Entity entity, params object[] args)
        {
            var builder = new NotificationFormBuilder();
            CanRemoveHandler(project, entity, builder, args);
            return DoValidationResult(builder);
        }

        public bool CanChangeRefs(Project project, List<Entity> refs, params object[] args)
        {
            var builder = new NotificationFormBuilder();
            CanChangeRefsHandler(project, refs, builder, args);
            return DoValidationResult(builder);
        }

        public bool Validate(Project project, Entity entity, params object[] args)
        {
            var builder = new NotificationFormBuilder();
            ValidateHandler(project, entity, builder, args);
            return DoValidationResult(builder);
        }

        protected virtual void CanCreateHandler(Project project, NotificationFormBuilder builder, object[] args)
        {

        }

        protected virtual void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {

        }

        protected virtual void CanChangeRefsHandler(Project project, List<Entity> refs, NotificationFormBuilder builder, object[] args)
        {

        }

        protected virtual void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {

        }
    }
}
