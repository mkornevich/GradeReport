using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Semester : EntityWithGuid
    {
        public Guid CourseGuid { get; set; }

        public int CourseHalf { get; set; }
    }
}
