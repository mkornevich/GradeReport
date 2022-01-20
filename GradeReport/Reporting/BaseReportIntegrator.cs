using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting
{
    public abstract class BaseReportIntegrator
    {
        public void Integrate(BaseOutputModel baseOutputModel, Document document)
        {
            DoIntegrate(baseOutputModel, document);
        }

        protected abstract void DoIntegrate(BaseOutputModel baseOutputModel, Document document);

        protected void Parametrize(ICell cell, Dictionary<string, object> _params)
        {
            if (cell.CellType != CellType.String)
                return;
            
            var cellStr = cell.StringCellValue;

            if (!cellStr.Contains("{") || !cellStr.Contains("}"))
                return;

            var richString = (XSSFRichTextString)cell.RichStringCellValue;
            var rst = richString.GetCTRst();
            var newRst = new CT_Rst();
            newRst.Set(rst);

            newRst.r = (rst.r == null) ? null : rst.r
                .Select(oldPart => new CT_RElt()
                {
                    rPr = oldPart.rPr,
                    t = Parametrize(oldPart.t, _params)
                }).ToList();

            newRst.t = (rst.t == null) ? null : Parametrize(rst.t, _params);

            cell.SetCellValue(new XSSFRichTextString(newRst));

            double numValue;
            if (double.TryParse(cell.StringCellValue, out numValue))
            {
                cell.SetCellValue(numValue);
            }
        }

        protected string Parametrize(string template, Dictionary<string, object> _params)
        {
            foreach (var key in _params.Keys)
            {
                template = template.Replace("{" + key + "}", _params[key].ToString());
            }

            return template;
        }

        protected void Parametrize(List<ICell> cells, Dictionary<string, object> _params)
        {
            cells.ForEach(cell => Parametrize(cell, _params));
        }

        protected void Parametrize(IRow row, Dictionary<string, object> _params)
        {
            Parametrize(row.Cells, _params);
        }

        protected void Parametrize(ISheet sheet, Dictionary<string, object> _params)
        {
            for (int rowIndex = 0; rowIndex < sheet.LastRowNum; rowIndex++)
            {
                var row = sheet.GetRow(rowIndex);
                if (row == null) return;
                Parametrize(row, _params);
            }
        }
    }
}
