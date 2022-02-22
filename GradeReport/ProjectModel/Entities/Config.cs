using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel.Entities
{
    public class Config : Entity
    {
        [EntityField]
        public string ParentOrganizationName { get; set; } = "";

        [EntityField]
        public string OrganizationName { get; set; } = "";

        [EntityField]
        public string CuratorName { get; set; } = "";

        [EntityField]
        public string TeacherName { get; set; } = "";

        [EntityField]
        public Guid CuratorGroupGuid { get; set; }

        [JsonIgnore]
        public Group CuratorGroup
        {
            get => Project.Groups.Find(g => g.Guid == CuratorGroupGuid);
            set => CuratorGroupGuid = value.Guid;
        }

        public Config(Project project)
        {
            Project = project;
        }
    }
}
