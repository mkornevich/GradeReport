using GradeReport.Edit;
using GradeReport.Edit.EditForms;
using GradeReport.Master;
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
    public class GroupListNode : PENode
    {
        public override string Description => "Данный узел содержит в себе список учебных групп.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = "Группы";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Добавить", Resources.add_16,
                PENodeActBuilder.BuildCreateAct(this, Project.Groups, new GroupEditForm(), new GroupValidator())));
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            Project.Groups.ForEach(g => nodes.Add(new GroupNode() { Entity = g }));
        }
    }
}
