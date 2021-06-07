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

namespace GradeReport.Core.Notify
{
    public partial class NotificationForm : Form
    {
        private Notification[] _notifications;

        private DialogResult _dialogResult = DialogResult.None;

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

            actionStrip.OkAction.Click += OkAct;
            actionStrip.OkAction.Text = "Продолжить";

            actionStrip.CancelAction.Click += CancelAct;
        }

        private void CancelAct(object sender, EventArgs e)
        {
            _dialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkAct(object sender, EventArgs e)
        {
            _dialogResult = DialogResult.OK;
            Close();
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

        public DialogResult ShowForResult()
        {
            actionStrip.Visible = true;
            ShowDialog();
            actionStrip.Visible = false;
            return _dialogResult;
        }
    }
}
