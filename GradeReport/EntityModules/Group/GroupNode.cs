using GradeReport.Core.ProjectExplorer;
using GradeReport.Core.Projects;
using GradeReport.EntityModules.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Group
{
    public class GroupNode : PENode
    {
        protected override void Visualize()
        {
            Text = ((Group)Object).Name;
        }

        protected override void CreateNodes(List<PENode> nodes)
        {
            nodes.Add(new StudentListNode());
        }

        protected override bool EqualsForFresh(PENode node)
        {
            return base.EqualsForFresh(node) && ((Group)Object).Guid == ((Group)node.Object).Guid;
        }
    }
}
