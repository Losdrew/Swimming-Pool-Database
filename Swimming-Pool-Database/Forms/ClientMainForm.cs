using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class ClientMainForm : Form
    {
        private readonly int _id;

        private ClientMainForm()
        {
            InitializeComponent();
        }

        public ClientMainForm(int? id) : this()
        {
            if (id != null)
            {
                _id = id.Value;
            }
        }

        public ClientMainForm(string login, string password) : this()
        {
            var id = clientsTableAdapter.GetClientByLoginAndPassword(login, password);
            if (id != null)
            {
                _id = id.Value;
                new EditClients(id.Value, login, password).ShowDialog();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, System.EventArgs e)
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
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
