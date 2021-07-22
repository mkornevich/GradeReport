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
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var group = (Student)entity;
            group.Name = nameTB.Text;
        }

    }
}
