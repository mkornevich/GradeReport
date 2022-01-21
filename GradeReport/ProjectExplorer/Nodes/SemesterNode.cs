using GradeReport.GradeEditor;
using GradeReport.ProjectModel.Entities;
using GradeReport.Properties;
using GradeReport.Validation.Validators;
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
            Text = semester.LocalNumber.ToString() + " семестр";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Удалить", Resources.remove_16,
                PENodeActBuilder.BuildRemoveAct(this, Project.Semesters, new SemesterValidator())));
            items.Add(new ToolStripMenuItem("Редактировать оценки", Resources.edit_16, GradesEditAct));
        }

        private void GradesEditAct(object sender, EventArgs e)
        {
            new GradeEditorForm((Semester)Entity).ShowDialog();
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            nodes.Add(new SemesterStudentRefListNode());
            nodes.Add(new SemesterSubjectRefListNode());
        }

        public override string GetEntityParams()
        {
            var semester = (Semester)Entity;
            return
                $"Половина курса: " + (semester.LocalNumber == 1 ? "первая" : "вторая");
        }
    }
}
