using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Listing
{
    public class EntityRow
    {
        public object Entity { get; set; }

        public bool Selected { get; set; }

        public string[] Columns { get; set; }
    }
}
