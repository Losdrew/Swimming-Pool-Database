namespace Swimming_Pool_Database.Forms
{
    partial class EditClients
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
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label date_of_birthLabel;
            System.Windows.Forms.Label client_typeLabel;
            System.Windows.Forms.Label medical_groupLabel;
            System.Windows.Forms.Label group_idLabel;
            System.Windows.Forms.Label locker_idLabel;
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lockerIdTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.clientTypeComboBox = new System.Windows.Forms.ComboBox();
            this.medicalGroupComboBox = new System.Windows.Forms.ComboBox();
            this.groupIdComboBox = new System.Windows.Forms.ComboBox();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            middle_nameLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            date_of_birthLabel = new System.Windows.Forms.Label();
            client_typeLabel = new System.Windows.Forms.Label();
            medical_groupLabel = new System.Windows.Forms.Label();
            group_idLabel = new System.Windows.Forms.Label();
            locker_idLabel = new System.Windows.Forms.Label();
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
            first_nameLabel.Location = new System.Drawing.Point(37, 31);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(109, 25);
            first_nameLabel.TabIndex = 3;
            first_nameLabel.Text = "First name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            last_nameLabel.Location = new System.Drawing.Point(37, 64);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(109, 25);
            last_nameLabel.TabIndex = 5;
            last_nameLabel.Text = "Last name:";
            // 
            // middle_nameLabel
            // 
            middle_nameLabel.AutoSize = true;
            middle_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middle_nameLabel.Location = new System.Drawing.Point(37, 96);
            middle_nameLabel.Name = "middle_nameLabel";
            middle_nameLabel.Size = new System.Drawing.Size(130, 25);
            middle_nameLabel.TabIndex = 7;
            middle_nameLabel.Text = "Middle name:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            sexLabel.Location = new System.Drawing.Point(37, 130);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(53, 25);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "Sex:";
            // 
            // date_of_birthLabel
            // 
            date_of_birthLabel.AutoSize = true;
            date_of_birthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_of_birthLabel.Location = new System.Drawing.Point(37, 163);
            date_of_birthLabel.Name = "date_of_birthLabel";
            date_of_birthLabel.Size = new System.Drawing.Size(122, 25);
            date_of_birthLabel.TabIndex = 11;
            date_of_birthLabel.Text = "Date of birth:";
            // 
            // client_typeLabel
            // 
            client_typeLabel.AutoSize = true;
            client_typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            client_typeLabel.Location = new System.Drawing.Point(37, 196);
            client_typeLabel.Name = "client_typeLabel";
            client_typeLabel.Size = new System.Drawing.Size(110, 25);
            client_typeLabel.TabIndex = 13;
            client_typeLabel.Text = "Client type:";
            // 
            // medical_groupLabel
            // 
            medical_groupLabel.AutoSize = true;
            medical_groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            medical_groupLabel.Location = new System.Drawing.Point(37, 231);
            medical_groupLabel.Name = "medical_groupLabel";
            medical_groupLabel.Size = new System.Drawing.Size(141, 25);
            medical_groupLabel.TabIndex = 15;
            medical_groupLabel.Text = "Medical group:";
            // 
            // group_idLabel
            // 
            group_idLabel.AutoSize = true;
            group_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            group_idLabel.Location = new System.Drawing.Point(37, 265);
            group_idLabel.Name = "group_idLabel";
            group_idLabel.Size = new System.Drawing.Size(72, 25);
            group_idLabel.TabIndex = 17;
            group_idLabel.Text = "Group:";
            // 
            // locker_idLabel
            // 
            locker_idLabel.AutoSize = true;
            locker_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            locker_idLabel.Location = new System.Drawing.Point(37, 300);
            locker_idLabel.Name = "locker_idLabel";
            locker_idLabel.Size = new System.Drawing.Size(77, 25);
            locker_idLabel.TabIndex = 19;
            locker_idLabel.Text = "Locker:";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(42, 351);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(158, 39);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(224, 351);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 39);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(191, 32);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.firstNameTextBox.TabIndex = 26;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.Location = new System.Drawing.Point(191, 65);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.lastNameTextBox.TabIndex = 27;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameTextBox.Location = new System.Drawing.Point(191, 98);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.middleNameTextBox.TabIndex = 28;
            // 
            // lockerIdTextBox
            // 
            this.lockerIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lockerIdTextBox.Location = new System.Drawing.Point(191, 301);
            this.lockerIdTextBox.Name = "lockerIdTextBox";
            this.lockerIdTextBox.Size = new System.Drawing.Size(193, 27);
            this.lockerIdTextBox.TabIndex = 29;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(191, 163);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(193, 27);
            this.dateOfBirthDateTimePicker.TabIndex = 30;
            this.dateOfBirthDateTimePicker.Value = new System.DateTime(2022, 10, 18, 21, 7, 4, 0);
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexComboBox.Location = new System.Drawing.Point(191, 130);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(193, 28);
            this.sexComboBox.TabIndex = 31;
            // 
            // clientTypeComboBox
            // 
            this.clientTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientTypeComboBox.FormattingEnabled = true;
            this.clientTypeComboBox.Items.AddRange(new object[] {
            "Amateur",
            "Sportsman"});
            this.clientTypeComboBox.Location = new System.Drawing.Point(191, 196);
            this.clientTypeComboBox.Name = "clientTypeComboBox";
            this.clientTypeComboBox.Size = new System.Drawing.Size(193, 28);
            this.clientTypeComboBox.TabIndex = 32;
            // 
            // medicalGroupComboBox
            // 
            this.medicalGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medicalGroupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicalGroupComboBox.FormattingEnabled = true;
            this.medicalGroupComboBox.Items.AddRange(new object[] {
            "Main",
            "Preparatory",
            "Special"});
            this.medicalGroupComboBox.Location = new System.Drawing.Point(191, 232);
            this.medicalGroupComboBox.Name = "medicalGroupComboBox";
            this.medicalGroupComboBox.Size = new System.Drawing.Size(193, 28);
            this.medicalGroupComboBox.TabIndex = 33;
            // 
            // groupIdComboBox
            // 
            this.groupIdComboBox.DataSource = this.groupsBindingSource;
            this.groupIdComboBox.DisplayMember = "group_id";
            this.groupIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupIdComboBox.FormattingEnabled = true;
            this.groupIdComboBox.Location = new System.Drawing.Point(191, 266);
            this.groupIdComboBox.Name = "groupIdComboBox";
            this.groupIdComboBox.Size = new System.Drawing.Size(193, 28);
            this.groupIdComboBox.TabIndex = 34;
            this.groupIdComboBox.ValueMember = "group_id";
            // 
            // EditClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 417);
            this.Controls.Add(this.groupIdComboBox);
            this.Controls.Add(this.medicalGroupComboBox);
            this.Controls.Add(this.clientTypeComboBox);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.lockerIdTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(middle_nameLabel);
            this.Controls.Add(sexLabel);
            this.Controls.Add(date_of_birthLabel);
            this.Controls.Add(client_typeLabel);
            this.Controls.Add(medical_groupLabel);
            this.Controls.Add(group_idLabel);
            this.Controls.Add(locker_idLabel);
            this.Name = "EditClients";
            this.Text = "EditClients";
            this.Load += new System.EventHandler(this.EditClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lockerIdTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.ComboBox clientTypeComboBox;
        private System.Windows.Forms.ComboBox medicalGroupComboBox;
        private System.Windows.Forms.ComboBox groupIdComboBox;
    }
}