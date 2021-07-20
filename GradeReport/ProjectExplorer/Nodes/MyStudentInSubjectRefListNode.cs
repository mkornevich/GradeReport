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
    public class MyStudentInSubjectRefListNode : PENode
    {
        public override string Description => "В данном узле располагаются студетны у которых ведет текущий преподаватель.";

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
            var subject = ((GroupSubjectRef)GetNodeEntity<GroupSubjectRefNode>()).Subject;
            var group = (Group)GetNodeEntity<GroupNode>();

            var listForm = new ListForm(new StudentListAdapter());
            listForm.SelectMode = SelectMode.Multiple;
            listForm.Entities = Project.Students.FindAll(s => s.GroupGuid == group.Guid).Cast<object>().ToList();
            listForm.SelectedEntities = Project.MyStudentInSubjectRefs.FindAll(msisr => msisr.SubjectGuid == subject.Guid).Select(gsr => gsr.Student).Cast<object>().ToList();

            if (listForm.ShowForResult() == DialogResult.OK)
            {
                var validator = new MyStudentInSubjectRefValidator();
                if (validator.CanChangeRefs(Project, listForm.SelectedEntities.Cast<Entity>().ToList()))
                {
                    Project.MyStudentInSubjectRefs.RemoveAll(msisr => msisr.SubjectGuid == subject.Guid);
                    Project.MyStudentInSubjectRefs.AddRange(listForm.SelectedEntities.Cast<Student>().Select(s =>
                    {
                        var newMsis = Project.MyStudentInSubjectRefs.Create();
                        newMsis.Student = s;
                        newMsis.Subject = subject;
                        return newMsis;
                    }));
                    Project.OnChanged();
                }
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var gsr = (GroupSubjectRef)GetNodeEntity<GroupSubjectRefNode>();
            Project.MyStudentInSubjectRefs
                .FindAll(msisr => msisr.SubjectGuid == gsr.SubjectGuid)
                .ForEach(msisr => nodes.Add(new MyStudentInSubjectRefNode() { Entity = msisr }));
        }
    }
}
