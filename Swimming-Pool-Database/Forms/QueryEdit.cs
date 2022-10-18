using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class QueryEdit : Form
    {
        private const string ConnectionString = "Dsn=PostgreSQL35W;database=swimmingpool;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-";

        public QueryEdit()
        {
            InitializeComponent();
        }

        private void DoSQLButton_Click(object sender, EventArgs e)
        {
            try
            {
                var odbcConnection = new OdbcConnection(ConnectionString);
                odbcConnection.Open();
                var odbcDataAdapter = new OdbcDataAdapter(TestInput.Text, odbcConnection);
                var dataTable = new DataTable();
                odbcDataAdapter.Fill(dataTable);
                DataGridView.DataSource = dataTable;
                odbcConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                "Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TestInput.Clear();
            TestInput.Text = "SELECT";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
