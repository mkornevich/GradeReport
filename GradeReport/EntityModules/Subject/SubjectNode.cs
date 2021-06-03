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
        public override void Init()
        {
            Text = GetNodeEntity<Subject>().ShortName;
            base.Init();
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null, EditAct));
        }

        private void EditAct(object sender, EventArgs e)
        {
            var subject = GetNodeEntity<Subject>();
            var editForm = new SubjectEditForm();
            editForm.ShowEditForm(subject, ChangeMode.Edit);
        }
    }
}
