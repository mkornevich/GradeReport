using GradeReport.EntityModules.Config;
using GradeReport.EntityModules.Group;
using GradeReport.EntityModules.GroupSubjectRef;
using GradeReport.EntityModules.Student;
using GradeReport.EntityModules.Subject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Projects
{
    public class Project
    {
        public Config Config { get; set; }

        public DaoWithGuid<Group> Groups { get; set; } = new DaoWithGuid<Group>();
        public Dao<GroupSubjectRef> GroupSubjectRefs { get; set; } = new Dao<GroupSubjectRef>();
        public DaoWithGuid<Student> Students { get; set; } = new DaoWithGuid<Student>();
        public DaoWithGuid<Subject> Subjects { get; set; } = new DaoWithGuid<Subject>();

        public static Project CreateEmpty()
        {
            var project = new Project();

            project.Groups.Add(new Group() { Include = true, Name = "T91" });
            project.Groups.Add(new Group() { Include = true, Name = "T92" });
            project.Groups.Add(new Group() { Include = true, Name = "T93" });

            return project;
        }
    }
}
