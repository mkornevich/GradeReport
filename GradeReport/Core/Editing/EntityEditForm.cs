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

        private FlowLayoutPanel _actionPanel = new FlowLayoutPanel()
        {
            FlowDirection = FlowDirection.RightToLeft,
            Dock = DockStyle.Bottom,
            Padding = new Padding(5, 5, 2, 5),
            Height = 40,
            BackColor = Color.FromArgb(232, 232, 232),
        };

        private EditFormResult _editFormResult = EditFormResult.Cancel;

        private object _entity;

        private ChangeMode _changeMode;

        public EntityEditForm()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            AddAction("Применить", OkAct);
            AddAction("Отмена", CancelAct);

            Controls.Add(_actionPanel);
        }

        protected ActionButton AddAction(string text, EventHandler onClick)
        {
            var btn = new ActionButton(text);
            btn.Click += onClick;
            _actionPanel.Controls.Add(btn);
            return btn;
        }

        private void CancelAct(object sender, EventArgs e)
        {
            _editFormResult = EditFormResult.Cancel;
            Close();
        }

        private void OkAct(object sender, EventArgs e)
        {
            FormToEntity(_entity, _changeMode);
            _editFormResult = EditFormResult.Ok;
            Close();
        }

        public EditFormResult ShowEditForm(object entity, ChangeMode mode)
        {
            _entity = entity;
            _changeMode = mode;
            EntityToForm(entity, mode);
            AdjustFormText();
            ShowDialog();
            return _editFormResult;
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
