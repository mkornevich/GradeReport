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
    public class SubjectValidator : Validator
    {
        protected override void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder)
        {
            var subject = (Subject)entity;
            builder.ErrorIf(subject.ShortName == "", "Короткое имя не должно быть пустым.");
            builder.ErrorIf(subject.Name == "", "Имя не должно быть пустым.");
        }

        protected override void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder)
        {
            var subject = (Subject)entity;

            project.GroupSubjectRefs.FindAll(gsr => gsr.SubjectGuid == subject.Guid)
                .ForEach(gsr => builder.Error($"Предмет не может быть удален так как привязан к группе {gsr.Group.Name}.", 
                $"Для исправления ошибки необходимо открепить данный предмет от указанной группы.")); ; ;

            project.SemesterSubjectRefs.FindAll(ssr => ssr.SubjectGuid == subject.Guid)
                .ForEach(gsr => builder.Error($"Предмет не может быть удален так как привязан к семестру: группа {gsr.Semester.Course.Group.Name} > курс {gsr.Semester.Course.Number} > семестр {gsr.Semester.CourseHalf}.",
                $"Для исправления ошибки необходимо открепить данный предмет от указанного семестра.")); ; ;
        }
    }
}
