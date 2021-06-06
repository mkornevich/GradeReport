using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Notify
{
    public class Notification
    {
        public NotificationType Type { get; set; }

        public string Message { get; set; }

        [Browsable(false)]
        public string Description { get; set; }

        public Notification(NotificationType type, string message, string description = null)
        {
            Type = type;
            Message = message;
            Description = description;
        }
    }
}
