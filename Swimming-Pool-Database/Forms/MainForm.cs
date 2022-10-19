using System;
using System.Data;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class MainForm : Form
    {
        private enum Tables
        {
            Clients,
            Groups,
            Coaches
        }

        private Tables currentTable;

        public MainForm()
        {
            InitializeComponent();
        }

        public static bool TryQuery<T>(Func<T> query)
        {
            try
            {
                query();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator.BindingSource = clientsBindingSource;
            dataGridView.DataSource = clientsBindingSource;
            label1.Text = "Clients";
            currentTable = Tables.Clients;
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator.BindingSource = groupsBindingSource;
            dataGridView.DataSource = groupsBindingSource;
            label1.Text = "Groups";
            currentTable = Tables.Groups;
        }

        private void coachesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator.BindingSource = coachesBindingSource;
            dataGridView.DataSource = coachesBindingSource;
            label1.Text = "Coaches";
            currentTable = Tables.Coaches;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FillTableAdapters();
            dataGridView.AutoGenerateColumns = true;
        }

        private void FillTableAdapters()
        {
            coachesTableAdapter.Fill(swimmingpoolDataSet.Coaches);
            groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientsTableAdapter.Update(swimmingpoolDataSet);
            groupsTableAdapter.Update(swimmingpoolDataSet);
            coachesTableAdapter.Update(swimmingpoolDataSet);
        }

        private void regroupingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var regrouping = new Regrouping();
            regrouping.ShowDialog();
        }

        private void threeTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var threeTables = new ThreeTables();
            threeTables.ShowDialog();
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var queryEdit = new QueryEdit();
            queryEdit.ShowDialog();
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
                case Tables.Groups:
                    editForm = new EditGroups();
                    break;
                case Tables.Coaches:
                    editForm = new EditCoaches();
                    break;
            }

            editForm.ShowDialog();
            FillTableAdapters();
            swimmingpoolDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAnyTableSelected())
            {
                return;
            }

            DataTable dataTable;
            bool isQueryExecuted = false;
            object[] row;
            Form editForm = new Form();

            switch (currentTable)
            {
                case Tables.Clients:
                    dataTable = new swimmingpoolDataSet.ClientsDataTable();
                    isQueryExecuted = TryQuery(() =>
                        clientsTableAdapter.FillBy((swimmingpoolDataSet.ClientsDataTable)dataTable,
                            Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row["client_id"])));
                    row = dataTable.Rows[0].ItemArray;
                    editForm = new EditClients(
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString(),
                        Convert.ToDateTime(row[5]),
                        row[6].ToString(),
                        row[7].ToString(),
                        Convert.ToInt32(row[8]),
                        Convert.ToInt32(row[9]));
                    break;
                case Tables.Groups:
                    dataTable = new swimmingpoolDataSet.GroupsDataTable();
                    isQueryExecuted = TryQuery(() =>
                        groupsTableAdapter.FillBy((swimmingpoolDataSet.GroupsDataTable)dataTable,
                            Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row["group_id"])));
                    row = dataTable.Rows[0].ItemArray;
                    editForm = new EditGroups(
                        Convert.ToInt32(row[0]),
                        Convert.ToInt32(row[1]),
                        row[2].ToString(),
                        row[3].ToString());
                    groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
                    break;
                case Tables.Coaches:
                    dataTable = new swimmingpoolDataSet.CoachesDataTable();
                    isQueryExecuted = TryQuery(() =>
                        coachesTableAdapter.FillBy((swimmingpoolDataSet.CoachesDataTable)dataTable,
                            Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row["coach_id"])));
                    row = dataTable.Rows[0].ItemArray;
                    editForm = new EditCoaches(
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        Convert.ToInt32(row[4]));
                    coachesTableAdapter.Fill(swimmingpoolDataSet.Coaches);
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
            if (!IsAnyTableSelected())
            {
                return;
            }

            var isQueryExecuted = false;

            switch (currentTable)
            {
                case Tables.Clients:
                    isQueryExecuted = TryQuery(() =>
                        clientsTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row["client_id"])));
                    break;
                case Tables.Groups:
                    isQueryExecuted = TryQuery(() =>
                        groupsTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row["group_id"])));
                    break;
                case Tables.Coaches:
                    isQueryExecuted = TryQuery(() =>
                        coachesTableAdapter.DeleteQuery(Convert.ToInt32(((DataRowView)dataGridView.SelectedRows[0].DataBoundItem).Row["coach_id"])));
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
                MessageBox.Show("No table is selected!",
                    "Error", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}