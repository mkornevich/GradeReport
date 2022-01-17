using GradeReport.Common;
using GradeReport.ProjectModel.Entities;
using GradeReport.ProjectModel.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.SemesterGradesSheet
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

            List<Student> students = GetStudents();

            var query = CreateQuery();

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

            _output.Params["ParentOrganizationName"] = Project.Config.ParentOrganizationName.ToUpper();
            _output.Params["OrganizationName"] = Project.Config.OrganizationName;
            _output.Params["SemesterNumber"] = _input.Semester.AbsolutePosition;
            _output.Params["CourseYears"] = course.StartYear + "/" + (course.StartYear + 1);
            _output.Params["SubjectName"] = _input.Subject.Name;
            _output.Params["CourseNumber"] = course.Number;
            _output.Params["GroupNameForCourse"] = course.GroupNameForCourse;
            _output.Params["SpecialtyName"] = course.Specialty.Code + " " + course.Specialty.Name;
            _output.Params["CuratorName"] = PersonNameUtils.Format(Project.Config.CuratorName, PersonNameUtils.SurnameNP);
            _output.Params["Date"] = _input.Date.ToString("d");

            return _output;
        }

        private GradeQuery CreateQuery()
        {
            return new GradeQuery(Project)
                .SetInSemester(_input.Semester)
                .SetInSubject(_input.Subject)
                .NewQueryFromCurrentGrades();
        }

        private List<Student> GetStudents()
        {
            IEnumerable<Student> students;

            if (_input.IsOnlyMyStudents)
            {
                students = Project.MyStudentRefs
                    .FindAll(msr => msr.SubjectGuid == _input.Subject.Guid && msr.Semester.Guid == _input.Semester.Guid)
                    .Select(msr => msr.Student);
            }
            else
            {
                students = Project.SemesterStudentRefs
                    .FindAll(ssr => ssr.SemesterGuid == _input.Semester.Guid)
                    .Select(ssr => ssr.Student);
            }

            return students.OrderBy(s => s.Name).ToList();
        }
    }
}
