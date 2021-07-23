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
    public class SemesterValidator : Validator
    {
        protected override void CanCreateHandler(Project project, NotificationFormBuilder builder, object[] args)
        {
            var course = (Course)args[0];
            builder.ErrorIf(project.Semesters.FindAll(s => s.CourseGuid == course.Guid).Count >= 2, 
                "В одном курсе не допускается более 2 семестров.");
        }

        protected override void CanRemoveHandler(Project project, Entity entity, NotificationFormBuilder builder, object[] args)
        {
            var semester = (Semester)entity;
            builder.ErrorIf(
                project.SemesterSubjectRefs.Exists(e => e.SemesterGuid == semester.Guid) ||
                project.Periods.Exists(e => e.SemesterGuid == semester.Guid) ||
                project.MyStudentRefs.Exists(e => e.SemesterGuid == semester.Guid) ||
                project.SemesterStudentRefs.Exists(e => e.SemesterGuid == semester.Guid),
                "Невозможно удалить семестр так как на него ссылаются другие объекты.",
                "Причины возникновения:\n" +
                "1) Для семестра не все предметы удалены.\n" +
                "2) Для семестра не все периоды удалены.\n" +
                "3) Для семестра не все студенты удалены.\n" +
                "4) По пути: семестр > предметы > предмет x > мои студенты - не все удалено.");
        }
    }
}
