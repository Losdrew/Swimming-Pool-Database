using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditSubscriptions : Form
    {
        private readonly int _id;
        private readonly bool _isEdit;

        public EditSubscriptions()
        {
            InitializeComponent();
        }

        public EditSubscriptions(int id, string name, decimal price, int attendanceCount, int dayCount) : this()
        {
            _isEdit = true;
            _id = id;

            nameTextBox.Text = name;
            priceNumericUpDown.Value = price;
            attendanceCountNumericUpDown.Value = attendanceCount;
            dayCountNumericUpDown.Value = dayCount;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        subscriptionsTableAdapter.UpdateQuery(
                            nameTextBox.Text,
                            priceNumericUpDown.Value,
                            Convert.ToInt32(attendanceCountNumericUpDown.Value),
                            Convert.ToInt32(dayCountNumericUpDown.Value),
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!CommonFunctions.TryQuery(() =>
                        subscriptionsTableAdapter.Insert(
                            nameTextBox.Text,
                            priceNumericUpDown.Value,
                            Convert.ToInt32(attendanceCountNumericUpDown.Value),
                            Convert.ToInt32(dayCountNumericUpDown.Value))))
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
