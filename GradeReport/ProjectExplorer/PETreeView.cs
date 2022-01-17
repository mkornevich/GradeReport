using GradeReport.ProjectModel;
using GradeReport.ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectExplorer
{
    public class PETreeView : TreeView
    {
        private ProjectNode _projectNode;

        public Project Project { get; private set; }

        public string Info 
        {
            get
            {
                var selectedNode = (PENode)SelectedNode;
                if (selectedNode == null) return "";
                var entityParams = selectedNode.GetEntityParams();
                string info = "";
                if (entityParams != null) info += $"Параметры:\n{entityParams}\n\n";
                info += $"Описание:\n{selectedNode.Description}";
                return info.Replace("\n", "\r\n");
            }
        }

        public void LoadProject(Project project)
        {
            Project = project;
            BeginUpdate();
            _projectNode = new ProjectNode();
            Nodes.Clear();
            Nodes.Add(_projectNode);
            _projectNode.Init();
            EndUpdate();
        }

        public void Fresh()
        {
            BeginUpdate();
            _projectNode.Fresh((PENode)SelectedNode);
            EndUpdate();
        }

    }
}
