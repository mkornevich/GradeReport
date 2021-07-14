﻿using GradeReport.Core;
using GradeReport.Core.ProjectExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.EntityModules.SubjectNS
{
    public class SubjectNode : PENode
    {
        protected override void Visualize()
        {
            Text = ((Subject)Object).ShortName;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null, EditAct));
            items.Add(new ToolStripMenuItem("Удалить", null, RemoveAct));
        }

        private void RemoveAct(object sender, EventArgs e)
        {
            Project.Subjects.Remove((Subject)Object);
            TreeViewFresh();
        }

        private void EditAct(object sender, EventArgs e)
        {
            var subject = Object;
            var editForm = new SubjectEditForm() { Project = Project };
            editForm.ShowEditForm(subject, ChangeMode.Edit);
            TreeViewFresh();
        }

        protected override bool EqualsForFresh(PENode node)
        {
            return base.EqualsForFresh(node) && ((Subject)Object).Guid == ((Subject)node.Object).Guid;
        }
    }
}