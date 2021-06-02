
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
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Конфигурация");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Все предметы");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Менеджер по эксплуатации");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Менеджер по эксплуатации 2");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Специальности", new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Техник программист", new System.Windows.Forms.TreeNode[] {
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Оператор ЭВМ");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Квалификации", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Студенты");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("КПиЯП (К)");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("ИПО (К)");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("АЛОвТ");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Ин Яз");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Предметы", new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Предметы преподавателя");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Корневич М.А.", new System.Windows.Forms.TreeNode[] {
            treeNode83});
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Алексей Г.");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Студенты", new System.Windows.Forms.TreeNode[] {
            treeNode84,
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("КПиЯП (ЭКЗ)");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("АЛОвТ (ЭКЗ)");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Ин Яз");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Предметы", new System.Windows.Forms.TreeNode[] {
            treeNode87,
            treeNode88,
            treeNode89});
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Периоды");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("1 Семестр", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode90,
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("2 Семестр");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Семестры", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93});
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("1 Курс", new System.Windows.Forms.TreeNode[] {
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("2 Курс");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("3 Курс");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Курсы", new System.Windows.Forms.TreeNode[] {
            treeNode95,
            treeNode96,
            treeNode97});
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("T91-19 (К)", new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode82,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("T92-19");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("T93-19");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Группы", new System.Windows.Forms.TreeNode[] {
            treeNode99,
            treeNode100,
            treeNode101});
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.CreateNewAct);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenAct);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveAct);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.SaveAsAct);
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
            treeNode69.Name = "Node1";
            treeNode69.Text = "Конфигурация";
            treeNode70.Name = "Node9";
            treeNode70.Text = "Все предметы";
            treeNode71.Name = "Node24";
            treeNode71.Text = "Менеджер по эксплуатации";
            treeNode72.Name = "Node25";
            treeNode72.Text = "Менеджер по эксплуатации 2";
            treeNode73.Name = "Node23";
            treeNode73.Text = "Специальности";
            treeNode74.Name = "Node21";
            treeNode74.Text = "Техник программист";
            treeNode75.Name = "Node22";
            treeNode75.Text = "Оператор ЭВМ";
            treeNode76.Name = "Node20";
            treeNode76.Text = "Квалификации";
            treeNode77.Name = "Node6";
            treeNode77.Text = "Студенты";
            treeNode78.Name = "Node26";
            treeNode78.Text = "КПиЯП (К)";
            treeNode79.Name = "Node27";
            treeNode79.Text = "ИПО (К)";
            treeNode80.Name = "Node28";
            treeNode80.Text = "АЛОвТ";
            treeNode81.Name = "Node29";
            treeNode81.Text = "Ин Яз";
            treeNode82.Name = "Node7";
            treeNode82.Text = "Предметы";
            treeNode83.Name = "Node19";
            treeNode83.Text = "Предметы преподавателя";
            treeNode84.Name = "Node17";
            treeNode84.Text = "Корневич М.А.";
            treeNode85.Name = "Node18";
            treeNode85.Text = "Алексей Г.";
            treeNode86.Name = "Node16";
            treeNode86.Text = "Студенты";
            treeNode87.Name = "Node32";
            treeNode87.Text = "КПиЯП (ЭКЗ)";
            treeNode88.Name = "Node33";
            treeNode88.Text = "АЛОвТ (ЭКЗ)";
            treeNode89.Name = "Node34";
            treeNode89.Text = "Ин Яз";
            treeNode90.Name = "Node30";
            treeNode90.Text = "Предметы";
            treeNode91.Name = "Node31";
            treeNode91.Text = "Периоды";
            treeNode92.Name = "Node14";
            treeNode92.Text = "1 Семестр";
            treeNode93.Name = "Node15";
            treeNode93.Text = "2 Семестр";
            treeNode94.Name = "Node13";
            treeNode94.Text = "Семестры";
            treeNode95.Name = "Node10";
            treeNode95.Text = "1 Курс";
            treeNode96.Name = "Node11";
            treeNode96.Text = "2 Курс";
            treeNode97.Name = "Node12";
            treeNode97.Text = "3 Курс";
            treeNode98.Name = "Node8";
            treeNode98.Text = "Курсы";
            treeNode99.Name = "Node3";
            treeNode99.Text = "T91-19 (К)";
            treeNode100.Name = "Node4";
            treeNode100.Text = "T92-19";
            treeNode101.Name = "Node5";
            treeNode101.Text = "T93-19";
            treeNode102.Name = "Node2";
            treeNode102.Text = "Группы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode70,
            treeNode76,
            treeNode102});
            this.treeView1.Size = new System.Drawing.Size(430, 698);
            this.treeView1.TabIndex = 3;
            // 
            // peTreeView1
            // 
            this.peTreeView1.Location = new System.Drawing.Point(436, 27);
            this.peTreeView1.Name = "peTreeView1";
            this.peTreeView1.Size = new System.Drawing.Size(452, 698);
            this.peTreeView1.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 758);
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
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

