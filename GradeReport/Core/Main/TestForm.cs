using GradeReport.Core.Listing;
using GradeReport.Core.Notify;
using GradeReport.EntityModules.Subject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Main
{
    public partial class TestForm : Form
    {
        private List<Subject> _subjects = new List<Subject>()
            {
                new Subject() { Include = true, Name = "Математика", ShortName = "Матем" },
                new Subject() { Include = false, Name = "Бел яз", ShortName = "Матем" },
                new Subject() { Include = true, Name = "Бел лит", ShortName = "Матем" },
                new Subject() { Include = true, Name = "Ин яз", ShortName = "Матем" },
                new Subject() { Include = false, Name = "Биология", ShortName = "Матем" },
                new Subject() { Include = true, Name = "График", ShortName = "Матем" },
            };

        private ListForm _subjectsForm = new ListForm(new SubjectListAdapter()) {
            SelectMode = SelectMode.Single,
        };

        public TestForm()
        {
            InitializeComponent();

            _subjectsForm.Entities = _subjects.Cast<object>().ToList();
            _subjectsForm.SelectedEntities = _subjects.FindAll(s => !s.Include).Cast<object>().ToList();
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
