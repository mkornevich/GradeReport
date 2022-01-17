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
    public class StudentValidator : Validator
    {
        protected override void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var student = (Student)entity;
            builder.ErrorIf(student.Name == "", "ФИО не должно быть пустым.");
            builder.ErrorIf(project.Students.Exists(g => g.Name == student.Name && g.Guid != student.Guid), "ФИО должно быть уникальным.");
        }

        protected override void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var student = (Student)entity;
            builder.ErrorIf(
                project.SemesterStudentRefs.Exists(ssr => ssr.StudentGuid == student.Guid) ||
                project.MyStudentRefs.Exists(msr => msr.StudentGuid == student.Guid) ||
                project.Grades.Exists(g => g.StudentGuid == student.Guid),
                "Невозможно удалить студента так как на него ссылаются другие объекты.",
                "Причины возникновения:\n" +
                "1) Есть ссылка по пути: группы > группа x > курсы > курс x > семестр x > студенты\n" +
                "2) Есть ссылка по пути: группы > группа x > курсы > курс x > семестр x > предметы > предмет x > мои студенты\n" +
                "3) Есть оценки которые выставленны для данного студента.");
        }
    }
}
