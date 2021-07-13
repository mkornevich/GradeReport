using GradeReport.Core.ProjectExplorer;
using GradeReport.EntityModules.StudentNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.GroupNS
{
    public class GroupNode : PENode
    {
        protected override void Visualize()
        {
            Text = ((Group)Object).Name;
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = true;
            nodes.Add(new StudentListNode());
        }

        protected override bool EqualsForFresh(PENode node)
        {
            return base.EqualsForFresh(node) && ((Group)Object).Guid == ((Group)node.Object).Guid;
        }
    }
}
