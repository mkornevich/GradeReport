
namespace GradeReport.Edit.EditForms
{
    partial class SpecialtyEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialtyEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.helpLabel1 = new GradeReport.Common.HelpLabel();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.codeTB = new System.Windows.Forms.TextBox();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // helpLabel1
            // 
            this.helpLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel1.BackgroundImage")));
            this.helpLabel1.HelpText = "В данном поле необходимо указать полное название специальности.\r\n";
            this.helpLabel1.Location = new System.Drawing.Point(388, 9);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(16, 16);
            this.helpLabel1.TabIndex = 2;
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(12, 27);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(392, 23);
            this.nameTB.TabIndex = 3;
            // 
            // codeTB
            // 
            this.codeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTB.Location = new System.Drawing.Point(12, 71);
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(392, 23);
            this.codeTB.TabIndex = 6;
            // 
            // helpLabel2
            // 
            this.helpLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.HelpText = "В данном поле необходимо указать шифр специальности.";
            this.helpLabel2.Location = new System.Drawing.Point(388, 53);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шифр";
            // 
            // SpecialtyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 150);
            this.Controls.Add(this.codeTB);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.label1);
            this.Name = "SpecialtyEditForm";
            this.Text = "SpecialtyEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Common.HelpLabel helpLabel1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox codeTB;
        private Common.HelpLabel helpLabel2;
        private System.Windows.Forms.Label label2;
    }
}