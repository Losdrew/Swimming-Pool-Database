using CommunityToolkit.WinUI.Notifications;
using Swimming_Pool_Database.Forms;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Swimming_Pool_Database
{
    public static class Automation
    {
        private static string _senderEmail;

        private static readonly SmtpClient SmtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            EnableSsl = true
        };

        public static void SetClientTimeOutNotification(int delayInMilliseconds, string clientFullName, int poolId,
            int swimLaneId, IEnumerable<string> instructorEmails)
        {
            if (SmtpClient.Credentials is null)
            {
                GetSenderEmailCredentials();
            }

            Task.Delay(delayInMilliseconds).ContinueWith(t =>
                SendWindowsNotification(clientFullName, poolId, swimLaneId));

            Task.Delay(delayInMilliseconds).ContinueWith(t =>
                SendEmailMessage(clientFullName, swimLaneId, instructorEmails));
        }

        private static void GetSenderEmailCredentials()
        {
            var enterEmailForm = new EnterEmailForm();
            enterEmailForm.ShowDialog();
            _senderEmail = enterEmailForm.email;
            SmtpClient.Credentials = new NetworkCredential(_senderEmail, enterEmailForm.password);
        }

        private static void SendWindowsNotification(string clientFullName, int poolId, int swimLaneId)
        {
            new ToastContentBuilder()
                .AddText("Час тренування клієнта сплив!")
                .AddText("Час тренування клієнта " + clientFullName + ", що знаходиться у басейні " + poolId +
                         " на доріжці " + swimLaneId + " сплив.\n" +
                         "Повідомлення розіслано інструктору(-ам), що чергують на вказаному басейні.")
                .Show();
        }

        private static void SendEmailMessage(string clientFullName, int swimLaneId, IEnumerable<string> instructorEmails)
        {
            SmtpClient.Send(_senderEmail, string.Join(", ", instructorEmails),
                "Тренування клієнта " + clientFullName + " закінчилося!",
                "Повідомте клієнту " + clientFullName + " на доріжці " + swimLaneId + " про сплив часу тренування.");
        }
    }
}
