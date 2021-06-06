using GradeReport.Core.Actioning;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Editing
{
    public class EntityEditForm : Form
    {
        public string EntityName { get; set; } = "Нет имени сущности";

        protected ActionStrip ActionStrip { get; private set; } = new ActionStrip();

        private DialogResult _dialogResult = DialogResult.None;

        private object _entity;

        private ChangeMode _changeMode;

        public EntityEditForm()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            ActionStrip.OkAction.Click += OkAct;
            ActionStrip.CancelAction.Click += CancelAct;

            Controls.Add(ActionStrip);
        }

        private void CancelAct(object sender, EventArgs e)
        {
            _dialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkAct(object sender, EventArgs e)
        {
            FormToEntity(_entity, _changeMode);
            _dialogResult = DialogResult.OK;
            Close();
        }

        public DialogResult ShowEditForm(object entity, ChangeMode mode)
        {
            _entity = entity;
            _changeMode = mode;
            EntityToForm(entity, mode);
            AdjustFormText();
            ShowDialog();
            return _dialogResult;
        }

        private void AdjustFormText()
        {
            Text = EntityName + " - " + (_changeMode == ChangeMode.Create ? "Создание" : "Редактирование");
        }

        protected virtual void EntityToForm(object entity, ChangeMode mode)
        {

        }

        protected virtual void FormToEntity(object entity, ChangeMode mode)
        {

        }


    }
}
