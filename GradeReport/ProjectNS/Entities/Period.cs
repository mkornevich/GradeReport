﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS.Entities
{
    public class Period : EntityWithGuid
    {
        public Guid SemesterGuid { get; set; }

        [JsonIgnore]
        public Semester Semester
        {
            get => Project.Semesters.Find(s => s.Guid == SemesterGuid);
            set => SemesterGuid = value.Guid;
        }

        public int Order { get; set; }

        public string Name { get; set; }
    }
}
