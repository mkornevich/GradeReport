using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Common
{
    public class Chooser : Panel
    {
        private Button _button = new Button()
        {
            Text = "...",
            Dock = DockStyle.Right,
            Width = 26,
            UseVisualStyleBackColor = true,
        };

        private TextBox _textBox = new TextBox()
        {
            BackColor = SystemColors.Window,
            ReadOnly = true,
            BorderStyle = BorderStyle.None,
            Anchor = AnchorStyles.Left | AnchorStyles.Right,
            Size = new Size(169, 16),
            Location = new Point(2, 2),
        };

        public string ChooseText
        {
            get => _textBox.Text;
            set => _textBox.Text = value;
        }

        public event EventHandler ChooseClick
        {
            add => _button.Click += value;
            remove => _button.Click -= value;
        }

        public Chooser()
        {
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.FixedSingle;
            Size = new Size(200, 23);

            Controls.Add(_button);
            Controls.Add(_textBox);

            EnabledChanged += (s, e) => BackColor = (Enabled ? SystemColors.Window : SystemColors.Control);
        }
    }
}
