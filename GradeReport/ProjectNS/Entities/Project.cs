using GradeReport.ProjectNS.Daos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Project
    {
        public Config Config { get; } = new Config();

        public GroupDao Groups { get; } = new GroupDao();

        public GroupSubjectRefDao GroupSubjectRefs { get; } = new GroupSubjectRefDao();

        public CourseDao Courses { get; } = new CourseDao();

        public SpecialtyDao Specialties { get; } = new SpecialtyDao();

        public QualificationDao Qualifications { get; } = new QualificationDao();

        public StudentDao Students { get; } = new StudentDao();

        public SemesterStudentRefDao SemesterStudentRefs { get; } = new SemesterStudentRefDao();

        public SemesterDao Semesters { get; } = new SemesterDao();

        public SemesterSubjectRefDao SemesterSubjectRefs { get; } = new SemesterSubjectRefDao();

        public SubjectDao Subjects { get; } = new SubjectDao();

        public GradeDao Grades { get; } = new GradeDao();

        public MyStudentRefDao MyStudentRefs { get; } = new MyStudentRefDao();

        public event Action Changed;

        public void OnChanged() 
        {
            Changed?.Invoke();
        }

        public Project()
        {
            new List<IProjectProperty> {
                Config, Groups, GroupSubjectRefs, Courses, Specialties, Qualifications,
                Students, SemesterStudentRefs, Semesters, SemesterSubjectRefs,
                Subjects, Grades, MyStudentRefs
            }.ForEach(e => e.Project = this);
        }
    }
}
