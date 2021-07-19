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
        [EntityField(Compare = true)]
        public Guid PeriodGuid { get; set; }

        [JsonIgnore]
        public Period Period
        {
            get => Project.Periods.Find(s => s.Guid == PeriodGuid);
            set => PeriodGuid = value.Guid;
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
        public string GradeType { get; set; }

        [EntityField(Compare = true)]
        public int Number { get; set; }

        [EntityField]
        public int Value { get; set; }
    }
}
