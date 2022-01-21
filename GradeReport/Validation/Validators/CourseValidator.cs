using GradeReport.Common.NotificationNS;
using GradeReport.ProjectModel;
using GradeReport.ProjectModel.Entities;
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
            builder.ErrorIf(
                project.Semesters.Exists(s => s.CourseGuid == course.Guid), 
                "Невозможно удалить данный курс так как не удалены семестры данного курса.");
            
            builder.ErrorIf(
                project.Courses.Exists(c => c.GroupGuid == course.GroupGuid && c.Number > course.Number),
                "Невозможно удалить данный курс так как для начала необходимо удалить все курсы с номером выше чем у данного.");
        }

        protected override void CanCreateHandler(Project project, NotificationFormBuilder builder, object[] args)
        {
            var group = (Group)args[0];
            var lastCourse = group.Courses.LastOrDefault();
            builder.ErrorIf(lastCourse != null ? lastCourse.Semesters.Count < 2 : false,
                "Невозможно добавить новый курс так как необходимо чтоб у последнего курса было создано 2 семестра.");
        }
    }
}