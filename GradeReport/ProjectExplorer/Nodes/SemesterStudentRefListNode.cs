using GradeReport.List;
using GradeReport.List.Adapters;
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
    public class SemesterStudentRefListNode : PENode
    {
        public override string Description => "Данный узел представляет только тех студентов которые перешли к обучению на семестр из узла выше.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = "Студенты";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Изменить", Resources.list_16, ChangeAct));
        }

        private void ChangeAct(object sender, EventArgs e)
        {
            var semester = (Semester)GetNodeEntity<SemesterNode>();
            var group = (Group)GetNodeEntity<GroupNode>();

            var listForm = new ListForm(new StudentListAdapter());
            listForm.SelectMode = SelectMode.Multiple;
            listForm.Entities = Project.Students.FindAll(s => s.GroupGuid == group.Guid).Cast<object>().ToList();
            listForm.SelectedEntities = Project.SemesterStudentRefs.FindAll(ssr => ssr.SemesterGuid == semester.Guid).Select(ssr => ssr.Student).Cast<object>().ToList();

            if (listForm.ShowForResult() == DialogResult.OK)
            {
                var validator = new SemesterStudentRefValidator();
                if (validator.CanChangeRefs(Project, listForm.SelectedEntities.Cast<Entity>().ToList()))
                {
                    Project.SemesterStudentRefs.RemoveAll(ssr => ssr.SemesterGuid == semester.Guid);
                    Project.SemesterStudentRefs.AddRange(listForm.SelectedEntities.Cast<Student>().Select(s =>
                    {
                        var newSsr = Project.SemesterStudentRefs.Create();
                        newSsr.Semester = semester;
                        newSsr.Student = s;
                        return newSsr;
                    }));
                    Project.OnChanged();
                }
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var semester = (Semester)GetNodeEntity<SemesterNode>();
            Project.SemesterStudentRefs
                .FindAll(ssr => ssr.SemesterGuid == semester.Guid)
                .OrderBy(ssr => ssr.Student.Name).ToList()
                .ForEach(ssr => nodes.Add(new SemesterStudentRefNode() { Entity = ssr }));
        }
    }
}
