
namespace GradeReport.Edit.EditForms
{
    partial class CourseEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupNameForCourseTB = new System.Windows.Forms.TextBox();
            this.numberNUD = new System.Windows.Forms.NumericUpDown();
            this.helpLabel1 = new GradeReport.Common.HelpLabel();
            this.startYearNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.specialtyCH = new GradeReport.Common.Chooser();
            this.label4 = new System.Windows.Forms.Label();
            this.helpLabel3 = new GradeReport.Common.HelpLabel();
            this.helpLabel4 = new GradeReport.Common.HelpLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numberNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYearNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер";
            // 
            // groupNameForCourseTB
            // 
            this.groupNameForCourseTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNameForCourseTB.Location = new System.Drawing.Point(209, 27);
            this.groupNameForCourseTB.Name = "groupNameForCourseTB";
            this.groupNameForCourseTB.Size = new System.Drawing.Size(296, 23);
            this.groupNameForCourseTB.TabIndex = 2;
            // 
            // numberNUD
            // 
            this.numberNUD.Location = new System.Drawing.Point(12, 27);
            this.numberNUD.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numberNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberNUD.Name = "numberNUD";
            this.numberNUD.Size = new System.Drawing.Size(92, 23);
            this.numberNUD.TabIndex = 3;
            this.numberNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // helpLabel1
            // 
            this.helpLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel1.BackgroundImage")));
            this.helpLabel1.HelpText = "В данном поле необходимо указать порядковый номер учебного курса.";
            this.helpLabel1.Location = new System.Drawing.Point(88, 9);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(16, 16);
            this.helpLabel1.TabIndex = 4;
            // 
            // startYearNUD
            // 
            this.startYearNUD.Location = new System.Drawing.Point(110, 27);
            this.startYearNUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.startYearNUD.Name = "startYearNUD";
            this.startYearNUD.Size = new System.Drawing.Size(93, 23);
            this.startYearNUD.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Год начала";
            // 
            // helpLabel2
            // 
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.HelpText = "В данном поле необходимо указать год начала данного учебного курса.";
            this.helpLabel2.Location = new System.Drawing.Point(187, 9);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Специальность";
            // 
            // specialtyCH
            // 
            this.specialtyCH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.specialtyCH.BackColor = System.Drawing.SystemColors.Window;
            this.specialtyCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specialtyCH.ChooseText = "";
            this.specialtyCH.Location = new System.Drawing.Point(12, 71);
            this.specialtyCH.Name = "specialtyCH";
            this.specialtyCH.Size = new System.Drawing.Size(493, 23);
            this.specialtyCH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название группы в данном курсе";
            // 
            // helpLabel3
            // 
            this.helpLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel3.BackgroundImage")));
            this.helpLabel3.HelpText = "В данном поле необходимо указать специальность по которой обучаются на данном кур" +
    "се.";
            this.helpLabel3.Location = new System.Drawing.Point(489, 53);
            this.helpLabel3.Name = "helpLabel3";
            this.helpLabel3.Size = new System.Drawing.Size(16, 16);
            this.helpLabel3.TabIndex = 5;
            // 
            // helpLabel4
            // 
            this.helpLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel4.BackgroundImage")));
            this.helpLabel4.HelpText = resources.GetString("helpLabel4.HelpText");
            this.helpLabel4.Location = new System.Drawing.Point(489, 9);
            this.helpLabel4.Name = "helpLabel4";
            this.helpLabel4.Size = new System.Drawing.Size(16, 16);
            this.helpLabel4.TabIndex = 6;
            // 
            // CourseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 146);
            this.Controls.Add(this.helpLabel4);
            this.Controls.Add(this.helpLabel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specialtyCH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startYearNUD);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.numberNUD);
            this.Controls.Add(this.groupNameForCourseTB);
            this.Controls.Add(this.label1);
            this.Name = "CourseEditForm";
            this.Text = "CourseEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.numberNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYearNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox groupNameForCourseTB;
        private System.Windows.Forms.NumericUpDown numberNUD;
        private Common.HelpLabel helpLabel1;
        private System.Windows.Forms.NumericUpDown startYearNUD;
        private System.Windows.Forms.Label label2;
        private Common.HelpLabel helpLabel2;
        private System.Windows.Forms.Label label3;
        private Common.Chooser specialtyCH;
        private System.Windows.Forms.Label label4;
        private Common.HelpLabel helpLabel3;
        private Common.HelpLabel helpLabel4;
    }
}