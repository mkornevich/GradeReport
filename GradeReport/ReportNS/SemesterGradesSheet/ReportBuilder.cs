using GradeReport.Common;
using GradeReport.ProjectNS.Entities;
using GradeReport.ProjectNS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.SemesterGradesSheet
{
    public class ReportBuilder : BaseReportBuilder
    {
        private OutputModel _output;

        private InputModel _input;

        private Student _student;

        protected override BaseOutputModel DoBuild(BaseInputModel baseInputModel)
        {
            _input = (InputModel)baseInputModel;
            _output = new OutputModel();

            var students = Project.SemesterStudentRefs
                .FindAll(ssr => ssr.SemesterGuid == _input.Semester.Guid)
                .Select(ssr => ssr.Student)
                .OrderBy(s => s.Name)
                .ToList();

            var query = new GradeQuery(Project)
                .SetInSemester(_input.Semester)
                .SetInSubject(_input.Subject)
                .NewQueryFromCurrentGrades();

            for (int i = 0; i < students.Count; i++)
            {
                _student = students[i];
                query.SetInStudent(_student);

                var row = new Dictionary<string, object>();
                row["Student"] = _student;
                row["StudentIndex"] = i + 1;
                row["StudentName"] = _student.Name;
                row["OKRAvg"] = query.SetInGradeType(GradeType.OKR).GetJoined();
                row["LPR"] = "зачтено";
                row["CourseGrade"] = query.SetInGradeType(GradeType.Course).GetOne();
                row["SemesterGrade"] = query.SetInGradeType(GradeType.Semester).GetOne();
                row["SemesterGradeText"] = GradeValue.GetByValue((int)row["SemesterGrade"]).Text;
                _output.TableRows.Add(row);
            }

            var course = _input.Semester.Course;

            _output.Params["SemesterNumber"] = _input.Semester.CourseHalf;
            _output.Params["CourseYears"] = course.StartYear + "/" + (course.StartYear + 1);
            _output.Params["SubjectName"] = _input.Subject.Name;
            _output.Params["CourseNumber"] = course.Number;
            _output.Params["GroupNameForCourse"] = course.GroupNameForCourse;
            _output.Params["SpecialtyName"] = course.Specialty.Code + " " + course.Specialty.Name;
            _output.Params["CuratorName"] = PersonNameUtils.Format(Project.Config.CuratorName, PersonNameUtils.SurnameNP);
            _output.Params["Date"] = _input.Date.ToString("d");

            return _output;
        }
    }
}
