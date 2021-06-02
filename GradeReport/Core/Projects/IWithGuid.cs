using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Projects
{
    public interface IWithGuid
    {
        public Guid Guid { get; set; }
    }
}
