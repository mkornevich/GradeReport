
namespace GradeReport.EntityModules.SubjectNS
{
    partial class SubjectEditForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shortNameTB = new System.Windows.Forms.TextBox();
            this.includeCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Полное название";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(12, 27);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(400, 23);
            this.nameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сокращенное название";
            // 
            // shortNameTB
            // 
            this.shortNameTB.Location = new System.Drawing.Point(12, 71);
            this.shortNameTB.Name = "shortNameTB";
            this.shortNameTB.Size = new System.Drawing.Size(400, 23);
            this.shortNameTB.TabIndex = 4;
            // 
            // includeCB
            // 
            this.includeCB.AutoSize = true;
            this.includeCB.Location = new System.Drawing.Point(12, 100);
            this.includeCB.Name = "includeCB";
            this.includeCB.Size = new System.Drawing.Size(84, 19);
            this.includeCB.TabIndex = 5;
            this.includeCB.Text = "Учитывать";
            this.includeCB.UseVisualStyleBackColor = true;
            // 
            // SubjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 165);
            this.Controls.Add(this.includeCB);
            this.Controls.Add(this.shortNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "SubjectEditForm";
            this.Text = "SubjectEditForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.nameTB, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.shortNameTB, 0);
            this.Controls.SetChildIndex(this.includeCB, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shortNameTB;
        private System.Windows.Forms.CheckBox includeCB;
    }
}