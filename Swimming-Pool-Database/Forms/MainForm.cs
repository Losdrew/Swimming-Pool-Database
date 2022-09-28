using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator.BindingSource = ñlientsBindingSource;
            dataGridView.DataSource = ñlientsBindingSource;
            label1.Text = "Clients";
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator.BindingSource = groupsBindingSource;
            dataGridView.DataSource = groupsBindingSource;
            label1.Text = "Groups";
        }

        private void lockersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator.BindingSource = coachesBindingSource;
            dataGridView.DataSource = coachesBindingSource;
            label1.Text = "Coaches";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            coachesTableAdapter.Fill(swimmingpoolDataSet.Coaches);
            groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
            ñlientsTableAdapter.Fill(swimmingpoolDataSet.Ñlients);
            dataGridView.AutoGenerateColumns = true;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            ñlientsTableAdapter.Update(swimmingpoolDataSet);
            groupsTableAdapter.Update(swimmingpoolDataSet);
            coachesTableAdapter.Update(swimmingpoolDataSet);
        }

        private void regroupingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var regrouping = new Regrouping();
            regrouping.ShowDialog();
            ñlientsTableAdapter.Fill(swimmingpoolDataSet.Ñlients); 
            groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
        }

        private void threeTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var threeTables = new ThreeTables();
            threeTables.ShowDialog();
            ñlientsTableAdapter.Fill(swimmingpoolDataSet.Ñlients); 
            groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
        }
    }
}