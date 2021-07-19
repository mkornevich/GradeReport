﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
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
        public int CourseHalf { get; set; }
    }
}
