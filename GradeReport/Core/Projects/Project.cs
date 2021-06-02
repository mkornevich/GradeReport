using GradeReport.EntityModules.Group;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Projects
{
    public class Project
    {
        public GroupDao Groups { get; set; }

        public static Project CreateEmpty()
        {
            return new Project();
        }
    }
}
