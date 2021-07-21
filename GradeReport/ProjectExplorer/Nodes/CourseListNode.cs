using GradeReport.Edit.EditForms;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
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
    public class CourseListNode : PENode
    {
        public override string Description => "Данный узел содержит курсы которые пренадлежат группе из узла выше.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = "Курсы";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Добавить", Resources.add_16,
                PENodeActBuilder.BuildCreateAct(this, CreateCourse, (e) => Project.Courses.Add((Course)e), new CourseEditForm(), new CourseValidator())));
        }

        private Entity CreateCourse()
        {
            var course = Project.Courses.Create();
            course.GroupGuid = ((Group)GetNodeEntity<GroupNode>()).Guid;
            course.StartYear = 1;
            course.Number = 1;
            return course;
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var group = (Group)GetNodeEntity<GroupNode>();
            Project.Courses.FindAll(c => c.GroupGuid == group.Guid)
                .OrderBy(c => c.Number).ToList().ForEach(c => nodes.Add(new CourseNode() { Entity = c }));
        }
    }
}
