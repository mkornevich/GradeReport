using GradeReport.ProjectModel.Entities;
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
    public partial class QualificationEditForm : EditForm
    {
        public QualificationEditForm()
        {
            InitializeComponent();
            EntityName = "Квалификация";
        }

        protected override void EntityToForm(object entity, ChangeMode mode)
        {
            var qualification = (Qualification)entity;
            nameTB.Text = qualification.Name;
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var qualification = (Qualification)entity;
            qualification.Name = nameTB.Text;
        }
    }
}
