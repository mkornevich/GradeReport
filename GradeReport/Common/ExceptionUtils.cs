using GradeReport.Common.NotificationNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Common
{
    public class ExceptionUtils
    {
        public static void Show(Exception e, string message)
        {
            var notes = new NotificationFormBuilder();
            notes.Error(message, string.Format(
                "Название исключения:\n{0}\n\nСообщение:\n{1}\n\nСтек вызова:\n{2}", 
                e.GetType().Name, e.Message, e.StackTrace));
            notes.BuildForm().Show();
        }
    }
}
