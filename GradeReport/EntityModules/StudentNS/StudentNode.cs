using GradeReport.Core;
using GradeReport.Core.ProjectExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.StudentNS
{
    public class StudentNode : PENode
    {
        public override string Description => "Данный узел представляет одного студента который пренадлежит группе из узла выше.";

        protected override void Visualize()
        {
            Text = ((Student)Object).Name;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null, EditAct));
            items.Add(new ToolStripMenuItem("Удалить", null, RemoveAct));
        }

        private void RemoveAct(object sender, EventArgs e)
        {
            Project.Students.Remove((Student)Object);
            TreeViewFresh();
        }

        private void EditAct(object sender, EventArgs e)
        {
            var editForm = new StudentEditForm() { Project = Project };
            if (editForm.ShowEditForm((Student)Object, ChangeMode.Create) == DialogResult.OK)
            {
                TreeViewFresh();
            }
        }

        protected override bool EqualsForFresh(PENode node)
        {
            return base.EqualsForFresh(node) && ((Student)Object).Guid == ((Student)node.Object).Guid;
        }
    }
}
