namespace Swimming_Pool_Database.Forms
{
    partial class EditTrainings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            this.lockerIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            this.visitorCardsComboBox = new System.Windows.Forms.ComboBox();
            this.visitorCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.ClientsTableAdapter();
            this.visitorCardsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter();
            this.swimLanesComboBox = new System.Windows.Forms.ComboBox();
            this.swimLanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimLanesTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter();
            this.trainingsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TrainingsTableAdapter();
            this.subscriptionsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter();
            this.instructorsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.InstructorsTableAdapter();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lockerIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(33, 166);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(157, 25);
            label4.TabIndex = 82;
            label4.Text = "Час закінчення:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(33, 133);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(130, 25);
            label5.TabIndex = 81;
            label5.Text = "Час початку:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(33, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(183, 25);
            label3.TabIndex = 80;
            label3.Text = "Номер шкафчика:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(33, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 25);
            label2.TabIndex = 79;
            label2.Text = "Клієнт:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(33, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(190, 25);
            label1.TabIndex = 78;
            label1.Text = "Картка відвідувача:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(33, 99);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(162, 25);
            label6.TabIndex = 89;
            label6.Text = "Номер доріжки:";
            // 
            // lockerIdNumericUpDown
            // 
            this.lockerIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lockerIdNumericUpDown.Location = new System.Drawing.Point(243, 199);
            this.lockerIdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lockerIdNumericUpDown.Name = "lockerIdNumericUpDown";
            this.lockerIdNumericUpDown.Size = new System.Drawing.Size(69, 27);
            this.lockerIdNumericUpDown.TabIndex = 87;
            this.lockerIdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(243, 166);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(212, 27);
            this.endDateTimePicker.TabIndex = 86;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.EndDateTimePicker_ValueChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(243, 133);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(212, 27);
            this.startDateTimePicker.TabIndex = 85;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientsBindingSource;
            this.clientComboBox.DisplayMember = "first_name";
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(243, 32);
            this.clientComboBox.MaxDropDownItems = 100;
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(254, 28);
            this.clientComboBox.TabIndex = 84;
            this.clientComboBox.ValueMember = "client_id";
            this.clientComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientComboBox_Format);
            this.clientComboBox.SelectedValueChanged += new System.EventHandler(this.ClientsBindingSource_CurrentChanged);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // swimmingpoolDataSet
            // 
            this.swimmingpoolDataSet.DataSetName = "swimmingpoolDataSet";
            this.swimmingpoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitorCardsComboBox
            // 
            this.visitorCardsComboBox.DataSource = this.visitorCardsBindingSource;
            this.visitorCardsComboBox.DisplayMember = "card_id";
            this.visitorCardsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visitorCardsComboBox.DropDownWidth = 1;
            this.visitorCardsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitorCardsComboBox.FormattingEnabled = true;
            this.visitorCardsComboBox.Location = new System.Drawing.Point(243, 65);
            this.visitorCardsComboBox.MaxDropDownItems = 100;
            this.visitorCardsComboBox.Name = "visitorCardsComboBox";
            this.visitorCardsComboBox.Size = new System.Drawing.Size(254, 28);
            this.visitorCardsComboBox.TabIndex = 83;
            this.visitorCardsComboBox.ValueMember = "card_id";
            this.visitorCardsComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.VisitorCardsComboBox_Format);
            // 
            // visitorCardsBindingSource
            // 
            this.visitorCardsBindingSource.DataMember = "VisitorCards";
            this.visitorCardsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(261, 258);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 39);
            this.cancelButton.TabIndex = 77;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(79, 258);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(158, 39);
            this.acceptButton.TabIndex = 76;
            this.acceptButton.Text = "Підтвердити";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // visitorCardsTableAdapter
            // 
            this.visitorCardsTableAdapter.ClearBeforeFill = true;
            // 
            // swimLanesComboBox
            // 
            this.swimLanesComboBox.DataSource = this.swimLanesBindingSource;
            this.swimLanesComboBox.DisplayMember = "swimlane_id";
            this.swimLanesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.swimLanesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.swimLanesComboBox.FormattingEnabled = true;
            this.swimLanesComboBox.Location = new System.Drawing.Point(243, 99);
            this.swimLanesComboBox.MaxDropDownItems = 100;
            this.swimLanesComboBox.Name = "swimLanesComboBox";
            this.swimLanesComboBox.Size = new System.Drawing.Size(105, 28);
            this.swimLanesComboBox.TabIndex = 88;
            this.swimLanesComboBox.ValueMember = "swimlane_id";
            // 
            // swimLanesBindingSource
            // 
            this.swimLanesBindingSource.DataMember = "SwimLanes";
            this.swimLanesBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // swimLanesTableAdapter
            // 
            this.swimLanesTableAdapter.ClearBeforeFill = true;
            // 
            // trainingsTableAdapter
            // 
            this.trainingsTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // EditTrainings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 332);
            this.Controls.Add(label6);
            this.Controls.Add(this.swimLanesComboBox);
            this.Controls.Add(this.lockerIdNumericUpDown);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.visitorCardsComboBox);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "EditTrainings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування тренувань";
            this.Load += new System.EventHandler(this.EditTrainings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lockerIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lockerIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.ComboBox visitorCardsComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private swimmingpoolDataSet swimmingpoolDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private swimmingpoolDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource visitorCardsBindingSource;
        private swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter visitorCardsTableAdapter;
        private System.Windows.Forms.ComboBox swimLanesComboBox;
        private System.Windows.Forms.BindingSource swimLanesBindingSource;
        private swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter swimLanesTableAdapter;
        private swimmingpoolDataSetTableAdapters.TrainingsTableAdapter trainingsTableAdapter;
        private swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter subscriptionsTableAdapter;
        private swimmingpoolDataSetTableAdapters.InstructorsTableAdapter instructorsTableAdapter;
    }
}