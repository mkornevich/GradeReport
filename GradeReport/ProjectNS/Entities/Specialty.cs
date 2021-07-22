using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Specialty : EntityWithGuid
    {
        [EntityField]
        public Guid QualificationGuid { get; set; }

        [JsonIgnore]
        public Qualification Qualification
        {
            get => Project.Qualifications.Find(q => q.Guid == QualificationGuid);
            set => QualificationGuid = value.Guid;
        }

        [EntityField]
        public string Code { get; set; }

        [EntityField]
        public string Name { get; set; }

        [JsonIgnore]
        public string FullName => $"{Qualification.Name} > {Name}, {Code}";
    }
}
