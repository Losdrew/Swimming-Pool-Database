using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public  partial class EditForm : Form
    {
        protected int _id;
        protected bool _isEdit;

        protected EditForm()
        {
            InitializeComponent();
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
            groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
            coachesTableAdapter.Fill(swimmingpoolDataSet.Coaches);
            _isEdit = false;
        }

        protected void EditForm_Load(object sender, EventArgs e)
        {
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
            groupsTableAdapter.Fill(swimmingpoolDataSet.Groups);
            coachesTableAdapter.Fill(swimmingpoolDataSet.Coaches);
        }

        protected void EditForm_CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
