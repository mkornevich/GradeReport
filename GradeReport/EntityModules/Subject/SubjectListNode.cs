using GradeReport.Core.ProjectExplorer;
using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Subject
{
    public class SubjectListNode : PENode
    {
        protected override void Visualize()
        {
            Text = "Предметы";
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = false;
            Project.Subjects.ForEach(s => nodes.Add(new SubjectNode() { Object = s }));
        }
    }
}
