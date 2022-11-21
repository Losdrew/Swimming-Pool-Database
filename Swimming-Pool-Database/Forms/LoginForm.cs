using System;
using System.Data.Odbc;
using System.Windows.Forms;
using Swimming_Pool_Database.Properties;

namespace Swimming_Pool_Database.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            clientsTableAdapter.Fill(swimmingpoolDataSet.Clients);
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (authLoginTextBox.Text == "" || authPasswordTextBox.Text == "")
            {
                ShowLoginOrPasswordEmptyMessage();
                return;
            }

            try
            {
                new OdbcConnection(GetNewConnectionString(authLoginTextBox.Text, authPasswordTextBox.Text)).Open();
            }
            catch
            {
                MessageBox.Show("Логін або пароль уведені неправильно.",
                    "Неправильні дані",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            CommonFunctions.MakeFormActive(new MainForm());
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

            var odbcConnection = new OdbcConnection(GetNewConnectionString(regLoginTextBox.Text, regPasswordTextBox.Text));

            try
            {
                odbcConnection.Open();
            }
            catch
            {
                odbcConnection = new OdbcConnection(Settings.Default.swimmingpoolConnectionString);
                var sql = "CREATE ROLE " + regLoginTextBox.Text + " LOGIN PASSWORD '" + regPasswordTextBox.Text + "'";
                var command = new OdbcCommand(sql, odbcConnection);
                odbcConnection.Open();
                command.ExecuteReader();
                odbcConnection.Close();
            }

            CommonFunctions.MakeFormActive(new MainForm());
        }

        private void ShowLoginOrPasswordEmptyMessage()
        {
            MessageBox.Show("Поля логіну або паролю пусті!",
                "Недостатньо даних",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private string GetNewConnectionString(string login, string password)
        {
            var newConnectionString = Settings.Default.swimmingpoolConnectionString;
            newConnectionString = newConnectionString.Replace("uid=postgres", "uid=" + login);
            newConnectionString = newConnectionString.Insert(newConnectionString.IndexOf("ssl"), "pwd=" + password + ";");
            return newConnectionString;
        }
    }
}
