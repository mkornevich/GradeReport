using GradeReport.Common.NotificationNS;
using GradeReport.ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Reporting
{
    public abstract class BaseValidator
    {
        protected NotificationFormBuilder Notes { get; set; } = new NotificationFormBuilder();

        protected Project Project { get; private set; }

        public bool Validate(Project project, BaseInputModel baseInputModel)
        {
            Project = project;

            Notes.Clear();

            DoValidate(baseInputModel);

            if (Notes.ErrorCount > 0)
            {
                Notes.BuildForm().ShowDialog();
                return false;
            }

            if (Notes.MessageCount > 0)
            {
                return Notes.BuildForm().ShowForResult() == DialogResult.OK;
            }

            return true;
        }

        public abstract void DoValidate(BaseInputModel baseInputModel);
    }
}
