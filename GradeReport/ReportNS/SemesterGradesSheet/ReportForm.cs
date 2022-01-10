using GradeReport.List;
using GradeReport.List.Adapters;
using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ReportNS.SemesterGradesSheet
{
    public partial class ReportForm : BaseReportForm
    {
        private ListForm groupLF = new ListForm(new GroupListAdapter());
        private ListForm semesterLF = new ListForm(new SemesterListAdapter());
        private ListForm subjectLF = new ListForm(new SubjectListAdapter());

        public ReportForm()
        {
            InitializeComponent();

            groupLF.Chooser = groupC;
            groupLF.SelectMode = SelectMode.Single;
            groupLF.SelectionChanged += () =>
            {
                var count = groupLF.SelectedEntities.Count;
                semesterC.Enabled = count > 0;
                semesterLF.SelectedEntities = new List<object>();
                if (count > 0)
                {
                    var group = (Group)groupLF.SelectedEntities[0];
                    var courses = Project.Courses.FindAll(c => c.GroupGuid == group.Guid);
                    semesterLF.Entities = Project.Semesters
                        .FindAll(s => courses.Exists(c => c.Guid == s.CourseGuid))
                        .Cast<object>().ToList();
                }
            };

            

            semesterC.Enabled = false;
            semesterLF.Chooser = semesterC;
            semesterLF.SelectMode = SelectMode.Single;
            semesterLF.SelectionChanged += () =>
            {
                var count = semesterLF.SelectedEntities.Count;
                subjectC.Enabled = count > 0;
                subjectLF.SelectedEntities = new List<object>();
                if (count > 0)
                {
                    var semester = (Semester)semesterLF.SelectedEntities[0];
                    subjectLF.Entities = Project.SemesterSubjectRefs
                        .FindAll(ssr => ssr.SemesterGuid == semester.Guid)
                        .Select(ssr => ssr.Subject)
                        .Cast<object>().ToList();
                }
            };

            subjectC.Enabled = false;
            subjectLF.Chooser = subjectC;
            subjectLF.SelectMode = SelectMode.Single;


            
        }

        protected override void SetStartData()
        {
            groupLF.Entities = Project.Groups.Cast<object>().ToList();
            groupLF.SelectedEntities = new List<object>();

            // TODO
            groupLF.SelectedEntities = new List<object>() { groupLF.Entities[0] };
            semesterLF.SelectedEntities = new List<object>() { semesterLF.Entities[0] };
            subjectLF.SelectedEntities = new List<object>() { subjectLF.Entities[0] };
        }

        protected override void CreateComponents()
        {
            Validator = new Validator();
            ReportBuilder = new ReportBuilder();
            ReportIntegrator = new ReportIntegrator();
        }

        protected override bool TryBuildInputModel()
        {
            var model = new InputModel();
            model.Group = (Group)groupLF.SelectedEntities.FirstOrDefault();
            model.Semester = (Semester)semesterLF.SelectedEntities.FirstOrDefault();
            model.Subject = (Subject)subjectLF.SelectedEntities.FirstOrDefault();
            model.Date = dateDTP.Value;

            InputModel = model;
            return true;
        }
    }
}
