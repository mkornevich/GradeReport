using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Projects
{
    public class ProjectLoader
    {
        public Project Load(string path)
        {
            var jsonProject = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Project>(jsonProject);
        }

        public void Store(string path, Project project)
        {
            var jsonProject = JsonConvert.SerializeObject(project);
            File.WriteAllText(path, jsonProject);
        }
    }
}
