using GradeReport.Core.ActionStripNS;
using GradeReport.Core.NotificationNS;
using GradeReport.Core.ProjectNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Edit
{
    public class EditForm : Form
    {
        public string EntityName { get; set; } = "Имя сущности не указано";

        public Project Project { get; set; }

        protected ActionStrip ActionStrip { get; private set; } = new ActionStrip();

        private DialogResult _dialogResult = DialogResult.None;

        private object _entity;

        private ChangeMode _changeMode;

        public EditForm()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            ActionStrip.PositiveAction.Click += OkAct;
            ActionStrip.NegativeAction.Click += CancelAct;

            Controls.Add(ActionStrip);

            StartPosition = FormStartPosition.CenterParent;
        }

        private void CancelAct(object sender, EventArgs e)
        {
            _dialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkAct(object sender, EventArgs e)
        {
            var builder = new NotificationFormBuilder();

            if (Validate(builder, _entity))
            {
                if (builder.MessageCount == 0 || (builder.MessageCount > 0 && builder.BuildForm().ShowForResult() == DialogResult.OK))
                {
                    FormToEntity(_entity, _changeMode);
                    _dialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                builder.BuildForm().Show();
            }
        }

        public DialogResult ShowEditForm(object entity, ChangeMode mode)
        {
            _entity = entity;
            _changeMode = mode;
            InitForm(_changeMode);
            EntityToForm(entity, mode);
            AdjustFormText();
            ShowDialog();
            return _dialogResult;
        }

        private void AdjustFormText()
        {
            Text = EntityName + " - " + (_changeMode == ChangeMode.Create ? "Создание" : "Редактирование");
        }

        protected virtual void InitForm(ChangeMode mode)
        {

        }

        protected virtual void EntityToForm(object entity, ChangeMode mode)
        {

        }

        protected virtual void FormToEntity(object entity, ChangeMode mode)
        {

        }

        protected virtual bool Validate(NotificationFormBuilder builder, object entity)
        {

            return builder.ErrorCount == 0;
        }
    }
}
