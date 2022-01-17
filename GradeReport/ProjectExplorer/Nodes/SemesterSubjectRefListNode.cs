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
    public class SemesterSubjectRefListNode : PENode
    {
        public override string Description => "Данный узел представляет только те предметы, которые будут преподаваться на семестре из узла выше.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = "Предметы";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Изменить", Resources.list_16, ChangeAct));
        }

        private void ChangeAct(object sender, EventArgs e)
        {
            var semester = (Semester)GetNodeEntity<SemesterNode>();
            var group = (Group)GetNodeEntity<GroupNode>();

            var listForm = new ListForm(new SubjectListAdapter());
            listForm.SelectMode = SelectMode.Multiple;
            listForm.Entities = Project.GroupSubjectRefs.FindAll(gsr => gsr.GroupGuid == group.Guid).Select(gsr => gsr.Subject).Cast<object>().ToList();
            listForm.SelectedEntities = Project.SemesterSubjectRefs.FindAll(ssr => ssr.SemesterGuid == semester.Guid).Select(ssr => ssr.Subject).Cast<object>().ToList();
            
            if (listForm.ShowForResult() == DialogResult.OK)
            {
                var validator = new SemesterSubjectRefValidator();
                if (validator.CanChangeRefs(Project, listForm.SelectedEntities.Cast<Entity>().ToList(), semester))
                {
                    Project.SemesterSubjectRefs.RemoveAll(ssr => ssr.SemesterGuid == semester.Guid);
                    Project.SemesterSubjectRefs.AddRange(listForm.SelectedEntities.Cast<Subject>().Select(s =>
                    {
                        var newSsr = Project.SemesterSubjectRefs.Create();
                        newSsr.Semester = semester;
                        newSsr.Subject = s;
                        return newSsr;
                    }));
                    Project.OnChanged();
                }
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var semester = (Semester)GetNodeEntity<SemesterNode>();
            Project.SemesterSubjectRefs.FindAll(ssr => ssr.SemesterGuid == semester.Guid).ForEach(ssr => nodes.Add(new SemesterSubjectRefNode() { Entity = ssr }));
        }
    }
}
