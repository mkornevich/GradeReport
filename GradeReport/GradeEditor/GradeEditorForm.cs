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

        private bool _isSyncGuiEvent = false;

        public GradeEditorForm(Semester semester)
        {
            InitializeComponent();
            _controller = new GradeEditFormController(semester);
            _semester = semester;
            _project = _semester.Project;

            // semester
            semesterTB.Text = _semester.FullName;

            // subject
            subjectsLB.DataSource = _project.SemesterSubjectRefs
                .FindAll(ssr => ssr.SemesterGuid == _semester.Guid)
                .Select(ssr => ssr.Subject)
                .ToList();
            subjectsLB.SelectedValueChanged += (s, e) =>
            {
                if (_isSyncGuiEvent) return;
                _controller.Subject = (Subject)subjectsLB.SelectedItem;
                _controller.Number = _controller.Numbers.Count > 0 ? 1 : 0;
                SyncGUI();
            };
            if (subjectsLB.SelectedItem != null)
            {
                _controller.Subject = (Subject)subjectsLB.SelectedItem;
            }

            // grade type
            gradeTypesLB.DataSource = GradeType.gradeTypes;
            gradeTypesLB.SelectedValueChanged += (s, e) =>
            {
                if (_isSyncGuiEvent) return;
                _controller.GradeType = (GradeType)gradeTypesLB.SelectedItem;
                _controller.Number = _controller.Numbers.Count > 0 ? 1 : 0;
                SyncGUI();
            };
            if (gradeTypesLB.SelectedItem != null)
            {
                _controller.GradeType = (GradeType)gradeTypesLB.SelectedItem;
            }

            // number
            _controller.Number = _controller.Numbers.Count > 0 ? 1 : 0;

            SyncGUI();
        }

        private void SyncGUI()
        {
            _isSyncGuiEvent = true;

            editorDGV.DataSource = _controller.GetGradeRowsForEditor();

            numberLbl.Text = _controller.Number > 0 ? _controller.Number.ToString() : "-";

            var selected = gradeTypesLB.SelectedIndex;
            gradeTypesLB.DataSource = null;
            gradeTypesLB.DataSource = GradeType.gradeTypes;
            gradeTypesLB.SelectedIndex = selected;


            _isSyncGuiEvent = false;
        }

        private void numberAddBtn_Click(object sender, EventArgs e)
        {
            _controller.AddNumber();
            SyncGUI();
        }

        private void numberLeftBtn_Click(object sender, EventArgs e)
        {
            if (_controller.Number - 1 >= 1)
            {
                _controller.Number -= 1;
            }
            SyncGUI();
        }

        private void numberRightBtn_Click(object sender, EventArgs e)
        {
            int last = _controller.Numbers.Count;
            if (_controller.Number + 1 <= last)
            {
                _controller.Number += 1;
            }
            SyncGUI();
        }

        private void numberDeleteBtn_Click(object sender, EventArgs e)
        {
            _controller.DeleteNumber();
            SyncGUI();
        }

        private void gradeTypesLB_Format(object sender, ListControlConvertEventArgs e)
        {
            int count = _controller.GetNumbersCountByGradeType((GradeType)e.ListItem);
            e.Value = ((GradeType)e.ListItem).Description + " (" + count.ToString() + ")";
        }

        private void editorDGV_KeyUp(object sender, KeyEventArgs e)
        {
            var gradeValue = GradeValue.GetByKeyCode(e.KeyCode);

            if (gradeValue == null || editorDGV.SelectedRows.Count <= 0) return;

            if (_controller.GradeType.Name != GradeType.Semester &&
                (gradeValue.Value == GradeValue.Passed || gradeValue.Value == GradeValue.Released)) return;

            int selectedRowIndex = editorDGV.SelectedRows[0].Index;
            editorDGV.Rows[selectedRowIndex].Cells["GradeValueColumn"].Value = gradeValue.Value;
            if (selectedRowIndex + 1 < editorDGV.RowCount)
            {
                editorDGV.Rows[selectedRowIndex + 1].Cells["GradeValueColumn"].Selected = true;
            }
        }

        private void editorDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == editorDGV.Columns["GradeValueColumn"].Index)
            {
                var value = (int)editorDGV.Rows[e.RowIndex].Cells["GradeValueColumn"].Value;
                e.Value = GradeValue.GetByValue(value).DisplayAs;
                e.FormattingApplied = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _project.Grades.RemoveAll(g => g.Semester.Guid == _semester.Guid);
            _controller.GradeRows.ForEach(gr =>
            {
                gr.ToGrade();
                _project.Grades.Add(gr.Grade);
            });
            App.ProjectContainer.OnProjectChanged();
            MessageBox.Show("Изменения успешно проверены и применены!");
        }
    }
}
