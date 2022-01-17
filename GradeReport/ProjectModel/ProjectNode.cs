using GradeReport.ProjectExplorer;
using GradeReport.ProjectExplorer.Nodes;
using GradeReport.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectModel
{
    public class ProjectNode : PENode
    {
        public override string Description => "Данный узел представляет из себя весь проект который можно редактировать. На основании информации из данного проекта будут генерироваться отчеты. Просто заполните остальные узлы ниже нужными данными.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            Text = "Проект";
        }

        protected override void CreateChildNodes(List<PENode> nodes)
        {
            nodes.Add(new ConfigNode() { Entity = Project.Config });
            nodes.Add(new SubjectListNode());
            nodes.Add(new QualificationListNode());
            nodes.Add(new GroupListNode());
        }
    }
}
