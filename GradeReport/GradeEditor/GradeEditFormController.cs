using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.GradeEditor
{
    public class GradeEditFormController
    {
        public Project Project { get; }

        public Semester Semester { get; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }

        public GradeType GradeType { get; set; }

        public List<GradeRow> GradeRows { get; set; }

        public int Number { get; set; } = 0;

        public GradeEditFormController(Semester semester)
        {
            Project = semester.Project;
            Semester = semester;

            GradeRows = Project.Grades
                .FindAll(g => g.SemesterGuid == Semester.Guid)
                .Select(g => new GradeRow(g))
                .ToList();
        }

        public List<int> Numbers => GradeRows
                    .FindAll(gr => gr.Grade.SubjectGuid == Subject.Guid && gr.Grade.GradeTypeName == GradeType.Name)
                    .Select(gr => gr.GradeNumber)
                    .Distinct()
                    .OrderBy(i => i)
                    .ToList();

        public void AddNumber()
        {
            int newNumber = Numbers.Count + 1;
            var students = Project.SemesterStudentRefs
                .FindAll(ssr => ssr.SemesterGuid == Semester.Guid)
                .Select(ssr => ssr.Student).ToList();
            foreach (var student in students)
            {
                var grade = new Grade()
                {
                    Project = Project,
                    SemesterGuid = Semester.Guid,
                    StudentGuid = student.Guid,
                    SubjectGuid = Subject.Guid,
                    GradeType = GradeType,
                    Number = newNumber,
                    Value = -1,
                };
                GradeRows.Add(new GradeRow(grade));
            }
            Number = newNumber;
        }

        public void DeleteNumber()
        {
            var count = Numbers.Count;
            GradeRows.RemoveAll(gr => gr.GradeNumber == Number && gr.Grade.GradeType.Name == GradeType.Name && gr.Grade.SubjectGuid == Subject.Guid);
            for (int num = Number + 1; num <= count; num++)
            {
                GradeRows
                    .FindAll(gr => gr.GradeNumber == num && gr.Grade.GradeType.Name == GradeType.Name && gr.Grade.SubjectGuid == Subject.Guid)
                    .ForEach(gr => gr.GradeNumber -= 1);
            }
            if (Number > count - 1)
            {
                Number -= 1;
            }
        }

        public List<GradeRow> GetGradeRowsForEditor()
        {
            return GradeRows
                    .FindAll(gr => gr.Grade.SubjectGuid == Subject.Guid
                    && gr.Grade.GradeTypeName == GradeType.Name
                    && gr.GradeNumber == Number)
                    .ToList();
        }

        public int GetNumbersCountByGradeType(GradeType gradeType)
        {
            return GradeRows
                .FindAll(gr => gr.Grade.GradeTypeName == gradeType.Name && gr.Grade.SubjectGuid == Subject.Guid)
                .Select(gr => gr.GradeNumber)
                .Distinct()
                .Count();
        } 
    }
}
