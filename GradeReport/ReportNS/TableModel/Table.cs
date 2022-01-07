using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.TableModel
{
    public class Table
    {
        public List<Column> Columns { get; private set; } = new List<Column>();

        public List<Row> Rows { get; private set; } = new List<Row>();

        public List<Cell> Cells { get; private set; } = new List<Cell>();

        public Column CreateColumn()
        {
            var col = new Column(this);
            Columns.Add(col);
            Rows.ForEach(row => Cells.Add(new Cell(this, row, col)));
            return col;
        }

        public Row CreateRow()
        {
            var row = new Row(this);
            Rows.Add(row);
            Columns.ForEach(col => Cells.Add(new Cell(this, row, col)));
            return row;
        }
    }
}
