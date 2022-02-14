
using GradeReport.Common.ActionNS;

namespace GradeReport.List
{
    partial class ListForm
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.selectAll = new System.Windows.Forms.ToolStripButton();
            this.unselectAll = new System.Windows.Forms.ToolStripButton();
            this.inverseAll = new System.Windows.Forms.ToolStripButton();
            this.selectionInfoLbl = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeRows = false;
            this.Table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 25);
            this.Table.MultiSelect = false;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersVisible = false;
            this.Table.RowTemplate.Height = 25;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(566, 355);
            this.Table.TabIndex = 1;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellContentClickAct);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAll,
            this.unselectAll,
            this.inverseAll,
            this.selectionInfoLbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // selectAll
            // 
            this.selectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAll.Image = global::GradeReport.Properties.Resources.check_16;
            this.selectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(23, 22);
            this.selectAll.Text = "toolStripButton1";
            this.selectAll.ToolTipText = "Выделить все";
            this.selectAll.Click += new System.EventHandler(this.SelectAllAct);
            // 
            // unselectAll
            // 
            this.unselectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unselectAll.Image = global::GradeReport.Properties.Resources.uncheck_16;
            this.unselectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unselectAll.Name = "unselectAll";
            this.unselectAll.Size = new System.Drawing.Size(23, 22);
            this.unselectAll.Text = "toolStripButton2";
            this.unselectAll.ToolTipText = "Снять выделение со всего";
            this.unselectAll.Click += new System.EventHandler(this.UnselectAllAct);
            // 
            // inverseAll
            // 
            this.inverseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inverseAll.Image = global::GradeReport.Properties.Resources.refresh_16;
            this.inverseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inverseAll.Name = "inverseAll";
            this.inverseAll.Size = new System.Drawing.Size(23, 22);
            this.inverseAll.Text = "toolStripButton3";
            this.inverseAll.ToolTipText = "Инвертировать";
            this.inverseAll.Click += new System.EventHandler(this.InverseAllAct);
            // 
            // selectionInfoTB
            // 
            this.selectionInfoLbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.selectionInfoLbl.Name = "selectionInfoTB";
            this.selectionInfoLbl.Size = new System.Drawing.Size(101, 22);
            this.selectionInfoLbl.Text = "Выделено 6 из 25";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 380);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListForm";
            this.ShowIcon = false;
            this.Text = "Список";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ToolStripButton selectAll;
        private System.Windows.Forms.ToolStripButton unselectAll;
        private System.Windows.Forms.ToolStripButton inverseAll;
        private System.Windows.Forms.ToolStripLabel selectionInfoLbl;
    }
}