﻿
namespace GradeReport.ReportNS.ControlWorksAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numberPivotSemesterNUD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numberControlWorkNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.professionTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.subjectTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.allStudentCountNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkerTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherTB = new System.Windows.Forms.TextBox();
            this.groupTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.educationalTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gradesPivotSemesterTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gradesControlWorkTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buildReportBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPivotSemesterNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberControlWorkNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStudentCountNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numberPivotSemesterNUD);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numberControlWorkNUD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateDTP);
            this.groupBox1.Controls.Add(this.professionTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.subjectTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.allStudentCountNUD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkerTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.teacherTB);
            this.groupBox1.Controls.Add(this.groupTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.educationalTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "№ опорного семестра\r\n";
            // 
            // numberPivotSemesterNUD
            // 
            this.numberPivotSemesterNUD.Location = new System.Drawing.Point(6, 305);
            this.numberPivotSemesterNUD.Name = "numberPivotSemesterNUD";
            this.numberPivotSemesterNUD.Size = new System.Drawing.Size(329, 20);
            this.numberPivotSemesterNUD.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "№ контрольной работы (ОКР)";
            // 
            // numberControlWorkNUD
            // 
            this.numberControlWorkNUD.Location = new System.Drawing.Point(6, 344);
            this.numberControlWorkNUD.Name = "numberControlWorkNUD";
            this.numberControlWorkNUD.Size = new System.Drawing.Size(329, 20);
            this.numberControlWorkNUD.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Дата проведения";
            // 
            // dateDTP
            // 
            this.dateDTP.Location = new System.Drawing.Point(6, 383);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(329, 20);
            this.dateDTP.TabIndex = 9;
            // 
            // professionTB
            // 
            this.professionTB.Location = new System.Drawing.Point(6, 227);
            this.professionTB.Name = "professionTB";
            this.professionTB.Size = new System.Drawing.Size(329, 20);
            this.professionTB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Название профессии (ОКР)";
            // 
            // subjectTB
            // 
            this.subjectTB.Location = new System.Drawing.Point(6, 188);
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(329, 20);
            this.subjectTB.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Название предмета";
            // 
            // allStudentCountNUD
            // 
            this.allStudentCountNUD.Location = new System.Drawing.Point(6, 266);
            this.allStudentCountNUD.Name = "allStudentCountNUD";
            this.allStudentCountNUD.Size = new System.Drawing.Size(329, 20);
            this.allStudentCountNUD.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кол-во учащихся всего (по списку)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Проверяющий (ДКР)";
            // 
            // checkerTB
            // 
            this.checkerTB.Location = new System.Drawing.Point(6, 149);
            this.checkerTB.Name = "checkerTB";
            this.checkerTB.Size = new System.Drawing.Size(328, 20);
            this.checkerTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Преподаватель";
            // 
            // teacherTB
            // 
            this.teacherTB.Location = new System.Drawing.Point(6, 110);
            this.teacherTB.Name = "teacherTB";
            this.teacherTB.Size = new System.Drawing.Size(329, 20);
            this.teacherTB.TabIndex = 2;
            // 
            // groupTB
            // 
            this.groupTB.Location = new System.Drawing.Point(6, 71);
            this.groupTB.Name = "groupTB";
            this.groupTB.Size = new System.Drawing.Size(329, 20);
            this.groupTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Учреждение образования";
            // 
            // educationalTB
            // 
            this.educationalTB.Location = new System.Drawing.Point(6, 32);
            this.educationalTB.Name = "educationalTB";
            this.educationalTB.Size = new System.Drawing.Size(329, 20);
            this.educationalTB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.gradesPivotSemesterTB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.gradesControlWorkTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оценки";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(147, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Пример: 14558*63010586***";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(6, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(293, 26);
            this.label13.TabIndex = 12;
            this.label13.Text = "- Оценки необходимо вводить по порядку без пробелов.\r\n- 10 необходимо заменить на" +
    " \"*\" (звезда) при вводе.";
            // 
            // gradesPivotSemesterTB
            // 
            this.gradesPivotSemesterTB.Location = new System.Drawing.Point(6, 71);
            this.gradesPivotSemesterTB.Name = "gradesPivotSemesterTB";
            this.gradesPivotSemesterTB.Size = new System.Drawing.Size(329, 20);
            this.gradesPivotSemesterTB.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Оценки по опорному семестру\r\n\r\n";
            // 
            // gradesControlWorkTB
            // 
            this.gradesControlWorkTB.Location = new System.Drawing.Point(6, 32);
            this.gradesControlWorkTB.Name = "gradesControlWorkTB";
            this.gradesControlWorkTB.Size = new System.Drawing.Size(329, 20);
            this.gradesControlWorkTB.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Оценики по контрольной работе";
            // 
            // buildReportBtn
            // 
            this.buildReportBtn.Location = new System.Drawing.Point(12, 578);
            this.buildReportBtn.Name = "buildReportBtn";
            this.buildReportBtn.Size = new System.Drawing.Size(341, 23);
            this.buildReportBtn.TabIndex = 2;
            this.buildReportBtn.Text = "Создать отчет";
            this.buildReportBtn.UseVisualStyleBackColor = true;
            this.buildReportBtn.Click += new System.EventHandler(this.buildReportBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Location = new System.Drawing.Point(190, 615);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Разработал Корневич Максим\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(12, 615);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "v 0.1\r\n";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.FileName = "отчет.xlsx";
            this.saveFileDialog.Filter = "Excel файл (*.xlsx)|*.xlsx";
            this.saveFileDialog.FilterIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 637);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buildReportBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Анализ контрольных работ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberPivotSemesterNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberControlWorkNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStudentCountNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buildReportBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        internal System.Windows.Forms.NumericUpDown numberPivotSemesterNUD;
        internal System.Windows.Forms.NumericUpDown numberControlWorkNUD;
        internal System.Windows.Forms.DateTimePicker dateDTP;
        internal System.Windows.Forms.TextBox professionTB;
        internal System.Windows.Forms.TextBox subjectTB;
        internal System.Windows.Forms.NumericUpDown allStudentCountNUD;
        internal System.Windows.Forms.TextBox checkerTB;
        internal System.Windows.Forms.TextBox teacherTB;
        internal System.Windows.Forms.TextBox groupTB;
        internal System.Windows.Forms.TextBox educationalTB;
        internal System.Windows.Forms.TextBox gradesPivotSemesterTB;
        internal System.Windows.Forms.TextBox gradesControlWorkTB;
    }
}

