
namespace GradeReport.ReportNS.GroupProgressSheet
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
            this.semesterC = new GradeReport.Common.Chooser();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupC = new GradeReport.Common.Chooser();
            this.SuspendLayout();
            // 
            // semesterC
            // 
            this.semesterC.BackColor = System.Drawing.SystemColors.Window;
            this.semesterC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.semesterC.ChooseText = "";
            this.semesterC.Location = new System.Drawing.Point(12, 87);
            this.semesterC.Name = "semesterC";
            this.semesterC.Size = new System.Drawing.Size(400, 23);
            this.semesterC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Семестр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 6;
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
            this.groupC.TabIndex = 4;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 124);
            this.Controls.Add(this.semesterC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupC);
            this.Name = "ReportForm";
            this.Tag = "GroupProgressSheet";
            this.Text = "Сводная ведомость успеваемости учащихся группы";
            this.Controls.SetChildIndex(this.groupC, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.semesterC, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Chooser semesterC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Common.Chooser groupC;
    }
}