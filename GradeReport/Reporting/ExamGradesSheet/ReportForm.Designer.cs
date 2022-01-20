
namespace GradeReport.Reporting.ExamGradesSheet
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
            this.subjectC = new GradeReport.Common.Chooser();
            this.label3 = new System.Windows.Forms.Label();
            this.semesterC = new GradeReport.Common.Chooser();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupC = new GradeReport.Common.Chooser();
            this.SuspendLayout();
            // 
            // subjectC
            // 
            this.subjectC.BackColor = System.Drawing.SystemColors.Window;
            this.subjectC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectC.ChooseText = "";
            this.subjectC.Location = new System.Drawing.Point(12, 131);
            this.subjectC.Name = "subjectC";
            this.subjectC.Size = new System.Drawing.Size(400, 23);
            this.subjectC.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Предмет";
            // 
            // semesterC
            // 
            this.semesterC.BackColor = System.Drawing.SystemColors.Window;
            this.semesterC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.semesterC.ChooseText = "";
            this.semesterC.Location = new System.Drawing.Point(12, 87);
            this.semesterC.Name = "semesterC";
            this.semesterC.Size = new System.Drawing.Size(400, 23);
            this.semesterC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Семестр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 7;
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
            this.groupC.TabIndex = 5;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 170);
            this.Controls.Add(this.subjectC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.semesterC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupC);
            this.Name = "ReportForm";
            this.Tag = "ExamGradesSheet";
            this.Text = "Экзаменационная ведомость";
            this.Controls.SetChildIndex(this.groupC, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.semesterC, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.subjectC, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Chooser subjectC;
        private System.Windows.Forms.Label label3;
        private Common.Chooser semesterC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Common.Chooser groupC;
    }
}