using GradeReport.ProjectModel.Queries;
using GradeReport.Reporting.TableModel;
using NPOI.XSSF.UserModel;
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

        private Table _summaryTable;

        private Table _coursesTable;

        private GradeQuery _query;

        protected override BaseOutputModel DoBuild(BaseInputModel baseInputModel)
        {
            _input = (InputModel)baseInputModel;
            _output = new OutputModel();

            _summaryTable = _output.SummaryTable;
            _coursesTable = _output.CoursesTable;

            for (int i = 0; i < 20; i++)
            {
                var column = _summaryTable.CreateColumn();
                column.Group = "Subject";
                column.Name = "Very very subject " + i;
            }

            for (int i = 0; i < 15; i++)
            {
                var row = _summaryTable.CreateRow();
                row.Group = "Student";
                row.Params["Number"] = i + 1;
                row.Params["HasRedDiploma"] = i % 2 == 0;
                row.Name = "Student " + i;
            }

            foreach (var row in _summaryTable.Rows)
            {
                foreach (var cell in row.Cells)
                {
                    cell.Value = cell.Column.Index;
                    if (row.Index == 5)
                    {
                        cell.Value = -1;
                    }
                    if (row.Index == 6)
                    {
                        cell.Value = -2;
                    }
                    if (row.Index == 7)
                    {
                        cell.Value = -3;
                    }
                }
            }

            // ---

            for (int i = 0; i < 6; i++)
            {
                var column = _coursesTable.CreateColumn();
                column.Group = "Subject";
                column.Name = "Very very subject " + i;
            }

            for (int i = 0; i < 20; i++)
            {
                var row = _coursesTable.CreateRow();
                row.Group = "Student";
                row.Params["Number"] = i + 1;
                row.Name = "Student " + i;
            }

            foreach (var row in _coursesTable.Rows)
            {
                foreach (var cell in row.Cells)
                {
                    cell.Value = cell.Column.Index;
                }
            }

            _output.Params["ParentOrganizationName"] = Project.Config.ParentOrganizationName;
            _output.Params["OrganizationName"] = Project.Config.OrganizationName;
            _output.Params["GroupName"] = _input.Group.Courses.Last().GroupNameForCourse;

            return _output;
        }
    }
}
