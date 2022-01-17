using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel
{
    public class EntityWithGuid : Entity
    {
        [EntityField(Compare = true)]
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}
