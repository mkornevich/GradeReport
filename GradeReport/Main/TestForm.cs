using GradeReport.List;
using GradeReport.List.Adapters;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Main
{
    public partial class TestForm : Form
    {
        private List<Subject> _subjects = new List<Subject>()
            {
                new Subject() { Name = "Математика", ShortName = "Матем" },
                new Subject() { Name = "Бел яз", ShortName = "Матем" },
                new Subject() { Name = "Бел лит", ShortName = "Матем" },
                new Subject() { Name = "Ин яз", ShortName = "Матем" },
                new Subject() { Name = "Биология", ShortName = "Матем" },
                new Subject() { Name = "График", ShortName = "Матем" },
            };

        private ListForm _subjectsForm = new ListForm(new SubjectListAdapter()) {
            SelectMode = SelectMode.Single,
        };

        public TestForm()
        {
            InitializeComponent();

            _subjectsForm.Entities = _subjects.Cast<object>().ToList();
            _subjectsForm.SelectedEntities = _subjects.Cast<object>().ToList();
            _subjectsForm.Chooser = chooser1;

            //_subjectsForm.SelectionChanged += () => MessageBox.Show(string.Join(", ", _subjectsForm.SelectedEntities.Select(e => ((Subject)e).Name)));
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show(string.Join(", ", _subjectsForm.SelectedEntities.Select(e => ((Subject)e).Name)));

            //MessageBox.Show(_subjectsForm.ShowForResult().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
