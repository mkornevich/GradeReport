using GradeReport.ProjectModel.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ProjectModel
{
    public interface IProjectProperty
    {
        Project Project { get; set; }
    }
}
