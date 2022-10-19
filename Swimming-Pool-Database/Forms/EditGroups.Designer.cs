namespace Swimming_Pool_Database.Forms
{
    partial class EditGroups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label middle_nameLabel;
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.trainingDaysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.coachComboBox = new System.Windows.Forms.ComboBox();
            this.groupTypeComboBox = new System.Windows.Forms.ComboBox();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_nameLabel.Location = new System.Drawing.Point(39, 29);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(76, 25);
            first_nameLabel.TabIndex = 35;
            first_nameLabel.Text = "Coach:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_nameLabel.Location = new System.Drawing.Point(39, 62);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(114, 25);
            last_nameLabel.TabIndex = 36;
            last_nameLabel.Text = "Group type:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(39, 94);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(136, 25);
            middle_nameLabel.TabIndex = 37;
            middle_nameLabel.Text = "Training days:";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(276, 278);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 39);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(94, 278);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(158, 39);
            this.okButton.TabIndex = 44;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // trainingDaysCheckedListBox
            // 
            this.trainingDaysCheckedListBox.CheckOnClick = true;
            this.trainingDaysCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainingDaysCheckedListBox.FormattingEnabled = true;
            this.trainingDaysCheckedListBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.trainingDaysCheckedListBox.Location = new System.Drawing.Point(193, 96);
            this.trainingDaysCheckedListBox.Name = "trainingDaysCheckedListBox";
            this.trainingDaysCheckedListBox.Size = new System.Drawing.Size(273, 158);
            this.trainingDaysCheckedListBox.TabIndex = 48;
            // 
            // coachComboBox
            // 
            this.coachComboBox.DataSource = this.coachesBindingSource;
            this.coachComboBox.DisplayMember = "last_name";
            this.coachComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coachComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coachComboBox.FormattingEnabled = true;
            this.coachComboBox.Location = new System.Drawing.Point(193, 29);
            this.coachComboBox.Name = "coachComboBox";
            this.coachComboBox.Size = new System.Drawing.Size(273, 28);
            this.coachComboBox.TabIndex = 49;
            this.coachComboBox.ValueMember = "coach_id";
            this.coachComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.coachComboBox_Format);
            // 
            // groupTypeComboBox
            // 
            this.groupTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTypeComboBox.FormattingEnabled = true;
            this.groupTypeComboBox.Items.AddRange(new object[] {
            "Amateur",
            "Sportsman"});
            this.groupTypeComboBox.Location = new System.Drawing.Point(193, 62);
            this.groupTypeComboBox.Name = "groupTypeComboBox";
            this.groupTypeComboBox.Size = new System.Drawing.Size(273, 28);
            this.groupTypeComboBox.TabIndex = 50;
            // 
            // EditGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 351);
            this.Controls.Add(this.groupTypeComboBox);
            this.Controls.Add(this.coachComboBox);
            this.Controls.Add(this.trainingDaysCheckedListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(middle_nameLabel);
            this.Name = "EditGroups";
            this.Text = "EditGroups";
            this.Load += new System.EventHandler(this.EditGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckedListBox trainingDaysCheckedListBox;
        private System.Windows.Forms.ComboBox coachComboBox;
        private System.Windows.Forms.ComboBox groupTypeComboBox;
    }
}