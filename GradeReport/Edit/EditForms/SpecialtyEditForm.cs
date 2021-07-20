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
    public partial class SpecialtyEditForm : EditForm
    {
        public SpecialtyEditForm()
        {
            InitializeComponent();
            EntityName = "Специальность";
        }

        protected override void EntityToForm(object entity, ChangeMode mode)
        {
            var specialty = (Specialty)entity;
            nameTB.Text = specialty.Name;
            codeTB.Text = specialty.Code;
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var specialty = (Specialty)entity;
            specialty.Name = nameTB.Text;
            specialty.Code = codeTB.Text;
        }
    }
}
