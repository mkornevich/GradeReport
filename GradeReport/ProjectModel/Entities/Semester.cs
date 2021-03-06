using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel.Entities
{
    public class Semester : EntityWithGuid
    {
        [EntityField]
        public Guid CourseGuid { get; set; }

        [JsonIgnore]
        public Course Course
        {
            get => Project.Courses.Find(s => s.Guid == CourseGuid);
            set => CourseGuid = value.Guid;
        }

        [EntityField]
        public int LocalNumber { get; set; }

        [JsonIgnore]
        public string FullName => $"группа {Course.Group.Name} > курс {Course.Number} > семестр {LocalNumber}";

        [JsonIgnore]
        public int AbsoluteNumber
        {
            get
            {
                var courseNumber = Course.Number;
                return courseNumber + courseNumber - 2 + LocalNumber;
            }
        }

        [JsonIgnore]
        public List<Student> Students => Project.SemesterStudentRefs
            .FindAll(ssr => ssr.SemesterGuid == Guid)
            .Select(gsr => gsr.Student)
            .OrderBy(s => s.Name)
            .ToList();
    }
}
