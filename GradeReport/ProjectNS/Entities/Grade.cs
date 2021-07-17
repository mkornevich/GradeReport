using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Grade : Entity
    {
        public Guid PeriodGuid { get; set; }

        public Guid StudentGuid { get; set; }

        public Guid SubjectGuid { get; set; }

        public string GradeType { get; set; }

        public int Number { get; set; }

        public int Value { get; set; }
    }
}
