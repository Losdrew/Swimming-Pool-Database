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
            if (!CommonFunctions.IsValidEmail(emailTextBox.Text, out var errorMessage))
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
    }
}
