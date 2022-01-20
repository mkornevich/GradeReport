using GradeReport.Common;
using GradeReport.ProjectModel.Entities;
using GradeReport.ProjectModel.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.ExamGradesSheet
{
    public class ReportBuilder : BaseReportBuilder
    {
        private OutputModel _output;

        private InputModel _input;

        private Student _student;

        private Course _course;

        private List<Semester> _courseSemesters;

        protected override BaseOutputModel DoBuild(BaseInputModel baseInputModel)
        {
            _input = (InputModel)baseInputModel;
            _output = new OutputModel();

            _course = _input.Semester.Course;
            _courseSemesters = _course.Semesters;

            var students = GetStudents();
            var query = CreateQuery();

            for (int i = 0; i < students.Count; i++)
            {
                _student = students[i];
                query.SetInStudent(_student).SetInSemester(_input.Semester);

                var row = new Dictionary<string, object>();
                row["Student"] = _student;
                row["StudentIndex"] = i + 1;
                row["StudentName"] = _student.Name;
                row["LPR"] = "зачтено";
                row["CourseGrade"] = query.SetInGradeType(GradeType.Course).GetOne();
                row["SemesterGrade"] = query.SetInGradeType(GradeType.Semester).GetOne();
                row["ExamGrade"] = query.SetInGradeType(GradeType.Exam).GetOne();
                row["ExamGradeText"] = GradeValue.GetByValue((int)row["ExamGrade"]).Text;

                query.SetInSemesters(_courseSemesters);
                row["OKRs"] = query.SetInGradeType(GradeType.OKR).GetJoined();

                _output.TableRows.Add(row);
            }

            _output.Params["ParentOrganizationName"] = Project.Config.ParentOrganizationName;
            _output.Params["OrganizationName"] = Project.Config.OrganizationName;
            _output.Params["SemesterNumber"] = _input.Semester.AbsolutePosition;
            _output.Params["SubjectName"] = _input.Subject.Name;
            _output.Params["CourseNumber"] = _course.Number;
            _output.Params["GroupName"] = _course.GroupNameForCourse;
            _output.Params["SpecialtyName"] = _course.Specialty.Code + " " + _course.Specialty.Name;
            _output.Params["FullCuratorName"] = Project.Config.CuratorName;

            return _output;
        }

        private GradeQuery CreateQuery()
        {
            return new GradeQuery(Project)
                .SetInSemesters(_courseSemesters)
                .SetInSubject(_input.Subject)
                .NewQueryFromCurrentGrades();
        }

        private List<Student> GetStudents()
        {
            return Project.SemesterStudentRefs
                .FindAll(ssr => ssr.SemesterGuid == _input.Semester.Guid)
                .Select(ssr => ssr.Student)
                .OrderBy(s => s.Name).ToList();
        }
    }
}
