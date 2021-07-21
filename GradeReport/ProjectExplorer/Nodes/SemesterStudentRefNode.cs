using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class SemesterStudentRefNode : PENode
    {
        public override string Description => "Данный узел представляет только того студента который перешел к обучению на семестр из узла выше.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            var semesterStudentRef = (SemesterStudentRef)Entity;
            Text = semesterStudentRef.Student.Name;
        }
    }
}
