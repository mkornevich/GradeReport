
using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Main
{
    public partial class MainForm : Form
    {
        private ProjectLoader _projectLoader = new ProjectLoader();

        private ProjectContainer _projectContainer;

        public MainForm()
        {
            InitializeComponent();
            _projectContainer = App.ProjectContainer;

            _projectContainer.NewProjectLoaded += AdjustFormName;
            _projectContainer.IsSavedChanged += AdjustFormName;
            _projectContainer.PathChanged += AdjustFormName;

            _projectContainer.NewProjectLoaded += () =>
            {
                peTreeView.Fresh(_projectContainer.Project);
            };

            CreateNewProject();
        }

        private void AdjustFormName()
        {
            Text = "GradeReport - " 
                + _projectContainer.Name 
                + (_projectContainer.IsSaved ? "" : "*") 
                + (_projectContainer.Path == null ? "" : " - " + _projectContainer.Path);
        }

        private void CreateNewAct(object sender, EventArgs e)
        {
            CreateNewProject();
        }

        private void CreateNewProject()
        {
            _projectContainer.Project = Project.CreateEmpty();
            _projectContainer.Path = null;
            _projectContainer.IsSaved = false;
        }

        private void OpenAct(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectContainer.Project = _projectLoader.Load(openFileDialog.FileName);
                _projectContainer.Path = openFileDialog.FileName;
                _projectContainer.IsSaved = true;
            }
        }

        private void SaveAct(object sender, EventArgs e)
        {
            if (_projectContainer.Path == null)
            {
                SaveAsAct(sender, e);
            }
            else
            {
                _projectLoader.Store(App.ProjectContainer.Path, App.ProjectContainer.Project);
                _projectContainer.IsSaved = true;
            }
        }

        private void SaveAsAct(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectLoader.Store(saveFileDialog.FileName, _projectContainer.Project);
                _projectContainer.Path = saveFileDialog.FileName;
                _projectContainer.IsSaved = true;
            }
        }
    }
}
