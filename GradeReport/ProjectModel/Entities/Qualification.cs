using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel.Entities
{
    public class Qualification : EntityWithGuid
    {
        [EntityField]
        public string Name { get; set; }
    }
}
