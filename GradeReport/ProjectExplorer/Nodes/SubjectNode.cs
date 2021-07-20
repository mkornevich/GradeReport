﻿using GradeReport.Edit;
using GradeReport.Edit.EditForms;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
using GradeReport.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class SubjectNode : PENode
    {
        public override string Description => "Данный узел представляет конкретный предмет.";

        protected override void Visualize()
        {
            Text = ((Subject)Entity).ShortName;
        }

        public override string GetEntityParams()
        {
            var subject = (Subject)Entity;
            return
                $"Название: {subject.Name}\n" +
                $"Короткое название: {subject.ShortName}";
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", null,
                PENodeActBuilder.BuildEditAct(this, Project.Subjects.Create(), new SubjectEditForm(), new SubjectValidator())));

            items.Add(new ToolStripMenuItem("Удалить", null, 
                PENodeActBuilder.BuildRemoveAct(this, Project.Subjects, new SubjectValidator())));
        }
    }
}
