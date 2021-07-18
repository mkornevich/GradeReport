using GradeReport.ProjectNS.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectNS
{
    public class Entity : IProjectProperty
    {
        [JsonIgnore]
        public Project Project { get; set; }

        public void CopyTo(Entity toEntity)
        {
            EntityUtils.Copy(this, toEntity);
        }
    }
}
