using GradeReport.Core.ProjectExplorer;
using GradeReport.EntityModules.GroupNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.StudentNS
{
    public class StudentListNode : PENode
    {
        protected override void Visualize()
        {
            Text = "Студенты";
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = false;
            var group = (Group)GetNodeObject<GroupNode>();
            var students = Project.Students.FindAll(s => s.GroupGuid == group.Guid).ToList();
            students.ForEach(s => nodes.Add(new StudentNode() { Object = s }));
        }
    }
}
