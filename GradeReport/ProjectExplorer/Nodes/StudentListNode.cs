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
    public class StudentListNode : PENode
    {
        public override string Description => "Данный узел содержет в себе список студентов которые пренадлежат круппе из узла выше.";

        protected override void Visualize()
        {
            Text = "Студенты";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Добавить", null, NewAct));
        }

        private void NewAct(object sender, EventArgs e)
        {
            var newStudent = new Student();
            newStudent.GroupGuid = ((Group)GetNodeObject<GroupNode>()).Guid;
            var editForm = new StudentEditForm() { Project = Project };
            if (editForm.ShowEditForm(newStudent, ChangeMode.Create) == DialogResult.OK)
            {
                Project.Students.Add(newStudent);
                TreeViewFresh();
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = false;
            var group = (Group)GetNodeObject<GroupNode>();
            var students = Project.Students.FindAll(s => s.GroupGuid == group.Guid).ToList();
            students.ForEach(s => nodes.Add(new StudentNode() { Object = s }));
        }
    }
}
