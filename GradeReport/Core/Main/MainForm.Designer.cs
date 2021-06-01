
namespace GradeReport.Core.Main
{
    public partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Проект 2455", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode8,
            treeNode34});
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьКРодительскомуСобраниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ведомостьОтметокПоКурсовомуПроектуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьОтметокЗаСеместрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализРезультатовОКРКПиЯПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализРезультатовДКРКПиЯПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экзаменационнаяВедомостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетУспеваемостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мониторингУчебныхДостиженийГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.своднаяВедомостьУспеваемостиУчащихсяГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.своднаяВедомостьУспеваемостиСлужебнаяЗапискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.своднаяВедомостьЗаПериодОбученияКрасныйДипломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.peTreeView1 = new GradeReport.Core.ProjectExplorer.PETreeView();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(900, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.успеваемостьЗаПериодToolStripMenuItem,
            this.успеваемостьКРодительскомуСобраниюToolStripMenuItem,
            this.toolStripSeparator1,
            this.ведомостьОтметокПоКурсовомуПроектуToolStripMenuItem,
            this.ведомостьОтметокЗаСеместрToolStripMenuItem,
            this.анализРезультатовОКРКПиЯПToolStripMenuItem,
            this.анализРезультатовДКРКПиЯПToolStripMenuItem,
            this.экзаменационнаяВедомостьToolStripMenuItem,
            this.отчетУспеваемостиToolStripMenuItem,
            this.мониторингУчебныхДостиженийГруппыToolStripMenuItem,
            this.своднаяВедомостьУспеваемостиУчащихсяГруппыToolStripMenuItem,
            this.своднаяВедомостьУспеваемостиСлужебнаяЗапискаToolStripMenuItem,
            this.toolStripSeparator2,
            this.своднаяВедомостьЗаПериодОбученияКрасныйДипломToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // успеваемостьЗаПериодToolStripMenuItem
            // 
            this.успеваемостьЗаПериодToolStripMenuItem.Name = "успеваемостьЗаПериодToolStripMenuItem";
            this.успеваемостьЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.успеваемостьЗаПериодToolStripMenuItem.Text = "1.1 Успеваемость за период";
            // 
            // успеваемостьКРодительскомуСобраниюToolStripMenuItem
            // 
            this.успеваемостьКРодительскомуСобраниюToolStripMenuItem.Name = "успеваемостьКРодительскомуСобраниюToolStripMenuItem";
            this.успеваемостьКРодительскомуСобраниюToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.успеваемостьКРодительскомуСобраниюToolStripMenuItem.Text = "1.2 Успеваемость к родительскому собранию";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(415, 6);
            // 
            // ведомостьОтметокПоКурсовомуПроектуToolStripMenuItem
            // 
            this.ведомостьОтметокПоКурсовомуПроектуToolStripMenuItem.Name = "ведомостьОтметокПоКурсовомуПроектуToolStripMenuItem";
            this.ведомостьОтметокПоКурсовомуПроектуToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.ведомостьОтметокПоКурсовомуПроектуToolStripMenuItem.Text = "2.1 Ведомость отметок по курсовому проекту";
            // 
            // ведомостьОтметокЗаСеместрToolStripMenuItem
            // 
            this.ведомостьОтметокЗаСеместрToolStripMenuItem.Name = "ведомостьОтметокЗаСеместрToolStripMenuItem";
            this.ведомостьОтметокЗаСеместрToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.ведомостьОтметокЗаСеместрToolStripMenuItem.Text = "2.2 Ведомость отметок за семестр";
            // 
            // анализРезультатовОКРКПиЯПToolStripMenuItem
            // 
            this.анализРезультатовОКРКПиЯПToolStripMenuItem.Name = "анализРезультатовОКРКПиЯПToolStripMenuItem";
            this.анализРезультатовОКРКПиЯПToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.анализРезультатовОКРКПиЯПToolStripMenuItem.Text = "2.3 Анализ результатов ОКР (КПиЯП)";
            // 
            // анализРезультатовДКРКПиЯПToolStripMenuItem
            // 
            this.анализРезультатовДКРКПиЯПToolStripMenuItem.Name = "анализРезультатовДКРКПиЯПToolStripMenuItem";
            this.анализРезультатовДКРКПиЯПToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.анализРезультатовДКРКПиЯПToolStripMenuItem.Text = "2.3.5 Анализ результатов ДКР (КПиЯП)";
            // 
            // экзаменационнаяВедомостьToolStripMenuItem
            // 
            this.экзаменационнаяВедомостьToolStripMenuItem.Name = "экзаменационнаяВедомостьToolStripMenuItem";
            this.экзаменационнаяВедомостьToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.экзаменационнаяВедомостьToolStripMenuItem.Text = "2.4 Экзаменационная ведомость";
            // 
            // отчетУспеваемостиToolStripMenuItem
            // 
            this.отчетУспеваемостиToolStripMenuItem.Name = "отчетУспеваемостиToolStripMenuItem";
            this.отчетУспеваемостиToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.отчетУспеваемостиToolStripMenuItem.Text = "2.5 Отчет успеваемости";
            // 
            // мониторингУчебныхДостиженийГруппыToolStripMenuItem
            // 
            this.мониторингУчебныхДостиженийГруппыToolStripMenuItem.Name = "мониторингУчебныхДостиженийГруппыToolStripMenuItem";
            this.мониторингУчебныхДостиженийГруппыToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.мониторингУчебныхДостиженийГруппыToolStripMenuItem.Text = "2.7 Мониторинг учебных достижений группы";
            // 
            // своднаяВедомостьУспеваемостиУчащихсяГруппыToolStripMenuItem
            // 
            this.своднаяВедомостьУспеваемостиУчащихсяГруппыToolStripMenuItem.Name = "своднаяВедомостьУспеваемостиУчащихсяГруппыToolStripMenuItem";
            this.своднаяВедомостьУспеваемостиУчащихсяГруппыToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.своднаяВедомостьУспеваемостиУчащихсяГруппыToolStripMenuItem.Text = "2.8 Сводная ведомость успеваемости учащихся группы";
            // 
            // своднаяВедомостьУспеваемостиСлужебнаяЗапискаToolStripMenuItem
            // 
            this.своднаяВедомостьУспеваемостиСлужебнаяЗапискаToolStripMenuItem.Name = "своднаяВедомостьУспеваемостиСлужебнаяЗапискаToolStripMenuItem";
            this.своднаяВедомостьУспеваемостиСлужебнаяЗапискаToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.своднаяВедомостьУспеваемостиСлужебнаяЗапискаToolStripMenuItem.Text = "2.9 Сводная ведомость успеваемости (Служебная записка)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(415, 6);
            // 
            // своднаяВедомостьЗаПериодОбученияКрасныйДипломToolStripMenuItem
            // 
            this.своднаяВедомостьЗаПериодОбученияКрасныйДипломToolStripMenuItem.Name = "своднаяВедомостьЗаПериодОбученияКрасныйДипломToolStripMenuItem";
            this.своднаяВедомостьЗаПериодОбученияКрасныйДипломToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.своднаяВедомостьЗаПериодОбученияКрасныйДипломToolStripMenuItem.Text = "4.1 Сводная ведомость за период обучения (Красный диплом)";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(0, 27);
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
            treeNode35.Name = "Node0";
            treeNode35.Text = "Проект 2455";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode35});
            this.treeView1.Size = new System.Drawing.Size(456, 534);
            this.treeView1.TabIndex = 3;
            // 
            // peTreeView1
            // 
            this.peTreeView1.Location = new System.Drawing.Point(462, 27);
            this.peTreeView1.Name = "peTreeView1";
            this.peTreeView1.Size = new System.Drawing.Size(426, 534);
            this.peTreeView1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 692);
            this.Controls.Add(this.peTreeView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "GradeReport";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьКРодительскомуСобраниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ведомостьОтметокПоКурсовомуПроектуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьОтметокЗаСеместрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализРезультатовОКРКПиЯПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализРезультатовДКРКПиЯПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экзаменационнаяВедомостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетУспеваемостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мониторингУчебныхДостиженийГруппыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem своднаяВедомостьУспеваемостиУчащихсяГруппыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem своднаяВедомостьУспеваемостиСлужебнаяЗапискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem своднаяВедомостьЗаПериодОбученияКрасныйДипломToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private ProjectExplorer.PETreeView peTreeView1;
    }
}

