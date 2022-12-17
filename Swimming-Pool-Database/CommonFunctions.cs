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
    }
}
