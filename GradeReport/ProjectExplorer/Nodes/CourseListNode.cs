using GradeReport.Edit;
using GradeReport.Edit.EditForms;
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
            items.Add(new ToolStripMenuItem("Добавить", Resources.add_16, CreateCourse));
        }

        private void CreateCourse(object sender, EventArgs e)
        {
            var validator = new CourseValidator();
            var group = (Group)GetNodeEntity<GroupNode>();

            if (!validator.CanCreate(Project, group)) return;

            var editForm = new CourseEditForm();
            editForm.Project = Project;

            var lastCourse = group.Courses.LastOrDefault();

            var newCourse = Project.Courses.Create();
            newCourse.GroupGuid = group.Guid;
            newCourse.StartYear = lastCourse != null ? lastCourse.StartYear + 1 : 20;
            newCourse.Number = lastCourse != null ? lastCourse.Number + 1 : 1;
            newCourse.GroupNameForCourse = group.Name;
            if (lastCourse != null) newCourse.SpecialtyGuid = lastCourse.SpecialtyGuid;

            if (editForm.ShowForResult(newCourse, validator, ChangeMode.Create) != DialogResult.OK) return;

            Project.Courses.Add(newCourse);

            for (int i = 0; i < 2; i++)
            {
                var semester = Project.Semesters.Create();
                semester.CourseGuid = newCourse.Guid;
                semester.LocalNumber = i + 1;
                Project.Semesters.Add(semester);
            }

            Project.OnChanged();
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var group = (Group)GetNodeEntity<GroupNode>();
            Project.Courses.FindAll(c => c.GroupGuid == group.Guid)
                .OrderBy(c => c.Number).ToList().ForEach(c => nodes.Add(new CourseNode() { Entity = c }));
        }
    }
}
