
namespace GradeReport.Edit.EditForms
{
    partial class StudentEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(12, 27);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(347, 23);
            this.nameTB.TabIndex = 2;
            // 
            // helpLabel2
            // 
            this.helpLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.HelpText = "В данном поле необходимо указать полное ФИО студента.";
            this.helpLabel2.Location = new System.Drawing.Point(343, 9);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 6;
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 111);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "StudentEditForm";
            this.Text = "StudentEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private Common.HelpLabel helpLabel2;
    }
}