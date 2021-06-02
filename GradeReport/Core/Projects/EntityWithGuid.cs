using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Projects
{
    public class EntityWithGuid : Entity
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}
