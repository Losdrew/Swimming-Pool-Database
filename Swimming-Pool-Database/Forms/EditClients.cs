using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditClients : Form
    {
        private readonly int _id;
        private readonly bool _isEdit;

        public EditClients()
        {
            InitializeComponent();
        }

        public EditClients(int id, string firstName, string lastName, string middleName, string sex, 
            DateTime dateOfBirth, string preparationLevel, string email) : this()
        {
            _isEdit = true;
            _id = id;

            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            middleNameTextBox.Text = middleName;
            switch (sex)
            {
                case "Чоловіча":
                    sexComboBox.SelectedIndex = 0;
                    break;
                case "Жіноча":
                    sexComboBox.SelectedIndex = 1;
                    break;
            }
            dateOfBirthDateTimePicker.Value = dateOfBirth;
            switch (preparationLevel)
            {
                case "Початківець":
                    preparationLevelComboBox.SelectedIndex = 0;
                    break;
                case "Любитель":
                    preparationLevelComboBox.SelectedIndex = 1;
                    break;
                case "Спортсмен":
                    preparationLevelComboBox.SelectedIndex = 2;
                    break;
            }
            emailTextBox.Text = email;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        clientsTableAdapter.UpdateQuery(
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleNameTextBox.Text,
                            sexComboBox.Items[sexComboBox.SelectedIndex].ToString(),
                            dateOfBirthDateTimePicker.Value,
                            preparationLevelComboBox.Items[preparationLevelComboBox.SelectedIndex].ToString(),
                            emailTextBox.Text,
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!CommonFunctions.TryQuery(() =>
                        clientsTableAdapter.Insert(
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleNameTextBox.Text,
                            sexComboBox.Items[sexComboBox.SelectedIndex].ToString(),
                            dateOfBirthDateTimePicker.Value,
                            preparationLevelComboBox.Items[preparationLevelComboBox.SelectedIndex].ToString(),
                            emailTextBox.Text)))
                {
                    return;
                }
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsValidEmail(emailTextBox.Text, out var errorMessage))
            {
                e.Cancel = true;
                emailTextBox.Select(0, emailTextBox.Text.Length);
                errorProvider.SetError(emailTextBox, errorMessage);
            }
        }

        private bool IsValidEmail(string email, out string errorMessage)
        {
            if (email.IndexOf("@") > -1)
            {
                if (email.IndexOf(".", email.IndexOf("@") ) > email.IndexOf("@") )
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Електронна адреса повинна бути у правильному форматі.\n" +
                           "Наприклад: 'someone@example.com' ";

            return false;
        }

        private void emailTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(emailTextBox, "");
        }
    }
}
