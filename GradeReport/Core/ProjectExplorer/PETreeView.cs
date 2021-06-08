using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.ProjectExplorer
{
    public class PETreeView : TreeView
    {
        private ProjectNode _projectNode;

        public void LoadProject(Project project)
        {
            BeginUpdate();
            _projectNode = new ProjectNode() { Project = project };
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
