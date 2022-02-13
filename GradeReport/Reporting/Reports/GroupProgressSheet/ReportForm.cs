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

namespace GradeReport.Reporting.Reports.GroupProgressSheet
{
    public partial class ReportForm : BaseReportForm
    {
        private ListForm groupLF = new ListForm(new GroupListAdapter());
        private ListForm semesterLF = new ListForm(new SemesterListAdapter());

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

            semesterLF.Chooser = semesterC;
            semesterLF.SelectMode = SelectMode.Single;
            semesterLF.SetParent(groupLF, selected =>
            {
                var group = (Group)selected[0];
                var courses = Project.Courses.FindAll(c => c.GroupGuid == group.Guid);
                return Project.Semesters
                    .FindAll(s => courses.Exists(c => c.Guid == s.CourseGuid))
                    .Cast<object>().ToList();
            });
        }

        protected override void ResetGUI()
        {
            groupLF.Entities = Project.Groups.Cast<object>().ToList();
            groupLF.SelectedEntities = new List<object>();

            if (App.IsDebug)
            {
                groupLF.SelectedEntities = new List<object>() { groupLF.Entities[0] };
                semesterLF.SelectedEntities = new List<object>() { semesterLF.Entities[0] };
            }
        }

        protected override BaseInputModel BuildInputModel()
        {
            var model = new InputModel();

            model.Group = (Group)groupLF.SelectedEntities.FirstOrDefault();
            model.Semester = (Semester)semesterLF.SelectedEntities.FirstOrDefault();

            return model;
        }
    }
}
