using GradeReport.Edit;
using GradeReport.Edit.EditForms;
using GradeReport.ProjectNS.Entities;
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

        protected override void Visualize()
        {
            Text = "Группы";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Добавить", null, NewAct));
        }

        private void NewAct(object sender, EventArgs e)
        {
            var newGroup = Project.Groups.Create();
            var editForm = new GroupEditForm() { Project = Project };
            if (editForm.ShowForResult(newGroup, ChangeMode.Create) == DialogResult.OK)
            {
                Project.Groups.Add(newGroup);
                Project.OnChanged();
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = false;
            Project.Groups.ForEach(g => nodes.Add(new GroupNode() { Object = g }));
        }
    }
}
