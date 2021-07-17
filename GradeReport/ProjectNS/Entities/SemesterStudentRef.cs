using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class SemesterStudentRef : Entity
    {
        public Guid SemesterGuid { get; set; }

        public Guid StudentGuid { get; set; }
    }
}
