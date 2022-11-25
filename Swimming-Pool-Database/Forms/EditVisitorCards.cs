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
            _isEdit = true;
            _id = id;

            subscriptionComboBox.SelectedValue = subscriptionId;
            clientComboBox.SelectedValue = clientId;
            startDateTimePicker.Value = startDate;
            expiryDateTimePicker.Value = expiryDate;
            attendanceLeftCountTextBox.Text = attendanceLeftCount.ToString();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var dataTable = new swimmingpoolDataSet.VisitorCardsDataTable();
            var cardId = visitorCardsTableAdapter.FillCurrentlyActiveCard(dataTable,
                Convert.ToInt32(((DataRowView)clientComboBox.SelectedItem)["client_id"]));

            if (cardId != 0)
            {
                MessageBox.Show(
                    "Неможливо додати нову картку клієнту, так як поточна ще дійсна!",
                    "Клієнт вже має дійсну картку",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        visitorCardsTableAdapter.UpdateQuery(
                            Convert.ToInt32(subscriptionComboBox.SelectedValue),
                            Convert.ToInt32(clientComboBox.SelectedValue),
                            startDateTimePicker.Value,
                            expiryDateTimePicker.Value,
                            Convert.ToInt32(attendanceLeftCountTextBox.Text),
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
                            Convert.ToInt32(attendanceLeftCountTextBox.Text))))
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
            attendanceLeftCountTextBox.Text = Convert.ToInt32(((DataRowView)subscriptionsBindingSource.Current)["attendance_count"]) + "";
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (subscriptionsBindingSource.Current is null)
            {
                return;
            }

            expiryDateTimePicker.Value =
                startDateTimePicker.Value.AddDays(
                    Convert.ToInt32(((DataRowView)subscriptionsBindingSource.Current)["day_count"]));
        }

        private void ExpiryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (subscriptionsBindingSource.Current is null)
            {
                return;
            }

            startDateTimePicker.Value =
                expiryDateTimePicker.Value.AddDays(
                    -Convert.ToInt32(((DataRowView)subscriptionsBindingSource.Current)["day_count"]));
        }
    }
}