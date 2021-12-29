
namespace GradeReport.Master
{
    partial class AddStudentsMasterForm
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
            this.groupLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentNamesTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группа:";
            // 
            // groupLbl
            // 
            this.groupLbl.AutoSize = true;
            this.groupLbl.Location = new System.Drawing.Point(67, 9);
            this.groupLbl.Name = "groupLbl";
            this.groupLbl.Size = new System.Drawing.Size(88, 15);
            this.groupLbl.TabIndex = 1;
            this.groupLbl.Text = "Т91-19 / 2019 г.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ниже необходимо заполнить список ФИО студентов. \r\nКаждый новый студент начинается" +
    " с новой строки.";
            // 
            // studentNamesTB
            // 
            this.studentNamesTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentNamesTB.Location = new System.Drawing.Point(12, 69);
            this.studentNamesTB.Multiline = true;
            this.studentNamesTB.Name = "studentNamesTB";
            this.studentNamesTB.Size = new System.Drawing.Size(403, 469);
            this.studentNamesTB.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(276, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(139, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Добавить студентов";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // AddStudentsMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 550);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.studentNamesTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentsMasterForm";
            this.Text = "Мастер множественного ввода студентов для группы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label groupLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentNamesTB;
        private System.Windows.Forms.Button addBtn;
    }
}