using GradeReport.ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Master
{
    public partial class AddStudentsMasterForm : Form
    {
        private Group _group;

        private Project _project;

        public AddStudentsMasterForm(Group group)
        {
            InitializeComponent();
            _group = group;
            _project = group.Project;

            groupLbl.Text = _group.Name;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var newStudents = studentNamesTB.Lines.ToList()
                .FindAll(name => name.Length > 0)
                .Select(name => new Student() { Project = _project, Group = _group, Name = name });

            _project.Students.AddRange(newStudents);
            App.ProjectContainer.OnProjectChanged();

            Close();
        }
    }
}
