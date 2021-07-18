using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Common.ActionNS
{
    public class ActionButton : Button
    {
        public ActionButton()
        {
            Padding = new Padding(2);
            Margin = new Padding(5, 0, 0, 0);
            UseVisualStyleBackColor = true;
            AutoSize = true;
        }
    }
}
