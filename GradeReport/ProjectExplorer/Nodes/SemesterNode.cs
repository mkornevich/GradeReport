using GradeReport.ProjectNS.Entities;
using GradeReport.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class SemesterNode : PENode
    {
        public override string Description => "Данный узел представляет один семестр который пренадлежит курсу из узла выше.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            var semester = (Semester)Entity;
            Text = semester.CourseHalf.ToString() + " семестр";
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            nodes.Add(new SemesterStudentRefListNode());
            nodes.Add(new SemesterSubjectRefListNode());
        }
    }
}
