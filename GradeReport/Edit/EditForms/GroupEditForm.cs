using GradeReport.Common.NotificationNS;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Edit.EditForms
{
    public partial class GroupEditForm : EditForm
    {
        public GroupEditForm()
        {
            InitializeComponent();
            EntityName = "Группа";
        }

        protected override void EntityToForm(object entity, ChangeMode mode)
        {
            var group = (Group)entity;
            nameTB.Text = group.Name;
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var group = (Group)entity;
            group.Name = nameTB.Text;;
        }

        protected override bool Validate(NotificationFormBuilder builder, object entity)
        {
            var group = (Group)entity;

            builder.ErrorIf(nameTB.Text == "", "Заполните полное название предмета.");
            builder.ErrorIf(Project.Groups.Exists(g => g.Guid != group.Guid && g.Name == nameTB.Text), "Такое имя уже занято, попробуйте другое.");

            return builder.ErrorCount == 0;
        }
    }
}
