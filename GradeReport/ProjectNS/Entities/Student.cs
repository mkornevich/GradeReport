using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Student : EntityWithGuid
    {
        public Guid GroupGuid { get; set; }

        [JsonIgnore]
        public Group Group
        {
            get => Project.Groups.Find(g => g.Guid == GroupGuid);
            set => GroupGuid = value.Guid;
        }

        public string Name { get; set; }

        public int Number { get; set; }
    }
}
