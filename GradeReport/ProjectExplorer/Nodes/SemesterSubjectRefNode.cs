using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class SemesterSubjectRefNode : PENode
    {
        public override string Description => "Данный узел представляет только тот предмет который преподается в семестре из узла выше.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            var semesterSubjectRef = (SemesterSubjectRef)Entity;
            Text = semesterSubjectRef.Subject.ShortName;
        }
    }
}
