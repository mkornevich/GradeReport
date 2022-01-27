using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel.Entities
{
    public class Course : EntityWithGuid
    {
        [EntityField]
        public Guid GroupGuid { get; set; }

        [JsonIgnore]
        public Group Group
        {
            get => Project.Groups.Find(g => g.Guid == GroupGuid);
            set => GroupGuid = value.Guid;
        }

        [EntityField]
        public Guid SpecialtyGuid { get; set; }

        [JsonIgnore]
        public Specialty Specialty
        {
            get => Project.Specialties.Find(s => s.Guid == SpecialtyGuid);
            set => SpecialtyGuid = value.Guid;
        }

        [EntityField]
        public string GroupNameForCourse { get; set; }

        [EntityField]
        public int Number { get; set; }

        [EntityField]
        public int StartYear { get; set; }

        [JsonIgnore]
        public string FullName => $"группа {Group.Name} > курс {Number}";

        [JsonIgnore]
        public List<Semester> Semesters => Project.Semesters
            .FindAll(s => s.CourseGuid == Guid)
            .OrderBy(s => s.LocalNumber)
            .ToList();
    }
}
