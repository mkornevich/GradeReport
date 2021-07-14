using GradeReport.Core;
using GradeReport.Core.List;
using GradeReport.Core.ProjectExplorer;
using GradeReport.EntityModules.GroupNS;
using GradeReport.EntityModules.SubjectNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.GroupSubjectRefNS
{
    public class GroupSubjectRefListNode : PENode
    {
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

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = false;
            Guid parentGuid = ((Group)GetNodeObject<GroupNode>()).Guid;
            Project.GroupSubjectRefs
                .FindAll(gsr => gsr.GroupGuid == parentGuid)
                .ForEach(gsr => nodes.Add(new GroupSubjectRefNode() { Object = gsr}));
        }
    }
}
