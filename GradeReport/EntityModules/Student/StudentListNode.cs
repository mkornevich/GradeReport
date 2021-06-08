using GradeReport.Core.ProjectExplorer;
using GradeReport.Core.Projects;
using GradeReport.EntityModules.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Student
{
    public class StudentListNode : PENode
    {
        protected override void Visualize()
        {
            Text = "Студенты";
        }

        protected override void CreateNodes(List<PENode> nodes)
        {
            var group = (Group.Group)GetNodeObject<GroupNode>();
            var students = Project.Students.FindAll(s => s.GroupGuid == group.Guid).ToList();
            students.ForEach(s => nodes.Add(new StudentNode() { Object = s }));
        }
    }
}
