using GradeReport.Edit.EditForms;
using GradeReport.ProjectModel.Entities;
using GradeReport.Properties;
using GradeReport.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class ConfigNode : PENode
    {
        public override string Description => "Данный узел представляет конфигурацию текущего проекта. Редактировать можно через ПКМ.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            Text = "Конфигурация";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", Resources.edit_16,
                PENodeActBuilder.BuildEditAct(this, new Config(), new ConfigEditForm(), new ConfigValidator())));
        }

        public override string GetEntityParams()
        {
            var config = (Config)Entity;
            return 
                $"Название вышестоящей организации: {config.ParentOrganizationName}\n" +
                $"Название учебного заведения: {config.OrganizationName}\n" +
                $"ФИО Куратора: {config.CuratorName}\n" +
                $"ФИО Преподавателя: {config.TeacherName}\n" +
                $"Курируемая группа: {(config.CuratorGroupGuid != Guid.Empty ? config.CuratorGroup.Name : "Не указана")}";
        }
    }
}
