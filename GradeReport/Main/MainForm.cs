using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
using GradeReport.ReportNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        public MainForm()
        {
            InitializeComponent();

            _projectContainer = App.ProjectContainer;

            _projectContainer.PathChanged += () => UpdateFormText(false);
            _projectContainer.NewProjectLoaded += () => peTreeView.LoadProject(_projectContainer.Project);

            _projectContainer.ProjectChanged += () => {
                UpdateFormText(false);
                peTreeView.Fresh();
                UpdateInfoPanel();
            };

            peTreeView.AfterSelect += (s, e) => UpdateInfoPanel();

            CreateNewAct(null, null);

            new ReportsLoader().LoadToMenuItem(reports);
        }

        private void UpdateInfoPanel() => infoTB.Text = peTreeView.Info;

        private void UpdateFormText(bool isSaved)
        {
            Text = "GradeReport - "
                + _projectContainer.Name
                + (isSaved ? "" : "*")
                + (_projectContainer.Path == null ? "" : " - " + _projectContainer.Path);
        }

        private void CreateNewAct(object sender, EventArgs e)
        {
            _projectContainer.Project = new Project();
            _projectContainer.Path = null;
        }

        private void OpenAct(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectContainer.Project = _projectLoader.Load(openFileDialog.FileName);
                _projectContainer.Path = openFileDialog.FileName;
                UpdateFormText(true);
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
                UpdateFormText(true);
            }
        }

        private void SaveAsAct(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectLoader.Store(saveFileDialog.FileName, _projectContainer.Project);
                _projectContainer.Path = saveFileDialog.FileName;
                UpdateFormText(true);
            }
        }

        private void ShowTestFormAct(object sender, EventArgs e)
        {
            new TestForm().Show();
        }
    }
}
