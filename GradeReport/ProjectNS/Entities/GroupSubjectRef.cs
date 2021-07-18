using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class GroupSubjectRef : Entity
    {
        [EntityField(Compare = true)]
        public Guid GroupGuid { get; set; }

        [JsonIgnore]
        public Group Group
        {
            get => Project.Groups.Find(g => g.Guid == GroupGuid);
            set => GroupGuid = value.Guid;
        }

        [EntityField(Compare = true)]
        public Guid SubjectGuid { get; set; }

        [JsonIgnore]
        public Subject Subject
        {
            get => Project.Subjects.Find(s => s.Guid == SubjectGuid);
            set => SubjectGuid = value.Guid;
        }
    }
}
