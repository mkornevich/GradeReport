using GradeReport.Core.ProjectExplorer;
using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Student
{
    public class StudentNode : PENode
    {
        protected override void Visualize()
        {
            Text = ((Student)Object).Name;
        }

        protected override bool EqualsForFresh(PENode node)
        {
            return base.EqualsForFresh(node) && ((Student)Object).Guid == ((Student)node.Object).Guid;
        }
    }
}
