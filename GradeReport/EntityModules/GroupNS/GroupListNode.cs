using GradeReport.Core.ProjectExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.GroupNS
{
    public class GroupListNode : PENode
    {
        protected override void Visualize()
        {
            Text = "Группы";
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = false;
            Project.Groups.ForEach(g => nodes.Add(new GroupNode() { Object = g }));
        }
    }
}
