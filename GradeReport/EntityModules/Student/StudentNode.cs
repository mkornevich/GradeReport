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
        public override void Init()
        {
            Text = GetNodeEntity<Student>().Name;
            base.Init();
        }
    }
}
