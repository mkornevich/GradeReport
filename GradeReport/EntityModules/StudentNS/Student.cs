using GradeReport.Core.ProjectNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.StudentNS
{
    public class Student : EntityWithGuid
    {
        public Guid GroupGuid { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }
    }
}
