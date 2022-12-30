using System;
using System.Data;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditVisitorCards : Form
    {
        private readonly int _id;
        private readonly bool _isEdit;

        public EditVisitorCards()
        {
            InitializeComponent();
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
            subscriptionsTableAdapter.Fill(swimmingpoolDataSet.Subscriptions);
        }

        public EditVisitorCards(int id, int subscriptionId, int clientId, DateTime startDate,
            DateTime expiryDate, int attendanceLeftCount) : this()
        {
            Text = "Редагування картки відвідувача";
            _isEdit = true;
            _id = id;

            subscriptionComboBox.SelectedValue = subscriptionId;
            clientComboBox.SelectedValue = clientId;
            startDateTimePicker.Value = startDate;
            expiryDateTimePicker.Value = expiryDate;
            attendanceLeftCountNumericUpDown.Value = attendanceLeftCount;
            attendanceLeftCountNumericUpDown.Maximum =
                Convert.ToInt32(((DataRowView)subscriptionsBindingSource.Current)["attendance_count"]);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        visitorCardsTableAdapter.UpdateQuery(
                            Convert.ToInt32(subscriptionComboBox.SelectedValue),
                            Convert.ToInt32(clientComboBox.SelectedValue),
                            startDateTimePicker.Value,
                            expiryDateTimePicker.Value,
                            Convert.ToInt32(attendanceLeftCountNumericUpDown.Value),
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!CommonFunctions.TryQuery(() =>
                        visitorCardsTableAdapter.Insert(
                            Convert.ToInt32(subscriptionComboBox.SelectedValue),
                            Convert.ToInt32(clientComboBox.SelectedValue),
                            startDateTimePicker.Value,
                            expiryDateTimePicker.Value,
                            Convert.ToInt32(attendanceLeftCountNumericUpDown.Value))))
                {
                    return;
                }
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var row = (DataRowView)e.ListItem;
            e.Value = row["first_name"] + " " + row["last_name"] + " " + row["middle_name"];
        }

        private void SubscriptionsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (subscriptionsBindingSource.Current is null)
            {
                return;
            }

            expiryDateTimePicker.Value =
                startDateTimePicker.Value.AddDays(
                    Convert.ToInt32(((DataRowView)subscriptionsBindingSource.Current)["day_count"]));
            attendanceLeftCountNumericUpDown.Maximum =
                Convert.ToInt32(((DataRowView)subscriptionsBindingSource.Current)["attendance_count"]);
            attendanceLeftCountNumericUpDown.Value = attendanceLeftCountNumericUpDown.Maximum;
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!startDateTimePicker.Focused)
            {
                return;
            }

            expiryDateTimePicker.Value =
                startDateTimePicker.Value.AddDays(
                    Convert.ToInt32(((DataRowView)subscriptionsBindingSource.Current)["day_count"]));
        }
    }
}