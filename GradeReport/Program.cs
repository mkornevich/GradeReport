using GradeReport.Main;
using System;
using System.Windows.Forms;

namespace GradeReport
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            App.Init();
            Application.Run(new MainForm());
        }
    }
}
