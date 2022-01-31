using GradeReport.Common;
using GradeReport.ProjectModel.Entities;
using GradeReport.ProjectModel.Queries;
using GradeReport.Reporting.TableModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.SummaryTrainingPeriodSheet
{
    public class ReportBuilder : BaseReportBuilder
    {
        private const int Count = 0;

        private const int Type = 1;

        private OutputModel _output;

        private InputModel _input;

        private Table _summaryTable;

        private Table _coursesTable;

        private List<Semester> _groupSemesters;

        private List<Student> _students;

        protected override BaseOutputModel DoBuild(BaseInputModel baseInputModel)
        {
            _input = (InputModel)baseInputModel;
            _output = new OutputModel();

            _summaryTable = _output.SummaryTable;
            _coursesTable = _output.CoursesTable;

            _groupSemesters = new List<Semester>();
            _input.Group.Courses.ForEach(course => _groupSemesters.AddRange(course.Semesters));

            _students = _input.Group.Courses.Last().Semesters.Last().Students;

            BuildSummaryTable();
            BuildCoursesTable();
            CalcRedDiploma();

            _output.Params["ParentOrganizationName"] = Project.Config.ParentOrganizationName;
            _output.Params["OrganizationName"] = Project.Config.OrganizationName;
            _output.Params["GroupName"] = _input.Group.Courses.Last().GroupNameForCourse;

            return _output;
        }

        private void CalcRedDiploma()
        {
            for (int i = 0; i < _students.Count; i++)
            {
                var stSummaryRow = _summaryTable.Rows[i];
                var grades = stSummaryRow.Cells
                    .Concat(_coursesTable.Rows[i].Cells)
                    .Select(cell => Convert.ToInt32(cell.Value))
                    .ToList().FindAll(g => g >= 0);

                double cntAll = grades.Count;
                double cnt9_10 = grades.Count(g => g >= 9);
                double cnt0_6 = grades.Count(g => g >= 0 && g <= 6);

                stSummaryRow.Params["HasRedDiploma"] = (cnt9_10 * 100 / cntAll >= 75 && cnt0_6 == 0);
            }
        }

        private void BuildCoursesTable()
        {
            var coursesQuery = new GradeQuery(Project)
                .SetInSemesters(_groupSemesters)
                .SetInGradeTypes(GradeType.Course)
                .NewQueryFromCurrentGrades();

            var subjects = _input.Group.Subjects.FindAll(s => coursesQuery.SetInSubjects(s).Exists());
            for (int i = 0; i < subjects.Count; i++)
            {
                var subject = subjects[i];
                var column = _coursesTable.CreateColumn();
                column.Entity = subject;
                column.Group = "Subject";
                column.Name = subject.Name;
            }

            for (int i = 0; i < _students.Count; i++)
            {
                var student = _students[i];
                var row = _coursesTable.CreateRow();
                row.Entity = student;
                row.Group = "Student";
                row.Name = PersonNameUtils.Format(student.Name, PersonNameUtils.SurnameNP);
                row.Params["Number"] = i + 1;
            }

            foreach (var column in _coursesTable.Columns)
            {
                var subject = (Subject)column.Entity;
                var sQuery = coursesQuery
                    .SetInSubjects(subject)
                    .NewQueryFromCurrentGrades();
                foreach (var cell in column.Cells)
                {
                    var row = cell.Row;
                    var student = (Student)row.Entity;
                    var ssQuery = sQuery.SetInStudents(student);
                    cell.Value = GradeValue.Empty;
                    if (ssQuery.Get().Count == 1)
                    {
                        cell.Value = ssQuery.GetFirstOrEmpty();
                    }
                }
            }
        }

        private void BuildSummaryTable()
        {
            var subjects = _input.Group.Subjects;
            for (int i = 0; i < subjects.Count; i++)
            {
                var subject = subjects[i];
                var column = _summaryTable.CreateColumn();
                column.Entity = subject;
                column.Group = "Subject";
                column.Name = subject.Name;
            }

            for (int i = 0; i < _students.Count; i++)
            {
                var student = _students[i];
                var row = _summaryTable.CreateRow();
                row.Entity = student;
                row.Group = "Student";
                row.Name = PersonNameUtils.Format(student.Name, PersonNameUtils.SurnameNP);
                row.Params["Number"] = i + 1;
                row.Params["HasRedDiploma"] = false;
            }

            var summaryQuery = new GradeQuery(Project)
                .SetInSemesters(_groupSemesters)
                .SetInGradeTypes(GradeType.Exam, GradeType.Semester)
                .NewQueryFromCurrentGrades();

            foreach (var column in _summaryTable.Columns)
            {
                var subject = (Subject)column.Entity;
                var query = summaryQuery
                    .SetInSubjects(subject)
                    .NewQueryFromCurrentGrades();

                var hasExamForSubject = query.Get().Exists(g => g.GradeTypeName == GradeType.Exam);

                foreach (var cell in column.Cells)
                {
                    var row = cell.Row;
                    var student = (Student)row.Entity;
                    var stQuery = query.SetInStudents(student);

                    var hasSemester = stQuery.Get().Exists(g => g.GradeTypeName == GradeType.Semester);
                    var hasExam = stQuery.Get().Exists(g => g.GradeTypeName == GradeType.Exam);
                    var hasExtra = stQuery.Get().Exists(g => g.Value < 0);

                    cell.Value = GradeValue.Empty;

                    if (hasExamForSubject && !hasExam)
                    {
                        cell.Value = GradeValue.Empty;
                        continue;
                    }

                    if (hasExam)
                    {
                        cell.Value = stQuery.SetInGradeTypes(GradeType.Exam).GetAvgRounded();
                        continue;
                    }

                    if (hasSemester && !hasExam && !hasExtra)
                    {
                        cell.Value = stQuery.GetAvgRounded();
                        continue;
                    }

                    if (!hasExam && hasExtra)
                    {
                        var gradeValueType = GetGradeValueType(stQuery);
                        cell.Value = gradeValueType == GradeValue.Grade ? stQuery.GetAvgRounded() : gradeValueType;
                    }
                }
            }
        }

        private int GetGradeValueType(GradeQuery stQuery)
        {
            var t = new int[,] // types
            {
                { stQuery.Get().Count(g => g.Value == GradeValue.Passed), GradeValue.Passed },
                { stQuery.Get().Count(g => g.Value == GradeValue.Released), GradeValue.Released },
                { stQuery.Get().Count(g => g.Value >= GradeValue.Grade), GradeValue.Grade },
            };

            var lastGradeValue = stQuery.Get().Max(g => g.Semester.AbsoluteNumber);
            var lastGradeValueType = lastGradeValue > 0 ? 0 : lastGradeValue;

            int gradeValueType = GradeValue.Empty;

            List<int> indexes = new List<int>() { 0, 1, 2 };

            foreach (var i in indexes)
            {
                foreach (var j in indexes.FindAll(j => j != i))
                {
                    var k = indexes.Find(k => k != i && k != j);

                    if (t[i, Count] > t[j, Count] + t[k, Count])
                    {
                        return t[i, Type];
                    }

                    if (t[i, Count] > 0 && t[j, Count] > 0 && t[k, Count] > 0 &&
                        t[i, Count] >= t[j, Count] + t[k, Count])
                    {
                        return t[i, Type];
                    }

                    if (t[i, Count] > 0 && t[j, Count] > 0 && t[k, Count] == 0)
                    {
                        if (t[i, Count] > t[j, Count])
                        {
                            return t[i, Type];
                        }

                        if (t[i, Count] < t[j, Count])
                        {
                            return t[j, Type];
                        }

                        if (t[i, Count] == t[j, Count])
                        {
                            return lastGradeValueType;
                        }
                    }

                    if (t[i, Count] > 0 && t[j, Count] == 0 && t[k, Count] == 0)
                    {
                        return t[i, Type];
                    }
                }
            }

            return gradeValueType;
        }
    }
}
