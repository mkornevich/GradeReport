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
            Text = $"{course.Number} курс ({course.GroupNameForCourse})";
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
            var course = (Course)Entity;
            var newSemester = Project.Semesters.Create();
            newSemester.Course = course;
            newSemester.CourseHalf = Project.Semesters.Exists(s => s.CourseGuid == course.Guid && s.CourseHalf == 1) ? 2 : 1;

            var validator = new SemesterValidator();
            if (validator.CanCreate(Project, course))
            {
                Project.Semesters.Add(newSemester);
                Project.OnChanged();
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var course = (Course)Entity;
            Project.Semesters
                .FindAll(s => s.CourseGuid == course.Guid)
                .OrderBy(s => s.CourseHalf)
                .ToList().ForEach(s => nodes.Add(new SemesterNode() { Entity = s }));
        }

        public override string GetEntityParams()
        {
            var course = (Course)Entity;
            var specialty = course.Specialty;
            return
                $"Номер: {course.Number}\n" +
                $"Специальность: {specialty.Qualification.Name} > {specialty.Name}, {specialty.Code}\n" +
                $"Название группы в курсе: {course.GroupNameForCourse}\n" +
                $"Год начала: {course.StartYear}";
        }
    }
}
