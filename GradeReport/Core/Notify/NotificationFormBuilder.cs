using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Core.Notify
{
    public class NotificationFormBuilder
    {
        private List<Notification> _notifications = new List<Notification>();

        private string _text;

        public int ErrorCount => _notifications.Count(n => n.Type == NotificationType.Error);

        public int WarningCount => _notifications.Count(n => n.Type == NotificationType.Warning);

        public int InfoCount => _notifications.Count(n => n.Type == NotificationType.Info);

        public int MessageCount => _notifications.Count;

        public NotificationFormBuilder Clear()
        {
            _notifications.Clear();
            return this;
        }

        public NotificationForm BuildForm()
        {
            var form = new NotificationForm();
            form.Notifications = _notifications;
            if (_text != null) form.Text = _text;
            return form;
        }

        public NotificationFormBuilder SetText(string text)
        {
            _text = text;
            return this;
        }

        public NotificationFormBuilder Add(NotificationType type, string message, string description = null)
        {
            _notifications.Add(new Notification(type, message, description));
            return this;
        }

        public NotificationFormBuilder Error(string message, string description = null)
        {
            return Add(NotificationType.Error, message, description);
        }

        public NotificationFormBuilder Warning(string message, string description = null)
        {
            return Add(NotificationType.Warning, message, description);
        }

        public NotificationFormBuilder Info(string message, string description = null)
        {
            return Add(NotificationType.Info, message, description);
        }

        public NotificationFormBuilder ErrorIf(bool condition, string message, string description = null)
        {
            return condition ? Error(message, description) : this;
        }

        public NotificationFormBuilder WarningIf(bool condition, string message, string description = null)
        {
            return condition ? Warning(message, description) : this;
        }

        public NotificationFormBuilder InfoIf(bool condition, string message, string description = null)
        {
            return condition ? Info(message, description) : this;
        }
    }
}
