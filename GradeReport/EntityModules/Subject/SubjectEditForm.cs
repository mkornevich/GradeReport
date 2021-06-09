using GradeReport.Core;
using GradeReport.Core.Editing;
using GradeReport.Core.Notify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.Subject
{
    public partial class SubjectEditForm : EditForm
    {
        public SubjectEditForm()
        {
            InitializeComponent();
            EntityName = "Предмет";
        }

        protected override void EntityToForm(object entity, ChangeMode mode)
        {
            var subject = (Subject)entity;
            nameTB.Text = subject.Name;
            shortNameTB.Text = subject.ShortName;
            includeCB.Checked = subject.Include;
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var subject = (Subject)entity;
            subject.Name = nameTB.Text;
            subject.ShortName = shortNameTB.Text;
            subject.Include = includeCB.Checked;
        }

        protected override bool Validate(NotificationFormBuilder builder, object entity)
        {
            var subject = (Subject)entity;


            builder.ErrorIf(nameTB.Text == "", "Заполните полное название предмета.");

            builder.ErrorIf(shortNameTB.Text == "", "Заполните короткое название предмета.");
            builder.ErrorIf(Project.Subjects.Exists(s => s.Guid != subject.Guid && s.ShortName == shortNameTB.Text), "Такое короткое имя уже занято, попробуйте другое.");

            return builder.ErrorCount == 0;
        }
    }
}
