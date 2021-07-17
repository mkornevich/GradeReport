using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class SemesterSubjectRef : Entity
    {
        public Guid SemesterGuid { get; set; }

        [JsonIgnore]
        public Semester Semester
        {
            get => Project.Semesters.Find(s => s.Guid == SemesterGuid);
            set => SemesterGuid = value.Guid;
        }

        public Guid SubjectGuid { get; set; }

        [JsonIgnore]
        public Subject Subject
        {
            get => Project.Subjects.Find(s => s.Guid == SubjectGuid);
            set => SubjectGuid = value.Guid;
        }
    }
}
