using GradeReport.ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel.Queries
{
    public class GradeQuery : ICloneable
    {
        private Project _project;
        private List<Grade> _grades;
        private List<Grade> _cachedGrades = null;

        private List<Semester> _inSemesters;
        private List<Semester> _notInSemesters;

        private List<Student> _inStudents;
        private List<Student> _notInStudents;

        private List<Subject> _inSubjects;
        private List<Subject> _notInSubjects;

        private List<string> _inGradeTypeNames;
        private List<string> _notInGradeTypeNames;

        private List<int?> _inNumbers;
        private List<int?> _notInNumbers;

        private List<int?> _inValues;
        private List<int?> _notInValues;

        public GradeQuery(Project project) : this(project, project.Grades)
        {

        }

        private GradeQuery(GradeQuery query)
        {
            _project = query._project;
            _grades = query._grades;
            _inSemesters = query._inSemesters;
            _notInSemesters = query._notInSemesters;
            _inStudents = query._inStudents;
            _notInStudents = query._notInStudents;
            _inSubjects = query._inSubjects;
            _notInSubjects = query._notInSubjects;
            _inGradeTypeNames = query._inGradeTypeNames;
            _notInGradeTypeNames = query._notInGradeTypeNames;
            _inNumbers = query._inNumbers;
            _notInNumbers = query._notInNumbers;
            _inValues = query._inValues;
            _notInValues = query._notInValues;
        }

        public GradeQuery(Project project, List<Grade> grades)
        {
            _project = project;
            _grades = grades;
        }

        private List<TItem> Normalize<TItem>(List<TItem> list)
        {
            if (list == null) return null;
            var clearList = list.ToList();
            clearList.RemoveAll(item => item == null);
            return list.Count == 0 ? null : clearList;
        }

        private List<TItem> Normalize<TItem>(TItem[] array)
        {
            return array.Length == 0 ? null : array.ToList();
        }

        public GradeQuery SetGrades(List<Grade> grades)
        {
            return new GradeQuery(this) { _grades = grades };
        }

        public GradeQuery SetInSemesters(List<Semester> inSemesters)
        {
            return new GradeQuery(this) { _inSemesters = Normalize(inSemesters) };
        }

        public GradeQuery SetInSemesters(params Semester[] inSemesters)
        {
            return SetInSemesters(Normalize(inSemesters));
        }

        public GradeQuery SetNotInSemesters(List<Semester> notInSemesters)
        {
            return new GradeQuery(this) { _notInSemesters = Normalize(notInSemesters) };
        }

        public GradeQuery SetNotInSemesters(params Semester[] notInSemesters)
        {
            return SetNotInSemesters(Normalize(notInSemesters));
        }

        public GradeQuery SetInStudents(List<Student> inStudents)
        {
            return new GradeQuery(this) { _inStudents = Normalize(inStudents) };
        }

        public GradeQuery SetInStudents(params Student[] inStudents)
        {
            return SetInStudents(Normalize(inStudents));
        }

        public GradeQuery SetNotInStudents(List<Student> notInStudents)
        {
            return new GradeQuery(this) { _notInStudents = Normalize(notInStudents) };
        }

        public GradeQuery SetNotInStudents(params Student[] notInStudents)
        {
            return SetNotInStudents(Normalize(notInStudents));
        }

        public GradeQuery SetInSubjects(List<Subject> inSubjects)
        {
            return new GradeQuery(this) { _inSubjects = Normalize(inSubjects) };
        }

        public GradeQuery SetInSubjects(params Subject[] inSubjects)
        {
            return SetInSubjects(Normalize(inSubjects));
        }

        public GradeQuery SetNotInSubjects(List<Subject> notInSubjects)
        {
            return new GradeQuery(this) { _notInSubjects = Normalize(notInSubjects) };
        }

        public GradeQuery SetNotInSubjects(params Subject[] notInSubjects)
        {
            return SetNotInSubjects(Normalize(notInSubjects));
        }

        public GradeQuery SetInGradeTypes(List<string> inGradeTypeNames)
        {
            return new GradeQuery(this) { _inGradeTypeNames = Normalize(inGradeTypeNames) };
        }

        public GradeQuery SetInGradeTypes(params string[] inGradeTypeNames)
        {
            return SetInGradeTypes(Normalize(inGradeTypeNames));
        }

        public GradeQuery SetNotInGradeTypes(List<string> notInGradeTypeNames)
        {
            return new GradeQuery(this) { _notInGradeTypeNames = Normalize(notInGradeTypeNames) };
        }

        public GradeQuery SetNotInGradeTypes(params string[] notInGradeTypeNames)
        {
            return SetNotInGradeTypes(Normalize(notInGradeTypeNames));
        }

        public GradeQuery SetInNumbers(List<int?> inNumbers)
        {
            return new GradeQuery(this) { _inNumbers = Normalize(inNumbers) };
        }

        public GradeQuery SetInNumbers(params int?[] inNumbers)
        {
            return SetInNumbers(Normalize(inNumbers));
        }

        public GradeQuery SetNotInNumbers(List<int?> notInNumbers)
        {
            return new GradeQuery(this) { _notInNumbers = Normalize(notInNumbers) };
        }

        public GradeQuery SetNotInNumbers(params int?[] notInNumbers)
        {
            return SetNotInNumbers(Normalize(notInNumbers));
        }

        public GradeQuery SetInValues(List<int?> inValues)
        {
            return new GradeQuery(this) { _inValues = Normalize(inValues) };
        }

        public GradeQuery SetInValues(params int?[] inValues)
        {
            return SetInValues(Normalize(inValues));
        }

        public GradeQuery SetNotInValues(List<int?> notInValues)
        {
            return new GradeQuery(this) { _notInValues = Normalize(notInValues) };
        }

        public GradeQuery SetNotInValues(params int?[] notInValues)
        {
            return SetNotInValues(Normalize(notInValues));
        }

        public List<Grade> Get()
        {
            if (_cachedGrades != null)
            {
                return _cachedGrades;
            }

            return _grades.FindAll(grade =>
            {
                return (
                    (_inSemesters == null || _inSemesters.Exists(s => grade.SemesterGuid == s.Guid)) &&
                    (_notInSemesters == null || !_notInSemesters.Exists(s => grade.SemesterGuid == s.Guid)) &&

                    (_inStudents == null || _inStudents.Exists(s => grade.StudentGuid == s.Guid)) &&
                    (_notInStudents == null || !_notInStudents.Exists(s => grade.StudentGuid == s.Guid)) &&

                    (_inSubjects == null || _inSubjects.Exists(s => grade.SubjectGuid == s.Guid)) &&
                    (_notInSubjects == null || !_notInSubjects.Exists(s => grade.SubjectGuid == s.Guid)) &&

                    (_inGradeTypeNames == null || _inGradeTypeNames.Exists(gtn => grade.GradeTypeName == gtn)) &&
                    (_notInGradeTypeNames == null || !_inGradeTypeNames.Exists(gtn => grade.GradeTypeName == gtn)) &&

                    (_inNumbers == null || _inNumbers.Exists(n => grade.Number == n)) &&
                    (_notInNumbers == null || !_inNumbers.Exists(n => grade.Number == n)) &&

                    (_inValues == null || _inValues.Exists(v => grade.Value == v)) &&
                    (_notInValues == null || !_inValues.Exists(v => grade.Value == v))
                );
            });
        }

        public string GetJoined(string separator = ", ")
        {
            return string.Join(separator, Get().Select(g => g.Value.ToString()));
        }

        public int GetFirstOrEmpty() => Exists() ? Get().OrderBy(g => g.Number).First().Value : GradeValue.Empty;

        public double GetAvg()
        {
            var grades = Get();
            if (grades.Count == 0) return -1;
            return Get().Average(g => g.Value);
        }

        public double GetAvgRounded(MidpointRounding midpoint = MidpointRounding.AwayFromZero)
        {
            var avg = GetAvg();
            if (avg == -1) return -1;
            return Math.Round(GetAvg(), midpoint);
        }

        public bool Exists() => Get().Count > 0;

        public object Clone()
        {
            return new GradeQuery(this);
        }

        public GradeQuery NewQueryFromCurrentGrades()
        {
            return new GradeQuery(_project, Get());
        }
    }
}
