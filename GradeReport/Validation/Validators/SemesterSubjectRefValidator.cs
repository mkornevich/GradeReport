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
    public class SemesterSubjectRefValidator : Validator
    {
        protected override void CanChangeRefsHandler(Project project, List<Entity> refs, NotificationFormBuilder builder, object[] args)
        {
            var subjects = refs.Cast<Subject>().ToList();

            var semester = (Semester)args[0];

            bool isMyStudentRefsValid = project.MyStudentRefs
                .FindAll(msr => msr.SemesterGuid == semester.Guid)
                .All(msr => subjects.Exists(s => msr.SubjectGuid == s.Guid));

            bool isGradesValid = project.Grades
                .FindAll(g => g.SemesterGuid == semester.Guid)
                .All(g => subjects.Exists(s => g.SubjectGuid == s.Guid));

            builder.ErrorIf(!isMyStudentRefsValid || !isGradesValid,
                "Невозможно убрать некоторые предметы по той пречине что они используются в дочерних узлах семестра.",
                "Посмотрите в дочерних узлах текущего семестра наличие предметов которые вы пытаетесь исключить и исключите их сначала оттуда. Так же удалите оценки которые выставленны данному предмету.");
        }
    }
}
