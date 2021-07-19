using GradeReport.Edit;
using GradeReport.Edit.EditForms;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class StudentNode : PENode
    {
        public override string Description => "Данный узел представляет одного студента который пренадлежит группе из узла выше.";

        protected override void Visualize()
        {
            Text = ((Student)Entity).Name;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null, EditAct));
            items.Add(new ToolStripMenuItem("Удалить", null, RemoveAct));
        }

        private void RemoveAct(object sender, EventArgs e)
        {
            Project.Students.Remove((Student)Entity);
            TreeViewFresh();
        }

        private void EditAct(object sender, EventArgs e)
        {
            //var editForm = new StudentEditForm() { Project = Project };
            //if (editForm.ShowForResult((Student)Object, ChangeMode.Create) == DialogResult.OK)
            //{
            //    TreeViewFresh();
            //}
        }
    }
}
