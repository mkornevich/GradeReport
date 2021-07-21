using GradeReport.Edit;
using GradeReport.Edit.EditForms;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
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
    public class SubjectNode : PENode
    {
        public override string Description => "Данный узел представляет конкретный предмет.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            Text = ((Subject)Entity).ShortName;
        }

        

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", Resources.edit_16,
                PENodeActBuilder.BuildEditAct(this, Project.Subjects.Create(), new SubjectEditForm(), new SubjectValidator())));

            items.Add(new ToolStripMenuItem("Удалить", Resources.remove_16, 
                PENodeActBuilder.BuildRemoveAct(this, Project.Subjects, new SubjectValidator())));
        }
        
        public override string GetEntityParams()
        {
            var subject = (Subject)Entity;
            return
                $"Название: {subject.Name}\n" +
                $"Короткое название: {subject.ShortName}";
        }
    }
}
