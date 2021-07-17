﻿using GradeReport.ProjectNS.Entities;
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

        public PETreeView PETreeView => (PETreeView)TreeView;

        public Project Project => PETreeView.Project;

        private bool _isChildNodesStatic;

        public object Object { get; set; }

        public void Init()
        {
            Visualize();
            LoadMenuItems();
            LoadChildNodes();
        }

        protected object GetNodeObject<TNode>()
        {
            if (typeof(TNode).FullName == GetType().FullName)
            {
                return Object;
            }
            var parent = (PENode)Parent;
            return parent.GetNodeObject<TNode>();
        }

        

        private void LoadChildNodes(bool initNodes = true)
        {
            var nodes = new List<PENode>();
            CreateChildNodes(nodes, out _isChildNodesStatic);
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

            if (_isChildNodesStatic)
            {
                foreach (PENode childNode in Nodes)
                {
                    childNode.Fresh(selectedOldNode);
                }
                return;
            }

            var childOldNodes = Nodes.Cast<PENode>().ToList();

            // remove old nodes
            Nodes.Clear();

            //// load new nodes
            LoadChildNodes(false);

            foreach (PENode childNewNode in Nodes)
            {
                var childOldNode = childOldNodes.Find(childOldNode => childOldNode.EqualsForFresh(childNewNode));
                if (childOldNode != null) // if for new node exists old node
                {
                    // для детей новой дочерней ноды загружаем детей старой дочерней ноды
                    foreach (PENode childChildOldNode in childOldNode.Nodes)
                    {
                        childNewNode.Nodes.Add(childChildOldNode);
                    }

                    if (childOldNode.IsExpanded) childNewNode.Expand();

                    if (childOldNode == selectedOldNode)
                    {
                        PETreeView.SelectedNode = childNewNode;
                    }

                    childNewNode.LoadMenuItems();
                    childNewNode.Fresh(selectedOldNode);
                }
                else // if for new node not exists old node
                {
                    childNewNode.Init();
                }
            }
        }

        public virtual string GetEntityParams()
        {
            return "Параметры для данного узла не указаны.";
        }

        protected virtual void Visualize()
        {

        }

        protected virtual void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = true;
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