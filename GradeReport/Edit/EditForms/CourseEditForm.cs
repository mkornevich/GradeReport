﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Edit.EditForms
{
    public partial class CourseEditForm : EditForm
    {
        public CourseEditForm()
        {
            InitializeComponent();
            EntityName = "Курс";
        }
    }
}
