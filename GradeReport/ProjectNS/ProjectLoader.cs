using GradeReport.ProjectNS.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS
{
    public class ProjectLoader
    {
        public Project Load(string path)
        {
            var jsonProject = File.ReadAllText(path);
            var project = JsonConvert.DeserializeObject<Project>(jsonProject, new JsonSerializerSettings() { 
                ContractResolver = new ProjectContractResolver(),
            });
            return project;
        }

        public void Store(string path, Project project)
        {
            var jsonProject = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(path, jsonProject);
        }
    }
}
