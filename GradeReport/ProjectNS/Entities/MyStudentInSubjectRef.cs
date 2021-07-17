using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class MyStudentInSubjectRef : Entity
    {
        public Guid StudentGuid { get; set; }

        public Guid SubjectGuid { get; set; }
    }
}
