namespace Swimming_Pool_Database.Forms
{
    partial class EditSwimLanes
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            this.poolComboBox = new System.Windows.Forms.ComboBox();
            this.poolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.poolsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.PoolsTableAdapter();
            this.swimLanesTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter();
            this.swimLaneIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poolsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLaneIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            firstNameLabel.Location = new System.Drawing.Point(33, 29);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(162, 25);
            firstNameLabel.TabIndex = 57;
            firstNameLabel.Text = "Номер доріжки:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lastNameLabel.Location = new System.Drawing.Point(33, 62);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(160, 25);
            lastNameLabel.TabIndex = 58;
            lastNameLabel.Text = "Номер басейна:";
            // 
            // poolComboBox
            // 
            this.poolComboBox.DataSource = this.poolsBindingSource;
            this.poolComboBox.DisplayMember = "pool_id";
            this.poolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poolComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poolComboBox.FormattingEnabled = true;
            this.poolComboBox.Location = new System.Drawing.Point(248, 62);
            this.poolComboBox.Name = "poolComboBox";
            this.poolComboBox.Size = new System.Drawing.Size(132, 28);
            this.poolComboBox.TabIndex = 66;
            this.poolComboBox.ValueMember = "pool_id";
            // 
            // poolsBindingSource
            // 
            this.poolsBindingSource.DataMember = "Pools";
            this.poolsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // swimmingpoolDataSet
            // 
            this.swimmingpoolDataSet.DataSetName = "swimmingpoolDataSet";
            this.swimmingpoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(220, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 39);
            this.cancelButton.TabIndex = 62;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(38, 120);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(158, 39);
            this.acceptButton.TabIndex = 61;
            this.acceptButton.Text = "Підтвердити";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // poolsTableAdapter
            // 
            this.poolsTableAdapter.ClearBeforeFill = true;
            // 
            // swimLanesTableAdapter
            // 
            this.swimLanesTableAdapter.ClearBeforeFill = true;
            // 
            // swimLaneIdNumericUpDown
            // 
            this.swimLaneIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.swimLaneIdNumericUpDown.Location = new System.Drawing.Point(248, 29);
            this.swimLaneIdNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.swimLaneIdNumericUpDown.Name = "swimLaneIdNumericUpDown";
            this.swimLaneIdNumericUpDown.Size = new System.Drawing.Size(76, 27);
            this.swimLaneIdNumericUpDown.TabIndex = 67;
            // 
            // EditSwimLanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 202);
            this.Controls.Add(this.swimLaneIdNumericUpDown);
            this.Controls.Add(this.poolComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Name = "EditSwimLanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування доріжок";
            ((System.ComponentModel.ISupportInitialize)(this.poolsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLaneIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox poolComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private swimmingpoolDataSet swimmingpoolDataSet;
        private System.Windows.Forms.BindingSource poolsBindingSource;
        private swimmingpoolDataSetTableAdapters.PoolsTableAdapter poolsTableAdapter;
        private swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter swimLanesTableAdapter;
        private System.Windows.Forms.NumericUpDown swimLaneIdNumericUpDown;
    }
}