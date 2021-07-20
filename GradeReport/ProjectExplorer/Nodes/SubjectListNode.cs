using GradeReport.Edit;
using GradeReport.Edit.EditForms;
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
    public class SubjectListNode : PENode
    {
        public override string Description => "Данный узел содержит список всех возможных предметов для данного проекта.";

        public override bool IsChildNodesStatic => false;

        protected override void Visualize()
        {
            Text = "Предметы";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Добавить", Resources.add_16, 
                PENodeActBuilder.BuildCreateAct(this, Project.Subjects, new SubjectEditForm(), new SubjectValidator())));
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            Project.Subjects.ForEach(s => nodes.Add(new SubjectNode() { Entity = s }));
        }
    }
}
