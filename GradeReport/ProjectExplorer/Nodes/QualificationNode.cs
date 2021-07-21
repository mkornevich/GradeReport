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
    public class QualificationNode : PENode
    {
        public override string Description => "Данный узел представляет из себя одну квалификацию. Внутри себя содержит специальности. ПКМ для того чтоб создать специальность.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = ((Qualification)Entity).Name;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", Resources.edit_16,
                PENodeActBuilder.BuildEditAct(this, Project.Qualifications.Create(), new QualificationEditForm(), new QualificationValidator())));

            items.Add(new ToolStripMenuItem("Добавить специальность", Resources.add_16,
                PENodeActBuilder.BuildCreateAct(this, CreateSpecialty, (e) => Project.Specialties.Add((Specialty)e), 
                new SpecialtyEditForm(), new SpecialtyValidator())));

            items.Add(new ToolStripMenuItem("Удалить", Resources.remove_16,
                PENodeActBuilder.BuildRemoveAct(this, Project.Qualifications, new QualificationValidator())));;
        }

        private Entity CreateSpecialty()
        {
            var specialty = Project.Specialties.Create();
            specialty.QualificationGuid = ((Qualification)Entity).Guid;
            return specialty;
        } 

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            var qualification = (Qualification)Entity;
            Project.Specialties.FindAll(s => s.QualificationGuid == qualification.Guid).ForEach(s => nodes.Add(new SpecialtyNode() { Entity = s }));
        }

        public override string GetEntityParams()
        {
            var qualification = (Qualification)Entity;
            return $"Название: {qualification.Name}";
        }
    }
}
