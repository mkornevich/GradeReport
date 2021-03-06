using GradeReport.ProjectModel.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ProjectModel
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
            try
            {
                File.WriteAllText(path, jsonProject);
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удается сохранить проект. Ошибка: " + e.Message);
            }
            
        }
    }
}
