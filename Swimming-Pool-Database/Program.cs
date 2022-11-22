using System;
using System.Windows.Forms;
using Swimming_Pool_Database.Forms;

namespace Swimming_Pool_Database
{
    internal static class Program
    {
        public static readonly ApplicationContext AppContext = new ApplicationContext();

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContext.MainForm = new LoginForm();
            Application.Run(AppContext);
        }
    }
}
