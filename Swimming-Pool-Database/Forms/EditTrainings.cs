using System;
using System.Data;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditTrainings : Form
    {
        private const int TrainingDuration = 45;

        private readonly int _id;
        private readonly bool _isEdit;

        public EditTrainings()
        {
            InitializeComponent();
            startDateTimePicker.Value = DateTime.Now;
            endDateTimePicker.Value = DateTime.Now.AddMinutes(TrainingDuration);
        }

        public EditTrainings(int id, int cardId, int clientId, int swimLaneId, DateTime startDateTime,
            DateTime endDateTime, int lockerId) : this()
        {
            _isEdit = true;
            _id = id;

            clientComboBox.SelectedValue = clientId;
            visitorCardsComboBox.SelectedValue = cardId;
            swimLanesComboBox.SelectedValue = swimLaneId;
            startDateTimePicker.Value = startDateTime;
            endDateTimePicker.Value = endDateTime;
            lockerIdNumericUpDown.Value = lockerId;
        }

        private void EditTrainings_Load(object sender, EventArgs e)
        {
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
            visitorCardsTableAdapter.Fill(swimmingpoolDataSet.VisitorCards);
            swimLanesTableAdapter.Fill(swimmingpoolDataSet.SwimLanes);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        trainingsTableAdapter.UpdateQuery(
                            Convert.ToInt32(visitorCardsComboBox.SelectedValue),
                            Convert.ToInt32(swimLanesComboBox.SelectedValue),
                            startDateTimePicker.Value,
                            endDateTimePicker.Value,
                            Convert.ToInt32(lockerIdNumericUpDown.Value),
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!CommonFunctions.TryQuery(() =>
                        trainingsTableAdapter.Insert(
                            Convert.ToInt32(visitorCardsComboBox.SelectedValue),
                            Convert.ToInt32(swimLanesComboBox.SelectedValue),
                            startDateTimePicker.Value,
                            endDateTimePicker.Value,
                            Convert.ToInt32(lockerIdNumericUpDown.Value))))
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

        private void ClientsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (clientsBindingSource.Current is null)
            {
                return;
            }

            visitorCardsBindingSource.RemoveFilter();
            visitorCardsBindingSource.Filter = "client_id = " + Convert.ToInt32(clientComboBox.SelectedValue);
        }

        private void VisitorCardsComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var visitorCardRow = (DataRowView)e.ListItem;
            var dataTable = new swimmingpoolDataSet.SubscriptionsDataTable();
            subscriptionsTableAdapter.FillBy(dataTable, Convert.ToInt32(visitorCardRow["subscription_id"]));
            var subscriptionsRow = dataTable.Rows[0].ItemArray;
            e.Value = subscriptionsRow[1] + ", " +
                      Convert.ToDateTime(visitorCardRow["start_date"]).ToShortDateString() + "-" +
                      Convert.ToDateTime(visitorCardRow["expiry_date"]).ToShortDateString() +
                      ", Відв. зал.: " + visitorCardRow["attendance_left_count"];

            var valueWidth = TextRenderer.MeasureText(e.Value.ToString(), visitorCardsComboBox.Font).Width;
            if (valueWidth > visitorCardsComboBox.DropDownWidth)
            {
                visitorCardsComboBox.DropDownWidth = valueWidth;
            }
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!startDateTimePicker.Focused)
            {
                return;
            }

            endDateTimePicker.Value = startDateTimePicker.Value.AddMinutes(TrainingDuration);
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!endDateTimePicker.Focused)
            {
                return;
            }

            startDateTimePicker.Value = endDateTimePicker.Value.AddMinutes(-TrainingDuration);
        }
    }
}
