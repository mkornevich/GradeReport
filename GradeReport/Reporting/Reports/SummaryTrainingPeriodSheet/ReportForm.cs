using GradeReport.List;
using GradeReport.List.Adapters;
using GradeReport.ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Reporting.Reports.SummaryTrainingPeriodSheet
{
    public partial class ReportForm : BaseReportForm
    {
        private ListForm groupLF = new ListForm(new GroupListAdapter());

        public ReportForm()
        {
            InitializeComponent();

            Validator = new Validator();
            ReportBuilder = new ReportBuilder();
            ReportIntegrator = new ReportIntegrator();
        }

        public override void InitGUI()
        {
            groupLF.Chooser = groupC;
            groupLF.SelectMode = SelectMode.Single;
        }

        protected override void ResetGUI()
        {
            groupLF.Entities = Project.Groups.Cast<object>().ToList();
            groupLF.SelectedEntities = new List<object>();

            // TODO
            groupLF.SelectedEntities = new List<object>() { groupLF.Entities[0] };
        }

        protected override BaseInputModel BuildInputModel()
        {
            var model = new InputModel();

            model.Group = (Group)groupLF.SelectedEntities.FirstOrDefault();

            return model;
        }
    }
}
