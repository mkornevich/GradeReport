using GradeReport.Core;
using GradeReport.Core.ProjectExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.Subject
{
    public class SubjectNode : PENode
    {
        protected override void Visualize()
        {
            Text = ((Subject)Object).ShortName;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null, EditAct));
        }

        private void EditAct(object sender, EventArgs e)
        {
            var subject = Object;
            var editForm = new SubjectEditForm();
            editForm.ShowEditForm(subject, ChangeMode.Edit);
            ((PETreeView)TreeView).Fresh();
        }

        protected override bool EqualsForFresh(PENode node)
        {
            return base.EqualsForFresh(node) && ((Subject)Object).Guid == ((Subject)node.Object).Guid;
        }
    }
}
