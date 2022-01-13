using GradeReport.List;
using GradeReport.List.Adapters;
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
    public partial class ConfigEditForm : EditForm
    {
        private ListForm curatorGroupLF = new ListForm(new GroupListAdapter());

        public ConfigEditForm()
        {
            InitializeComponent();
            EntityName = "Конфигурация";
            curatorGroupLF.Chooser = curatorGroupCH;
        }

        protected override void EntityToForm(object entity, ChangeMode mode)
        {
            var config = (Config)entity;
            parentOrganisationNameTB.Text = config.ParentOrganizationName;
            organizationNameTB.Text = config.OrganizationName;
            curatorNameTB.Text = config.CuratorName;
            teacherNameTB.Text = config.TeacherName;

            curatorGroupLF.Entities = Project.Groups.Cast<object>().ToList();
            curatorGroupLF.SelectedEntities = Project.Groups.FindAll(g => g.Guid == config.CuratorGroupGuid).Cast<object>().ToList();
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var config = (Config)entity;
            config.ParentOrganizationName = parentOrganisationNameTB.Text;
            config.OrganizationName = organizationNameTB.Text;
            config.CuratorName = curatorNameTB.Text;
            config.TeacherName = teacherNameTB.Text;

            config.CuratorGroupGuid = curatorGroupLF.SelectedEntities.Cast<Group>().FirstOrDefault()?.Guid ?? Guid.Empty;
        }
    }
}
