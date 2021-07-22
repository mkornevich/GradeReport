using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class GroupSubjectRefNode : PENode
    {
        public override string Description => "Данный узел представляет предмет который привязан к группе из узла выше.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            var subject = ((GroupSubjectRef)Entity).Subject;
            Text = subject.ShortName;
        }
    }
}
