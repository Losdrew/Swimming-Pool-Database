using System;
using System.Data;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class UserMainForm : Form
    {
        private readonly int _id;

        private UserMainForm()
        {
            InitializeComponent();
        }

        public UserMainForm(int id) : this() => _id = id;

        public UserMainForm(string login, string password) : this()
        {
            var id = clientsTableAdapter.GetClientByLoginAndPassword(login, password);
            if (id != null)
            {
                _id = id.Value;
                new EditClients(id.Value, login, password).ShowDialog();
            }
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
            clientsBindingSource.Filter = "client_id = " + _id;
            subscriptionsTableAdapter.Fill(swimmingpoolDataSet.Subscriptions);
            visitorCardsTableAdapter.Fill(swimmingpoolDataSet.VisitorCards);
            visitorCardsBindingSource.Filter = "client_id = " + _id;
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage)
            {
                case TabPage tabPage when tabPage.Equals(profileTabPage):
                    clientsDataGridView.Columns[0].Visible = false;
                    break;
                case TabPage tabPage when tabPage.Equals(subscriptionsTabPage):
                    subscriptionsDataGridView.Columns[0].Visible = false;
                    break;
                case TabPage tabPage when tabPage.Equals(visitorCardTabPage):
                    visitorCardsDataGridView.Columns[0].Visible = false;
                    break;
            }
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (!CommonFunctions.IsAnyRowSelected(subscriptionsDataGridView))
            {
                return;
            }

            var subscriptionsDataTable = new swimmingpoolDataSet.SubscriptionsDataTable();
            var clientsDataTable = new swimmingpoolDataSet.ClientsDataTable();

            if (!CommonFunctions.TryQuery(() =>
                    subscriptionsTableAdapter.FillBy(subscriptionsDataTable,
                        Convert.ToInt32(((DataRowView)subscriptionsDataGridView.SelectedRows[0].DataBoundItem).Row[0])))
                || !CommonFunctions.TryQuery(() => clientsTableAdapter.FillBy(clientsDataTable, _id)))
            {
                return;
            }

            var subscriptionsRow = subscriptionsDataTable.Rows[0].ItemArray;
            var clientsRow = clientsDataTable.Rows[0].ItemArray;
            new OrderSubscription(
                Convert.ToInt32(subscriptionsRow[0]),
                subscriptionsRow[1].ToString(),
                Convert.ToDecimal(subscriptionsRow[2]),
                Convert.ToInt32(subscriptionsRow[3]),
                Convert.ToInt32(subscriptionsRow[4]),
                Convert.ToInt32(clientsRow[0]),
                clientsRow[1].ToString(),
                clientsRow[2].ToString(),
                clientsRow[3].ToString()
            ).ShowDialog();

            visitorCardsTableAdapter.Fill(swimmingpoolDataSet.VisitorCards);
            swimmingpoolDataSet.AcceptChanges();
        }

        private void EditClientButton_Click(object sender, EventArgs e)
        {
            var dataTable = new swimmingpoolDataSet.ClientsDataTable();

            if (!CommonFunctions.TryQuery(() => clientsTableAdapter.FillBy(dataTable, _id)))
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

            clientsTableAdapter.FillBy(dataTable, _id);
            swimmingpoolDataSet.AcceptChanges();
        }

        private void DeleteVisitorCardButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити вашу картку?",
                    "Видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (!CommonFunctions.TryQuery(() => visitorCardsTableAdapter.DeleteQuery(
                    Convert.ToInt32(visitorCardsDataGridView.Rows[0].Cells[0].Value))))
            {
                return;
            }

            visitorCardsTableAdapter.Fill(swimmingpoolDataSet.VisitorCards);
            swimmingpoolDataSet.AcceptChanges();
        }
    }
}