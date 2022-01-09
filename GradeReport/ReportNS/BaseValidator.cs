using GradeReport.Common.NotificationNS;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ReportNS
{
    public abstract class BaseValidator
    {
        protected NotificationFormBuilder Notes { get; set; } = new NotificationFormBuilder();

        protected Project Project { get; private set; }

        public bool Validate(Project project, BaseInputModel inputModel)
        {
            Project = project;

            Notes.Clear();

            DoValidate(inputModel);

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

        public abstract void DoValidate(BaseInputModel input);
    }
}
