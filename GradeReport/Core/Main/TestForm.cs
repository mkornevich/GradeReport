using GradeReport.Core.Notify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Main
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NotificationFormBuilder()
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Error("Error", "descr")
                .Warning("Error", "descr")
                .Warning("Error", "descr")
                .Warning("Error", "descr")
                .Warning("Error", "descr")
                .Warning("Error", "descr")
                .BuildForm()
                .ShowDialog();
        }
    }
}
