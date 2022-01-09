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
        private OutputModel _output = new OutputModel();

        private InputModel _input;

        private Student _student;

        protected override BaseOutputModel DoBuild(BaseInputModel input)
        {
            _input = (InputModel)input;

            var students = Project.SemesterStudentRefs
                .FindAll(ssr => ssr.Student.GroupGuid == _input.Group.Guid)
                .Select(ssr => ssr.Student).ToList();

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
                _output.Table.Add(row);
            } 

            return _output;
        }

        private object GetCourseGrade()
        {
            return Project.Grades
                .FindAll(g => g.Semester.Guid == _input.Semester.Guid && g.Student.Guid == _student.Guid && g.SubjectGuid == _input.Subject.Guid && g.GradeTypeName == GradeType.Course)
                .Select(g => g.Value)
                .FirstOrDefault();
        }

        private object GetSemesterGrade()
        {
            return Project.Grades
                .FindAll(g => g.Semester.Guid == _input.Semester.Guid && g.Student.Guid == _student.Guid && g.SubjectGuid == _input.Subject.Guid && g.GradeTypeName == GradeType.Semester)
                .Select(g => g.Value)
                .FirstOrDefault();
        }

        private object GetOKRAvg()
        {
            return Project.Grades
                .FindAll(g => g.Semester.Guid == _input.Semester.Guid && g.Student.Guid == _student.Guid && g.SubjectGuid == _input.Subject.Guid && g.GradeTypeName == GradeType.OKR)
                .Average(g => g.Value);
        }
    }
}
