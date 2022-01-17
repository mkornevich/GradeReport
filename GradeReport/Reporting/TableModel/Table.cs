using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.TableModel
{
    public class Table
    {
        public ColumnCollection Columns { get; private set; } = new ColumnCollection();

        public RowCollection Rows { get; private set; } = new RowCollection();

        public List<Cell> Cells { get; private set; } = new List<Cell>();

        public Cell this[int rowIndex, int columnIndex] => this[Rows[rowIndex], Columns[columnIndex]];

        public Cell this[Row row, Column column] => Cells.Find(c => c.Row == row && c.Column == column);

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
