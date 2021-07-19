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
        [EntityField]
        public string CuratorName { get; set; }

        [EntityField]
        public string TeacherName { get; set; }

        [EntityField]
        public Guid CuratorGroupGuid { get; set; }

        [JsonIgnore]
        public Group CuratorGroup
        {
            get => Project.Groups.Find(g => g.Guid == CuratorGroupGuid);
            set => CuratorGroupGuid = value.Guid;
        }
    }
}
