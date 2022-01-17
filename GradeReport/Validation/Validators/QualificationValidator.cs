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
    public class QualificationValidator : Validator
    {
        protected override void ValidateHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var qualification = (Qualification)entity;
            builder.ErrorIf(qualification.Name == "", "Название квалификации не должно быть пустым.");
            builder.ErrorIf(project.Qualifications.Exists(q => q.Name == qualification.Name && q.Guid != qualification.Guid), "Название квалификации желательно не должно совпадать.");
        }

        protected override void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var qualification = (Qualification)entity;
            builder.ErrorIf(project.Specialties.Exists(s => s.QualificationGuid == qualification.Guid), 
                "Невозможно удалить данную квалификацию так как в ней есть специальности.", 
                "Для удаления данной квалфикации необходимо удалить все дочерние специальности.");
        }
    }
}
