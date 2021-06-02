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

        public object Entity { get; set; }

        protected TEntity GetNodeEntity<TEntity, TNode>()
        {
            if (typeof(TNode).FullName == GetType().FullName)
            {
                return GetNodeEntity<TEntity>();
            }
            var PEParent = (PENode)Parent;
            return PEParent.GetNodeEntity<TEntity, TNode>();
        }

        protected TEntity GetNodeEntity<TEntity>()
        {
            return (TEntity)Entity;
        }

        protected virtual void LoadNodes(List<PENode> nodes)
        {

        }

        public virtual void Init()
        {
            var nodes = new List<PENode>();
            LoadNodes(nodes);
            if (nodes.Count > 0)
            {
                nodes.ForEach(n => n.Project = Project);
                Nodes.AddRange(nodes.ToArray());
                nodes.ForEach(n => n.Init());
            }
        }
    }
}
