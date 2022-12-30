namespace Swimming_Pool_Database.Forms
{
    partial class EditSubscriptions
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label attendanceCountLabel;
            System.Windows.Forms.Label dayCountLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.attendanceCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dayCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.subscriptionsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter();
            this.subscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            attendanceCountLabel = new System.Windows.Forms.Label();
            dayCountLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(35, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(72, 25);
            nameLabel.TabIndex = 35;
            nameLabel.Text = "Назва:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priceLabel.Location = new System.Drawing.Point(35, 68);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(57, 25);
            priceLabel.TabIndex = 36;
            priceLabel.Text = "Ціна:";
            // 
            // attendanceCountLabel
            // 
            attendanceCountLabel.AutoSize = true;
            attendanceCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            attendanceCountLabel.Location = new System.Drawing.Point(35, 100);
            attendanceCountLabel.Name = "attendanceCountLabel";
            attendanceCountLabel.Size = new System.Drawing.Size(209, 25);
            attendanceCountLabel.TabIndex = 37;
            attendanceCountLabel.Text = "Кількість відвідувань:";
            // 
            // dayCountLabel
            // 
            dayCountLabel.AutoSize = true;
            dayCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dayCountLabel.Location = new System.Drawing.Point(35, 134);
            dayCountLabel.Name = "dayCountLabel";
            dayCountLabel.Size = new System.Drawing.Size(102, 25);
            dayCountLabel.TabIndex = 38;
            dayCountLabel.Text = "Строк дії:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(356, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(23, 25);
            label1.TabIndex = 50;
            label1.Text = "₴";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(356, 134);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 25);
            label2.TabIndex = 51;
            label2.Text = "днів";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(260, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(193, 27);
            this.nameTextBox.TabIndex = 43;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(250, 196);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 39);
            this.cancelButton.TabIndex = 42;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(68, 196);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(158, 39);
            this.acceptButton.TabIndex = 41;
            this.acceptButton.Text = "Підтвердити";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceNumericUpDown.Location = new System.Drawing.Point(260, 68);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(90, 27);
            this.priceNumericUpDown.TabIndex = 47;
            // 
            // attendanceCountNumericUpDown
            // 
            this.attendanceCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attendanceCountNumericUpDown.Location = new System.Drawing.Point(260, 101);
            this.attendanceCountNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.attendanceCountNumericUpDown.Name = "attendanceCountNumericUpDown";
            this.attendanceCountNumericUpDown.Size = new System.Drawing.Size(90, 27);
            this.attendanceCountNumericUpDown.TabIndex = 48;
            // 
            // dayCountNumericUpDown
            // 
            this.dayCountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayCountNumericUpDown.Location = new System.Drawing.Point(260, 134);
            this.dayCountNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.dayCountNumericUpDown.Name = "dayCountNumericUpDown";
            this.dayCountNumericUpDown.Size = new System.Drawing.Size(90, 27);
            this.dayCountNumericUpDown.TabIndex = 49;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsBindingSource
            // 
            this.subscriptionsBindingSource.DataMember = "Subscriptions";
            this.subscriptionsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // swimmingpoolDataSet
            // 
            this.swimmingpoolDataSet.DataSetName = "swimmingpoolDataSet";
            this.swimmingpoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EditSubscriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 279);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dayCountNumericUpDown);
            this.Controls.Add(this.attendanceCountNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(nameLabel);
            this.Controls.Add(priceLabel);
            this.Controls.Add(attendanceCountLabel);
            this.Controls.Add(dayCountLabel);
            this.Name = "EditSubscriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання нового абонемента";
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown attendanceCountNumericUpDown;
        private System.Windows.Forms.NumericUpDown dayCountNumericUpDown;
        private swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter subscriptionsTableAdapter;
        private System.Windows.Forms.BindingSource subscriptionsBindingSource;
        private swimmingpoolDataSet swimmingpoolDataSet;
    }
}