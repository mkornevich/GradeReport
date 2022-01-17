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
    public class GroupSubjectRefValidator : Validator
    {
        protected override void CanChangeRefsHandler(Project project, List<Entity> refs, NotificationFormBuilder builder, object[] args)
        {
            var group = (Group)args[0];
            var subjects = refs.Cast<Subject>().ToList();

            var coursesInGroup = project.Courses.FindAll(c => c.GroupGuid == group.Guid);

            var semestersInGroup = project.Semesters.FindAll(s => coursesInGroup.Exists(c => s.CourseGuid == c.Guid));

            bool isSemesterSubjectRefsValid = project.SemesterSubjectRefs
                // нахождение всех ssr которые пренадлежат группе
                .FindAll(ssr => semestersInGroup.Exists(sem => sem.Guid == ssr.SemesterGuid))
                // проверка на то что все ssr входят в новые gsRefs
                .All(ssr => subjects.Exists(s => s.Guid == ssr.SubjectGuid));

            bool isMyStudentRefsValid = project.MyStudentRefs
                .FindAll(msr => semestersInGroup.Exists(sem => sem.Guid == msr.SemesterGuid))
                .All(msr => subjects.Exists(s => s.Guid == msr.SubjectGuid));
            
            builder.ErrorIf(!isSemesterSubjectRefsValid || !isMyStudentRefsValid, 
                "Невозможно убрать некоторые предметы по той пречине что они используются в дочерних узлах.",
                "Посмотрите в дочерних узлах наличие предметов которые вы пытаетесь исключить и исключите их сначала оттуда.");
        }
    }
}
