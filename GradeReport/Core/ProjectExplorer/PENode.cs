using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.ProjectExplorer
{
    public abstract class PENode : TreeNode
    {
        public Project Project { get; set; }

        public object Object { get; set; }

        protected object GetNodeObject<TNode>()
        {
            if (typeof(TNode).FullName == GetType().FullName)
            {
                return Object;
            }
            var parent = (PENode)Parent;
            return parent.GetNodeObject<TNode>();
        }

        public void Init()
        {
            Visualize();
            LoadMenuItems();
            LoadNodes();
        }

        private void LoadNodes(bool initNodes = true)
        {
            var nodes = new List<PENode>();
            CreateNodes(nodes);
            if (nodes.Count > 0)
            {
                nodes.ForEach(n => n.Project = Project);
                Nodes.AddRange(nodes.ToArray());
                if (initNodes) nodes.ForEach(n => n.Init());
            }
        }

        private void LoadMenuItems()
        {
            var menuItems = new List<ToolStripMenuItem>();
            CreateMenuItems(menuItems);
            if (menuItems.Count > 0)
            {
                ContextMenuStrip = new ContextMenuStrip();
                ContextMenuStrip.Items.AddRange(menuItems.ToArray());
            }
        }

        public void Fresh(PENode selectedOldNode)
        {
            Visualize();

            var childOldNodes = Nodes.Cast<PENode>().ToList();

            //// удаляем старые ноды
            Nodes.Clear();

            //// загружаем новые ноды
            LoadNodes(false);

            //// проходимся по новым нодам
            foreach (PENode childNewNode in Nodes)
            {

                // находим для новой ноды эквивалентную старую ноду
                var childOldNode = childOldNodes.Find(childOldNode => childOldNode.EqualsForFresh(childNewNode));
                if (childOldNode != null)
                {
                    // если для новой ноды есть старая нода

                    // для детей новой дочерней ноды загружаем детей старой дочерней ноды
                    foreach (PENode childChildOldNode in childOldNode.Nodes)
                    {
                        childNewNode.Nodes.Add(childChildOldNode);
                    }

                    if (childOldNode.IsExpanded) childNewNode.Expand();

                    if (childOldNode == selectedOldNode)
                    {
                        ((PETreeView)TreeView).SelectedNode = childNewNode;
                    }

                    childNewNode.LoadMenuItems();
                    childNewNode.Fresh(selectedOldNode);
                }
                else
                {
                    // если для новой нету старой
                    childNewNode.Init();
                }
            }
        }

        protected virtual void Visualize()
        {

        }

        protected virtual void CreateNodes(List<PENode> nodes)
        {

        }

        protected virtual void CreateMenuItems(List<ToolStripMenuItem> items)
        {

        }

        protected virtual bool EqualsForFresh(PENode node)
        {
            return GetType().Equals(node.GetType());
        }
    }
}
