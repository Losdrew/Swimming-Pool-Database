namespace Swimming_Pool_Database.Forms
{
    partial class LoginForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.regButton = new System.Windows.Forms.Button();
            this.regPasswordTextBox = new System.Windows.Forms.TextBox();
            this.regLoginTextBox = new System.Windows.Forms.TextBox();
            this.regPasswordLabel = new System.Windows.Forms.Label();
            this.regLoginLabel = new System.Windows.Forms.Label();
            this.regRepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.regRepeatPasswordLabel = new System.Windows.Forms.Label();
            this.authButton = new System.Windows.Forms.Button();
            this.authPasswordTextBox = new System.Windows.Forms.TextBox();
            this.authLoginTextBox = new System.Windows.Forms.TextBox();
            this.authPasswordLabel = new System.Windows.Forms.Label();
            this.authLoginLabel = new System.Windows.Forms.Label();
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            this.clientsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.ClientsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.authButton);
            this.tabPage1.Controls.Add(this.authPasswordTextBox);
            this.tabPage1.Controls.Add(this.authLoginTextBox);
            this.tabPage1.Controls.Add(this.authPasswordLabel);
            this.tabPage1.Controls.Add(this.authLoginLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизація";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.regRepeatPasswordTextBox);
            this.tabPage2.Controls.Add(this.regRepeatPasswordLabel);
            this.tabPage2.Controls.Add(this.regButton);
            this.tabPage2.Controls.Add(this.regPasswordTextBox);
            this.tabPage2.Controls.Add(this.regLoginTextBox);
            this.tabPage2.Controls.Add(this.regPasswordLabel);
            this.tabPage2.Controls.Add(this.regLoginLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Реєстрація";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(191, 204);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(159, 41);
            this.regButton.TabIndex = 9;
            this.regButton.Text = "Реєстрація";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // regPasswordTextBox
            // 
            this.regPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPasswordTextBox.Location = new System.Drawing.Point(250, 93);
            this.regPasswordTextBox.Name = "regPasswordTextBox";
            this.regPasswordTextBox.Size = new System.Drawing.Size(210, 27);
            this.regPasswordTextBox.TabIndex = 8;
            this.regPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // regLoginTextBox
            // 
            this.regLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLoginTextBox.Location = new System.Drawing.Point(250, 54);
            this.regLoginTextBox.Name = "regLoginTextBox";
            this.regLoginTextBox.Size = new System.Drawing.Size(210, 27);
            this.regLoginTextBox.TabIndex = 7;
            // 
            // regPasswordLabel
            // 
            this.regPasswordLabel.AutoSize = true;
            this.regPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPasswordLabel.Location = new System.Drawing.Point(51, 95);
            this.regPasswordLabel.Name = "regPasswordLabel";
            this.regPasswordLabel.Size = new System.Drawing.Size(86, 25);
            this.regPasswordLabel.TabIndex = 6;
            this.regPasswordLabel.Text = "Пароль:";
            // 
            // regLoginLabel
            // 
            this.regLoginLabel.AutoSize = true;
            this.regLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLoginLabel.Location = new System.Drawing.Point(51, 54);
            this.regLoginLabel.Name = "regLoginLabel";
            this.regLoginLabel.Size = new System.Drawing.Size(67, 25);
            this.regLoginLabel.TabIndex = 5;
            this.regLoginLabel.Text = "Логін:";
            // 
            // regRepeatPasswordTextBox
            // 
            this.regRepeatPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regRepeatPasswordTextBox.Location = new System.Drawing.Point(250, 136);
            this.regRepeatPasswordTextBox.Name = "regRepeatPasswordTextBox";
            this.regRepeatPasswordTextBox.Size = new System.Drawing.Size(210, 27);
            this.regRepeatPasswordTextBox.TabIndex = 11;
            this.regRepeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // regRepeatPasswordLabel
            // 
            this.regRepeatPasswordLabel.AutoSize = true;
            this.regRepeatPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regRepeatPasswordLabel.Location = new System.Drawing.Point(51, 136);
            this.regRepeatPasswordLabel.Name = "regRepeatPasswordLabel";
            this.regRepeatPasswordLabel.Size = new System.Drawing.Size(183, 25);
            this.regRepeatPasswordLabel.TabIndex = 10;
            this.regRepeatPasswordLabel.Text = "Повторіть пароль:";
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(190, 170);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(159, 41);
            this.authButton.TabIndex = 16;
            this.authButton.Text = "Вхід";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // authPasswordTextBox
            // 
            this.authPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authPasswordTextBox.Location = new System.Drawing.Point(222, 100);
            this.authPasswordTextBox.Name = "authPasswordTextBox";
            this.authPasswordTextBox.Size = new System.Drawing.Size(210, 27);
            this.authPasswordTextBox.TabIndex = 15;
            this.authPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // authLoginTextBox
            // 
            this.authLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLoginTextBox.Location = new System.Drawing.Point(222, 61);
            this.authLoginTextBox.Name = "authLoginTextBox";
            this.authLoginTextBox.Size = new System.Drawing.Size(210, 27);
            this.authLoginTextBox.TabIndex = 14;
            // 
            // authPasswordLabel
            // 
            this.authPasswordLabel.AutoSize = true;
            this.authPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authPasswordLabel.Location = new System.Drawing.Point(108, 101);
            this.authPasswordLabel.Name = "authPasswordLabel";
            this.authPasswordLabel.Size = new System.Drawing.Size(86, 25);
            this.authPasswordLabel.TabIndex = 13;
            this.authPasswordLabel.Text = "Пароль:";
            // 
            // authLoginLabel
            // 
            this.authLoginLabel.AutoSize = true;
            this.authLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLoginLabel.Location = new System.Drawing.Point(108, 60);
            this.authLoginLabel.Name = "authLoginLabel";
            this.authLoginLabel.Size = new System.Drawing.Size(67, 25);
            this.authLoginLabel.TabIndex = 12;
            this.authLoginLabel.Text = "Логін:";
            // 
            // swimmingpoolDataSet
            // 
            this.swimmingpoolDataSet.DataSetName = "swimmingpoolDataSet";
            this.swimmingpoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 321);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід у систему";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox regRepeatPasswordTextBox;
        private System.Windows.Forms.Label regRepeatPasswordLabel;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox regPasswordTextBox;
        private System.Windows.Forms.TextBox regLoginTextBox;
        private System.Windows.Forms.Label regPasswordLabel;
        private System.Windows.Forms.Label regLoginLabel;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.TextBox authPasswordTextBox;
        private System.Windows.Forms.TextBox authLoginTextBox;
        private System.Windows.Forms.Label authPasswordLabel;
        private System.Windows.Forms.Label authLoginLabel;
        private swimmingpoolDataSet swimmingpoolDataSet;
        private swimmingpoolDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}