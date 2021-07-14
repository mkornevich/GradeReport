using GradeReport.Core;
using GradeReport.Core.ProjectExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.GroupNS
{
    public class GroupListNode : PENode
    {
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
            var newGroup = new Group();
            var editForm = new GroupEditForm() { Project = Project };
            if (editForm.ShowEditForm(newGroup, ChangeMode.Create) == DialogResult.OK)
            {
                Project.Groups.Add(newGroup);
                TreeViewFresh();
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = false;
            Project.Groups.ForEach(g => nodes.Add(new GroupNode() { Object = g }));
        }
    }
}
