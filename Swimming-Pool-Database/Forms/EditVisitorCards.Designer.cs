namespace Swimming_Pool_Database.Forms
{
    partial class EditVisitorCards
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.visitorCardsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter();
            this.subscriptionComboBox = new System.Windows.Forms.ComboBox();
            this.subscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            this.subscriptionsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.ClientsTableAdapter();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.attendanceLeftCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLeftCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(61, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 25);
            label1.TabIndex = 59;
            label1.Text = "Абонемент:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(61, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 25);
            label2.TabIndex = 61;
            label2.Text = "Клієнт:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(61, 169);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(241, 25);
            label3.TabIndex = 63;
            label3.Text = "Залишилось відвідувань:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(61, 103);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(173, 25);
            label5.TabIndex = 67;
            label5.Text = "Дата початку дії:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(61, 134);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(200, 25);
            label4.TabIndex = 69;
            label4.Text = "Дата закінчення дії:";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(328, 231);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 39);
            this.cancelButton.TabIndex = 46;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(146, 231);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(158, 39);
            this.acceptButton.TabIndex = 45;
            this.acceptButton.Text = "Підтвердити";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // visitorCardsTableAdapter
            // 
            this.visitorCardsTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionComboBox
            // 
            this.subscriptionComboBox.DataSource = this.subscriptionsBindingSource;
            this.subscriptionComboBox.DisplayMember = "name";
            this.subscriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subscriptionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionComboBox.FormattingEnabled = true;
            this.subscriptionComboBox.Location = new System.Drawing.Point(316, 35);
            this.subscriptionComboBox.MaxDropDownItems = 100;
            this.subscriptionComboBox.Name = "subscriptionComboBox";
            this.subscriptionComboBox.Size = new System.Drawing.Size(254, 28);
            this.subscriptionComboBox.TabIndex = 71;
            this.subscriptionComboBox.ValueMember = "subscription_id";
            // 
            // subscriptionsBindingSource
            // 
            this.subscriptionsBindingSource.DataMember = "Subscriptions";
            this.subscriptionsBindingSource.DataSource = this.swimmingpoolDataSet;
            this.subscriptionsBindingSource.CurrentChanged += new System.EventHandler(this.SubscriptionsBindingSource_CurrentChanged);
            // 
            // swimmingpoolDataSet
            // 
            this.swimmingpoolDataSet.DataSetName = "swimmingpoolDataSet";
            this.swimmingpoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientsBindingSource;
            this.clientComboBox.DisplayMember = "first_name";
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(316, 69);
            this.clientComboBox.MaxDropDownItems = 100;
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(254, 28);
            this.clientComboBox.TabIndex = 72;
            this.clientComboBox.ValueMember = "client_id";
            this.clientComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientComboBox_Format);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateTimePicker.Location = new System.Drawing.Point(316, 103);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(212, 27);
            this.startDateTimePicker.TabIndex = 73;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // expiryDateTimePicker
            // 
            this.expiryDateTimePicker.Enabled = false;
            this.expiryDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryDateTimePicker.Location = new System.Drawing.Point(316, 136);
            this.expiryDateTimePicker.Name = "expiryDateTimePicker";
            this.expiryDateTimePicker.Size = new System.Drawing.Size(212, 27);
            this.expiryDateTimePicker.TabIndex = 74;
            // 
            // attendanceLeftCountNumericUpDown
            // 
            this.attendanceLeftCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attendanceLeftCountNumericUpDown.Location = new System.Drawing.Point(316, 169);
            this.attendanceLeftCountNumericUpDown.Name = "attendanceLeftCountNumericUpDown";
            this.attendanceLeftCountNumericUpDown.Size = new System.Drawing.Size(69, 27);
            this.attendanceLeftCountNumericUpDown.TabIndex = 75;
            // 
            // EditVisitorCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 305);
            this.Controls.Add(this.attendanceLeftCountNumericUpDown);
            this.Controls.Add(this.expiryDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.subscriptionComboBox);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "EditVisitorCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування картки відвідувача";
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLeftCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter visitorCardsTableAdapter;
        private System.Windows.Forms.ComboBox subscriptionComboBox;
        private System.Windows.Forms.BindingSource subscriptionsBindingSource;
        private swimmingpoolDataSet swimmingpoolDataSet;
        private swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter subscriptionsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private swimmingpoolDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker expiryDateTimePicker;
        private System.Windows.Forms.NumericUpDown attendanceLeftCountNumericUpDown;
    }
}