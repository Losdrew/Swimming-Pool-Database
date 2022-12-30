using System;
using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    public partial class EditSwimLanes : Form
    {
        private readonly int _id;
        private readonly bool _isEdit;

        public EditSwimLanes()
        {
            InitializeComponent();
            poolsTableAdapter.Fill(swimmingpoolDataSet.Pools);
            swimLaneIdNumericUpDown.Value = Convert.ToDecimal(swimLanesTableAdapter.GetMaxId() + 1);
        }

        public EditSwimLanes(int id, int poolId) : this()
        {
            Text = "Редагування доріжки";
            _isEdit = true;
            _id = id;

            swimLaneIdNumericUpDown.Value = Convert.ToDecimal(id);
            poolComboBox.SelectedValue = poolId;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                if (!CommonFunctions.TryQuery(() =>
                        swimLanesTableAdapter.UpdateQuery(
                            Convert.ToInt32(poolComboBox.SelectedValue),
                            _id)))
                {
                    return;
                }
            }
            else
            {
                if (!CommonFunctions.TryQuery(() =>
                        swimLanesTableAdapter.InsertQuery(
                            Convert.ToInt32(swimLaneIdNumericUpDown.Value),
                            Convert.ToInt32(poolComboBox.SelectedValue))))
                {
                    return;
                }
            }

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
