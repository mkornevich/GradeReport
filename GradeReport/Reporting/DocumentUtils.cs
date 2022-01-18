using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting
{
    static class DocumentUtils
    {
        public static void InsertColumns(XSSFSheet sheet, int columnIndex, int count = 1, Direction insertDirection = Direction.Left)
        {
            RightShiftColumns(sheet, columnIndex, count, insertDirection);
            LeftShiftMergedRanges(sheet, columnIndex, count, true);
        }


        public static void RightShiftColumns(XSSFSheet sheet, int columnIndex, int count = 1, Direction direction = Direction.Left)
        {
            var startColumn = direction == Direction.Right ? columnIndex + 1 : columnIndex;

            foreach (XSSFRow row in sheet)
            {
                foreach (XSSFCell cell in row.Cells.OrderByDescending(cell => cell.ColumnIndex))
                {
                    var index = cell.ColumnIndex;
                    var newIndex = cell.ColumnIndex + count;

                    if (index < startColumn) continue;

                    cell.CopyCellTo(newIndex);
                    row.RemoveCell(cell);
                    sheet.SetColumnWidth(newIndex, sheet.GetColumnWidth(index));
                }
            }
        }

        public static void LeftShiftColumns(XSSFSheet sheet, int columnIndex, int count = 1, Direction direction = Direction.Left)
        {
            var startColumn = direction == Direction.Right ? columnIndex + 1 : columnIndex;

            int index = -1;
            int toLeftIndex = -1;

            foreach (XSSFRow row in sheet)
            {
                foreach (XSSFCell cell in row.Cells)
                {
                    index = cell.ColumnIndex;
                    toLeftIndex = cell.ColumnIndex - count;

                    if (toLeftIndex < startColumn) continue;

                    cell.CopyCellTo(toLeftIndex);
                    row.RemoveCell(cell);
                }

                if (index != -1)
                {
                    sheet.SetColumnWidth(toLeftIndex, sheet.GetColumnWidth(index));
                    index = -1;
                }
            }
        }

        public static void LeftShiftMergedRanges(XSSFSheet sheet, int columnIndex, int count, bool stickRangeToStart)
        {
            List<int> removes = new List<int>();
            List<CellRangeAddress> adds = new List<CellRangeAddress>();

            for (int regionIndex = 0; regionIndex < sheet.NumMergedRegions; regionIndex++)
            {
                var region = sheet.GetMergedRegion(regionIndex);

                if (region.LastColumn >= columnIndex)
                {
                    removes.Add(regionIndex);
                    adds.Add(region);

                    region.LastColumn += count;
                }

                if (region.FirstColumn > columnIndex || (region.FirstColumn == columnIndex && !stickRangeToStart))
                {
                    region.FirstColumn += count;
                }
            }

            sheet.RemoveMergedRegions(removes);
            adds.ForEach(reg => sheet.AddMergedRegion(reg));
        }
    }

    public enum Direction
    {
        Right,
        Left,
    }
}
