using GradeReport.ProjectNS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.ReportNS
{
    public class BaseReportForm : Form
    {
        private ToolStrip toolStrip;
        protected ToolStripButton buildReportBtn;
        protected ToolStripButton validateReportBtn;

        protected BaseValidator Validator { get; set; }

        protected BaseInputModel InputModel { get; set; }

        protected BaseReportBuilder ReportBuilder { get; set; }

        protected BaseReportIntegrator ReportIntegrator { get; set; }

        protected Project Project { get; private set; }

        public BaseReportForm()
        {
            InitializeComponent();
        }

        protected virtual void ValidateAct(object sender, EventArgs e)
        {
            if (TryBuildInputModel() && Validator.Validate(InputModel))
            {
                MessageBox.Show("Проверка успешно пройдена.");
            }
            else
            {
                MessageBox.Show("Проверка не пройдена. Исправте ошибки.");
            }
        }

        protected virtual void CreateComponents()
        {

        }

        protected virtual void SetStartData()
        {

        }

        public void ShowReportForm(Project project)
        {
            Project = project;
            CreateComponents();
            SetStartData();
            ShowDialog();
        }

        protected virtual void BuildAct(object sender, EventArgs e)
        {
            if (!TryBuildInputModel() || !Validator.Validate(InputModel))
            {
                return;
            }

            var outputModel = ReportBuilder.Build(InputModel);

            var document = new Document();
            document.Load(App.AppDataPath + "\\Reports\\" + Tag + "\\Template.xlsx");

            ReportIntegrator.Integrate(outputModel, document);

            document.StoreWithDialog(true);
        }

        protected virtual bool TryBuildInputModel()
        {
            return false;
        }

        private void InitializeComponent()
        {
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.buildReportBtn = new System.Windows.Forms.ToolStripButton();
            this.validateReportBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildReportBtn,
            this.validateReportBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(424, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // buildReportBtn
            // 
            this.buildReportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buildReportBtn.Image = global::GradeReport.Properties.Resources.run_16;
            this.buildReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buildReportBtn.Name = "buildReportBtn";
            this.buildReportBtn.Size = new System.Drawing.Size(23, 22);
            this.buildReportBtn.ToolTipText = "Построить отчет";
            this.buildReportBtn.Click += new System.EventHandler(this.BuildAct);
            // 
            // validateReportBtn
            // 
            this.validateReportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.validateReportBtn.Image = global::GradeReport.Properties.Resources.validate_16;
            this.validateReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.validateReportBtn.Name = "validateReportBtn";
            this.validateReportBtn.Size = new System.Drawing.Size(23, 22);
            this.validateReportBtn.ToolTipText = "Проверить отчет на ошибки";
            this.validateReportBtn.Click += new System.EventHandler(this.ValidateAct);
            // 
            // BaseReportForm
            // 
            this.ClientSize = new System.Drawing.Size(424, 363);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
