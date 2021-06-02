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
        public void Fresh(Project project)
        {
            var projectNode = new ProjectNode() { Project = project };
            Nodes.Clear();
            Nodes.Add(projectNode);
            projectNode.Init();
        }
    }
}
