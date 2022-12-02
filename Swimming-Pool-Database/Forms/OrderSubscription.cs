using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class OrderSubscription : Form
    {
        private readonly int _subscriptionId;
        private readonly int _clientId;
        private readonly Print _print = new Print();

        private OrderSubscription()
        {
            InitializeComponent();
        }

        public OrderSubscription(int subscriptionId, string subscriptionName, decimal price, int attendanceCount, 
            int dayCount, int clientId, string firstName, string lastName, string middleName, string preparationLevel) : this()
        {
            _subscriptionId = subscriptionId;
            _clientId = clientId;

            subscriptionNameTextBox.Text = subscriptionName;
            priceTextBox.Text = price + "₴";
            attendanceCountTextBox.Text = attendanceCount.ToString();
            startDateTextBox.Text = DateTime.Now.ToLongDateString();
            expiryDateTextBox.Text = DateTime.Now.AddDays(dayCount).ToLongDateString();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            middleNameTextBox.Text = middleName;
            preparationLevelTextBox.Text = preparationLevel;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                visitorCardsTableAdapter.Insert(
                    _subscriptionId,
                    _clientId,
                    DateTime.Parse(startDateTextBox.Text),
                    DateTime.Parse(expiryDateTextBox.Text),
                    int.Parse(attendanceCountTextBox.Text));
            }
            catch
            {
                MessageBox.Show(
                    "Неможливо оформити новий абонемент, так як поточний ще дійсний!",
                    "Ви вже маєте абонемент",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (MessageBox.Show(
                    "Оформлення абонемента успішне!\n" +
                    "На його основі створено картку відвідувача.\n" +
                    "Бажаєте роздрукувати її?",
                    "Оформлення успішне",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.No)
            {
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            _print.PrintVisitorCard(e,
                subscriptionNameTextBox.Text,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                middleNameTextBox.Text,
                preparationLevelTextBox.Text,
                Convert.ToDateTime(startDateTextBox.Text),
                Convert.ToDateTime(expiryDateTextBox.Text));
        }
    }
}
