using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Course : EntityWithGuid
    {
        public Guid GroupGuid { get; set; }

        [JsonIgnore]
        public Group Group
        {
            get => Project.Groups.Find(g => g.Guid == GroupGuid);
            set => GroupGuid = value.Guid;
        }

        public Guid SpecialtyGuid { get; set; }

        [JsonIgnore]
        public Specialty Specialty
        {
            get => Project.Specialties.Find(s => s.Guid == SpecialtyGuid);
            set => SpecialtyGuid = value.Guid;
        }

        public string GroupNameForCourse { get; set; }

        public int Number { get; set; }

        public int StartYear { get; set; }
    }
}
