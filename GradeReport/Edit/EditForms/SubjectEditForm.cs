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
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var subject = (Subject)entity;
            subject.Name = nameTB.Text;
            subject.ShortName = shortNameTB.Text;
        }
    }
}
