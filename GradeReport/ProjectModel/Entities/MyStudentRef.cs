using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel.Entities
{
    public class MyStudentRef : Entity
    {
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
        public Guid SemesterGuid { get; set; }

        [JsonIgnore]
        public Semester Semester
        {
            get => Project.Semesters.Find(s => s.Guid == SemesterGuid);
            set => SemesterGuid = value.Guid;
        }
    }
}
