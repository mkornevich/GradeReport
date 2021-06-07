
namespace GradeReport.Core.Notify
{
    partial class NotificationForm
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
            this.notificationDGV = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewImageColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.actionStrip = new GradeReport.Core.Actioning.ActionStrip();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationDGV
            // 
            this.notificationDGV.AllowUserToAddRows = false;
            this.notificationDGV.AllowUserToDeleteRows = false;
            this.notificationDGV.AllowUserToResizeColumns = false;
            this.notificationDGV.AllowUserToResizeRows = false;
            this.notificationDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.notificationDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notificationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notificationDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Message});
            this.notificationDGV.Cursor = System.Windows.Forms.Cursors.Default;
            this.notificationDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationDGV.Location = new System.Drawing.Point(0, 0);
            this.notificationDGV.MultiSelect = false;
            this.notificationDGV.Name = "notificationDGV";
            this.notificationDGV.ReadOnly = true;
            this.notificationDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.notificationDGV.RowHeadersVisible = false;
            this.notificationDGV.RowTemplate.Height = 25;
            this.notificationDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.notificationDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notificationDGV.Size = new System.Drawing.Size(450, 314);
            this.notificationDGV.TabIndex = 0;
            this.notificationDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.notificationDGV_CellFormatting);
            this.notificationDGV.SelectionChanged += new System.EventHandler(this.notificationDGV_SelectionChanged);
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Type.Width = 35;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Сообщение";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // descriptionTB
            // 
            this.descriptionTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTB.Location = new System.Drawing.Point(0, 0);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.ReadOnly = true;
            this.descriptionTB.Size = new System.Drawing.Size(450, 157);
            this.descriptionTB.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.notificationDGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTB);
            this.splitContainer1.Size = new System.Drawing.Size(450, 475);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.TabIndex = 2;
            // 
            // actionStrip
            // 
            this.actionStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.actionStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionStrip.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.actionStrip.Location = new System.Drawing.Point(0, 475);
            this.actionStrip.Name = "actionStrip";
            this.actionStrip.Padding = new System.Windows.Forms.Padding(5, 5, 2, 5);
            this.actionStrip.Size = new System.Drawing.Size(450, 40);
            this.actionStrip.TabIndex = 3;
            this.actionStrip.Visible = false;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 515);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.actionStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotificationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Менеджер сообщений";
            ((System.ComponentModel.ISupportInitialize)(this.notificationDGV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView notificationDGV;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewImageColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private Actioning.ActionStrip actionStrip;
    }
}