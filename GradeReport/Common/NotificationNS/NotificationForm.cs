using GradeReport.Common.ActionNS;
using GradeReport.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeReport.Common.NotificationNS
{
    public partial class NotificationForm : ActionForm
    {
        private Notification[] _notifications;

        public List<Notification> Notifications { 
            set
            {
                _notifications = value.ToArray();
                notificationDGV.DataSource = _notifications;
            }
        }

        public NotificationForm()
        {
            InitializeComponent();
            ActionStrip.PositiveAction.Text = "Продолжить";
        }

        private void notificationDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (notificationDGV.SelectedRows.Count > 0)
            {
                int row = notificationDGV.SelectedRows[0].Index;
                descriptionTB.Text = BuildFullDescription(_notifications[row]);
            }
        }

        private string BuildFullDescription(Notification notification)
        {
            string type = "Ошибка";
            if (notification.Type == NotificationType.Warning) type = "Предупреждение";
            if (notification.Type == NotificationType.Info) type = "Информация";

            return type + ": " + notification.Message + "\r\n\r\n" + notification.Description;
        }

        private void notificationDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (notificationDGV.Columns[e.ColumnIndex].DataPropertyName == "Type")
            {
                switch (_notifications[e.RowIndex].Type)
                {
                    case NotificationType.Error:
                        e.Value = Resources.error_16;
                        break;
                    case NotificationType.Warning:
                        e.Value = Resources.warning_16;
                        break;
                    case NotificationType.Info:
                        e.Value = Resources.info_16;
                        break;
                }
            }
        }
    }
}
