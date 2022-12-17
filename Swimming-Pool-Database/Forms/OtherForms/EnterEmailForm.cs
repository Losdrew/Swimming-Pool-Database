using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EnterEmailForm : Form
    {
        public string email;
        public string password;

        public EnterEmailForm()
        {
            InitializeComponent();
        }

        private void EmailAuthButton_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(emailTextBox.Text, out var errorMessage))
            {
                MessageBox.Show("Неправильний формат адреси!",
                    errorMessage,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            email = emailTextBox.Text;
            password = passwordTextBox.Text;
            Close();
        }

        private bool IsValidEmail(string email, out string errorMessage)
        {
            if (email.IndexOf('@') > -1)
            {
                if (email.IndexOf('.', email.IndexOf('@') ) > email.IndexOf('@') )
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Електронна адреса повинна бути у правильному форматі.\n" +
                           "Наприклад: 'someone@example.com' ";

            return false;
        }
    }
}
