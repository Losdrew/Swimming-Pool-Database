using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class Regrouping : Form
    {
        public Regrouping()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            сlientsTableAdapter.Fill(swimmingpoolDataSet.Сlients);
            groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to accept changes?", "Change data",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                groupsBindingSource.EndEdit();
                groupsTableAdapter.Update(swimmingpoolDataSet);
                сlientsTableAdapter.Update(swimmingpoolDataSet);
            }
        }
    }
}