using GradeReport.GradeEditor;
using GradeReport.ProjectModel;
using GradeReport.ProjectModel.Entities;
using GradeReport.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Main
{
    public partial class MainForm : Form
    {
        private ProjectLoader _projectLoader = new ProjectLoader();

        private ProjectContainer _projectContainer;

        private bool _isSaved = true;

        private bool IsSaved
        {
            get => _isSaved;
            set
            {
                _isSaved = value;
                UpdateFormText();
            }
        }

        public MainForm()
        {
            InitializeComponent();

            _projectContainer = App.ProjectContainer;

            _projectContainer.PathChanged += () => IsSaved = false;
            _projectContainer.NewProjectLoaded += () => peTreeView.LoadProject(_projectContainer.Project);

            _projectContainer.ProjectChanged += () =>
            {
                IsSaved = false;
                peTreeView.Fresh();
                UpdateInfoPanel();
            };

            peTreeView.AfterSelect += (s, e) => UpdateInfoPanel();

            CreateNewAct(null, null);

            new ReportsLoader().LoadToMenuItem(reports);

            var args = Environment.GetCommandLineArgs();
            if (args.Length == 2 && File.Exists(args[1]))
            {
                _projectContainer.Project = _projectLoader.Load(args[1]);
                _projectContainer.Path = args[1];
                IsSaved = true;
            }

            if (App.IsDebug)
            {
                _projectContainer.Project = _projectLoader.Load(App.AppDataPath + "\\test.gr");
                _projectContainer.Path = App.AppDataPath + "\\test.gr";
                IsSaved = true;
            }
        }

        private void UpdateInfoPanel() => infoTB.Text = peTreeView.Info;

        private void UpdateFormText()
        {
            Text = "GradeReport - "
                + _projectContainer.Name
                + (_isSaved ? "" : "*")
                + (_projectContainer.Path == null ? "" : " - " + _projectContainer.Path);
        }

        private void CreateNewAct(object sender, EventArgs e)
        {
            _projectContainer.Project = new Project();
            _projectContainer.Path = null;
            IsSaved = true;
        }

        private void OpenAct(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectContainer.Project = _projectLoader.Load(openFileDialog.FileName);
                _projectContainer.Path = openFileDialog.FileName;
                IsSaved = true;
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
                IsSaved = true;
            }
        }

        private void SaveAsAct(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectLoader.Store(saveFileDialog.FileName, _projectContainer.Project);
                _projectContainer.Path = saveFileDialog.FileName;
                IsSaved = true;
            }
        }

        private void ShowTestFormAct(object sender, EventArgs e)
        {
            new TestForm().Show();
        }

        private void aboutMI_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void guideMI_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, App.AppDataPath + "\\Guide.chm");
        }

        private void FormClosingAct(object sender, FormClosingEventArgs e)
        {
            if (IsSaved) return;

            var result = MessageBox.Show("Хотите сохранить изменения?", "Выход", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

            if (result == DialogResult.Yes)
            {
                SaveAct(sender, e);
            }
        }
    }
}
