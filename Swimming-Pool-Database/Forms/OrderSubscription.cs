using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class OrderSubscription : Form
    {
        private readonly int _subscriptionId;
        private readonly int _clientId;
        private readonly int _dayCount;

        private OrderSubscription()
        {
            InitializeComponent();
        }

        public OrderSubscription(int subscriptionId, string subscriptionName, decimal price, int attendanceCount, 
            int dayCount, int clientId, string firstName, string lastName, string middleName) : this()
        {
            _subscriptionId = subscriptionId;
            _clientId = clientId;
            _dayCount = dayCount;

            subscriptionNameTextBox.Text = subscriptionName;
            priceTextBox.Text = price + "₴";
            attendanceCountTextBox.Text = attendanceCount.ToString();
            startDateTimePicker.Value = DateTime.Now;
            expiryDateTimePicker.Value = DateTime.Now;
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            middleNameTextBox.Text = middleName;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                visitorCardsTableAdapter.Insert(
                    _subscriptionId,
                    _clientId,
                    startDateTimePicker.Value,
                    expiryDateTimePicker.Value,
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
                //TODO - Звіт з карткою відвідувача
            }

            Close();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDateTimePicker.Focused)
            {
                expiryDateTimePicker.Value = startDateTimePicker.Value.AddDays(_dayCount);
            }
        }

        private void ExpiryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (expiryDateTimePicker.Focused)
            {
                startDateTimePicker.Value = expiryDateTimePicker.Value.AddDays(-_dayCount);
            }
        }
    }
}
