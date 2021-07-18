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
    public class SubjectNode : PENode
    {
        public override string Description => "Данный узел представляет конкретный предмет.";

        protected override void Visualize()
        {
            Text = ((Subject)Object).ShortName;
        }

        public override string GetEntityParams()
        {
            var subject = (Subject)Object;
            return 
                $"Название: {subject.Name}\n" +
                $"Короткое название: {subject.ShortName}";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null, EditAct));
            items.Add(new ToolStripMenuItem("Удалить", null, RemoveAct));
        }

        private void RemoveAct(object sender, EventArgs e)
        {
            Project.Subjects.Remove((Subject)Object);
            TreeViewFresh();
        }

        private void EditAct(object sender, EventArgs e)
        {
            var subject = Object;
            var editForm = new SubjectEditForm() { Project = Project };
            editForm.ShowForResult(subject, ChangeMode.Edit);
            TreeViewFresh();
        }
    }
}
