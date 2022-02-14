
namespace GradeReport.Reporting.Reports.SemesterGradesSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.groupC = new GradeReport.Common.Chooser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.semesterC = new GradeReport.Common.Chooser();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectC = new GradeReport.Common.Chooser();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.isOnlyMyStudentsCB = new System.Windows.Forms.CheckBox();
            this.helpLabel1 = new GradeReport.Common.HelpLabel();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
            this.SuspendLayout();
            // 
            // groupC
            // 
            this.groupC.BackColor = System.Drawing.SystemColors.Window;
            this.groupC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupC.ChooseText = "";
            this.groupC.Location = new System.Drawing.Point(12, 43);
            this.groupC.Name = "groupC";
            this.groupC.Size = new System.Drawing.Size(400, 23);
            this.groupC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Группа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Семестр";
            // 
            // semesterC
            // 
            this.semesterC.BackColor = System.Drawing.SystemColors.Window;
            this.semesterC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.semesterC.ChooseText = "";
            this.semesterC.Location = new System.Drawing.Point(12, 87);
            this.semesterC.Name = "semesterC";
            this.semesterC.Size = new System.Drawing.Size(400, 23);
            this.semesterC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Предмет";
            // 
            // subjectC
            // 
            this.subjectC.BackColor = System.Drawing.SystemColors.Window;
            this.subjectC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectC.ChooseText = "";
            this.subjectC.Location = new System.Drawing.Point(12, 131);
            this.subjectC.Name = "subjectC";
            this.subjectC.Size = new System.Drawing.Size(400, 23);
            this.subjectC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата";
            // 
            // dateDTP
            // 
            this.dateDTP.Location = new System.Drawing.Point(12, 175);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(400, 23);
            this.dateDTP.TabIndex = 6;
            // 
            // isOnlyMyStudentsCB
            // 
            this.isOnlyMyStudentsCB.AutoSize = true;
            this.isOnlyMyStudentsCB.Location = new System.Drawing.Point(12, 204);
            this.isOnlyMyStudentsCB.Name = "isOnlyMyStudentsCB";
            this.isOnlyMyStudentsCB.Size = new System.Drawing.Size(176, 19);
            this.isOnlyMyStudentsCB.TabIndex = 7;
            this.isOnlyMyStudentsCB.Text = "Только для моих студентов";
            this.isOnlyMyStudentsCB.UseVisualStyleBackColor = true;
            // 
            // helpLabel1
            // 
            this.helpLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel1.BackgroundImage")));
            this.helpLabel1.HelpText = "Здесь необходимо указать дату создания сводной ведомости за семестр.";
            this.helpLabel1.Location = new System.Drawing.Point(396, 157);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(16, 16);
            this.helpLabel1.TabIndex = 8;
            // 
            // helpLabel2
            // 
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.HelpText = "Если данный параметр активен, то в таком случае при построении отчета будут учиты" +
    "ваться только ваши студенты (из вашей подгруппы).";
            this.helpLabel2.Location = new System.Drawing.Point(194, 204);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 9;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 232);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.isOnlyMyStudentsCB);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subjectC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.semesterC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupC);
            this.Name = "ReportForm";
            this.Tag = "SemesterGradesSheet";
            this.Text = "Сводная ведомость за семестр";
            this.Controls.SetChildIndex(this.groupC, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.semesterC, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.subjectC, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dateDTP, 0);
            this.Controls.SetChildIndex(this.isOnlyMyStudentsCB, 0);
            this.Controls.SetChildIndex(this.helpLabel1, 0);
            this.Controls.SetChildIndex(this.helpLabel2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Chooser groupC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Common.Chooser semesterC;
        private System.Windows.Forms.Label label3;
        private Common.Chooser subjectC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.CheckBox isOnlyMyStudentsCB;
        private Common.HelpLabel helpLabel1;
        private Common.HelpLabel helpLabel2;
    }
}