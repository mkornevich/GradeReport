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
    public class SubjectListNode : PENode
    {
        public override string Description => "Данный узел содержит список всех возможных предметов для данного проекта.";

        protected override void Visualize()
        {
            Text = "Предметы";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Добавить", null, NewAct));
        }

        private void NewAct(object sender, EventArgs e)
        {
            var newSubject = new Subject();
            var editForm = new SubjectEditForm() { Project = Project };
            if (editForm.ShowEditForm(newSubject, ChangeMode.Create) == DialogResult.OK)
            {
                Project.Subjects.Add(newSubject);
                TreeViewFresh();
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = false;
            Project.Subjects.ForEach(s => nodes.Add(new SubjectNode() { Object = s }));
        }
    }
}
