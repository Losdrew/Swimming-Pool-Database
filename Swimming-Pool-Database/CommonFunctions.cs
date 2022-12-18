using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database
{
    public static class CommonFunctions
    {
        public static void MakeFormActive(Form form)
        {
            Program.AppContext.MainForm?.Hide();
            Program.AppContext.MainForm = form;
            Program.AppContext.MainForm.Show();
        }

        public static bool TryQuery<T>(Func<T> query)
        {
            try
            {
                query();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool IsAnyRowSelected(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Рядок не обрано!",
                    "Помилка", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public static bool IsValidEmail(string email, out string errorMessage)
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
