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
        public override void Init()
        {
            Text = GetNodeEntity<Group>().Name;
            base.Init();
        }

        protected override void LoadNodes(List<PENode> nodes)
        {
            nodes.Add(new StudentListNode());
        }
    }
}
