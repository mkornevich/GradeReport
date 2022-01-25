
namespace GradeReport.Reporting.Reports.SummaryTrainingPeriodSheet
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupC = new GradeReport.Common.Chooser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Группа";
            // 
            // groupC
            // 
            this.groupC.BackColor = System.Drawing.SystemColors.Window;
            this.groupC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupC.ChooseText = "";
            this.groupC.Location = new System.Drawing.Point(12, 43);
            this.groupC.Name = "groupC";
            this.groupC.Size = new System.Drawing.Size(400, 23);
            this.groupC.TabIndex = 7;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 81);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupC);
            this.Name = "ReportForm";
            this.Tag = "SummaryTrainingPeriodSheet";
            this.Text = "Сводная ведомость за период обучения";
            this.Controls.SetChildIndex(this.groupC, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Common.Chooser groupC;
    }
}