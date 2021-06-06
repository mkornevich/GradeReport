
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
            this.peTreeView = new GradeReport.Core.ProjectExplorer.PETreeView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестФормаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(518, 24);
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
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.CreateNewAct);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenAct);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveAct);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
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
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1,
            this.настройкиToolStripMenuItem,
            this.тестФормаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.оПрограммеToolStripMenuItem.Text = "Программа";
            // 
            // peTreeView
            // 
            this.peTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.peTreeView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.peTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peTreeView.Location = new System.Drawing.Point(0, 15);
            this.peTreeView.Name = "peTreeView";
            this.peTreeView.Size = new System.Drawing.Size(516, 536);
            this.peTreeView.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(518, 748);
            this.splitContainer1.SplitterDistance = 553;
            this.splitContainer1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.peTreeView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 553);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Обозреватель проекта";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 191);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Описание выделенного элемента";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // тестФормаToolStripMenuItem
            // 
            this.тестФормаToolStripMenuItem.Name = "тестФормаToolStripMenuItem";
            this.тестФормаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.тестФормаToolStripMenuItem.Text = "Тест форма";
            this.тестФормаToolStripMenuItem.Click += new System.EventHandler(this.showTestFormAct);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 772);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "GradeReport";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private ProjectExplorer.PETreeView peTreeView;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестФормаToolStripMenuItem;
    }
}

