
namespace GradeReport.Reporting.Reports.ControlWorksAnalyzer
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpLabel10 = new GradeReport.Common.HelpLabel();
            this.helpLabel9 = new GradeReport.Common.HelpLabel();
            this.helpLabel8 = new GradeReport.Common.HelpLabel();
            this.helpLabel7 = new GradeReport.Common.HelpLabel();
            this.helpLabel6 = new GradeReport.Common.HelpLabel();
            this.helpLabel5 = new GradeReport.Common.HelpLabel();
            this.helpLabel4 = new GradeReport.Common.HelpLabel();
            this.helpLabel3 = new GradeReport.Common.HelpLabel();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
            this.helpLabel1 = new GradeReport.Common.HelpLabel();
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
            this.helpLabel12 = new GradeReport.Common.HelpLabel();
            this.helpLabel11 = new GradeReport.Common.HelpLabel();
            this.gradesPivotSemesterCountLbl = new System.Windows.Forms.Label();
            this.gradesControlWorkCountLbl = new System.Windows.Forms.Label();
            this.gradesPivotSemesterTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gradesControlWorkTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.helpLabel10);
            this.groupBox1.Controls.Add(this.helpLabel9);
            this.groupBox1.Controls.Add(this.helpLabel8);
            this.groupBox1.Controls.Add(this.helpLabel7);
            this.groupBox1.Controls.Add(this.helpLabel6);
            this.groupBox1.Controls.Add(this.helpLabel5);
            this.groupBox1.Controls.Add(this.helpLabel4);
            this.groupBox1.Controls.Add(this.helpLabel3);
            this.groupBox1.Controls.Add(this.helpLabel2);
            this.groupBox1.Controls.Add(this.helpLabel1);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(398, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // helpLabel10
            // 
            this.helpLabel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel10.BackgroundImage")));
            this.helpLabel10.HelpText = "Здесь необходимо указать дату проведения контрольной работы.";
            this.helpLabel10.Location = new System.Drawing.Point(374, 423);
            this.helpLabel10.Name = "helpLabel10";
            this.helpLabel10.Size = new System.Drawing.Size(16, 16);
            this.helpLabel10.TabIndex = 29;
            // 
            // helpLabel9
            // 
            this.helpLabel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel9.BackgroundImage")));
            this.helpLabel9.HelpText = "Здесь необходимо указать номер контрольной работы. Это необходимо только для анал" +
    "иза ОКР так как их может быть несколько.";
            this.helpLabel9.Location = new System.Drawing.Point(374, 378);
            this.helpLabel9.Name = "helpLabel9";
            this.helpLabel9.Size = new System.Drawing.Size(16, 16);
            this.helpLabel9.TabIndex = 28;
            // 
            // helpLabel8
            // 
            this.helpLabel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel8.BackgroundImage")));
            this.helpLabel8.HelpText = "Здесь необходимо указать номер опорного семестра. Опорный семестр -  семестр с ко" +
    "торым выполняется сравнение.";
            this.helpLabel8.Location = new System.Drawing.Point(374, 333);
            this.helpLabel8.Name = "helpLabel8";
            this.helpLabel8.Size = new System.Drawing.Size(16, 16);
            this.helpLabel8.TabIndex = 27;
            // 
            // helpLabel7
            // 
            this.helpLabel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel7.BackgroundImage")));
            this.helpLabel7.HelpText = "Здесь необходимо указать количество учащихся по списку. Данный параметр используе" +
    "тся в расчетах.";
            this.helpLabel7.Location = new System.Drawing.Point(374, 288);
            this.helpLabel7.Name = "helpLabel7";
            this.helpLabel7.Size = new System.Drawing.Size(16, 16);
            this.helpLabel7.TabIndex = 26;
            // 
            // helpLabel6
            // 
            this.helpLabel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel6.BackgroundImage")));
            this.helpLabel6.HelpText = "Здесь необходимо указать полное название профессии.";
            this.helpLabel6.Location = new System.Drawing.Point(374, 243);
            this.helpLabel6.Name = "helpLabel6";
            this.helpLabel6.Size = new System.Drawing.Size(16, 16);
            this.helpLabel6.TabIndex = 25;
            // 
            // helpLabel5
            // 
            this.helpLabel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel5.BackgroundImage")));
            this.helpLabel5.HelpText = "Здесь необходимо ввести название предмета.";
            this.helpLabel5.Location = new System.Drawing.Point(374, 198);
            this.helpLabel5.Name = "helpLabel5";
            this.helpLabel5.Size = new System.Drawing.Size(16, 16);
            this.helpLabel5.TabIndex = 24;
            // 
            // helpLabel4
            // 
            this.helpLabel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel4.BackgroundImage")));
            this.helpLabel4.HelpText = "Данный параметр вводится только если необходимо выполнить анализ ДКР. Все аналоги" +
    "чно вводу параметра Преподаватель.";
            this.helpLabel4.Location = new System.Drawing.Point(374, 153);
            this.helpLabel4.Name = "helpLabel4";
            this.helpLabel4.Size = new System.Drawing.Size(16, 16);
            this.helpLabel4.TabIndex = 23;
            // 
            // helpLabel3
            // 
            this.helpLabel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel3.BackgroundImage")));
            this.helpLabel3.HelpText = "Здесь необходимо указать ФИО преподавателя. Если нужно чтоб в отчете было сокраще" +
    "но то введите в данном поле сокращенное нужным образом ФИО.";
            this.helpLabel3.Location = new System.Drawing.Point(374, 108);
            this.helpLabel3.Name = "helpLabel3";
            this.helpLabel3.Size = new System.Drawing.Size(16, 16);
            this.helpLabel3.TabIndex = 22;
            // 
            // helpLabel2
            // 
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.HelpText = "Здесь необходимо ввести название группы.";
            this.helpLabel2.Location = new System.Drawing.Point(374, 63);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 21;
            // 
            // helpLabel1
            // 
            this.helpLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel1.BackgroundImage")));
            this.helpLabel1.HelpText = "Здесь необходимо указать название учреждения образования.\r\n\r\n";
            this.helpLabel1.Location = new System.Drawing.Point(374, 18);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(16, 16);
            this.helpLabel1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 333);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "№ опорного семестра\r\n";
            // 
            // numberPivotSemesterNUD
            // 
            this.numberPivotSemesterNUD.Location = new System.Drawing.Point(7, 352);
            this.numberPivotSemesterNUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberPivotSemesterNUD.Name = "numberPivotSemesterNUD";
            this.numberPivotSemesterNUD.Size = new System.Drawing.Size(383, 23);
            this.numberPivotSemesterNUD.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 378);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "№ контрольной работы (ОКР)";
            // 
            // numberControlWorkNUD
            // 
            this.numberControlWorkNUD.Location = new System.Drawing.Point(7, 397);
            this.numberControlWorkNUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numberControlWorkNUD.Name = "numberControlWorkNUD";
            this.numberControlWorkNUD.Size = new System.Drawing.Size(383, 23);
            this.numberControlWorkNUD.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 423);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Дата проведения";
            // 
            // dateDTP
            // 
            this.dateDTP.Location = new System.Drawing.Point(7, 442);
            this.dateDTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(383, 23);
            this.dateDTP.TabIndex = 9;
            // 
            // professionTB
            // 
            this.professionTB.Location = new System.Drawing.Point(7, 262);
            this.professionTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.professionTB.Name = "professionTB";
            this.professionTB.Size = new System.Drawing.Size(383, 23);
            this.professionTB.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Название профессии (ОКР)";
            // 
            // subjectTB
            // 
            this.subjectTB.Location = new System.Drawing.Point(7, 217);
            this.subjectTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(383, 23);
            this.subjectTB.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Название предмета";
            // 
            // allStudentCountNUD
            // 
            this.allStudentCountNUD.Location = new System.Drawing.Point(7, 307);
            this.allStudentCountNUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allStudentCountNUD.Name = "allStudentCountNUD";
            this.allStudentCountNUD.Size = new System.Drawing.Size(383, 23);
            this.allStudentCountNUD.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кол-во учащихся всего (по списку)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Проверяющий (ДКР)";
            // 
            // checkerTB
            // 
            this.checkerTB.Location = new System.Drawing.Point(7, 172);
            this.checkerTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkerTB.Name = "checkerTB";
            this.checkerTB.Size = new System.Drawing.Size(383, 23);
            this.checkerTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Преподаватель";
            // 
            // teacherTB
            // 
            this.teacherTB.Location = new System.Drawing.Point(7, 127);
            this.teacherTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.teacherTB.Name = "teacherTB";
            this.teacherTB.Size = new System.Drawing.Size(383, 23);
            this.teacherTB.TabIndex = 2;
            // 
            // groupTB
            // 
            this.groupTB.Location = new System.Drawing.Point(7, 82);
            this.groupTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupTB.Name = "groupTB";
            this.groupTB.Size = new System.Drawing.Size(383, 23);
            this.groupTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Группа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Учреждение образования";
            // 
            // educationalTB
            // 
            this.educationalTB.Location = new System.Drawing.Point(7, 37);
            this.educationalTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.educationalTB.Name = "educationalTB";
            this.educationalTB.Size = new System.Drawing.Size(383, 23);
            this.educationalTB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.helpLabel12);
            this.groupBox2.Controls.Add(this.helpLabel11);
            this.groupBox2.Controls.Add(this.gradesPivotSemesterCountLbl);
            this.groupBox2.Controls.Add(this.gradesControlWorkCountLbl);
            this.groupBox2.Controls.Add(this.gradesPivotSemesterTB);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.gradesControlWorkTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(13, 508);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(398, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оценки";
            // 
            // helpLabel12
            // 
            this.helpLabel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel12.BackgroundImage")));
            this.helpLabel12.HelpText = "Все по аналогии с параметром Оценки по контрольной работе только выполняется с оц" +
    "енками по оторному семестру.";
            this.helpLabel12.Location = new System.Drawing.Point(194, 63);
            this.helpLabel12.Name = "helpLabel12";
            this.helpLabel12.Size = new System.Drawing.Size(16, 16);
            this.helpLabel12.TabIndex = 31;
            // 
            // helpLabel11
            // 
            this.helpLabel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel11.BackgroundImage")));
            this.helpLabel11.HelpText = "Здесь необходимо вводить оценки по контрольной работе.\r\nПробелы ставить не нужно." +
    "\r\nВместо 10 необходимо ставить *.\r\nСправа отображается количество введенных оцен" +
    "ок.\r\n\r\nПример: 458787**98996969*68";
            this.helpLabel11.Location = new System.Drawing.Point(204, 18);
            this.helpLabel11.Name = "helpLabel11";
            this.helpLabel11.Size = new System.Drawing.Size(16, 16);
            this.helpLabel11.TabIndex = 30;
            // 
            // gradesPivotSemesterCountLbl
            // 
            this.gradesPivotSemesterCountLbl.Location = new System.Drawing.Point(344, 63);
            this.gradesPivotSemesterCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradesPivotSemesterCountLbl.Name = "gradesPivotSemesterCountLbl";
            this.gradesPivotSemesterCountLbl.Size = new System.Drawing.Size(46, 15);
            this.gradesPivotSemesterCountLbl.TabIndex = 15;
            this.gradesPivotSemesterCountLbl.Text = "0";
            this.gradesPivotSemesterCountLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gradesControlWorkCountLbl
            // 
            this.gradesControlWorkCountLbl.Location = new System.Drawing.Point(344, 18);
            this.gradesControlWorkCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradesControlWorkCountLbl.Name = "gradesControlWorkCountLbl";
            this.gradesControlWorkCountLbl.Size = new System.Drawing.Size(46, 15);
            this.gradesControlWorkCountLbl.TabIndex = 14;
            this.gradesControlWorkCountLbl.Text = "0";
            this.gradesControlWorkCountLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gradesPivotSemesterTB
            // 
            this.gradesPivotSemesterTB.Location = new System.Drawing.Point(7, 82);
            this.gradesPivotSemesterTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gradesPivotSemesterTB.Name = "gradesPivotSemesterTB";
            this.gradesPivotSemesterTB.Size = new System.Drawing.Size(383, 23);
            this.gradesPivotSemesterTB.TabIndex = 11;
            this.gradesPivotSemesterTB.TextChanged += new System.EventHandler(this.GradesChangedAct);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 30);
            this.label12.TabIndex = 2;
            this.label12.Text = "Оценки по опорному семестру\r\n\r\n";
            // 
            // gradesControlWorkTB
            // 
            this.gradesControlWorkTB.Location = new System.Drawing.Point(7, 37);
            this.gradesControlWorkTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gradesControlWorkTB.Name = "gradesControlWorkTB";
            this.gradesControlWorkTB.Size = new System.Drawing.Size(383, 23);
            this.gradesControlWorkTB.TabIndex = 10;
            this.gradesControlWorkTB.TextChanged += new System.EventHandler(this.GradesChangedAct);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Оценки по контрольной работе";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ReportForm";
            this.Tag = "ControlWorksAnalyzer";
            this.Text = "Анализ контрольных работ ОКР ДКР";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.Label gradesPivotSemesterCountLbl;
        private System.Windows.Forms.Label gradesControlWorkCountLbl;
        private Common.HelpLabel helpLabel1;
        private Common.HelpLabel helpLabel10;
        private Common.HelpLabel helpLabel9;
        private Common.HelpLabel helpLabel8;
        private Common.HelpLabel helpLabel7;
        private Common.HelpLabel helpLabel6;
        private Common.HelpLabel helpLabel5;
        private Common.HelpLabel helpLabel4;
        private Common.HelpLabel helpLabel3;
        private Common.HelpLabel helpLabel2;
        private Common.HelpLabel helpLabel12;
        private Common.HelpLabel helpLabel11;
    }
}

