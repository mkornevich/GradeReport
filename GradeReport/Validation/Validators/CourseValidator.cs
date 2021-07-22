using GradeReport.Common.NotificationNS;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Validation.Validators
{
    public class CourseValidator : Validator
    {
        protected override void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var course = (Course)entity;
            builder.ErrorIf(course.SpecialtyGuid == Guid.Empty, "Специальность должна быть обязательно выбрана.");
            builder.WarningIf(project.Courses.Exists(c => c.Number == course.Number && c.Guid != course.Guid), "Номер курса должен быть уникальным.");
        }

        protected override void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var course = (Course)entity;
            builder.ErrorIf(project.Semesters.Exists(s => s.CourseGuid == course.Guid), "Невозможно удалить данный курс так как не удалены семестры данного курса.");
        }
    }
}
