using GradeReport.Core.ProjectNS;
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

        public Project Project { get; private set; }

        public event InfoChangedEventHandler InfoChanged;

        public PETreeView()
        {
            AfterSelect += AfterSelectAct;
        }

        private void AfterSelectAct(object sender, TreeViewEventArgs e)
        {
            var peNode = (PENode)e.Node;
            InfoChanged?.Invoke($"Параметры:\n{peNode.GetEntityParams()}\n\nОписание:\n{peNode.Description}");
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
