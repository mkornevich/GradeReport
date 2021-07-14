﻿using GradeReport.Core;
using GradeReport.Core.ProjectExplorer;
using GradeReport.EntityModules.GroupSubjectRefNS;
using GradeReport.EntityModules.StudentNS;
using GradeReport.EntityModules.SubjectNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.GroupNS
{
    public class GroupNode : PENode
    {
        protected override void Visualize()
        {
            Text = ((Group)Object).Name;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null, EditAct));
            items.Add(new ToolStripMenuItem("Удалить", null, RemoveAct));
        }

        private void RemoveAct(object sender, EventArgs e)
        {
            Project.Groups.Remove((Group)Object);
            TreeViewFresh();
        }

        private void EditAct(object sender, EventArgs e)
        {
            var editForm = new GroupEditForm() { Project = Project };
            if (editForm.ShowEditForm((Group)Object, ChangeMode.Create) == DialogResult.OK)
            {
                TreeViewFresh();
            }
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = true;
            nodes.Add(new GroupSubjectRefListNode());
            nodes.Add(new StudentListNode());
        }

        protected override bool EqualsForFresh(PENode node)
        {
            return base.EqualsForFresh(node) && ((Group)Object).Guid == ((Group)node.Object).Guid;
        }
    }
}