using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.TableModel
{
    public class Cell
    {
        public Table Table { get; private set; }

        public Row Row { get; set; }

        public Column Column { get; set; }

        public Dictionary<string, object> Params { get; } = new Dictionary<string, object>();

        public object Value { get; set; }

        internal Cell(Table table, Row row, Column column)
        {
            Table = table;
            Row = row;
            Column = column;
        }
    }
}
