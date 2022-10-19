using System;
using System.Data;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditGroups : EditForm
    {
        public EditGroups()
        {
            InitializeComponent();
        }

        public EditGroups(int id, int coachId, string trainingDays, string groupType) : this()
        {
            _isEdit = true;
            _id = id;

            coachComboBox.SelectedValue = coachId;
            foreach (var day in trainingDays.Trim('{', '}').Split(','))
            {
                for (var i = 0; i < trainingDaysCheckedListBox.Items.Count; i++)
                {
                    if (trainingDaysCheckedListBox.Items[i].ToString() == day)
                    {
                        trainingDaysCheckedListBox.SetItemChecked(i, true);
                    }
                }
            }
            switch (groupType)
            {
                case "Amateur":
                    groupTypeComboBox.SelectedIndex = 0;
                    break;
                case "Sportsman":
                    groupTypeComboBox.SelectedIndex = 1;
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var trainingDaysChecked = "{";

            for (int i = 0; i < trainingDaysCheckedListBox.CheckedItems.Count; i++)
            {
                if (i != 0)
                {
                    trainingDaysChecked += ",";
                }

                trainingDaysChecked += trainingDaysCheckedListBox.CheckedItems[i];
            }

            trainingDaysChecked += "}";

            if (_isEdit)
            {
                if (!MainForm.TryQuery(() => 
                        groupsTableAdapter.UpdateQuery(
                            int.Parse(coachComboBox.SelectedValue.ToString()), 
                            trainingDaysChecked,
                            groupTypeComboBox.Items[groupTypeComboBox.SelectedIndex].ToString(), 
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!MainForm.TryQuery(() => 
                        groupsTableAdapter.Insert(
                            int.Parse(coachComboBox.SelectedValue.ToString()), 
                            trainingDaysChecked,
                            groupTypeComboBox.Items[groupTypeComboBox.SelectedIndex].ToString())))
                {
                    return;
                }
            }

            Close();
        }

        private void coachComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            var row = (DataRowView)e.ListItem;
            e.Value = row["last_name"] + " " + row["first_name"] + " " + row["middle_name"];
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            EditForm_CancelButton_Click(sender, e);
        }

        private void EditGroups_Load(object sender, EventArgs e)
        {
            EditForm_Load(sender, e);
        }
    }
}
