using GradeReport.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Common
{
    public class HelpLabel : ContainerControl
    {
        [Bindable(false)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string Text { get; set; }

        [Category("Appearance")]
        [Editor("System.ComponentModel.Design.MultilineStringEditor", typeof(UITypeEditor))]
        public string HelpText { get; set; }

        public HelpLabel()
        {
            Size = new Size(16, 16);
            BackgroundImage = Resources.question_16;
            Click += ShowHelpAct;
        }

        private void ShowHelpAct(object sender, EventArgs e)
        {
            var helpText = new TextBox()
            {
                Multiline = true,
                ReadOnly = true,
                Text = HelpText,
                Dock = DockStyle.Fill,
                BackColor = SystemColors.Window,
                TabStop = false,
                ScrollBars = ScrollBars.Vertical,
            };

            var form = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = true,
                TopMost = true,
            };
            form.Deactivate += (s, e) => form.Close();
            form.Controls.Add(helpText);
            form.Show();
            form.Top = ParentForm.Top + Top + 30;
            form.Left = ParentForm.Left + Left + 30;
        }
    }
}
