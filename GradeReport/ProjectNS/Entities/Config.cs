using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Config : Entity
    {
        public string CuratorName { get; set; }

        public string TeacherName { get; set; }

        public Guid CuratorGroupGuid { get; set; }

        [JsonIgnore]
        public Group CuratorGroup
        {
            get => Project.Groups.Find(g => g.Guid == CuratorGroupGuid);
            set => CuratorGroupGuid = value.Guid;
        }
    }
}
