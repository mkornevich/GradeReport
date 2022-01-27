using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel.Entities
{
    public class Project
    {
        [JsonProperty]
        public Config Config { get; private set; }

        public EntityCollection<Group> Groups { get; }

        public EntityCollection<GroupSubjectRef> GroupSubjectRefs { get; }

        public EntityCollection<Course> Courses { get; }

        public EntityCollection<Specialty> Specialties { get; }

        public EntityCollection<Qualification> Qualifications { get; }

        public EntityCollection<Student> Students { get; }

        public EntityCollection<SemesterStudentRef> SemesterStudentRefs { get; }

        public EntityCollection<Semester> Semesters { get; }

        public EntityCollection<SemesterSubjectRef> SemesterSubjectRefs { get; }

        public EntityCollection<Subject> Subjects { get; }

        public EntityCollection<Grade> Grades { get; }

        public EntityCollection<MyStudentRef> MyStudentRefs { get; }

        public event Action Changed;

        public Project()
        {
            Config = new Config();
            Groups = new EntityCollection<Group>(this);
            GroupSubjectRefs = new EntityCollection<GroupSubjectRef>(this);
            Courses = new EntityCollection<Course>(this);
            Specialties = new EntityCollection<Specialty>(this);
            Qualifications = new EntityCollection<Qualification>(this);
            Students = new EntityCollection<Student>(this);
            SemesterStudentRefs = new EntityCollection<SemesterStudentRef>(this);
            Semesters = new EntityCollection<Semester>(this);
            SemesterSubjectRefs = new EntityCollection<SemesterSubjectRef>(this);
            Subjects = new EntityCollection<Subject>(this);
            Grades = new EntityCollection<Grade>(this);
            MyStudentRefs = new EntityCollection<MyStudentRef>(this);
        }

        public void OnChanged()
        {
            Changed?.Invoke();
        }
    }
}
