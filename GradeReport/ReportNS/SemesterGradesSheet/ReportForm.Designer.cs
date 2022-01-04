
namespace GradeReport.ReportNS.SemesterGradesSheet
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
            this.chooser1 = new GradeReport.Common.Chooser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooser2 = new GradeReport.Common.Chooser();
            this.label3 = new System.Windows.Forms.Label();
            this.chooser3 = new GradeReport.Common.Chooser();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // chooser1
            // 
            this.chooser1.BackColor = System.Drawing.SystemColors.Window;
            this.chooser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooser1.ChooseText = "";
            this.chooser1.Location = new System.Drawing.Point(12, 43);
            this.chooser1.Name = "chooser1";
            this.chooser1.Size = new System.Drawing.Size(400, 23);
            this.chooser1.TabIndex = 1;
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
            // chooser2
            // 
            this.chooser2.BackColor = System.Drawing.SystemColors.Window;
            this.chooser2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooser2.ChooseText = "";
            this.chooser2.Location = new System.Drawing.Point(12, 87);
            this.chooser2.Name = "chooser2";
            this.chooser2.Size = new System.Drawing.Size(400, 23);
            this.chooser2.TabIndex = 2;
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
            // chooser3
            // 
            this.chooser3.BackColor = System.Drawing.SystemColors.Window;
            this.chooser3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooser3.ChooseText = "";
            this.chooser3.Location = new System.Drawing.Point(12, 131);
            this.chooser3.Name = "chooser3";
            this.chooser3.Size = new System.Drawing.Size(400, 23);
            this.chooser3.TabIndex = 3;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(400, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 214);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chooser3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chooser2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooser1);
            this.Name = "ReportForm";
            this.Tag = "SemesterGradesSheet";
            this.Text = "Сводная ведомость за семестр";
            this.Controls.SetChildIndex(this.chooser1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.chooser2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.chooser3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Chooser chooser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Common.Chooser chooser2;
        private System.Windows.Forms.Label label3;
        private Common.Chooser chooser3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}