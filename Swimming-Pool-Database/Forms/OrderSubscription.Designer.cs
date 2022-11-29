namespace Swimming_Pool_Database.Forms
{
    partial class OrderSubscription
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label preparationLevelLabel;
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.subscriptionNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.attendanceCountTextBox = new System.Windows.Forms.TextBox();
            this.visitorCardsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter();
            this.preparationLevelTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.expiryDateTextBox = new System.Windows.Forms.TextBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            preparationLevelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(48, 198);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(55, 25);
            firstNameLabel.TabIndex = 39;
            firstNameLabel.Text = "Ім\'я:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(48, 231);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(107, 25);
            lastNameLabel.TabIndex = 40;
            lastNameLabel.Text = "Прізвище:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middleNameLabel.Location = new System.Drawing.Point(48, 264);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(128, 25);
            middleNameLabel.TabIndex = 41;
            middleNameLabel.Text = "По-батькові:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(48, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 25);
            label1.TabIndex = 59;
            label1.Text = "Назва абонемента:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(48, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 25);
            label2.TabIndex = 61;
            label2.Text = "До сплати:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(48, 99);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(209, 25);
            label3.TabIndex = 63;
            label3.Text = "Кількість відвідувань:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(48, 132);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(173, 25);
            label5.TabIndex = 67;
            label5.Text = "Дата початку дії:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(48, 165);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(200, 25);
            label4.TabIndex = 69;
            label4.Text = "Дата закінчення дії:";
            // 
            // preparationLevelLabel
            // 
            preparationLevelLabel.AutoSize = true;
            preparationLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            preparationLevelLabel.Location = new System.Drawing.Point(48, 297);
            preparationLevelLabel.Name = "preparationLevelLabel";
            preparationLevelLabel.Size = new System.Drawing.Size(181, 25);
            preparationLevelLabel.TabIndex = 72;
            preparationLevelLabel.Text = "Рівень підготовки:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameTextBox.Location = new System.Drawing.Point(263, 264);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.ReadOnly = true;
            this.middleNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.middleNameTextBox.TabIndex = 49;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.Location = new System.Drawing.Point(263, 231);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.lastNameTextBox.TabIndex = 48;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(263, 198);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.firstNameTextBox.TabIndex = 47;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(263, 358);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 39);
            this.cancelButton.TabIndex = 46;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.Location = new System.Drawing.Point(81, 358);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(158, 39);
            this.orderButton.TabIndex = 45;
            this.orderButton.Text = "Оформити";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // subscriptionNameTextBox
            // 
            this.subscriptionNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionNameTextBox.Location = new System.Drawing.Point(263, 33);
            this.subscriptionNameTextBox.Name = "subscriptionNameTextBox";
            this.subscriptionNameTextBox.ReadOnly = true;
            this.subscriptionNameTextBox.Size = new System.Drawing.Size(193, 27);
            this.subscriptionNameTextBox.TabIndex = 60;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(263, 66);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(193, 27);
            this.priceTextBox.TabIndex = 62;
            // 
            // attendanceCountTextBox
            // 
            this.attendanceCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attendanceCountTextBox.Location = new System.Drawing.Point(263, 99);
            this.attendanceCountTextBox.Name = "attendanceCountTextBox";
            this.attendanceCountTextBox.ReadOnly = true;
            this.attendanceCountTextBox.Size = new System.Drawing.Size(193, 27);
            this.attendanceCountTextBox.TabIndex = 64;
            // 
            // visitorCardsTableAdapter
            // 
            this.visitorCardsTableAdapter.ClearBeforeFill = true;
            // 
            // preparationLevelTextBox
            // 
            this.preparationLevelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preparationLevelTextBox.Location = new System.Drawing.Point(263, 297);
            this.preparationLevelTextBox.Name = "preparationLevelTextBox";
            this.preparationLevelTextBox.ReadOnly = true;
            this.preparationLevelTextBox.Size = new System.Drawing.Size(193, 27);
            this.preparationLevelTextBox.TabIndex = 73;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateTextBox.Location = new System.Drawing.Point(263, 132);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.ReadOnly = true;
            this.startDateTextBox.Size = new System.Drawing.Size(193, 27);
            this.startDateTextBox.TabIndex = 74;
            // 
            // expiryDateTextBox
            // 
            this.expiryDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expiryDateTextBox.Location = new System.Drawing.Point(263, 165);
            this.expiryDateTextBox.Name = "expiryDateTextBox";
            this.expiryDateTextBox.ReadOnly = true;
            this.expiryDateTextBox.Size = new System.Drawing.Size(193, 27);
            this.expiryDateTextBox.TabIndex = 75;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // OrderSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 430);
            this.Controls.Add(this.expiryDateTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.preparationLevelTextBox);
            this.Controls.Add(preparationLevelLabel);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(this.attendanceCountTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.subscriptionNameTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(middleNameLabel);
            this.Name = "OrderSubscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформлення абонемента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.TextBox subscriptionNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox attendanceCountTextBox;
        private swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter visitorCardsTableAdapter;
        private System.Windows.Forms.TextBox preparationLevelTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox expiryDateTextBox;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}