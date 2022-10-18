using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class ThreeTables : Form
    {
        public ThreeTables()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clientsTableAdapter.Update(swimmingpoolDataSet);
            groupsTableAdapter.Update(swimmingpoolDataSet);
            coachesTableAdapter.Update(swimmingpoolDataSet);
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            coachesTableAdapter.Fill(swimmingpoolDataSet.Coaches);
            groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
        }
    }
}