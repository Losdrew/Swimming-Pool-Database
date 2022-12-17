using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class AdminMainForm : Form
    {
        private readonly Print _print = new Print();

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillTableAdapters();

            var minimalDateOfBirth = clientsTableAdapter.GetMinimalDateOfBirth();
            if (minimalDateOfBirth != null)
            {
                filterFromDateTimePicker.Value = minimalDateOfBirth.Value;
            }
        }

        private void FillTableAdapters()
        {
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
            subscriptionsTableAdapter.Fill(swimmingpoolDataSet.Subscriptions);
            visitorCardsTableAdapter.Fill(swimmingpoolDataSet.VisitorCards);
            trainingsTableAdapter.Fill(swimmingpoolDataSet.Trainings);
            swimLanesTableAdapter.Fill(swimmingpoolDataSet.SwimLanes);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage)
            {
                case TabPage tabPage when tabPage.Equals(clientsTabPage):
                    clientsDataGridView.Columns[0].Visible = false;
                    break;
                case TabPage tabPage when tabPage.Equals(subscriptionsTabPage):
                    subscriptionsDataGridView.Columns[0].Visible = false;
                    break;
                case TabPage tabPage when tabPage.Equals(visitorCardsTabPage):
                    visitorCardsDataGridView.Columns[0].Visible = false;
                    break;
                case TabPage tabPage when tabPage.Equals(trainingsTabPage):
                    trainingsDataGridView.Columns[0].Visible = false;
                    break;
            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            new EditClients().ShowDialog();
            FillAdaptersAndAcceptChanges();
        }

        private void EditClientButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(clientsDataGridView))
            {
                return;
            }

            var dataTable = new swimmingpoolDataSet.ClientsDataTable();

            if (!CommonFunctions.TryQuery(() =>
                    clientsTableAdapter.FillBy(dataTable,
                        Convert.ToInt32(((DataRowView)clientsDataGridView.SelectedRows[0].DataBoundItem).Row[0]))))
            {
                return;
            }

            var row = dataTable.Rows[0].ItemArray;
            new EditClients(
                Convert.ToInt32(row[0]),
                row[1].ToString(),
                row[2].ToString(),
                row[3].ToString(),
                Convert.ToDateTime(row[4]),
                row[5].ToString(),
                row[6].ToString(),
                row[7].ToString(),
                row[8].ToString(),
                row[9].ToString()).ShowDialog();

            FillAdaptersAndAcceptChanges();
        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(clientsDataGridView) || !IsSureToDelete())
            {
                return;
            }

            if (!CommonFunctions.TryQuery(() =>
                    clientsTableAdapter.DeleteQuery(
                        Convert.ToInt32(((DataRowView)clientsDataGridView.SelectedRows[0].DataBoundItem).Row[0]))))
            {
                return;
            }

            FillAdaptersAndAcceptChanges();
        }

        private void AddSubscriptionButton_Click(object sender, EventArgs e)
        {
            new EditSubscriptions().ShowDialog();
            FillAdaptersAndAcceptChanges();
        }

        private void EditSubscriptionButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(subscriptionsDataGridView))
            {
                return;
            }

            var dataTable = new swimmingpoolDataSet.SubscriptionsDataTable();

            if (!CommonFunctions.TryQuery(() =>
                    subscriptionsTableAdapter.FillBy(dataTable,
                        Convert.ToInt32(((DataRowView)subscriptionsDataGridView.SelectedRows[0].DataBoundItem).Row[0]))))
            {
                return;
            }

            var row = dataTable.Rows[0].ItemArray;
            new EditSubscriptions(
                Convert.ToInt32(row[0]),
                row[1].ToString(),
                Convert.ToDecimal(row[2]),
                Convert.ToInt32(row[3]),
                Convert.ToInt32(row[4])).ShowDialog();

            FillAdaptersAndAcceptChanges();
        }

        private void DeleteSubscriptionButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(subscriptionsDataGridView) || !IsSureToDelete())
            {
                return;
            }

            if (!CommonFunctions.TryQuery(() =>
                    subscriptionsTableAdapter.DeleteQuery(
                        Convert.ToInt32(((DataRowView)subscriptionsDataGridView.SelectedRows[0].DataBoundItem).Row[0]))))
            {
                return;
            }

            FillAdaptersAndAcceptChanges();
        }

        private void AddVisitorCardButton_Click(object sender, EventArgs e)
        {
            new EditVisitorCards().ShowDialog();
            FillAdaptersAndAcceptChanges();
        }

        private void EditVisitorCardButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(visitorCardsDataGridView))
            {
                return;
            }

            var dataTable = new swimmingpoolDataSet.VisitorCardsDataTable();

            if (!CommonFunctions.TryQuery(() =>
                    visitorCardsTableAdapter.FillBy(dataTable,
                        Convert.ToInt32(((DataRowView)visitorCardsDataGridView.SelectedRows[0].DataBoundItem).Row[0]))))
            {
                return;
            }

            var row = dataTable.Rows[0].ItemArray;
            new EditVisitorCards(
                Convert.ToInt32(row[0]),
                Convert.ToInt32(row[1]),
                Convert.ToInt32(row[2]),
                Convert.ToDateTime(row[3]),
                Convert.ToDateTime(row[4]),
                Convert.ToInt32(row[5])).ShowDialog();

            FillAdaptersAndAcceptChanges();
        }

        private void DeleteVisitorCardButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(visitorCardsDataGridView) || !IsSureToDelete())
            {
                return;
            }

            if (!CommonFunctions.TryQuery(() =>
                    visitorCardsTableAdapter.DeleteQuery(
                        Convert.ToInt32(((DataRowView)visitorCardsDataGridView.SelectedRows[0].DataBoundItem).Row[0]))))
            {
                return;
            }

            FillAdaptersAndAcceptChanges();
        }

        private void AddTrainingButton_Click(object sender, EventArgs e)
        {
            new EditTrainings().ShowDialog();
            FillAdaptersAndAcceptChanges();
        }

        private void EditTrainingButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(trainingsDataGridView))
            {
                return;
            }

            var trainingsDataTable = new swimmingpoolDataSet.TrainingsDataTable();
            var visitorCardsDataTable = new swimmingpoolDataSet.VisitorCardsDataTable();

            if (!CommonFunctions.TryQuery(() =>
                    trainingsTableAdapter.FillBy(trainingsDataTable,
                        Convert.ToInt32(((DataRowView)trainingsDataGridView.SelectedRows[0].DataBoundItem).Row[0])))
                || !CommonFunctions.TryQuery(() =>
                    visitorCardsTableAdapter.FillBy(visitorCardsDataTable,
                        Convert.ToInt32(((DataRowView)trainingsDataGridView.SelectedRows[0].DataBoundItem).Row[1]))))
            {
                return;
            }

            var trainingsRow = trainingsDataTable.Rows[0].ItemArray;
            var visitorCardsRow = visitorCardsDataTable.Rows[0].ItemArray;
            new EditTrainings(
                Convert.ToInt32(trainingsRow[0]),
                Convert.ToInt32(trainingsRow[1]),
                Convert.ToInt32(visitorCardsRow[2]),
                Convert.ToInt32(trainingsRow[2]),
                Convert.ToDateTime(trainingsRow[3]),
                Convert.ToDateTime(trainingsRow[4]),
                Convert.ToInt32(trainingsRow[5])).ShowDialog();

            FillAdaptersAndAcceptChanges();
        }

        private void DeleteTrainingButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(trainingsDataGridView) || !IsSureToDelete())
            {
                return;
            }

            if (!CommonFunctions.TryQuery(() =>
                    trainingsTableAdapter.DeleteQuery(
                        Convert.ToInt32(((DataRowView)trainingsDataGridView.SelectedRows[0].DataBoundItem).Row[0]))))
            {
                return;
            }

            FillAdaptersAndAcceptChanges();
        }

        private void FillAdaptersAndAcceptChanges()
        {
            FillTableAdapters();
            swimmingpoolDataSet.AcceptChanges();
        }

        private bool IsSureToDelete()
        {
            return MessageBox.Show("Ви впевнені, що хочете видалити запис?",
                "Видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void SubscriptionsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == subscriptionsDataGridView.Columns["price"].Index)
            {
                e.Value = $"{e.Value:#.##'₴'}";
                e.FormattingApplied = true;
            }

            if (e.ColumnIndex == subscriptionsDataGridView.Columns["daycount"].Index)
            {
                e.Value = $"{e.Value:## 'днів'}";
                e.FormattingApplied = true;
            }
        }

        private void TrainingsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != trainingsDataGridView.Columns["cardIdColumn"].Index)
            {
                return;
            }

            var dataTable = new swimmingpoolDataSet.ClientsDataTable();
            clientsTableAdapter.FillByTrainingCardId(dataTable, Convert.ToInt32(e.Value));
            var row = dataTable.Rows[0].ItemArray;
            e.Value = row[1] + " " + row[2] + " " + row[3];
            e.FormattingApplied = true;
        }

        private void SetClientsFiltering(object sender, EventArgs e)
        {
            clientsBindingSource.RemoveFilter();
            SetClientsSearch();
            SetClientsFilters();
        }

        private void ClearClientFilteringButton_Click(object sender, EventArgs e)
        {
            clientsBindingSource.RemoveFilter();
        }

        private void SetClientsSearch()
        {
            SetClientsFilter(true,
                $"first_name LIKE '%{firstNameTextBox.Text}%' " +
                $"AND last_name LIKE '%{lastNameTextBox.Text}%' " +
                $"AND middle_name LIKE '%{middleNameTextBox.Text}%'");
        }

        private void SetClientsFilters()
        {
            SetClientsFilter(filterDateCheckBox.Checked,
                $"date_of_birth >= '{filterFromDateTimePicker.Value:yyyy-MM-dd}' " +
                $"AND date_of_birth < '{filterToDateTimePicker.Value:yyyy-MM-dd}'");

            if (maleRadioButton.Checked || femaleRadioButton.Checked)
            {
                var sex = (maleRadioButton.Checked && !femaleRadioButton.Checked) ? "Чоловіча" : "Жіноча";
                SetClientsFilter(filterSexCheckBox.Checked, "sex LIKE '" + sex + "'");
            }
            
            if (beginnerRadioButton.Checked || amateurRadioButton.Checked || sportsmanRadioButton.Checked)
            {
                var preparationLevel = "";
                switch (beginnerRadioButton.Checked)
                {
                    case true when !amateurRadioButton.Checked && !sportsmanRadioButton.Checked:
                        preparationLevel = "Початківець";
                        break;
                    case false when amateurRadioButton.Checked && !sportsmanRadioButton.Checked:
                        preparationLevel = "Любитель";
                        break;
                    case false when !amateurRadioButton.Checked && sportsmanRadioButton.Checked:
                        preparationLevel = "Спортсмен";
                        break;
                }
                SetClientsFilter(filterPreparationLevelCheckBox.Checked,
                    "preparation_level LIKE '" + preparationLevel + "'");
            }
        }

        private void SetClientsFilter(bool condition, string filterString)
        {
            if (condition)
            {
                clientsBindingSource.Filter = (string.IsNullOrEmpty(clientsBindingSource.Filter))
                    ? filterString
                    : clientsBindingSource.Filter + " AND " + filterString;
            }
        }

        private void SubscriptionsSearchButton_Click(object sender, EventArgs e)
        {
            subscriptionsBindingSource.Filter = "name LIKE '%" + subscriptionNameTextBox.Text + "%'";
        }

        private void SubscriptionsSortButton_Click(object sender, EventArgs e)
        {
            subscriptionsBindingSource.RemoveSort();

            if (priceCheapestRadioButton.Checked || priceExpensiveRadioButton.Checked)
            {
                var sort = (priceCheapestRadioButton.Checked && !priceExpensiveRadioButton.Checked) ? "ASC" : "DESC";
                SetSubscriptionsSort(sortByPriceCheckBox.Checked, "price " + sort);
            }

            if (attendanceCountMoreRadioButton.Checked || attendanceCountLessRadioButton.Checked)
            {
                var sort = (attendanceCountMoreRadioButton.Checked && !attendanceCountLessRadioButton.Checked) ? "DESC" : "ASC";
                SetSubscriptionsSort(sortByAttendanceCountCheckBox.Checked, "attendance_count " + sort);
            }

            if (dayCountMoreRadioButton.Checked || dayCountLessRadioButton.Checked)
            {
                var sort = (dayCountMoreRadioButton.Checked && !dayCountLessRadioButton.Checked) ? "DESC" : "ASC";
                SetSubscriptionsSort(sortByDayCountCheckBox.Checked, "day_count " + sort);
            }
        }

        private void SetSubscriptionsSort(bool condition, string sortString)
        {
            if (condition)
            {
                subscriptionsBindingSource.Sort = (string.IsNullOrEmpty(subscriptionsBindingSource.Sort))
                    ? sortString
                    : subscriptionsBindingSource.Sort + ", " + sortString;
            }
        }

        private void TrainingsClientComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var row = (DataRowView)e.ListItem;
            e.Value = row["first_name"] + " " + row["last_name"] + " " + row["middle_name"];
        }

        private void FilterTrainingsButton_Click(object sender, EventArgs e)
        {
            trainingsBindingSource.RemoveFilter();

            if (!filterClientCheckBox.Checked)
            {
                return;
            }

            var dataTable = new swimmingpoolDataSet.VisitorCardsDataTable();
            visitorCardsTableAdapter.FillByClientId(dataTable, Convert.ToInt32(trainingsClientComboBox.SelectedValue));

            if (dataTable.Rows.Count == 0)
            {
                trainingsBindingSource.Filter += "card_id = -1";
            }

            for (var i = 0; i < dataTable.Rows.Count; i++)
            {
                if (i == 0)
                {
                    trainingsBindingSource.Filter = "card_id = " + dataTable.Rows[i].ItemArray[0];
                }
                else
                {
                    trainingsBindingSource.Filter += " OR card_id = " + dataTable.Rows[i].ItemArray[0];
                }
            }
        }

        private void PrintVisitorCardButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(visitorCardsDataGridView))
            {
                return;
            }

            printDialog.Document = printVisitorCard;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printVisitorCard.Print();
            }
        }

        private void PrintVisitorCard_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var subscriptionsDataTable = new swimmingpoolDataSet.SubscriptionsDataTable();
            var clientsDataTable = new swimmingpoolDataSet.ClientsDataTable();

            var selectedRowData = (DataRowView)visitorCardsDataGridView.SelectedRows[0].DataBoundItem;

            if (!CommonFunctions.TryQuery(() =>
                    subscriptionsTableAdapter.FillBy(subscriptionsDataTable,
                        Convert.ToInt32(selectedRowData.Row[1]))) 
                || !CommonFunctions.TryQuery(() =>
                    clientsTableAdapter.FillBy(clientsDataTable,
                        Convert.ToInt32(selectedRowData.Row[2]))))
            {
                return;
            }

            var subscriptionsRow = subscriptionsDataTable.Rows[0].ItemArray;
            var clientsRow = clientsDataTable.Rows[0].ItemArray;
            _print.PrintVisitorCard(e,
                subscriptionsRow[1].ToString(),
                clientsRow[1].ToString(),
                clientsRow[2].ToString(),
                clientsRow[3].ToString(),
                clientsRow[6].ToString(),
                Convert.ToDateTime(((DataRowView)visitorCardsDataGridView.SelectedRows[0].DataBoundItem).Row[3]),
                Convert.ToDateTime(((DataRowView)visitorCardsDataGridView.SelectedRows[0].DataBoundItem).Row[4])
            );
        }

        private void PrintClientTrainingsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(trainingsBindingSource.Filter))
            {
                MessageBox.Show("Спочатку оберіть клієнта.",
                    "Клієнта не обрано",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            printDialog.Document = printClientTrainings;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printClientTrainings.Print();
            }
        }

        private void PrintClientTrainings_BeginPrint(object sender, PrintEventArgs e)
        {
            trainingsDataGridView.Columns[1].Visible = false;
            _print.BeginPrintClientTrainings(trainingsDataGridView);
        }

        private void PrintClientTrainings_PrintPage(object sender, PrintPageEventArgs e)
        {
            _print.PrintClientTrainings(e);
        }

        private void PrintClientTrainings_EndPrint(object sender, PrintEventArgs e)
        {
            trainingsDataGridView.Columns[1].Visible = true;
        }

        private void MostPopularSubscriptionsButton_Click(object sender, EventArgs e)
        {
            queryDataGridView.Columns.Clear();
            queryDataGridView.Rows.Clear();

            queryDataGridView.Columns.Add("subscriptionName", "Назва абонемента");
            queryDataGridView.Columns.Add("subscriptionCount", "Кількість разів замовлено");

            var dataTable = new swimmingpoolDataSet.SubscriptionsDataTable();
            subscriptionsTableAdapter.FillByMostPopular(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                queryDataGridView.Rows.Add(dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[5]);
            }
        }

        private void ClientsMostMoneySpentButton_Click(object sender, EventArgs e)
        {
            queryDataGridView.Columns.Clear();
            queryDataGridView.Rows.Clear();

            queryDataGridView.Columns.Add("firstName", "Ім'я");
            queryDataGridView.Columns.Add("lastName", "Прізвище");
            queryDataGridView.Columns.Add("middleName", "По-батькові");
            queryDataGridView.Columns.Add("moneySum", "Грошей витрачено");

            var dataTable = new swimmingpoolDataSet.ClientsDataTable();
            clientsTableAdapter.FillByMostMoneySpent(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                queryDataGridView.Rows.Add(
                    dataTable.Rows[i].ItemArray[1], 
                    dataTable.Rows[i].ItemArray[2],
                    dataTable.Rows[i].ItemArray[3],
                    dataTable.Rows[i].ItemArray[10] + "₴");
            }
        }

        private void ClientsMostTrainingsButton_Click(object sender, EventArgs e)
        {
            queryDataGridView.Columns.Clear();
            queryDataGridView.Rows.Clear();

            queryDataGridView.Columns.Add("firstName", "Ім'я");
            queryDataGridView.Columns.Add("lastName", "Прізвище");
            queryDataGridView.Columns.Add("middleName", "По-батькові");
            queryDataGridView.Columns.Add("trainingsCount", "Кількість тренувань відвідано");

            var dataTable = new swimmingpoolDataSet.ClientsDataTable();
            clientsTableAdapter.FillByMostTrainings(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                queryDataGridView.Rows.Add(
                    dataTable.Rows[i].ItemArray[1], 
                    dataTable.Rows[i].ItemArray[2],
                    dataTable.Rows[i].ItemArray[3],
                    dataTable.Rows[i].ItemArray[10]);
            }
        }

        private void InstructorsMostClientsButton_Click(object sender, EventArgs e)
        {
            queryDataGridView.Columns.Clear();
            queryDataGridView.Rows.Clear();

            queryDataGridView.Columns.Add("firstName", "Ім'я");
            queryDataGridView.Columns.Add("lastName", "Прізвище");
            queryDataGridView.Columns.Add("middleName", "По-батькові");
            queryDataGridView.Columns.Add("clientsCount", "Кількість клієнтів у басейні");

            var dataTable = new swimmingpoolDataSet.InstructorsDataTable();
            instructorsTableAdapter.FillByMostClientsCurrentlyInPool(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                queryDataGridView.Rows.Add(
                    dataTable.Rows[i].ItemArray[1], 
                    dataTable.Rows[i].ItemArray[2],
                    dataTable.Rows[i].ItemArray[3],
                    dataTable.Rows[i].ItemArray[7]);
            }
        }
    }
}