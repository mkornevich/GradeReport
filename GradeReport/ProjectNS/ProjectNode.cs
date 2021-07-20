using GradeReport.ProjectExplorer;
using GradeReport.ProjectExplorer.Nodes;
using GradeReport.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectNS
{
    public class ProjectNode : PENode
    {
        public override string Description => "Данный узел представляет из себя весь проект который можно редактировать. На основании информации из данного проекта будут генерироваться отчеты. Просто заполните остальные узлы ниже нужными данными.";

        protected override void Visualize()
        {
            Text = "Проект";
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = true;
            nodes.Add(new ConfigNode() { Entity = Project.Config });
            nodes.Add(new SubjectListNode());
            nodes.Add(new GroupListNode());
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("hello", Resources.error_16, HelloAct));
        }

        private void HelloAct(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнул");
        }
    }
}
