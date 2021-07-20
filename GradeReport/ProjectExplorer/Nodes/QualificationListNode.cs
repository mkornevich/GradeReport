using GradeReport.Edit.EditForms;
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
    public class QualificationListNode : PENode
    {
        public override string Description => "Данный узел представляет из себя список всех квалификаций.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = "Квалификации";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Добавить", Resources.add_16,
                PENodeActBuilder.BuildCreateAct(this, Project.Qualifications, new QualificationEditForm(), new QualificationValidator())));
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            Project.Qualifications.ForEach(q => nodes.Add(new QualificationNode() { Entity = q }));
        }
    }
}
