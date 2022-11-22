using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class AdminMainForm : Form
    {
        private enum Tables
        {
            Clients,
            Subscriptions,
            VisitorCards
        }

        private Tables currentTable;

        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = clientsBindingSource;
            dataGridView.Columns[0].Visible = false;
            tableNameLabel.Text = "Клієнти";
            currentTable = Tables.Clients;
        }

        private void subscriptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = subscriptionsBindingSource;
            dataGridView.Columns[0].Visible = false;
            var format = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            format.CurrencySymbol = "₴";
            dataGridView.Columns["ціна"].DefaultCellStyle.FormatProvider = format;
            dataGridView.Columns["ціна"].DefaultCellStyle.Format = "c";
            tableNameLabel.Text = "Абонементи";
            currentTable = Tables.Subscriptions;
        }

        private void visitorCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = visitorCardsBindingSource;
            dataGridView.Columns[0].Visible = false;
            tableNameLabel.Text = "Картки відвідувачів";
            currentTable = Tables.VisitorCards;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillTableAdapters();
        }

        private void FillTableAdapters()
        {
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
            subscriptionsTableAdapter.Fill(swimmingpoolDataSet.Subscriptions);
            visitorCardsTableAdapter.Fill(swimmingpoolDataSet.VisitorCards);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientsTableAdapter.Update(swimmingpoolDataSet);
            subscriptionsTableAdapter.Update(swimmingpoolDataSet);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAnyTableSelected())
            {
                return;
            }

            var editForm = new Form();

            switch (currentTable)
            {
                case Tables.Clients:
                    editForm = new EditClients();
                    break;
                case Tables.Subscriptions:
                    editForm = new EditSubscriptions();
                    break;
            }

            editForm.ShowDialog();
            FillTableAdapters();
            swimmingpoolDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAnyTableSelected() || !IsAnyRowSelected() || IsRowEmpty())
            {
                return;
            }

            DataTable dataTable;
            var isQueryExecuted = false;
            object[] row;
            var editForm = new Form();

            switch (currentTable)
            {
                case Tables.Clients:
                    dataTable = new swimmingpoolDataSet.ClientsDataTable();
                    isQueryExecuted = CommonFunctions.TryQuery(() =>
                        clientsTableAdapter.FillBy((swimmingpoolDataSet.ClientsDataTable)dataTable,
                          Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row[0])));
                    row = dataTable.Rows[0].ItemArray;
                    editForm = new EditClients(
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString(),
                        Convert.ToDateTime(row[5]),
                        row[6].ToString(),
                        row[7].ToString());
                    break;
                case Tables.Subscriptions:
                    dataTable = new swimmingpoolDataSet.SubscriptionsDataTable();
                    isQueryExecuted = CommonFunctions.TryQuery(() =>
                        subscriptionsTableAdapter.FillBy((swimmingpoolDataSet.SubscriptionsDataTable)dataTable,
                            Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row[0])));
                    row = dataTable.Rows[0].ItemArray;
                    editForm = new EditSubscriptions(
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        Convert.ToDecimal(row[2]),
                        Convert.ToInt32(row[3]),
                        Convert.ToInt32(row[4]));
                    break;
            }

            if (!isQueryExecuted)
            {
                return;
            }

            editForm.ShowDialog();
            FillTableAdapters();
            swimmingpoolDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAnyTableSelected() || !IsAnyRowSelected() || IsRowEmpty() || 
                MessageBox.Show("Ви впевнені, що хочете видалити запис?",
                    "Видалення", 
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var isQueryExecuted = false;

            switch (currentTable)
            {
                case Tables.Clients:
                    isQueryExecuted = CommonFunctions.TryQuery(() =>
                        clientsTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row[0])));
                    break;
                case Tables.Subscriptions:
                    isQueryExecuted = CommonFunctions.TryQuery(() =>
                        subscriptionsTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row[0])));
                    break;
            }

            if (!isQueryExecuted)
            {
                return;
            }

            FillTableAdapters();
            swimmingpoolDataSet.AcceptChanges();
        }

        private bool IsAnyTableSelected()
        {
            if (dataGridView.DataSource is null)
            {
                MessageBox.Show("Таблицю не обрано!",
                    "Помилка", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool IsAnyRowSelected()
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Рядок не обрано!",
                    "Помилка", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool IsRowEmpty()
        {
            if (dataGridView.SelectedRows[0].DataBoundItem is null)
            {
                MessageBox.Show("Рядок пустий!",
                    "Помилка", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return true;
            }

            return false;
        }
    }
}