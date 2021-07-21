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
    public class CourseNode : PENode
    {
        public override string Description =>
            "Данный узел представляет один курс который пренадлежит группе из узла выше.\n\n" +
            "В качестве вложенных элементов данного узла представлены семестры которые предадлежат данному курсу.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            var course = (Course)Entity;
            Text = course.Number.ToString() + " курс";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", Resources.edit_16,
                PENodeActBuilder.BuildEditAct(this, Project.Courses.Create(), new CourseEditForm(), new CourseValidator())));

            items.Add(new ToolStripMenuItem("Добавить семестр", Resources.add_16, CreateSemesterAct));

            items.Add(new ToolStripMenuItem("Удалить", Resources.remove_16,
                PENodeActBuilder.BuildRemoveAct(this, Project.Courses, new CourseValidator())));
        }

        private void CreateSemesterAct(object sender, EventArgs e)
        {
            var newSemester = Project.Semesters.Create();
            newSemester.Course = (Course)Entity;
            newSemester.CourseHalf = 1;

            var validator = new SemesterValidator();
            if (validator.CanCreate(Project))
            {
                Project.Semesters.Add(newSemester);
                Project.OnChanged();
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var course = (Course)Entity;
            Project.Semesters.FindAll(s => s.CourseGuid == course.Guid).ForEach(s => nodes.Add(new SemesterNode() { Entity = s }));
        }
    }
}
