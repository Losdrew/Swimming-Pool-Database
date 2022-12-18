using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditInstructors : Form
    {
        private readonly int _id;
        private readonly bool _isEdit;

        public EditInstructors()
        {
            InitializeComponent();
            poolsTableAdapter.Fill(swimmingpoolDataSet.Pools);
        }

        public EditInstructors(int id, string firstName, string lastName, string middleName, 
            string salary, int poolId, string email) : this()
        {
            _isEdit = true;
            _id = id;

            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            middleNameTextBox.Text = middleName;
            salaryTextBox.Text = salary;
            poolComboBox.SelectedValue = poolId;
            emailTextBox.Text = email;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        instructorsTableAdapter.UpdateQuery(
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleNameTextBox.Text,
                            Convert.ToDecimal(salaryTextBox.Text),
                            Convert.ToInt32(poolComboBox.SelectedValue),
                            emailTextBox.Text,
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!CommonFunctions.TryQuery(() =>
                        instructorsTableAdapter.Insert(
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleNameTextBox.Text,
                            Convert.ToDecimal(salaryTextBox.Text),
                            Convert.ToInt32(poolComboBox.SelectedValue),
                            emailTextBox.Text)))
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

        private void EmailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!CommonFunctions.IsValidEmail(emailTextBox.Text, out var errorMessage))
            {
                e.Cancel = true;
                emailTextBox.Select(0, emailTextBox.Text.Length);
                errorProvider.SetError(emailTextBox, errorMessage);
            }
        }

        private void EmailTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(emailTextBox, "");
        }
    }
}
