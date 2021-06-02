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
        public override void Init()
        {
            Text = "Студенты";
            base.Init();
        }

        protected override void LoadNodes(List<PENode> nodes)
        {
            var group = GetNodeEntity<Group.Group, GroupNode>();
            var students = Project.Students.FindAll(s => s.GroupGuid == group.Guid).ToList();
            students.ForEach(s => nodes.Add(new StudentNode() { Entity = s }));
        }
    }
}
