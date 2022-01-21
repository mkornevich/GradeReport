using GradeReport.Common;
using GradeReport.ProjectModel.Entities;
using GradeReport.ProjectModel.Queries;
using GradeReport.Reporting.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.GroupProgressSheet
{
    public class ReportBuilder : BaseReportBuilder
    {
        private OutputModel _output;

        private InputModel _input;

        private Table _table;

        private GradeQuery _query;

        protected override BaseOutputModel DoBuild(BaseInputModel baseInputModel)
        {
            _input = (InputModel)baseInputModel;
            _output = new OutputModel();
            _table = _output.Table;
            _query = CreateQuery();

            LoadStudentsToTable();
            LoadSubjectsToTable();
            CalcSemesterGrades();

            CalcStudentSubjectsAvg();
            CalcTotalAvg();

            var semester = _input.Semester;
            var course = semester.Course;
            _output.Params["SemesterNumber"] = semester.AbsoluteNumber;
            _output.Params["CourseNumber"] = course.Number;
            _output.Params["CourseYears"] = course.StartYear + "/" + (course.StartYear + 1);
            _output.Params["GroupName"] = course.GroupNameForCourse;
            _output.Params["StudentsCount"] = _table.Rows.Count;
            _output.Params["CuratorName"] = PersonNameUtils.Format(semester.Project.Config.CuratorName, PersonNameUtils.SurnameNP);

            CalcTotalGradesCounts();

            return _output;
        }

        private void CalcTotalGradesCounts()
        {
            int eightNineCount = 0;
            int sixSevenCount = 0;
            int badOneTwoSubjectsCount = 0;
            int badThreeAndMoreSubjectsCount = 0;

            foreach (var row in _table.Rows)
            {
                var grades = row.Cells
                    .FindAll(cell => cell.Column.Group == "Subject" && (int)cell.Value >= 0)
                    .Select(cell => (int)cell.Value)
                    .ToList();

                var badGrades = grades.Count(grade => grade <= 3);

                var isEightNine = grades.All(grade => grade >= 8);
                var isSixSeven = grades.All(grade => grade >= 6);
                var isBadOneTwoSubjects = badGrades >= 1 && badGrades <= 2;
                var isBadThreeAndMoreSubjects = badGrades >= 3;

                if (isEightNine) eightNineCount++;
                if (!isEightNine && isSixSeven) sixSevenCount++;
                if (isBadOneTwoSubjects) badOneTwoSubjectsCount++;
                if (isBadThreeAndMoreSubjects) badThreeAndMoreSubjectsCount++;
            }

            var p = _output.Params;
            Func<int, string> fmt = (count) => count == 0 ? "-" : count.ToString();
            p["EightNineCount"] = fmt(eightNineCount);
            p["SixSevenCount"] = fmt(sixSevenCount);
            p["BadOneTwoSubjectsCount"] = fmt(badOneTwoSubjectsCount);
            p["BadThreeAndMoreSubjectsCount"] = fmt(badThreeAndMoreSubjectsCount);
        }

        private void CalcTotalAvg()
        {
            double sum = 0;
            double count = 0;

            foreach (var cell in _table.Columns.FindByName("SubjectsAvg").Cells)
            {
                count++;
                sum += (double)cell.Value;
            }

            _output.Params["TotalAvg"] = Math.Round(sum / count, 2);
        }

        private void CalcStudentSubjectsAvg()
        {
            var avgColumn = _table.CreateColumn();
            avgColumn.Name = "SubjectsAvg";

            foreach (var row in _table.Rows)
            {
                double sum = 0;
                double count = 0;

                foreach (var column in _table.Columns.FindAllByGroup("Subject"))
                {
                    var gradeValue = (int)_table[row, column].Value;
                    if (gradeValue < 0) continue;
                    count += 1;
                    sum += gradeValue;
                }

                var avgCell = _table[row, avgColumn];
                avgCell.Value = sum / count;
            }
        }

        private GradeQuery CreateQuery()
        {
            return new GradeQuery(Project)
                .SetInSemester(_input.Semester)
                .SetInGradeTypes(new List<string> { GradeType.Semester, GradeType.Exam })
                .NewQueryFromCurrentGrades();
        }

        private void CalcSemesterGrades()
        {
            foreach (var column in _table.Columns.FindAllByGroup("Subject"))
            {
                var subject = (Subject)column.Entity;
                var isExam = _query
                    .SetInSubject(subject)
                    .SetInGradeType(GradeType.Exam)
                    .Exists();

                column.Params["IsExam"] = isExam;

                foreach (var row in _table.Rows)
                {
                    var cell = _table[row, column];
                    cell.Value = _query
                        .SetInStudent((Student)row.Entity)
                        .SetInSubject(subject)
                        .SetInGradeType(isExam ? GradeType.Exam : GradeType.Semester)
                        .GetOne();
                }
            }
        }

        private void LoadSubjectsToTable()
        {
            var subjects = Project.SemesterSubjectRefs
                .FindAll(ssr => ssr.SemesterGuid == _input.Semester.Guid)
                .Select(ssr => ssr.Subject)
                .ToList();

            for (int i = 0; i < subjects.Count; i++)
            {
                var subject = subjects[i];
                var column = _table.CreateColumn();
                column.Entity = subject;
                column.Name = subject.Name;
                column.Group = "Subject";
            }
        }

        private void LoadStudentsToTable()
        {
            var students = Project.SemesterStudentRefs
                .FindAll(ssr => ssr.SemesterGuid == _input.Semester.Guid)
                .Select(ssr => ssr.Student)
                .OrderBy(s => s.Name).ToList();

            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                var row = _table.CreateRow();
                row.Entity = student;
                row.Name = student.Name;
                row.Params["Index"] = i + 1;
            }
        }
    }
}
