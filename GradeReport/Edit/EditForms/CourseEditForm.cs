using GradeReport.List;
using GradeReport.List.Adapters;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Edit.EditForms
{
    public partial class CourseEditForm : EditForm
    {

        private ListForm specialtyLF = new ListForm(new SpecialtyListAdapter());
        public CourseEditForm()
        {
            InitializeComponent();
            EntityName = "Курс";
            specialtyLF.Chooser = specialtyCH;
        }

        protected override void EntityToForm(object entity, ChangeMode mode)
        {
            var course = (Course)entity;
            groupNameForCourseTB.Text = course.GroupNameForCourse;
            numberNUD.Value = course.Number;
            startYearNUD.Value = course.StartYear;

            specialtyLF.Entities = Project.Specialties.Cast<object>().ToList();
            specialtyLF.SelectedEntities = Project.Specialties.FindAll(s => s.Guid == course.SpecialtyGuid).Cast<object>().ToList();
        }

        protected override void FormToEntity(object entity, ChangeMode mode)
        {
            var course = (Course)entity;
            course.GroupNameForCourse = groupNameForCourseTB.Text;
            course.Number = (int)numberNUD.Value;
            course.StartYear = (int)startYearNUD.Value;

            course.SpecialtyGuid = specialtyLF.SelectedEntities.Cast<Specialty>().FirstOrDefault()?.Guid ?? Guid.Empty;
        }
    }
}
