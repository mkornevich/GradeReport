using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Grade : Entity
    {
        // зачтено
        public const int Passed = -1;

        // освобожден
        public const int Released = -2;

        [EntityField(Compare = true)]
        public Guid SemesterGuid { get; set; }

        [JsonIgnore]
        public Semester Semester
        {
            get => Project.Semesters.Find(s => s.Guid == SemesterGuid);
            set => SemesterGuid = value.Guid;
        }

        [EntityField(Compare = true)]
        public Guid StudentGuid { get; set; }

        [JsonIgnore]
        public Student Student
        {
            get => Project.Students.Find(s => s.Guid == StudentGuid);
            set => StudentGuid = value.Guid;
        }

        [EntityField(Compare = true)]
        public Guid SubjectGuid { get; set; }

        [JsonIgnore]
        public Subject Subject
        {
            get => Project.Subjects.Find(s => s.Guid == SubjectGuid);
            set => SubjectGuid = value.Guid;
        }

        [EntityField(Compare = true)]
        public string GradeTypeName { get; set; }

        [JsonIgnore]
        public GradeType GradeType
        {
            get => GradeType.GetByName(GradeTypeName);
            set => GradeTypeName = value.Name;
        }

        [EntityField(Compare = true)]
        public int Number { get; set; }

        [EntityField]
        public int Value { get; set; }
    }
}
