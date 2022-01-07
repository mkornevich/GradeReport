﻿using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.SemesterGradesSheet
{
    public class InputModel : BaseInputModel
    {
        public Group Group { get; set; }

        public Semester Semester { get; set; }

        public Subject Subject { get; set; }

        public DateTime Date { get; set; }
    }
}