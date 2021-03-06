using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.TableModel
{
    public class Column : Line
    {
        public override List<Cell> Cells
        {
            get
            {
                var colCells = Table.Cells.FindAll(c => c.Column == this);
                return Table.Rows
                    .Select(row => colCells.Find(c => c.Row == row))
                    .ToList();
            }
        }

        public override int Index => Table.Columns.IndexOf(this);

        internal Column(Table table) : base(table)
        {
        }

        public override void Remove()
        {
            Table.Cells.RemoveAll(c => c.Column == this);
            Table.Columns.Remove(this);
        }
    }
}
