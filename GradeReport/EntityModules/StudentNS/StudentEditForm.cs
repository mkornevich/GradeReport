using GradeReport.Core;
using GradeReport.Core.Edit;
using GradeReport.Core.NotificationNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.StudentNS
{
    public partial class StudentEditForm : EditForm
    {
        public StudentEditForm()
        {
            InitializeComponent();
            EntityName = "Студент";
        }

        protected override void EntityToForm(object entity, ChangeMode mode)
        {
            var student = (Student)entity;
            nameTB.Text = student.Name;
            numberNUD.Value = student.Number;
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var group = (Student)entity;
            group.Name = nameTB.Text;
            group.Number = (int)numberNUD.Value;
        }

        protected override bool Validate(NotificationFormBuilder builder, object entity)
        {
            var group = (Student)entity;

            builder.ErrorIf(nameTB.Text == "", "Заполните название студента.");
            builder.ErrorIf(Project.Students.Exists(s => s.Guid != group.Guid && s.Number == (int)numberNUD.Value), "Указанный номер уже занят, попробуйте другой.");

            return builder.ErrorCount == 0;
        }
    }
}
