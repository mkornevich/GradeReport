﻿using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectNS
{
    public class Entity : IProjectProperty
    {
        public Project Project { get; set; }
    }
}
