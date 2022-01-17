using GradeReport.ProjectModel.Entities;
using GradeReport.ProjectModel.Queries;
using GradeReport.Reporting.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.GroupProgressSheet
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

            return _output;
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
