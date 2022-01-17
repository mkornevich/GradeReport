using GradeReport.List;
using GradeReport.List.Adapters;
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
    public class MyStudentRefListNode : PENode
    {
        public override string Description => "В данном узле располагаются студетны у которых ведет текущий преподаватель в текущем семестре.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = "Мои студенты";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Изменить", Resources.list_16, ChangeAct));
        }

        private void ChangeAct(object sender, EventArgs e)
        {
            var ssr = (SemesterSubjectRef)GetNodeEntity<SemesterSubjectRefNode>();

            var listForm = new ListForm(new StudentListAdapter());
            listForm.SelectMode = SelectMode.Multiple;
            listForm.Entities = Project.SemesterStudentRefs.FindAll(s => s.SemesterGuid == ssr.SemesterGuid).Select(ssr => ssr.Student).Cast<object>().ToList();


            listForm.SelectedEntities = Project.MyStudentRefs
                .FindAll(msr => msr.SubjectGuid == ssr.SubjectGuid && msr.SemesterGuid == ssr.SemesterGuid).Select(msr => msr.Student).Cast<object>().ToList();

            if (listForm.ShowForResult() == DialogResult.OK)
            {
                var validator = new MyStudentRefValidator();
                if (validator.CanChangeRefs(Project, listForm.SelectedEntities.Cast<Entity>().ToList()))
                {
                    Project.MyStudentRefs.RemoveAll(msr => msr.SubjectGuid == ssr.SubjectGuid && msr.SemesterGuid == ssr.SemesterGuid);
                    Project.MyStudentRefs.AddRange(listForm.SelectedEntities.Cast<Student>().Select(s =>
                    {
                        var newMsr = Project.MyStudentRefs.Create();
                        newMsr.Student = s;
                        newMsr.SemesterGuid = ssr.SemesterGuid;
                        newMsr.SubjectGuid = ssr.SubjectGuid;
                        return newMsr;
                    }));
                    Project.OnChanged();
                }
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var ssr = (SemesterSubjectRef)GetNodeEntity<SemesterSubjectRefNode>();

            Project.MyStudentRefs
                .FindAll(msr => msr.SubjectGuid == ssr.SubjectGuid && msr.SemesterGuid == ssr.SemesterGuid)
                .OrderBy(msr => msr.Student.Name).ToList()
                .ForEach(msr => nodes.Add(new MyStudentRefNode() { Entity = msr }));
        }
    }
}
