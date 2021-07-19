
namespace GradeReport.Edit.EditForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shortNameTB = new System.Windows.Forms.TextBox();
            this.helpLabel1 = new GradeReport.Common.HelpLabel();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
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
            // helpLabel1
            // 
            this.helpLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel1.BackgroundImage")));
            this.helpLabel1.HelpText = "В данном поле необходимо указать полное наименование предмета.";
            this.helpLabel1.Location = new System.Drawing.Point(396, 9);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(16, 16);
            this.helpLabel1.TabIndex = 5;
            // 
            // helpLabel2
            // 
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.HelpText = "В данном поле необходимо указать сокращенное наименование предмета. Используется " +
    "для отображения.\r\n\r\nДанное поле должно быть уникальным.\r\n";
            this.helpLabel2.Location = new System.Drawing.Point(396, 53);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 6;
            // 
            // SubjectEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 146);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.shortNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "SubjectEditForm";
            this.Text = "SubjectEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shortNameTB;
        private Common.HelpLabel helpLabel1;
        private Common.HelpLabel helpLabel2;
    }
}