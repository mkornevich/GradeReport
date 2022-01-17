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
    public class SpecialtyValidator : Validator
    {
        protected override void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var specialty = (Specialty)entity;
            builder.ErrorIf(specialty.Name == "", "Название не должно быть пустым.");
            builder.ErrorIf(project.Specialties.Exists(s => s.Name == specialty.Name && s.Guid != specialty.Guid), "Название должно быть уникальным.");
            builder.ErrorIf(specialty.Code == "", "Шифр не должен быть пустым.");
        }

        protected override void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var specialty = (Specialty)entity;
            builder.ErrorIf(project.Courses.Exists(c => c.SpecialtyGuid == specialty.Guid), "Данную специальность нельзя удалить так как на нее ссылаются курсы.", 
                "Один из вариантов разрешения данного конфликта, найти курсы которые ссылаются и поменять для их специальность на другую.");
        }
    }
}
