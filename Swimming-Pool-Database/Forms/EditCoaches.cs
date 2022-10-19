namespace Swimming_Pool_Database.Forms
{
    public partial class EditCoaches : EditForm
    {
        public EditCoaches()
        {
            InitializeComponent();
        }

        public EditCoaches(int id, string firstName, string lastName, string middleName, int salary) : this()
        {
            _isEdit = true;
            _id = id;

            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            middleNameTextBox.Text = middleName;
            salaryTextBox.Text = salary.ToString();
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            if (_isEdit)
            {
                if (!MainForm.TryQuery(() => 
                        coachesTableAdapter.UpdateQuery(
                            firstNameTextBox.Text, 
                            lastNameTextBox.Text, 
                            middleNameTextBox.Text,
                            int.Parse(salaryTextBox.Text),
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!MainForm.TryQuery(() => 
                        coachesTableAdapter.Insert(
                            firstNameTextBox.Text, 
                            lastNameTextBox.Text, 
                            middleNameTextBox.Text,
                            int.Parse(salaryTextBox.Text))))
                {
                    return;
                }
            }

            Close();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            EditForm_CancelButton_Click(sender, e);
        }

        private void EditCoaches_Load(object sender, System.EventArgs e)
        {
            EditForm_Load(sender, e);
        }
    }
}
