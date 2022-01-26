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
        public static void InsertColumns(XSSFSheet sheet, int columnIndex, int count = 1, Direction insertDirection = Direction.Start)
        {
            RightShiftColumns(sheet, columnIndex, count, insertDirection);
            RightShiftMergedRanges(sheet, columnIndex, count, true);
            DublicateColumns(sheet, columnIndex, columnIndex + 1, columnIndex + count);
        }

        public static void InsertRows(XSSFSheet sheet, int baseRowIndex, int insertCount = 1)
        {
            sheet.ShiftRows(baseRowIndex + 1, sheet.LastRowNum + 1, insertCount, true, false);

            for (int i = 0; i < insertCount; i++)
            {
                sheet.CopyRow(baseRowIndex, baseRowIndex + 1 + i);
            }
        }

        public static void DublicateColumns(XSSFSheet sheet, int baseColumn, int start, int end)
        {
            foreach (XSSFRow row in sheet)
            {
                var baseCell = row.GetCell(baseColumn);
                if (baseCell == null) continue;
                for (int toCellIndex = start; toCellIndex <= end; toCellIndex++)
                {
                    baseCell.CopyCellTo(toCellIndex);
                    sheet.SetColumnWidth(toCellIndex, sheet.GetColumnWidth(baseCell.ColumnIndex));
                }
            }
        }

        public static void RightShiftColumns(XSSFSheet sheet, int columnIndex, int count = 1, Direction direction = Direction.Start)
        {
            var startColumn = direction == Direction.End ? columnIndex + 1 : columnIndex;

            foreach (XSSFRow row in sheet)
            {
                foreach (XSSFCell cell in row.Cells.OrderByDescending(cell => cell.ColumnIndex))
                {
                    var index = cell.ColumnIndex;
                    var newIndex = cell.ColumnIndex + count;

                    if (index < startColumn) continue;

                    cell.CopyCellTo(newIndex);
                    // row.RemoveCell(cell);
                    sheet.SetColumnWidth(newIndex, sheet.GetColumnWidth(index));
                }
            }
        }

        private static void LeftShiftColumns(XSSFSheet sheet, int columnIndex, int count = 1, Direction direction = Direction.Start)
        {
            var startColumn = direction == Direction.End ? columnIndex + 1 : columnIndex;

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

        public static void RightShiftMergedRanges(XSSFSheet sheet, int columnIndex, int count, bool stickRangeToStart)
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

        private static void LeftShiftMergedRanges(XSSFSheet sheet, int columnIndex, int count)
        {
            List<int> removes = new List<int>();
            List<CellRangeAddress> adds = new List<CellRangeAddress>();

            for (int regionIndex = 0; regionIndex < sheet.NumMergedRegions; regionIndex++)
            {
                var oldRegion = sheet.GetMergedRegion(regionIndex);
                var newRegion = oldRegion.Copy();

                if (oldRegion.LastColumn < columnIndex)
                {
                    continue;
                }

                newRegion.FirstColumn = newRegion.FirstColumn >= count ? newRegion.FirstColumn - count : 0;
                newRegion.LastColumn = newRegion.LastColumn >= count ? newRegion.LastColumn - count : 0;

                if ((oldRegion.FirstColumn >= columnIndex && newRegion.FirstColumn < columnIndex) || oldRegion.FirstColumn < columnIndex)
                {
                    newRegion.FirstColumn = oldRegion.FirstColumn;
                    newRegion.LastColumn = newRegion.LastColumn < newRegion.FirstColumn ? newRegion.FirstColumn : newRegion.LastColumn;
                }

                removes.Add(regionIndex);

                if (newRegion.LastColumn - newRegion.FirstColumn < 2 - 1)
                {
                    continue;
                }

                adds.Add(newRegion);
            }

            sheet.RemoveMergedRegions(removes);
            adds.ForEach(reg => sheet.AddMergedRegion(reg));
        }
    }

    public enum Direction
    {
        End,
        Start,
    }
}
