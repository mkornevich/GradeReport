using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Subject : EntityWithGuid
    {
        [EntityField]
        public string Name { get; set; }

        [EntityField]
        public string ShortName { get; set; }

        [EntityField]
        public bool Include { get; set; }
    }
}