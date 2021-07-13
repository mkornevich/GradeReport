using GradeReport.EntityModules.ConfigNS;
using GradeReport.EntityModules.GroupNS;
using GradeReport.EntityModules.GroupSubjectRefNS;
using GradeReport.EntityModules.StudentNS;
using GradeReport.EntityModules.SubjectNS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.ProjectNS
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
            return project;
        }
    }
}
