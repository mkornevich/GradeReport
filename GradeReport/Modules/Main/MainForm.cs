
using GradeReport.Modules.Group;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Modules.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var groupForm = new GroupListForm();
            groupForm.MdiParent = this;
            groupForm.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var groupForm = new GroupListForm();
            groupForm.MdiParent = this;
            groupForm.Show();
        }
    }
}
