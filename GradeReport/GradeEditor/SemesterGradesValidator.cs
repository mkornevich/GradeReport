using GradeReport.Common.NotificationNS;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.GradeEditor
{
    public class SemesterGradesValidator
    {
        private Semester _semester;

        private Project _project;

        private List<GradeRow> _gradeRows;

        private NotificationFormBuilder _builder;

        public bool Validate(Semester semester, List<GradeRow> gradeRows)
        {
            _semester = semester;
            _project = semester.Project;
            _gradeRows = gradeRows;
            _builder = new NotificationFormBuilder();

            DoValidate();

            if (_builder.ErrorCount > 0)
            {
                _builder.BuildForm().ShowDialog();
                return false;
            }

            if (_builder.MessageCount > 0)
            {
                return _builder.BuildForm().ShowForResult() == DialogResult.OK;
            }

            return true;
        }

        private void DoValidate()
        {
            _gradeRows.FindAll(gr => gr.GradeValue == GradeValue.Empty).ForEach(gr =>
            {
                var gradeType = gr.Grade.GradeType.Description.ToLower();
                var subject = gr.Grade.Subject.ShortName;
                var student = gr.Grade.Student.Name;
                _builder.Info($"Пропущена {gradeType} оценка по {subject} у {student}.");
            });
        }
    }
}
