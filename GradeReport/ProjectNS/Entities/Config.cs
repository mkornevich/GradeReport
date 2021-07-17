using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Config : Entity
    {
        public string CuratorName { get; set; }

        public string TeacherName { get; set; }

        public Guid CuratorGroupGuid { get; set; }
    }
}
