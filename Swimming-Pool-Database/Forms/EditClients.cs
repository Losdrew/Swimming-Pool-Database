using System;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditClients : EditForm
    {
        public EditClients()
        {
            InitializeComponent();
        }

        public EditClients(int id, string firstName, string lastName, string middleName, string sex, DateTime dateOfBirth, string clientType, 
            string medicalGroup, int groupId, int lockerId) : this()
        {
            _isEdit = true;
            _id = id;

            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            middleNameTextBox.Text = middleName;
            switch (sex)
            {
                case "Male":
                    sexComboBox.SelectedIndex = 0;
                    break;
                case "Female":
                    sexComboBox.SelectedIndex = 1;
                    break;
            }
            dateOfBirthDateTimePicker.Value = dateOfBirth;
            switch (clientType)
            {
                case "Amateur":
                    clientTypeComboBox.SelectedIndex = 0;
                    break;
                case "Sportsman":
                    clientTypeComboBox.SelectedIndex = 1;
                    break;
            }
            switch (medicalGroup)
            {
                case "Main":
                    medicalGroupComboBox.SelectedIndex = 0;
                    break;
                case "Preparatory":
                    medicalGroupComboBox.SelectedIndex = 1;
                    break;
                case "Special":
                    medicalGroupComboBox.SelectedIndex = 2;
                    break;
            }
            groupIdComboBox.SelectedValue = groupId;
            lockerIdTextBox.Text = lockerId.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!MainForm.TryQuery(() => 
                        clientsTableAdapter.UpdateQuery(
                            firstNameTextBox.Text, 
                            lastNameTextBox.Text, 
                            middleNameTextBox.Text,
                            sexComboBox.Items[sexComboBox.SelectedIndex].ToString(), 
                            dateOfBirthDateTimePicker.Value,
                            clientTypeComboBox.Items[clientTypeComboBox.SelectedIndex].ToString(),
                            medicalGroupComboBox.Items[medicalGroupComboBox.SelectedIndex].ToString(), 
                            int.Parse(groupIdComboBox.SelectedValue.ToString()),
                            int.Parse(lockerIdTextBox.Text), 
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!MainForm.TryQuery(() => 
                        clientsTableAdapter.Insert(
                            firstNameTextBox.Text, 
                            lastNameTextBox.Text, 
                            middleNameTextBox.Text,
                            sexComboBox.Items[sexComboBox.SelectedIndex].ToString(), 
                            dateOfBirthDateTimePicker.Value, 
                            clientTypeComboBox.Items[clientTypeComboBox.SelectedIndex].ToString(),
                            medicalGroupComboBox.Items[medicalGroupComboBox.SelectedIndex].ToString(),
                            int.Parse(groupIdComboBox.SelectedValue.ToString()),
                            int.Parse(lockerIdTextBox.Text))))
                {
                    return;
                }
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            EditForm_CancelButton_Click(sender, e);
        }

        private void EditClients_Load(object sender, EventArgs e)
        {
            EditForm_Load(sender, e);
        }
    }
}
