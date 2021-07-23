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
    public class GroupSubjectRefListNode : PENode
    {
        public override string Description => "В данном узле содержатся предметы которые присутствуют в группе из узла выше.";

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
            var group = (Group)GetNodeEntity<GroupNode>();

            var listForm = new ListForm(new SubjectListAdapter());
            listForm.SelectMode = SelectMode.Multiple;
            listForm.Entities = Project.Subjects.Cast<object>().ToList();
            listForm.SelectedEntities = Project.GroupSubjectRefs.FindAll(gsr => gsr.GroupGuid == group.Guid).Select(gsr => gsr.Subject).Cast<object>().ToList();

            if (listForm.ShowForResult() == DialogResult.OK)
            {
                var validator = new GroupSubjectRefValidator();
                if (validator.CanChangeRefs(Project, listForm.SelectedEntities.Cast<Entity>().ToList(), group))
                {
                    Project.GroupSubjectRefs.RemoveAll(gsr => gsr.GroupGuid == group.Guid);
                    Project.GroupSubjectRefs.AddRange(listForm.SelectedEntities.Cast<Subject>().Select(s =>
                    {
                        var newGsr = Project.GroupSubjectRefs.Create();
                        newGsr.Subject = s;
                        newGsr.Group = group;
                        return newGsr;
                    }));
                    Project.OnChanged();
                }
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var group = (Group)GetNodeEntity<GroupNode>();
            Project.GroupSubjectRefs
                .FindAll(gsr => gsr.GroupGuid == group.Guid)
                .ForEach(gsr => nodes.Add(new GroupSubjectRefNode() { Entity = gsr}));
        }
    }
}
