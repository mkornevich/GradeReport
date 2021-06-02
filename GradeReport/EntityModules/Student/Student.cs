using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Student
{
    public class Student : EntityWithGuid
    {
        public string Name { get; set; }

        public int Number { get; set; }
    }
}
