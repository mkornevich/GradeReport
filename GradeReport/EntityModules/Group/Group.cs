using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Group
{
    public class Group : EntityWithGuid
    {
        public string Name { get; set; }

        public bool Include { get; set; }
    }
}
