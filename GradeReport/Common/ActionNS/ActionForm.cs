using GradeReport.Common.NotificationNS;
using GradeReport.Edit;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Common.ActionNS
{
    public class ActionForm : Form
    {
        protected ActionStrip ActionStrip { get; private set; } = new ActionStrip();

        private DialogResult _dialogResult = DialogResult.None;

        public ActionForm()
        {
            ActionStrip.Visible = false;
            ActionStrip.PositiveAction.Click += (s, e) => ReturnOk();
            ActionStrip.NegativeAction.Click += (s, e) => ReturnCancel();

            Controls.Add(ActionStrip);
            StartPosition = FormStartPosition.CenterParent;
        }

        protected void SimplifyFrom(bool simplify)
        {
            MaximizeBox = !simplify;
            MinimizeBox = !simplify;
            FormBorderStyle = simplify ? FormBorderStyle.FixedDialog : FormBorderStyle.Sizable;
        }

        protected virtual void ReturnOk()
        {
            _dialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void ReturnCancel()
        {
            _dialogResult = DialogResult.Cancel;
            Close();
        }

        public virtual DialogResult ShowForResult()
        {
            ActionStrip.Visible = true;
            ShowDialog();
            ActionStrip.Visible = false;
            return _dialogResult;
        }
    }
}
