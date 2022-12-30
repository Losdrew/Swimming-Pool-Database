using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditPools : Form
    {
        private readonly int _id;
        private readonly bool _isEdit;

        public EditPools()
        {
            InitializeComponent();
            poolIdNumericUpDown.Value = Convert.ToDecimal(poolsTableAdapter.GetMaxId() + 1);
        }

        public EditPools(int id, int capacity) : this()
        {
            Text = "Редагування басейна";
            _isEdit = true;
            _id = id;

            poolIdNumericUpDown.Text = id.ToString();
            capacityNumericUpDown.Value = capacity;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        poolsTableAdapter.UpdateQuery(
                            Convert.ToInt32(capacityNumericUpDown.Value),
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!CommonFunctions.TryQuery(() =>
                        poolsTableAdapter.InsertQuery(
                            Convert.ToInt32(poolIdNumericUpDown.Value), 
                            Convert.ToInt32(capacityNumericUpDown.Value))))
                {
                    return;
                }
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}