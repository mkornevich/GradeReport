using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.GradeEditor
{
    public class GradeRow
    {
        public int StudentIndex = 0;

        public string StudentName => Grade.Student.Name;

        [Browsable(false)]
        public Grade Grade { get; set; }

        [Browsable(false)]
        public int GradeNumber { get; set; }

        public int GradeValue { get; set; }

        public GradeRow(Grade grade)
        {
            Grade = grade;
            GradeValue = grade.Value;
            GradeNumber = grade.Number;
        }

        public void ToGrade() {
            Grade.Value = GradeValue;
            Grade.Number = GradeNumber;
        }
    }
}
