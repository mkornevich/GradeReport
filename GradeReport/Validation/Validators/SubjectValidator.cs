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
        protected override void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var subject = (Subject)entity;
            builder.ErrorIf(subject.ShortName == "", "Короткое имя не должно быть пустым.");
            builder.ErrorIf(project.Subjects.Exists(s => s.ShortName == subject.ShortName && s.Guid != subject.Guid), "Короткое имя предмета должно быть уникальным.");
            builder.ErrorIf(subject.Name == "", "Имя не должно быть пустым.");
            builder.WarningIf(project.Subjects.Exists(s => s.Name == subject.Name && s.Guid != subject.Guid), "Имя предмета желательно должно быть уникальным.");
        }

        protected override void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var subject = (Subject)entity;

            builder.ErrorIf(
                project.GroupSubjectRefs.Exists(e => e.SubjectGuid == subject.Guid) ||
                project.SemesterSubjectRefs.Exists(e => e.SubjectGuid == subject.Guid) ||
                project.MyStudentRefs.Exists(e => e.SubjectGuid == subject.Guid) ||
                project.Grades.Exists(e => e.SubjectGuid == subject.Guid),
                "Невозможно удалть предмет поскольку на него есть ссылки из других объектов.",
                "Причины возникновения:\n" +
                "1) Есть ссылка по пути: группы > группа x > предметы\n" +
                "2) Есть ссылка по пути: группы > группа x > курсы > курс x > семестр x > предметы\n" +
                "3) Есть ссылка на студента по пути: группы > группа x > курсы > курс x > семестр x > предметы > предмет x > мои студенты\n");
        }
    }
}
