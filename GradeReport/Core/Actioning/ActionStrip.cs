using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Actioning
{
    public class ActionStrip : FlowLayoutPanel
    {
        public ActionButton OkAction { get; private set; }

        public ActionButton CancelAction { get; private set; }

        public ActionStrip()
        {
            FlowDirection = FlowDirection.RightToLeft;
            Dock = DockStyle.Bottom;
            Padding = new Padding(5, 5, 2, 5);
            Height = 40;
            BackColor = Color.FromArgb(232, 232, 232);

            OkAction = AddAction("Применить");
            CancelAction = AddAction("Отмена");
        }

        public ActionButton AddAction(string text, EventHandler onClick = null)
        {
            var btn = new ActionButton() { Text = text };
            if (onClick != null) btn.Click += onClick;
            Controls.Add(btn);
            return btn;
        }
    }
}
