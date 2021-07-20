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
    public class GroupNode : PENode
    {
        public override string Description => "Данный узел представляет из себя одну конкретную учебную группу.";

        protected override void Visualize()
        {
            Text = ((Group)Entity).Name;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null,
                PENodeActBuilder.BuildEditAct(this, Project.Groups.Create(), new GroupEditForm(), new GroupValidator())));

            items.Add(new ToolStripMenuItem("Удалить", null, 
                PENodeActBuilder.BuildRemoveAct(this, Project.Groups, new GroupValidator())));
        }



        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = true;
            nodes.Add(new GroupSubjectRefListNode());
            nodes.Add(new StudentListNode());
        }
    }
}
