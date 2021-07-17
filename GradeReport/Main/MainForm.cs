using CefSharp.WinForms;
using GradeReport.ProjectNS;
using GradeReport.ProjectNS.Entities;
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

            _projectContainer.ProjectChanged += () => AdjustFormName(false);
            _projectContainer.PathChanged += () => AdjustFormName(false);

            _projectContainer.NewProjectLoaded += () =>
            {
                peTreeView.LoadProject(_projectContainer.Project);
            };

            CreateNewAct(null, null);

            peTreeView.InfoChanged += PEInfoChangedAct;
        }

        private void PEInfoChangedAct(string info)
        {
            infoTB.Text = info.Replace("\n", "\r\n");
        }

        private void AdjustFormName(bool isSaved)
        {
            Text = "GradeReport - "
                + _projectContainer.Name
                + (isSaved ? "" : "*")
                + (_projectContainer.Path == null ? "" : " - " + _projectContainer.Path);
        }

        private void CreateNewAct(object sender, EventArgs e)
        {
            _projectContainer.Project = Project.CreateEmpty();
            _projectContainer.Path = null;
        }

        private void OpenAct(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectContainer.Project = _projectLoader.Load(openFileDialog.FileName);
                _projectContainer.Path = openFileDialog.FileName;
                AdjustFormName(true);
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
                AdjustFormName(true);
            }
        }

        private void SaveAsAct(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _projectLoader.Store(saveFileDialog.FileName, _projectContainer.Project);
                _projectContainer.Path = saveFileDialog.FileName;
                AdjustFormName(true);
            }
        }

        private void ShowTestFormAct(object sender, EventArgs e)
        {
            new TestForm().Show();
        }
    }
}
