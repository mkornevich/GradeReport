using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Course : EntityWithGuid
    {
        public Guid GroupGuid { get; set; }

        public Guid SpecialtyGuid { get; set; }

        public string GroupNameForCourse { get; set; }

        public int Number { get; set; }

        public int StartYear { get; set; }
    }
}
