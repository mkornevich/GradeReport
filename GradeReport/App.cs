using GradeReport.ProjectNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport
{
    public static class App
    {
        public static ProjectContainer ProjectContainer { get; private set; } = new ProjectContainer();

        public static string AppDataPath => AppDomain.CurrentDomain.BaseDirectory + "\\AppData";

        public static void Init()
        {

        }
    }
}
