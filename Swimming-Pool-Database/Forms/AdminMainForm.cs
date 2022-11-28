using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillTableAdapters();
        }

        private void FillTableAdapters()
        {
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
            subscriptionsViewTableAdapter.Fill(swimmingpoolDataSet.SubscriptionsView);
            visitorCardsTableAdapter.Fill(swimmingpoolDataSet.VisitorCards);
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

        private void SetFiltering(object sender, EventArgs e)
        {
            clientsBindingSource.RemoveFilter();
            SetSearch();
            SetFilters();
        }

        private void SetSearch()
        {
            SetClientsFilter(true,
                $"first_name LIKE '%{firstNameTextBox.Text}%' " +
                $"AND last_name LIKE '%{lastNameTextBox.Text}%' " +
                $"AND middle_name LIKE '%{middleNameTextBox.Text}%'");
        }

        private void SetFilters()
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
    }
}