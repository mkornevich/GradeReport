using GradeReport.Core.ProjectExplorer;
using GradeReport.EntityModules.Config;
using GradeReport.EntityModules.Group;
using GradeReport.EntityModules.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Projects
{
    public class ProjectNode : PENode
    {
        public override void Init()
        {
            Text = "Проект";
            base.Init();
        }

        protected override void LoadNodes(List<PENode> nodes)
        {
            nodes.Add(new ConfigNode());
            nodes.Add(new SubjectListNode());
            nodes.Add(new GroupListNode());
        }
    }
}
