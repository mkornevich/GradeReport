using GradeReport.Common.ActionNS;
using GradeReport.Common.NotificationNS;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
using GradeReport.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Edit
{
    public class EditForm : ActionForm
    {
        public string EntityName { get; set; } = "Имя сущности не указано";

        public Project Project { get; set; }

        private Entity _entity;

        private Validator _validator;

        private ChangeMode _changeMode;

        public EditForm()
        {
            SimplifyFrom(true);
            ActionStrip.Visible = true;
        }

        protected override void ReturnOk()
        {
            FormToEntity(_entity, _changeMode);
            if (_validator.Validate(Project, _entity))
                base.ReturnOk();
        }

        public DialogResult ShowForResult(Entity entity, Validator validator, ChangeMode mode)
        {
            _entity = entity;
            _validator = validator;
            _changeMode = mode;
            InitForm(_changeMode);
            EntityToForm(entity, mode);
            AdjustFormText();

            return ShowForResult();
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
