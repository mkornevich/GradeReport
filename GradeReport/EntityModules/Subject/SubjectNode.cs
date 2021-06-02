using GradeReport.Core.ProjectExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Subject
{
    public class SubjectNode : PENode
    {
        public override void Init()
        {
            Text = GetNodeEntity<Subject>().ShortName;
            base.Init();
        }
    }
}
