using GradeReport.ProjectNS.Entities;
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
            items.Add(new ToolStripMenuItem("Изменить", null, ChangeAct));
        }

        private void ChangeAct(object sender, EventArgs e)
        {
            
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            Guid parentGuid = ((Group)GetNodeEntity<GroupNode>()).Guid;
            Project.GroupSubjectRefs
                .FindAll(gsr => gsr.GroupGuid == parentGuid)
                .ForEach(gsr => nodes.Add(new GroupSubjectRefNode() { Entity = gsr}));
        }
    }
}
