using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Core.Listing
{
    public partial class ListForm : Form
    {
        private ListAdapter _adapter;

        public ListAdapter Adapter
        {
            get => _adapter;
            set
            {
                if (_adapter != null) _adapter.Form = null;
                _adapter = value;
                _adapter.Form = this;
            }
        }

        public ListForm()
        {
            InitializeComponent();
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _adapter.CellContentClick(sender, e);
        }
    }
}
