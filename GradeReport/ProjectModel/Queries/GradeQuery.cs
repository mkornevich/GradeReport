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

        private List<Semester> _inSemesters;
        private List<Semester> _notInSemesters;

        private List<Student> _inStudents;
        private List<Student> _notInStudents;

        private List<Subject> _inSubjects;
        private List<Subject> _notInSubjects;

        private List<string> _inGradeTypeNames;
        private List<string> _notInGradeTypeNames;

        private List<int> _inNumbers;
        private List<int> _notInNumbers;

        private List<int> _inValues;
        private List<int> _notInValues;

        public GradeQuery(Project project) : this(project, project.Grades)
        {

        }

        public GradeQuery(Project project, List<Grade> grades)
        {
            _project = project;
            _grades = grades;
        }

        public GradeQuery SetGrades(List<Grade> grades)
        {
            _grades = grades;
            return this;
        }

        public GradeQuery SetInSemesters(List<Semester> inSemesters)
        {
            _inSemesters = (inSemesters.Count == 0) ? null : inSemesters;
            return this;
        }

        public GradeQuery SetInSemester(Semester inSemester)
        {
            return SetInSemesters((inSemester == null) ? null : new List<Semester>() { inSemester });
        }

        public GradeQuery SetNotInSemesters(List<Semester> notInSemesters)
        {
            _notInSemesters = (notInSemesters.Count == 0) ? null : notInSemesters;
            return this;
        }

        public GradeQuery SetNotInSemester(Semester notInSemester)
        {
            return SetNotInSemesters((notInSemester == null) ? null : new List<Semester>() { notInSemester });
        }

        public GradeQuery SetInStudents(List<Student> inStudents)
        {
            _inStudents = (inStudents.Count == 0) ? null : inStudents;
            return this;
        }

        public GradeQuery SetInStudent(Student inStudent)
        {
            return SetInStudents((inStudent == null) ? null : new List<Student>() { inStudent });
        }

        public GradeQuery SetNotInStudents(List<Student> notInStudents)
        {
            _notInStudents = (notInStudents.Count == 0) ? null : notInStudents;
            return this;
        }

        public GradeQuery SetNotInStudent(Student notInStudent)
        {
            return SetNotInStudents((notInStudent == null) ? null : new List<Student>() { notInStudent });
        }

        public GradeQuery SetInSubjects(List<Subject> inSubjects)
        {
            _inSubjects = (inSubjects.Count == 0) ? null : inSubjects;
            return this;
        }

        public GradeQuery SetInSubject(Subject inSubject)
        {
            return SetInSubjects((inSubject == null) ? null : new List<Subject>() { inSubject });
        }

        public GradeQuery SetNotInSubjects(List<Subject> notInSubjects)
        {
            _notInSubjects = (notInSubjects.Count == 0) ? null : notInSubjects;
            return this;
        }

        public GradeQuery SetNotInSubject(Subject notInSubject)
        {
            return SetNotInSubjects((notInSubject == null) ? null : new List<Subject>() { notInSubject });
        }

        public GradeQuery SetInGradeTypes(List<string> inGradeTypeNames)
        {
            _inGradeTypeNames = (inGradeTypeNames.Count == 0) ? null : inGradeTypeNames;
            return this;
        }

        public GradeQuery SetInGradeType(string inGradeTypeName)
        {
            return SetInGradeTypes((inGradeTypeName == null) ? null : new List<string>() { inGradeTypeName });
        }

        public GradeQuery SetNotInGradeTypes(List<string> notInGradeTypeNames)
        {
            _notInGradeTypeNames = (notInGradeTypeNames.Count == 0) ? null : notInGradeTypeNames;
            return this;
        }

        public GradeQuery SetNotInGradeType(string notInGradeTypeName)
        {
            return SetNotInGradeTypes((notInGradeTypeName == null) ? null : new List<string>() { notInGradeTypeName });
        }

        public GradeQuery SetInNumbers(List<int> inNumbers)
        {
            _inNumbers = (inNumbers.Count == 0) ? null : inNumbers;
            return this;
        }

        public GradeQuery SetInNumber(int? inNumber)
        {
            return SetInNumbers((inNumber == null) ? null : new List<int>() { inNumber.Value });
        }

        public GradeQuery SetNotInNumbers(List<int> notInNumbers)
        {
            _notInNumbers = (notInNumbers.Count == 0) ? null : notInNumbers;
            return this;
        }

        public GradeQuery SetNotInNumber(int? notInNumber)
        {
            return SetNotInNumbers((notInNumber == null) ? null : new List<int>() { notInNumber.Value });
        }

        public GradeQuery SetInValues(List<int> inValues)
        {
            _inValues = (inValues.Count == 0) ? null : inValues;
            return this;
        }

        public GradeQuery SetInValue(int? inValue)
        {
            return SetInValues((inValue == null) ? null : new List<int>() { inValue.Value });
        }

        public GradeQuery SetNotInValues(List<int> notInValues)
        {
            _notInValues = (notInValues.Count == 0) ? null : notInValues;
            return this;
        }

        public GradeQuery SetNotInValue(int? notInValue)
        {
            return SetNotInValues((notInValue == null) ? null : new List<int>() { notInValue.Value });
        }

        public List<Grade> Get()
        {
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

        public int GetOne() => Get().First().Value;

        public double GetAvg() => Get().Average(g => g.Value);

        public bool Exists() => Get().Count > 0;

        public object Clone()
        {
            return new GradeQuery(_project)
            {
                _inSemesters = (_inSemesters != null) ? new List<Semester>(_inSemesters) : null,
                _notInSemesters = (_notInSemesters != null) ? new List<Semester>(_notInSemesters) : null,

                _inStudents = (_inStudents != null) ? new List<Student>(_inStudents) : null,
                _notInStudents = (_notInStudents != null) ? new List<Student>(_notInStudents) : null,

                _inSubjects = (_inSubjects != null) ? new List<Subject>(_inSubjects) : null,
                _notInSubjects = (_notInSubjects != null) ? new List<Subject>(_notInSubjects) : null,

                _inGradeTypeNames = (_inGradeTypeNames != null) ? new List<string>(_inGradeTypeNames) : null,
                _notInGradeTypeNames = (_notInGradeTypeNames != null) ? new List<string>(_notInGradeTypeNames) : null,

                _inNumbers = (_inNumbers != null) ? new List<int>(_inNumbers) : null,
                _notInNumbers = (_notInNumbers != null) ? new List<int>(_notInNumbers) : null,

                _inValues = (_inValues != null) ? new List<int>(_inValues) : null,
                _notInValues = (_notInValues != null) ? new List<int>(_notInValues) : null,
            };
        }

        public GradeQuery NewQueryFromCurrentGrades()
        {
            return new GradeQuery(_project, Get());
        }
    }
}
