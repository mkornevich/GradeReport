
using GradeReport.Core.Listing;
using GradeReport.Core.Notify;
using GradeReport.Core.Projects;
using GradeReport.EntityModules.Subject;
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

            Shown += MainForm_Shown;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            var subjects = new List<Subject>()
            {
                new Subject() { Include = true, Name = "Математика", ShortName = "Матем" },
                new Subject() { Include = false, Name = "Бел яз", ShortName = "Матем" },
                new Subject() { Include = true, Name = "Бел лит", ShortName = "Матем" },
                new Subject() { Include = true, Name = "Ин яз", ShortName = "Матем" },
                new Subject() { Include = false, Name = "Биология", ShortName = "Матем" },
                new Subject() { Include = true, Name = "График", ShortName = "Матем" },
            };


            var form = new ListForm();
            form.Adapter = new SubjectListAdapter();

            form.Entities = subjects.Cast<object>().ToList();
            form.SelectedEntities = subjects.FindAll(s => !s.Include).Cast<object>().ToList();

            form.SelectMode = SelectMode.Single;

            form.SelectionChanged += () => MessageBox.Show(string.Join(", ", form.SelectedEntities.Select(e => ((Subject)e).Name)));

            form.ShowDialog();
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

        private void showTestFormAct(object sender, EventArgs e)
        {
            new TestForm().Show();
        }
    }
}
