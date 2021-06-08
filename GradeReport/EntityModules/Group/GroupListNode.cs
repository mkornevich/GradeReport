using GradeReport.Core.ProjectExplorer;
using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Group
{
    public class GroupListNode : PENode
    {
        protected override void Visualize()
        {
            Text = "Группы";
        }

        protected override void CreateNodes(List<PENode> nodes)
        {
            Project.Groups.ForEach(g => nodes.Add(new GroupNode() { Object = g }));
        }
    }
}
