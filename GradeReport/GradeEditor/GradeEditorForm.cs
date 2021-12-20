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

namespace GradeReport.GradeEditor
{
    public partial class GradeEditorForm : Form
    {
        private GradeEditFormController _controller;

        private Project _project;

        private Semester _semester;


        public GradeEditorForm(Semester semester)
        {
            InitializeComponent();
            _controller = new GradeEditFormController(semester);
            _semester = semester;
            _project = _semester.Project;

            // semester
            semesterTB.Text = _semester.FullName;

            // subject
            var subjects = _project.SemesterSubjectRefs
                .FindAll(ssr => ssr.SemesterGuid == _semester.Guid)
                .Select(ssr => ssr.Subject)
                .ToList();
            subjectsLB.DataSource = subjects;
            subjectsLB.SelectedValueChanged += (s, e) =>
            {
                _controller.Subject = (Subject)subjectsLB.SelectedItem;
                _controller.Number = _controller.Numbers.Count > 0 ? 1 : 0;
                ReloadGradeTypesCount();
                ReloadEditor();
            };
            if (subjectsLB.SelectedItem != null)
            {
                _controller.Subject = (Subject)subjectsLB.SelectedItem;
            }

            // grade type
            gradeTypesLB.DataSource = GradeType.gradeTypes;
            gradeTypesLB.SelectedValueChanged += (s, e) =>
            {
                if (gradeTypesLB.DataSource != null)
                {
                    _controller.GradeType = (GradeType)gradeTypesLB.SelectedItem;
                    _controller.Number = _controller.Numbers.Count > 0 ? 1 : 0;
                    ReloadNumberLabel();
                    ReloadEditor();
                }
            };
            if (gradeTypesLB.SelectedItem != null)
            {
                _controller.GradeType = (GradeType)gradeTypesLB.SelectedItem;
            }

            // number
            _controller.Number = _controller.Numbers.Count > 0 ? 1 : 0;
            ReloadNumberLabel();

            ReloadEditor();
        }

        private void ReloadEditor()
        {
            editorDGV.DataSource = _controller.GetGradeRowsForEditor();
        }

        private void ReloadNumberLabel() => numberLbl.Text = _controller.Number > 0 ? _controller.Number.ToString() : "-";

        private void ReloadGradeTypesCount()
        {
            gradeTypesLB.DataSource = null;
            gradeTypesLB.DataSource = GradeType.gradeTypes;
        }

        private void numberAddBtn_Click(object sender, EventArgs e)
        {
            _controller.AddNumber();
            ReloadGradeTypesCount();
            ReloadNumberLabel();
            ReloadEditor();
        }

        private void numberLeftBtn_Click(object sender, EventArgs e)
        {
            if (_controller.Number - 1 >= 1)
            {
                _controller.Number -= 1;
            }
            ReloadNumberLabel();
            ReloadEditor();
        }

        private void numberRightBtn_Click(object sender, EventArgs e)
        {
            int last = _controller.Numbers.Count;
            if (_controller.Number + 1 <= last)
            {
                _controller.Number += 1;
            }
            ReloadNumberLabel();
            ReloadEditor();
        }

        private void numberDeleteBtn_Click(object sender, EventArgs e)
        {
            _controller.DeleteNumber();
            ReloadGradeTypesCount();
            ReloadNumberLabel();
            ReloadEditor();
        }

        private void gradeTypesLB_Format(object sender, ListControlConvertEventArgs e)
        {
            int count = _controller.GetNumbersCountByGradeType((GradeType)e.ListItem);
            e.Value = ((GradeType)e.ListItem).Description + " (" + count.ToString() + ")";
        }
    }
}
