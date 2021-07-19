
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
            this.numberNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.helpLabel1 = new GradeReport.Common.HelpLabel();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numberNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(100, 27);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(279, 23);
            this.nameTB.TabIndex = 2;
            // 
            // numberNUD
            // 
            this.numberNUD.Location = new System.Drawing.Point(12, 27);
            this.numberNUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numberNUD.Name = "numberNUD";
            this.numberNUD.Size = new System.Drawing.Size(82, 23);
            this.numberNUD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер";
            // 
            // helpLabel1
            // 
            this.helpLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel1.BackgroundImage")));
            this.helpLabel1.HelpText = "В данном поле необходимо указать порядковый номер студента. \r\n\r\nДолжен быть уника" +
    "льным для студентов одной группы.";
            this.helpLabel1.Location = new System.Drawing.Point(78, 9);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(16, 16);
            this.helpLabel1.TabIndex = 5;
            // 
            // helpLabel2
            // 
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.HelpText = "В данном поле необходимо указать полное ФИО студента.";
            this.helpLabel2.Location = new System.Drawing.Point(363, 9);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 6;
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 111);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberNUD);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "StudentEditForm";
            this.Text = "StudentEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.numberNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.NumericUpDown numberNUD;
        private System.Windows.Forms.Label label2;
        private Common.HelpLabel helpLabel1;
        private Common.HelpLabel helpLabel2;
    }
}