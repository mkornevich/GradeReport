using GradeReport.ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel
{
    public class ProjectContainer
    {
        private string _path;

        public string Path
        {
            get => _path; 
            set
            {
                _path = value;
                PathChanged?.Invoke();
            }
        }

        public event Action PathChanged;

        public string Name => Path == null ? "Новый проект" : System.IO.Path.GetFileName(Path);

        private Project _project;

        public Project Project
        {
            get => _project;
            set
            {
                if (_project != null) _project.Changed -= OnProjectChanged;
                _project = value;
                _project.Changed += OnProjectChanged;
                OnNewProjectLoaded();
            }
        }

        public event Action NewProjectLoaded;

        public void OnNewProjectLoaded()
        {
            NewProjectLoaded?.Invoke();
            OnProjectChanged();
        }

        public event Action ProjectChanged;

        public void OnProjectChanged()
        {
            ProjectChanged?.Invoke();
        }
    }
}
