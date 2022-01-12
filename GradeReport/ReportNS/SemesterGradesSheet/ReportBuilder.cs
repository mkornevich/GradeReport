using GradeReport.Common;
using GradeReport.ProjectNS.Entities;
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
                .FindAll(ssr => ssr.Student.GroupGuid == _input.Group.Guid)
                .Select(ssr => ssr.Student)
                .OrderBy(s => s.Name)
                .ToList();

            var studentIndex = 1;

            foreach (var student in students)
            {
                _student = student;
                var row = new Dictionary<string, object>();
                row["Student"] = student;
                row["StudentIndex"] = studentIndex++;
                row["StudentName"] = student.Name;
                row["OKRAvg"] = GetOKRAvg();
                row["LPR"] = "зачтено";
                row["CourseGrade"] = GetCourseGrade();
                row["SemesterGrade"] = GetSemesterGrade();
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

        private object GetCourseGrade()
        {
            return Project.Grades
                .FindAll(g => g.Semester.Guid == _input.Semester.Guid && g.Student.Guid == _student.Guid 
                && g.SubjectGuid == _input.Subject.Guid && g.GradeTypeName == GradeType.Course)
                .Select(g => g.Value)
                .FirstOrDefault();
        }

        private object GetSemesterGrade()
        {
            return Project.Grades
                .FindAll(g => g.Semester.Guid == _input.Semester.Guid && g.Student.Guid == _student.Guid 
                && g.SubjectGuid == _input.Subject.Guid && g.GradeTypeName == GradeType.Semester)
                .Select(g => g.Value)
                .FirstOrDefault();
        }

        private object GetOKRAvg()
        {
            return Project.Grades
                .FindAll(g => g.Semester.Guid == _input.Semester.Guid && g.Student.Guid == _student.Guid 
                && g.SubjectGuid == _input.Subject.Guid && g.GradeTypeName == GradeType.OKR)
                .Average(g => g.Value);
        }
    }
}
