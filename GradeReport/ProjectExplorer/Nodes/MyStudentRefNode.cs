using GradeReport.ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class MyStudentRefNode : PENode
    {
        public override string Description => "Данный узел представляет студента у которого ведет текущий преподаватель в предмете и семестре из узлов выше.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            Text = ((MyStudentRef)Entity).Student.Name;
        }
    }
}
