using GradeReport.Edit.EditForms;
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
    public class SpecialtyNode : PENode
    {
        public override string Description => "Данный узел представляет из себя одну специальность.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            Text = ((Specialty)Entity).Name;
        }

        

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", Resources.edit_16,
                PENodeActBuilder.BuildEditAct(this, Project.Specialties.Create(), new SpecialtyEditForm(), new SpecialtyValidator())));

            items.Add(new ToolStripMenuItem("Удалить", Resources.remove_16,
                PENodeActBuilder.BuildRemoveAct(this, Project.Specialties, new SpecialtyValidator())));
        }

        public override string GetEntityParams()
        {
            var specialty = (Specialty)Entity;
            return
                $"Название: {specialty.Name}\n" +
                $"Шифр: {specialty.Code}";
        }
    }
}
