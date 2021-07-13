using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.ProjectNS
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

        public string Name => Path == null ? "Новый проект" : System.IO.Path.GetFileName(Path);

        private bool _isSaved = true;

        public bool IsSaved
        {
            get => _isSaved;
            set
            {
                if (_isSaved != value)
                {
                    _isSaved = value;
                    IsSavedChanged?.Invoke();
                }
            }
        }

        private Project _project;

        public Project Project
        {
            get => _project;
            set
            {
                _project = value;
                OnNewProjectLoaded();
            }
        }

        public event Action IsSavedChanged;

        public event Action NewProjectLoaded;

        public event Action PathChanged;

        public void OnNewProjectLoaded() => NewProjectLoaded?.Invoke();
    }
}
