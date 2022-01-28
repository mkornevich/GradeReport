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

            List<Semester> _groupSemesters = new List<Semester>();
            _input.Group.Courses.ForEach(course => _groupSemesters.AddRange(course.Semesters));

            _students = _input.Group.Courses.Last().Semesters.Last().Students;

            BuildSummaryTable();
            BuildCoursesTable();

            _output.Params["ParentOrganizationName"] = Project.Config.ParentOrganizationName;
            _output.Params["OrganizationName"] = Project.Config.OrganizationName;
            _output.Params["GroupName"] = _input.Group.Courses.Last().GroupNameForCourse;

            return _output;
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
                        cell.Value = ssQuery.GetFirst();
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
                        gradeValueType = t[i, Type];
                    }

                    if (t[i, Count] > 0 && t[j, Count] > 0 && t[k, Count] > 0 &&
                        t[i, Count] >= t[j, Count] + t[k, Count])
                    {
                        gradeValueType = t[i, Type];
                    }

                    if (t[i, Count] > 0 && t[j, Count] > 0 && t[k, Count] == 0)
                    {
                        if (t[i, Count] > t[j, Count])
                        {
                            gradeValueType = t[i, Type];
                        }

                        if (t[i, Count] < t[j, Count])
                        {
                            gradeValueType = t[j, Type];
                        }

                        if (t[i, Count] == t[j, Count])
                        {
                            gradeValueType = lastGradeValueType;
                        }
                    }

                    if (t[i, Count] > 0 && t[j, Count] == 0 && t[k, Count] == 0)
                    {
                        gradeValueType = t[i, Type];
                    }
                }
            }

            return gradeValueType;
        }

        private void FillTestData()
        {
            for (int i = 0; i < 20; i++)
            {
                var column = _summaryTable.CreateColumn();
                column.Group = "Subject";
                column.Name = "Very very subject " + i;
            }

            for (int i = 0; i < 15; i++)
            {
                var row = _summaryTable.CreateRow();
                row.Group = "Student";
                row.Params["Number"] = i + 1;
                row.Params["HasRedDiploma"] = i % 2 == 0;
                row.Name = "Student " + i;
            }

            foreach (var row in _summaryTable.Rows)
            {
                foreach (var cell in row.Cells)
                {
                    cell.Value = cell.Column.Index;
                    if (row.Index == 5)
                    {
                        cell.Value = -1;
                    }
                    if (row.Index == 6)
                    {
                        cell.Value = -2;
                    }
                    if (row.Index == 7)
                    {
                        cell.Value = -3;
                    }
                }
            }

            // ---

            for (int i = 0; i < 6; i++)
            {
                var column = _coursesTable.CreateColumn();
                column.Group = "Subject";
                column.Name = "Very very subject " + i;
            }

            for (int i = 0; i < 20; i++)
            {
                var row = _coursesTable.CreateRow();
                row.Group = "Student";
                row.Params["Number"] = i + 1;
                row.Name = "Student " + i;
            }

            foreach (var row in _coursesTable.Rows)
            {
                foreach (var cell in row.Cells)
                {
                    cell.Value = cell.Column.Index;
                }
            }
        }
    }
}
