using GradeReport.Edit;
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
    public class GroupNode : PENode
    {
        public override string Description => "Данный узел представляет из себя одну конкретную учебную группу.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            Text = ((Group)Entity).Name;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", Resources.edit_16,
                PENodeActBuilder.BuildEditAct(this, Project.Groups.Create(), new GroupEditForm(), new GroupValidator())));

            items.Add(new ToolStripMenuItem("Удалить", Resources.remove_16, 
                PENodeActBuilder.BuildRemoveAct(this, Project.Groups, new GroupValidator())));
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            nodes.Add(new GroupSubjectRefListNode());
            nodes.Add(new StudentListNode());
            nodes.Add(new CourseListNode());
        }

        public override string GetEntityParams()
        {
            var group = (Group)Entity;
            return
                $"Название: {group.Name}";
        }
    }
}
