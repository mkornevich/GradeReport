using GradeReport.Edit;
using GradeReport.Edit.EditForms;
using GradeReport.ProjectModel.Entities;
using GradeReport.Properties;
using GradeReport.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectExplorer.Nodes
{
    public class StudentNode : PENode
    {
        public override string Description => "Данный узел представляет одного студента который принадлежит группе из узла выше.";

        public override bool IsChildNodesStatic => true;

        protected override void Visualize()
        {
            var student = (Student)Entity;
            Text = student.Name;
        }

        protected override void CreateMenuItems(List<ToolStripMenuItem> items)
        {
            items.Add(new ToolStripMenuItem("Редактировать", Resources.edit_16,
                PENodeActBuilder.BuildEditAct(this, Project.Students.Create(), new StudentEditForm(), new StudentValidator())));

            items.Add(new ToolStripMenuItem("Удалить", Resources.remove_16,
                PENodeActBuilder.BuildRemoveAct(this, Project.Students, new StudentValidator())));
        }

        public override string GetEntityParams()
        {
            var student = (Student)Entity;
            return $"ФИО: {student.Name}";
        }
    }
}
