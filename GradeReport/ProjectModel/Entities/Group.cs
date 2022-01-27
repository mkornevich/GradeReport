using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel.Entities
{
    public class Group : EntityWithGuid
    {
        [EntityField]
        public string Name { get; set; }

        [JsonIgnore]
        public List<Course> Courses => Project.Courses
            .FindAll(c => c.GroupGuid == Guid)
            .OrderBy(c => c.Number)
            .ToList();

        [JsonIgnore]
        public List<Subject> Subjects => Project.GroupSubjectRefs
            .FindAll(gsr => gsr.GroupGuid == Guid)
            .Select(gsr => gsr.Subject)
            .ToList();
    }
}
