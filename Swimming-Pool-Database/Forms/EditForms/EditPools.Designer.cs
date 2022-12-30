namespace Swimming_Pool_Database.Forms
{
    partial class EditPools
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.capacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.poolsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.PoolsTableAdapter();
            this.poolIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(42, 31);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(160, 25);
            firstNameLabel.TabIndex = 67;
            firstNameLabel.Text = "Номер басейна:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(42, 64);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(106, 25);
            lastNameLabel.TabIndex = 68;
            lastNameLabel.Text = "Місткість:";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(202, 124);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 39);
            this.cancelButton.TabIndex = 70;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(20, 124);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(158, 39);
            this.acceptButton.TabIndex = 69;
            this.acceptButton.Text = "Підтвердити";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // capacityNumericUpDown
            // 
            this.capacityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capacityNumericUpDown.Location = new System.Drawing.Point(256, 64);
            this.capacityNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.capacityNumericUpDown.Name = "capacityNumericUpDown";
            this.capacityNumericUpDown.Size = new System.Drawing.Size(68, 27);
            this.capacityNumericUpDown.TabIndex = 72;
            // 
            // poolsTableAdapter
            // 
            this.poolsTableAdapter.ClearBeforeFill = true;
            // 
            // poolIdNumericUpDown
            // 
            this.poolIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poolIdNumericUpDown.Location = new System.Drawing.Point(256, 31);
            this.poolIdNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.poolIdNumericUpDown.Name = "poolIdNumericUpDown";
            this.poolIdNumericUpDown.Size = new System.Drawing.Size(68, 27);
            this.poolIdNumericUpDown.TabIndex = 73;
            // 
            // EditPools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 201);
            this.Controls.Add(this.poolIdNumericUpDown);
            this.Controls.Add(this.capacityNumericUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Name = "EditPools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання нового басейна";
            ((System.ComponentModel.ISupportInitialize)(this.capacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.NumericUpDown capacityNumericUpDown;
        private swimmingpoolDataSetTableAdapters.PoolsTableAdapter poolsTableAdapter;
        private System.Windows.Forms.NumericUpDown poolIdNumericUpDown;
    }
}