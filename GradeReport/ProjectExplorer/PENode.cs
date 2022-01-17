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
    public abstract class PENode : TreeNode
    {
        public abstract string Description { get; }

        public abstract bool IsChildNodesStatic { get; }

        public PETreeView PETreeView => (PETreeView)TreeView;

        public Project Project => PETreeView.Project;

        public Entity Entity { get; set; }

        public void Init()
        {
            Visualize();
            LoadMenuItems();
            LoadChildNodes();
        }

        protected object GetNodeEntity<TNode>()
        {
            if (typeof(TNode).FullName == GetType().FullName)
            {
                return Entity;
            }
            var parent = (PENode)Parent;
            return parent.GetNodeEntity<TNode>();
        }



        private void LoadChildNodes(bool initNodes = true)
        {
            var nodes = new List<PENode>();
            CreateChildNodes(nodes);
            if (nodes.Count > 0)
            {
                Nodes.AddRange(nodes.ToArray());
                if (initNodes) nodes.ForEach(n => n.Init());
            }
        }

        protected void TreeViewFresh()
        {
            PETreeView.Fresh();
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

            // если набор детей зафиксирован и не изменен то просто у каждого ребенка вызываем обновления и выходим
            if (IsChildNodesStatic)
            {
                foreach (PENode childNode in Nodes)
                {
                    childNode.Fresh(selectedOldNode);

                    if (childNode == selectedOldNode) 
                        PETreeView.SelectedNode = childNode;
                }
                return;
            }

            // сохраняем старые дочерние ноды
            var childOldNodes = Nodes.Cast<PENode>().ToList();

            // удаляем старые дочерние ноды
            Nodes.Clear();

            // загружаем новые дочерние ноды
            LoadChildNodes(false);

            foreach (PENode childNewNode in Nodes)
            {
                var childOldNode = childOldNodes.Find(childOldNode => CompareNodesByInnerEntity(childOldNode, childNewNode));
                if (childOldNode != null) // если для новой дочерней ноды была старая дочерняя нода
                {
                    // для детей новой дочерней ноды загружаем детей старой дочерней ноды
                    foreach (PENode childChildOldNode in childOldNode.Nodes)
                    {
                        childNewNode.Nodes.Add(childChildOldNode);
                    }

                    if (childOldNode.IsExpanded) childNewNode.Expand();

                    if (childOldNode == selectedOldNode)
                        PETreeView.SelectedNode = childNewNode;

                    childNewNode.LoadMenuItems();
                    childNewNode.Fresh(selectedOldNode);
                }
                else // если для новой ноды нету старой ноды
                {
                    childNewNode.Init();
                }
            }
        }

        private bool CompareNodesByInnerEntity(PENode nodeA, PENode nodeB)
        {
            if (nodeA.Entity == null || nodeB.Entity == null)
                throw new NullReferenceException("Incorrect set property: PENode.IsChildNodesStatic.");

            return EntityUtils.Compare(nodeA.Entity, nodeB.Entity);
        }

        public virtual string GetEntityParams()
        {
            return null;
        }

        protected virtual void Visualize()
        {

        }

        protected virtual void CreateChildNodes(List<PENode> nodes)
        {

        }

        protected virtual void CreateMenuItems(List<ToolStripMenuItem> items)
        {

        }
    }
}
