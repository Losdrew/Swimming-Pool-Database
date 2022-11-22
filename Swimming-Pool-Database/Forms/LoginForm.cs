using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (authLoginTextBox.Text == "" || authPasswordTextBox.Text == "")
            {
                ShowLoginOrPasswordEmptyMessage();
                return;
            }

            if (authLoginTextBox.Text == "admin" && authPasswordTextBox.Text == "admin")
            {
                CommonFunctions.MakeFormActive(new AdminMainForm());
                return;
            }

            int? clientId;

            try
            {
                clientId = clientsTableAdapter.GetClientByLoginAndPassword(authLoginTextBox.Text, authPasswordTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Логін або пароль уведені неправильно.",
                    "Неправильні дані",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            CommonFunctions.MakeFormActive(new ClientMainForm(clientId));
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (regLoginTextBox.Text == "" || regPasswordTextBox.Text == "" || regRepeatPasswordTextBox.Text == "")
            {
                ShowLoginOrPasswordEmptyMessage();
                return;
            }

            if (regPasswordTextBox.Text != regRepeatPasswordTextBox.Text)
            {
                MessageBox.Show("Уведені паролі не співпадають!",
                    "Неправильний пароль",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            try
            {
                if (regLoginTextBox.Text == "admin")
                {
                    throw new Exception();
                }

                clientsTableAdapter.InsertLoginAndPassword(regLoginTextBox.Text, regPasswordTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Користувач з таким логіном вже існує!",
                    "Неправильний логін",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            CommonFunctions.MakeFormActive(new ClientMainForm(regLoginTextBox.Text, regPasswordTextBox.Text));
        }

        private void ShowLoginOrPasswordEmptyMessage()
        {
            MessageBox.Show("Поля логіну або паролю пусті!",
                "Недостатньо даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
