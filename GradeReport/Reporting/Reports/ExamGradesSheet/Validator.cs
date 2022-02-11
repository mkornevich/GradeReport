using GradeReport.ProjectModel.Entities;
using GradeReport.ProjectModel.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.ExamGradesSheet
{
    public class Validator : BaseValidator
    {
        public override void DoValidate(BaseInputModel baseInputModel)
        {
            var input = (InputModel)baseInputModel;

            Notes.ErrorIf(input.Group == null, "Не выбрана группа");
            Notes.ErrorIf(input.Semester == null, "Не выбран семестр");
            Notes.ErrorIf(input.Subject == null, "Не выбран предмет");

            if (Notes.ErrorCount > 0) return;

            var query = new GradeQuery(Project)
                .SetInSemesters(input.Semester.Course.Semesters)
                .SetInSubjects(input.Subject)
                .NewQueryFromCurrentGrades();

            Notes.ErrorIf(
                query.SetInGradeTypes(GradeType.Course).Get().Select(g => g.Number + "-" + g.Semester.LocalNumber).Distinct().Count() > 1,
                "Невозможно построить отчет из за некорректно введенных данных.",
                "Данная ошибка произошла из за того что в сумме для курса указанного семестра задано более одной партии оценок по курсовым работам.");
        }
    }
}
