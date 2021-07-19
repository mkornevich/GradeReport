using GradeReport.Edit;
using GradeReport.Edit.EditForms;
using GradeReport.ProjectNS.Entities;
using GradeReport.Properties;
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

        protected override void Visualize()
        {
            Text = ((Group)Entity).Name;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", Resources.edit_16, EditAct));
            items.Add(new ToolStripMenuItem("Удалить", Resources.remove_16, RemoveAct));
        }

        private void RemoveAct(object sender, EventArgs e)
        {
            Project.Groups.Remove((Group)Entity);
            TreeViewFresh();
        }

        private void EditAct(object sender, EventArgs e)
        {
            //var editForm = new GroupEditForm() { Project = Project };
            //if (editForm.ShowForResult((Group)Object, ChangeMode.Create) == DialogResult.OK)
            //{
            //    TreeViewFresh();
            //}
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = true;
            nodes.Add(new GroupSubjectRefListNode());
            nodes.Add(new StudentListNode());
        }
    }
}
