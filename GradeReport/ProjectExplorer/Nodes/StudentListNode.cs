using GradeReport.Edit;
using GradeReport.Edit.EditForms;
using GradeReport.Master;
using GradeReport.ProjectModel;
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
    public class StudentListNode : PENode
    {
        public override string Description => "Данный узел содержет в себе список студентов которые пренадлежат круппе из узла выше.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = "Студенты";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Добавить", Resources.add_16,
                PENodeActBuilder.BuildCreateAct(this, CreateStudent, (s) => Project.Students.Add((Student)s), new StudentEditForm(), new StudentValidator())));

            items.Add(new ToolStripMenuItem("Мастер множественно ввода", Resources.new_16, (s, e) =>
            {
                var master = new AddStudentsMasterForm((Group)GetNodeEntity<GroupNode>());
                master.ShowDialog();
            }));
        }

        private Entity CreateStudent()
        {
            var student = Project.Students.Create();
            student.Group = (Group)GetNodeEntity<GroupNode>();
            return student;
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var group = (Group)GetNodeEntity<GroupNode>();
            Project.Students
                .FindAll(s => s.GroupGuid == group.Guid)
                .OrderBy(s => s.Name).ToList()
                .ForEach(s => nodes.Add(new StudentNode() { Entity = s }));
        }
    }
}
