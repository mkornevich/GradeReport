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
        public Guid QualificationGuid { get; set; }

        [JsonIgnore]
        public Qualification Qualification
        {
            get => Project.Qualifications.Find(q => q.Guid == QualificationGuid);
            set => QualificationGuid = value.Guid;
        }

        public string Code { get; set; }

        public string Name { get; set; }
    }
}
