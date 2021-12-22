using GradeReport.GradeEditor;
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

            // auto load project for debug
            _projectContainer.Project = _projectLoader.Load(App.AppDataPath + "\\test.gr");
            _projectContainer.Path = App.AppDataPath + "\\test.gr";

            //var semester = App.ProjectContainer.Project.Semesters.Find(s => s.Guid.ToString() == "539bbaaf-b99b-4771-b81b-83036fc6b5e5");
            //new GradeEditorForm(semester).Show();
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

        private void aboutMI_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
    }
}
