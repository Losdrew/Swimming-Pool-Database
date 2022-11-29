using System;
using System.Drawing;
using System.Drawing.Printing;
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

        public static void PrintVisitorCard(PrintPageEventArgs e, string subscriptionName, string firstName,
            string lastName, string middleName, string preparationLevel, DateTime startDate, DateTime expiryDate)
        {
            var headerFont = new Font("Arial", 30, FontStyle.Bold);
            var labelFont = new Font("Arial", 18, FontStyle.Bold);
            var dataFont = new Font("Arial", 18, FontStyle.Regular);

            const float spacing = 15;
            var headerLineHeight = headerFont.GetHeight() + spacing;
            var labelLineHeight = labelFont.GetHeight() + spacing;

            var headerFormat = new StringFormat(StringFormatFlags.NoClip);
            var labelFormat = new StringFormat(StringFormatFlags.NoClip);
            headerFormat.Alignment = StringAlignment.Center;

            var (x, y) = (e.MarginBounds.X, e.MarginBounds.Y + spacing);

            e.Graphics.DrawString("Картка відвідувача", headerFont, Brushes.Black, e.MarginBounds, headerFormat);
            y += headerLineHeight;

            var labelSize = e.Graphics.MeasureString("Назва абонемента:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("Назва абонемента:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(subscriptionName, dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("ПІБ:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("ПIБ:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(lastName + " " + firstName + " " + middleName, dataFont, Brushes.Black,
                x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Рівень підготовки:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("Рівень підготовки:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(preparationLevel, dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Дата початку дії:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("Дата початку дії:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(startDate.ToLongDateString(), dataFont, Brushes.Black, x + labelSize.Width + 1, y);
            y += labelLineHeight;

            labelSize = e.Graphics.MeasureString("Дата завершення дії:", labelFont, e.MarginBounds.Size, labelFormat);
            e.Graphics.DrawString("Дата завершення дії:", labelFont, Brushes.Black, x, y);
            e.Graphics.DrawString(expiryDate.ToLongDateString(), dataFont, Brushes.Black, x + labelSize.Width + 1, y);
        }
    }
}
