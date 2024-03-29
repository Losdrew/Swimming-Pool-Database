﻿using System;
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
            sexComboBox.SelectedIndex = 0;
            preparationLevelComboBox.SelectedIndex = 0;
        }

        public EditClients(int id, string login, string password) : this()
        {
            Text = "Редагування клієнта";
            _isEdit = true;
            _id = id;

            loginTextBox.Text = login;
            passwordTextBox.Text = password;
        }

        public EditClients(int id, string firstName, string lastName, string middleName, DateTime dateOfBirth, 
            string sex, string preparationLevel, string email, string login, string password) : this()
        {
            Text = "Редагування клієнта";
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
            loginTextBox.Text = login;
            passwordTextBox.Text = password;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        clientsTableAdapter.UpdateQuery(
                            firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            middleNameTextBox.Text,
                            dateOfBirthDateTimePicker.Value,
                            sexComboBox.Items[sexComboBox.SelectedIndex].ToString(),
                            preparationLevelComboBox.Items[preparationLevelComboBox.SelectedIndex].ToString(),
                            emailTextBox.Text,
                            loginTextBox.Text,
                            passwordTextBox.Text,
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
                            dateOfBirthDateTimePicker.Value,
                            sexComboBox.Items[sexComboBox.SelectedIndex].ToString(),
                            preparationLevelComboBox.Items[preparationLevelComboBox.SelectedIndex].ToString(),
                            emailTextBox.Text,
                            loginTextBox.Text,
                            passwordTextBox.Text)))
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
