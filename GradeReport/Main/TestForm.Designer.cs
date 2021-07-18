
using GradeReport.Common;
using GradeReport.Common.ActionNS;

namespace GradeReport.Main
{
    partial class TestForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Конфигурация");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Все предметы");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Менеджер по эксплуатации");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Менеджер по эксплуатации 2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Специальности", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Техник программист", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Оператор ЭВМ");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Квалификации", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Студенты");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("КПиЯП (К)");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("ИПО (К)");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("АЛОвТ");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Ин Яз");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Предметы", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Предметы преподавателя");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Корневич М.А.", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Алексей Г.");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Студенты", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("КПиЯП (ЭКЗ)");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("АЛОвТ (ЭКЗ)");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Ин Яз");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Предметы", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Периоды");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("1 Семестр", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("2 Семестр");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Семестры", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("1 Курс", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("2 Курс");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("3 Курс");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Курсы", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("T91-19 (К)", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode14,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("T92-19");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("T93-19");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Группы", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.actionStrip1 = new GradeReport.Common.ActionNS.ActionStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chooser1 = new GradeReport.Common.Chooser();
            this.label2 = new System.Windows.Forms.Label();
            this.helpLabel1 = new GradeReport.Common.HelpLabel();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Конфигурация";
            treeNode2.Name = "Node9";
            treeNode2.Text = "Все предметы";
            treeNode3.Name = "Node24";
            treeNode3.Text = "Менеджер по эксплуатации";
            treeNode4.Name = "Node25";
            treeNode4.Text = "Менеджер по эксплуатации 2";
            treeNode5.Name = "Node23";
            treeNode5.Text = "Специальности";
            treeNode6.Name = "Node21";
            treeNode6.Text = "Техник программист";
            treeNode7.Name = "Node22";
            treeNode7.Text = "Оператор ЭВМ";
            treeNode8.Name = "Node20";
            treeNode8.Text = "Квалификации";
            treeNode9.Name = "Node6";
            treeNode9.Text = "Студенты";
            treeNode10.Name = "Node26";
            treeNode10.Text = "КПиЯП (К)";
            treeNode11.Name = "Node27";
            treeNode11.Text = "ИПО (К)";
            treeNode12.Name = "Node28";
            treeNode12.Text = "АЛОвТ";
            treeNode13.Name = "Node29";
            treeNode13.Text = "Ин Яз";
            treeNode14.Name = "Node7";
            treeNode14.Text = "Предметы";
            treeNode15.Name = "Node19";
            treeNode15.Text = "Предметы преподавателя";
            treeNode16.Name = "Node17";
            treeNode16.Text = "Корневич М.А.";
            treeNode17.Name = "Node18";
            treeNode17.Text = "Алексей Г.";
            treeNode18.Name = "Node16";
            treeNode18.Text = "Студенты";
            treeNode19.Name = "Node32";
            treeNode19.Text = "КПиЯП (ЭКЗ)";
            treeNode20.Name = "Node33";
            treeNode20.Text = "АЛОвТ (ЭКЗ)";
            treeNode21.Name = "Node34";
            treeNode21.Text = "Ин Яз";
            treeNode22.Name = "Node30";
            treeNode22.Text = "Предметы";
            treeNode23.Name = "Node31";
            treeNode23.Text = "Периоды";
            treeNode24.Name = "Node14";
            treeNode24.Text = "1 Семестр";
            treeNode25.Name = "Node15";
            treeNode25.Text = "2 Семестр";
            treeNode26.Name = "Node13";
            treeNode26.Text = "Семестры";
            treeNode27.Name = "Node10";
            treeNode27.Text = "1 Курс";
            treeNode28.Name = "Node11";
            treeNode28.Text = "2 Курс";
            treeNode29.Name = "Node12";
            treeNode29.Text = "3 Курс";
            treeNode30.Name = "Node8";
            treeNode30.Text = "Курсы";
            treeNode31.Name = "Node3";
            treeNode31.Text = "T91-19 (К)";
            treeNode32.Name = "Node4";
            treeNode32.Text = "T92-19";
            treeNode33.Name = "Node5";
            treeNode33.Text = "T93-19";
            treeNode34.Name = "Node2";
            treeNode34.Text = "Группы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode8,
            treeNode34});
            this.treeView1.Size = new System.Drawing.Size(435, 521);
            this.treeView1.TabIndex = 4;
            // 
            // actionStrip1
            // 
            this.actionStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.actionStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionStrip1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.actionStrip1.Location = new System.Drawing.Point(0, 587);
            this.actionStrip1.Name = "actionStrip1";
            this.actionStrip1.Padding = new System.Windows.Forms.Padding(5, 5, 2, 5);
            this.actionStrip1.Size = new System.Drawing.Size(1246, 40);
            this.actionStrip1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(732, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(495, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 16);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Test";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(172, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 21);
            this.button2.TabIndex = 0;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(607, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 9;
            // 
            // chooser1
            // 
            this.chooser1.BackColor = System.Drawing.SystemColors.Window;
            this.chooser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chooser1.ChooseText = "";
            this.chooser1.Location = new System.Drawing.Point(607, 217);
            this.chooser1.Name = "chooser1";
            this.chooser1.Size = new System.Drawing.Size(200, 23);
            this.chooser1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // helpLabel1
            // 
            this.helpLabel1.AutoScroll = true;
            this.helpLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel1.BackgroundImage")));
            this.helpLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpLabel1.HelpText = "Тут необходимо указать полное наименование предмета.\r\n\r\nДанная информация использ" +
    "уется при генерации отчета.\r\n\r\nЖелательно чтоб это поле было уникальным по отнош" +
    "ению к другим предметом.";
            this.helpLabel1.Location = new System.Drawing.Point(791, 155);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(16, 16);
            this.helpLabel1.TabIndex = 13;
            // 
            // helpLabel2
            // 
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpLabel2.HelpText = "Здесь необходимо выбрать тех пользователей которые пренадлежат определенной групп" +
    "е.\r\n\r\nДанная информация используется при генерации отчетов.";
            this.helpLabel2.Location = new System.Drawing.Point(791, 199);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooser1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.actionStrip1);
            this.Controls.Add(this.treeView1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private ActionStrip actionStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private Chooser entitySelector1;
        private System.Windows.Forms.TextBox textBox2;
        private Chooser chooser1;
        private System.Windows.Forms.Label label2;
        private HelpLabel helpLabel1;
        private HelpLabel helpLabel2;
        private System.Windows.Forms.Label label1;
    }
}