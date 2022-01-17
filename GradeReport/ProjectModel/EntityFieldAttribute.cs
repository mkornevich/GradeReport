﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class EntityFieldAttribute : Attribute
    {
        public bool Compare { get; set; } = false;
    }
}