﻿using GradeReport.Core.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.EntityModules.GroupSubjectRef
{
    public class GroupSubjectRef : Entity
    {
        public Guid GroupGuid { get; set; }

        public Guid SubjectGuid { get; set; }

        public bool HasCourse { get; set; }
    }
}
