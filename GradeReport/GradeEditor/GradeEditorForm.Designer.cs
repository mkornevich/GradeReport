
namespace GradeReport.GradeEditor
{
    partial class GradeEditorForm
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
            this.subjectsLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.semesterTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
            this.editorDGV = new System.Windows.Forms.DataGridView();
            this.StudentIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.numberLeftBtn = new System.Windows.Forms.Button();
            this.numberRightBtn = new System.Windows.Forms.Button();
            this.numberAddBtn = new System.Windows.Forms.Button();
            this.numberDeleteBtn = new System.Windows.Forms.Button();
            this.numberLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradeTypesLB = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.editorDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // subjectsLB
            // 
            this.subjectsLB.DisplayMember = "ShortName";
            this.subjectsLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectsLB.FormattingEnabled = true;
            this.subjectsLB.ItemHeight = 15;
            this.subjectsLB.Items.AddRange(new object[] {
            "КПиЯП",
            "АУДО",
            "БДиСУБД",
            "Матем",
            "ПССИП",
            "ЛР"});
            this.subjectsLB.Location = new System.Drawing.Point(3, 19);
            this.subjectsLB.Name = "subjectsLB";
            this.subjectsLB.Size = new System.Drawing.Size(265, 668);
            this.subjectsLB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Семестр";
            // 
            // semesterTB
            // 
            this.semesterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.semesterTB.Location = new System.Drawing.Point(6, 35);
            this.semesterTB.Name = "semesterTB";
            this.semesterTB.ReadOnly = true;
            this.semesterTB.Size = new System.Drawing.Size(259, 23);
            this.semesterTB.TabIndex = 5;
            this.semesterTB.Text = "т291 / Курс 2 / Семестр 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Типы оценок";
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Location = new System.Drawing.Point(6, 19);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(292, 105);
            this.infoLbl.TabIndex = 0;
            this.infoLbl.Text = "Для ввода 10 нажимать *.\r\n\r\nESC - Предыдущий учащийся.\r\nEnter - Следующий учащийс" +
    "я.\r\n\r\nПоддержка дополнительных оценок (Зач/Осв): Нет\r\n\r\n";
            // 
            // editorDGV
            // 
            this.editorDGV.AllowUserToAddRows = false;
            this.editorDGV.AllowUserToDeleteRows = false;
            this.editorDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.editorDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editorDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIndexColumn,
            this.StudentNameColumn,
            this.GradeValueColumn});
            this.editorDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorDGV.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.editorDGV.Location = new System.Drawing.Point(3, 19);
            this.editorDGV.MultiSelect = false;
            this.editorDGV.Name = "editorDGV";
            this.editorDGV.ReadOnly = true;
            this.editorDGV.RowHeadersVisible = false;
            this.editorDGV.RowTemplate.Height = 25;
            this.editorDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editorDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.editorDGV.Size = new System.Drawing.Size(414, 668);
            this.editorDGV.TabIndex = 23;
            this.editorDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.editorDGV_CellFormatting);
            this.editorDGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.editorDGV_KeyUp);
            // 
            // StudentIndexColumn
            // 
            this.StudentIndexColumn.DataPropertyName = "StudentIndex";
            this.StudentIndexColumn.HeaderText = "№";
            this.StudentIndexColumn.Name = "StudentIndexColumn";
            this.StudentIndexColumn.ReadOnly = true;
            this.StudentIndexColumn.Width = 40;
            // 
            // StudentNameColumn
            // 
            this.StudentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentNameColumn.DataPropertyName = "StudentName";
            this.StudentNameColumn.HeaderText = "ФИО";
            this.StudentNameColumn.Name = "StudentNameColumn";
            this.StudentNameColumn.ReadOnly = true;
            // 
            // GradeValueColumn
            // 
            this.GradeValueColumn.DataPropertyName = "GradeValue";
            this.GradeValueColumn.HeaderText = "Оценка";
            this.GradeValueColumn.Name = "GradeValueColumn";
            this.GradeValueColumn.ReadOnly = true;
            this.GradeValueColumn.Width = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.infoLbl);
            this.groupBox2.Location = new System.Drawing.Point(289, 699);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 225);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.editorDGV);
            this.groupBox3.Location = new System.Drawing.Point(289, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 690);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Редактор оценок";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveBtn);
            this.groupBox4.Controls.Add(this.numberLeftBtn);
            this.groupBox4.Controls.Add(this.numberRightBtn);
            this.groupBox4.Controls.Add(this.numberAddBtn);
            this.groupBox4.Controls.Add(this.numberDeleteBtn);
            this.groupBox4.Controls.Add(this.numberLbl);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.gradeTypesLB);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.semesterTB);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 225);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(6, 193);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(259, 23);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Проверить и применить изменения";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // numberLeftBtn
            // 
            this.numberLeftBtn.Location = new System.Drawing.Point(135, 164);
            this.numberLeftBtn.Name = "numberLeftBtn";
            this.numberLeftBtn.Size = new System.Drawing.Size(28, 23);
            this.numberLeftBtn.TabIndex = 13;
            this.numberLeftBtn.Text = "<";
            this.numberLeftBtn.UseVisualStyleBackColor = true;
            this.numberLeftBtn.Click += new System.EventHandler(this.numberLeftBtn_Click);
            // 
            // numberRightBtn
            // 
            this.numberRightBtn.Location = new System.Drawing.Point(169, 164);
            this.numberRightBtn.Name = "numberRightBtn";
            this.numberRightBtn.Size = new System.Drawing.Size(28, 23);
            this.numberRightBtn.TabIndex = 12;
            this.numberRightBtn.Text = ">";
            this.numberRightBtn.UseVisualStyleBackColor = true;
            this.numberRightBtn.Click += new System.EventHandler(this.numberRightBtn_Click);
            // 
            // numberAddBtn
            // 
            this.numberAddBtn.Location = new System.Drawing.Point(203, 164);
            this.numberAddBtn.Name = "numberAddBtn";
            this.numberAddBtn.Size = new System.Drawing.Size(28, 23);
            this.numberAddBtn.TabIndex = 11;
            this.numberAddBtn.Text = "+";
            this.numberAddBtn.UseVisualStyleBackColor = true;
            this.numberAddBtn.Click += new System.EventHandler(this.numberAddBtn_Click);
            // 
            // numberDeleteBtn
            // 
            this.numberDeleteBtn.Location = new System.Drawing.Point(237, 164);
            this.numberDeleteBtn.Name = "numberDeleteBtn";
            this.numberDeleteBtn.Size = new System.Drawing.Size(28, 23);
            this.numberDeleteBtn.TabIndex = 10;
            this.numberDeleteBtn.Text = "-";
            this.numberDeleteBtn.UseVisualStyleBackColor = true;
            this.numberDeleteBtn.Click += new System.EventHandler(this.numberDeleteBtn_Click);
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Location = new System.Drawing.Point(88, 168);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(13, 15);
            this.numberLbl.TabIndex = 9;
            this.numberLbl.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Позиция №:";
            // 
            // gradeTypesLB
            // 
            this.gradeTypesLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradeTypesLB.DisplayMember = "Description";
            this.gradeTypesLB.FormattingEnabled = true;
            this.gradeTypesLB.ItemHeight = 15;
            this.gradeTypesLB.Items.AddRange(new object[] {
            "Курсовая (0)",
            "Семестровая (1)",
            "Экзаменационная (1)"});
            this.gradeTypesLB.Location = new System.Drawing.Point(7, 79);
            this.gradeTypesLB.Name = "gradeTypesLB";
            this.gradeTypesLB.Size = new System.Drawing.Size(258, 79);
            this.gradeTypesLB.TabIndex = 7;
            this.gradeTypesLB.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.gradeTypesLB_Format);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.subjectsLB);
            this.groupBox5.Location = new System.Drawing.Point(12, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(271, 690);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Предметы";
            // 
            // GradeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 936);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "GradeEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование оценок";
            ((System.ComponentModel.ISupportInitialize)(this.editorDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox subjectsLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox semesterTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.DataGridView editorDGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button numberLeftBtn;
        private System.Windows.Forms.Button numberRightBtn;
        private System.Windows.Forms.Button numberAddBtn;
        private System.Windows.Forms.Button numberDeleteBtn;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox gradeTypesLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeValueColumn;
    }
}