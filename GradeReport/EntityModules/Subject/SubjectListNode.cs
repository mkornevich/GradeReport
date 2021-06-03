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
        public override void Init()
        {
            Text = "Предметы";
            base.Init();
        }

        protected override void CreateNodes(List<PENode> nodes)
        {
            Project.Subjects.ForEach(s => nodes.Add(new SubjectNode() { Entity = s }));
        }
    }
}
