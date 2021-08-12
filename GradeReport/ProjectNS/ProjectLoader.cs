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
            var project = JsonConvert.DeserializeObject<Project>(jsonProject);
            AddProjectToEntities(project);
            return project;
        }

        private void AddProjectToEntities(Project project)
        {
            project.Groups.ForEach(e => e.Project = project);
            project.GroupSubjectRefs.ForEach(e => e.Project = project);
            project.Courses.ForEach(e => e.Project = project);
            project.Specialties.ForEach(e => e.Project = project);
            project.Qualifications.ForEach(e => e.Project = project);
            project.Students.ForEach(e => e.Project = project);
            project.SemesterStudentRefs.ForEach(e => e.Project = project);
            project.Semesters.ForEach(e => e.Project = project);
            project.SemesterSubjectRefs.ForEach(e => e.Project = project);
            project.Periods.ForEach(e => e.Project = project);
            project.Subjects.ForEach(e => e.Project = project);
            project.Grades.ForEach(e => e.Project = project);
            project.MyStudentRefs.ForEach(e => e.Project = project);
        }

        public void Store(string path, Project project)
        {
            var jsonProject = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(path, jsonProject);
        }
    }
}
