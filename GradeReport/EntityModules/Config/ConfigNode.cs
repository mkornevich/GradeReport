using GradeReport.Core.ProjectExplorer;
using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.Config
{
    public class ConfigNode : PENode
    {
        protected override void Visualize()
        {
            Text = "Конфигурация";
        }
    }
}
