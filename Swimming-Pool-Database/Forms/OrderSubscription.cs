using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class OrderSubscription : Form
    {
        private readonly int _subscriptionId;
        private readonly int _clientId;

        private OrderSubscription()
        {
            InitializeComponent();
        }

        public OrderSubscription(int subscriptionId, string subscriptionName, decimal price, int attendanceCount, 
            int dayCount, int clientId, string firstName, string lastName, string middleName) : this()
        {
            _subscriptionId = subscriptionId;
            _clientId = clientId;

            subscriptionNameTextBox.Text = subscriptionName;
            priceTextBox.Text = price + "₴";
            attendanceCountTextBox.Text = attendanceCount.ToString();
            startDateTextBox.Text = DateTime.Now.ToShortDateString();
            expiryDateTextBox.Text = DateTime.Now.AddDays(dayCount).ToShortDateString();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            middleNameTextBox.Text = middleName;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.TryQuery(() => 
                    visitorCardsTableAdapter.Insert(
                        _subscriptionId,
                        _clientId,
                        DateTime.Parse(startDateTextBox.Text),
                        DateTime.Parse(expiryDateTextBox.Text),
                        int.Parse(attendanceCountTextBox.Text))))
            {
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
                //TODO - Звіт з карткою відвідувача
            }

            Close();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
