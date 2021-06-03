using GradeReport.Core;
using GradeReport.Core.Editing;
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
    public partial class SubjectEditForm : EntityEditForm
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
    }
}
