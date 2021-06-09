﻿using GradeReport.Core.ProjectExplorer;
using GradeReport.EntityModules.Config;
using GradeReport.EntityModules.Group;
using GradeReport.EntityModules.Subject;
using GradeReport.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Projects
{
    public class ProjectNode : PENode
    {
        protected override void Visualize()
        {
            Text = "Проект";
        }

        protected override void CreateChildNodes(List<PENode> nodes, out bool isChildNodesStatic)
        {
            isChildNodesStatic = true;
            nodes.Add(new ConfigNode());
            nodes.Add(new SubjectListNode());
            nodes.Add(new GroupListNode());
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("hello", Resources.error_16, HelloAct));
        }

        private void HelloAct(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнул");
        }
    }
}
