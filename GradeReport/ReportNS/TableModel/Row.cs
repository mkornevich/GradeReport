using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.ReportNS.TableModel
{
    public class Row : Line
    {
        public override List<Cell> Cells
        {
            get
            {
                var rowCells = Table.Cells.FindAll(c => c.Row == this);
                return Table.Columns
                    .Select(col => rowCells.Find(c => c.Column == col))
                    .ToList();
            }
        }

        internal Row(Table table) : base(table)
        {
        }

        public override void Remove()
        {
            Table.Cells.RemoveAll(c => c.Row == this);
            Table.Rows.Remove(this);
        }
    }
}
