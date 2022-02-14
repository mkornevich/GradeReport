
namespace GradeReport.Edit.EditForms
{
    partial class ConfigEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.curatorNameTB = new System.Windows.Forms.TextBox();
            this.helpLabel1 = new GradeReport.Common.HelpLabel();
            this.curatorGroupCH = new GradeReport.Common.Chooser();
            this.helpLabel2 = new GradeReport.Common.HelpLabel();
            this.teacherNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helpLabel3 = new GradeReport.Common.HelpLabel();
            this.organizationNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.parentOrganisationNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.helpLabel4 = new GradeReport.Common.HelpLabel();
            this.helpLabel5 = new GradeReport.Common.HelpLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО куратора";
            // 
            // curatorNameTB
            // 
            this.curatorNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curatorNameTB.Location = new System.Drawing.Point(12, 175);
            this.curatorNameTB.Name = "curatorNameTB";
            this.curatorNameTB.Size = new System.Drawing.Size(395, 23);
            this.curatorNameTB.TabIndex = 2;
            // 
            // helpLabel1
            // 
            this.helpLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel1.BackgroundImage")));
            this.helpLabel1.HelpText = "В данном поле необходимо указать полное ФИО куратора.\r\n\r\nДанная информация исполь" +
    "зуется при построении отчетов.";
            this.helpLabel1.Location = new System.Drawing.Point(391, 157);
            this.helpLabel1.Name = "helpLabel1";
            this.helpLabel1.Size = new System.Drawing.Size(16, 16);
            this.helpLabel1.TabIndex = 3;
            // 
            // curatorGroupCH
            // 
            this.curatorGroupCH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curatorGroupCH.BackColor = System.Drawing.SystemColors.Window;
            this.curatorGroupCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curatorGroupCH.ChooseText = "";
            this.curatorGroupCH.Location = new System.Drawing.Point(12, 263);
            this.curatorGroupCH.Name = "curatorGroupCH";
            this.curatorGroupCH.Size = new System.Drawing.Size(395, 23);
            this.curatorGroupCH.TabIndex = 4;
            // 
            // helpLabel2
            // 
            this.helpLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel2.BackgroundImage")));
            this.helpLabel2.HelpText = "В данном поле необходимо указать полное ФИО преподавателя.\r\n\r\nДанная информация и" +
    "спользуется при построении отчетов.";
            this.helpLabel2.Location = new System.Drawing.Point(391, 201);
            this.helpLabel2.Name = "helpLabel2";
            this.helpLabel2.Size = new System.Drawing.Size(16, 16);
            this.helpLabel2.TabIndex = 7;
            // 
            // teacherNameTB
            // 
            this.teacherNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teacherNameTB.Location = new System.Drawing.Point(12, 219);
            this.teacherNameTB.Name = "teacherNameTB";
            this.teacherNameTB.Size = new System.Drawing.Size(395, 23);
            this.teacherNameTB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО преподавателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Группа куратора";
            // 
            // helpLabel3
            // 
            this.helpLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel3.BackgroundImage")));
            this.helpLabel3.HelpText = "В данном поле необходимо выбрать ту группу которую ведет куратор.";
            this.helpLabel3.Location = new System.Drawing.Point(391, 245);
            this.helpLabel3.Name = "helpLabel3";
            this.helpLabel3.Size = new System.Drawing.Size(16, 16);
            this.helpLabel3.TabIndex = 8;
            // 
            // organizationNameTB
            // 
            this.organizationNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationNameTB.Location = new System.Drawing.Point(12, 101);
            this.organizationNameTB.Multiline = true;
            this.organizationNameTB.Name = "organizationNameTB";
            this.organizationNameTB.Size = new System.Drawing.Size(395, 53);
            this.organizationNameTB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Название учебного заведения";
            // 
            // parentOrganisationNameTB
            // 
            this.parentOrganisationNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentOrganisationNameTB.Location = new System.Drawing.Point(12, 27);
            this.parentOrganisationNameTB.Multiline = true;
            this.parentOrganisationNameTB.Name = "parentOrganisationNameTB";
            this.parentOrganisationNameTB.Size = new System.Drawing.Size(395, 53);
            this.parentOrganisationNameTB.TabIndex = 10;
            this.parentOrganisationNameTB.Text = "\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Название вышестоящей организации";
            // 
            // helpLabel4
            // 
            this.helpLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel4.BackgroundImage")));
            this.helpLabel4.HelpText = "Здесь необходимо указать название учебного заведения.";
            this.helpLabel4.Location = new System.Drawing.Point(391, 83);
            this.helpLabel4.Name = "helpLabel4";
            this.helpLabel4.Size = new System.Drawing.Size(16, 16);
            this.helpLabel4.TabIndex = 4;
            // 
            // helpLabel5
            // 
            this.helpLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpLabel5.BackgroundImage")));
            this.helpLabel5.HelpText = "Здесь необходимо указать название вышестоящей организации.";
            this.helpLabel5.Location = new System.Drawing.Point(391, 9);
            this.helpLabel5.Name = "helpLabel5";
            this.helpLabel5.Size = new System.Drawing.Size(16, 16);
            this.helpLabel5.TabIndex = 5;
            // 
            // ConfigEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 340);
            this.Controls.Add(this.helpLabel5);
            this.Controls.Add(this.helpLabel4);
            this.Controls.Add(this.organizationNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parentOrganisationNameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.helpLabel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.helpLabel2);
            this.Controls.Add(this.teacherNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.curatorGroupCH);
            this.Controls.Add(this.helpLabel1);
            this.Controls.Add(this.curatorNameTB);
            this.Controls.Add(this.label1);
            this.Name = "ConfigEditForm";
            this.Text = "ConfigEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox curatorNameTB;
        private Common.HelpLabel helpLabel1;
        private Common.Chooser curatorGroupCH;
        private Common.HelpLabel helpLabel2;
        private System.Windows.Forms.TextBox teacherNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Common.HelpLabel helpLabel3;
        private System.Windows.Forms.TextBox organizationNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox parentOrganisationNameTB;
        private System.Windows.Forms.Label label5;
        private Common.HelpLabel helpLabel4;
        private Common.HelpLabel helpLabel5;
    }
}