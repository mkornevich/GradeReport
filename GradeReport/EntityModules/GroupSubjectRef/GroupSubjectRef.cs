using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.GroupSubjectRef
{
    public class GroupSubjectRef
    {
        public int GroupId { get; set; }

        public int SubjectId { get; set; }

        public bool HasCourse { get; set; }
    }
}
