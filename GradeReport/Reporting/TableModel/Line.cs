using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.TableModel
{
    public abstract class Line
    {
        public Table Table { get; private set; }

        public abstract int Index { get; }

        public string Group { get; set; }

        public string Name { get; set; }

        public Dictionary<string, object> Params { get; private set; } = new Dictionary<string, object>();

        public object Entity { get; set; }

        public abstract List<Cell> Cells { get; }

        public abstract void Remove();

        internal Line(Table table)
        {
            Table = table;
        }
    }
}
