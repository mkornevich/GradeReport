using GradeReport.ProjectModel.Queries;
using GradeReport.Reporting.TableModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Reporting.Reports.SummaryTrainingPeriodSheet
{
    public class ReportBuilder : BaseReportBuilder
    {
        private OutputModel _output;

        private InputModel _input;

        private Table _table;

        private GradeQuery _query;

        protected override BaseOutputModel DoBuild(BaseInputModel baseInputModel)
        {
            _input = (InputModel)baseInputModel;
            _output = new OutputModel();
            _table = _output.Table;
            // _query = CreateQuery();



            return _output;
        }
    }
}
