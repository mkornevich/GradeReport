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
    public class SemesterStudentRefValidator : Validator
    {
        protected override void CanChangeRefsHandler(Project project, List<Entity> refs, NotificationFormBuilder builder, object[] args)
        {
            var students = refs.Cast<Student>().ToList();

            var semester = (Semester)args[0];

            bool isMyStudentRefsValid = project.MyStudentRefs
                .FindAll(msr => msr.SemesterGuid == semester.Guid)
                .All(msr => students.Exists(st => msr.StudentGuid == st.Guid));

            bool isGradesValid = project.Grades
                .FindAll(g => g.SemesterGuid == semester.Guid)
                .All(g => students.Exists(st => g.StudentGuid == st.Guid));

            builder.ErrorIf(!isMyStudentRefsValid || !isGradesValid,
                "Невозможно убрать некоторых студентов по той пречине что они используются в дочерних узлах семестра.",
                "Посмотрите в дочерних узлах текущего семестра наличие студентов которые вы пытаетесь исключить и исключите их сначала оттуда. Так же удалите оценки которые выставленны данному студенту.");
        }
    }
}
