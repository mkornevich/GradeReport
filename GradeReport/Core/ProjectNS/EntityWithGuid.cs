using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.ProjectNS
{
    public class EntityWithGuid : Entity
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}
