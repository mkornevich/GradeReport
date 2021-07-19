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
            builder.WarningIf(subject.Name == "", "Имя не должно быть пустым.");
        }
    }
}
