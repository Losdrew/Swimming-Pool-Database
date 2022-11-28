using System.Windows.Forms;

namespace Swimming_Pool_Database.Forms
{
    partial class AdminMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TableAdapterManager();
            this.subscriptionsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.clientsTabPage = new System.Windows.Forms.TabPage();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparationlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.beginnerRadioButton = new System.Windows.Forms.RadioButton();
            this.amateurRadioButton = new System.Windows.Forms.RadioButton();
            this.sportsmanRadioButton = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.filterPreparationLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.filterSexCheckBox = new System.Windows.Forms.CheckBox();
            this.filterDateCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filterToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.filterFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.editClientButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.subscriptionsTabPage = new System.Windows.Forms.TabPage();
            this.subscriptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.subscriptionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daycountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteSubscriptionButton = new System.Windows.Forms.Button();
            this.editSubscriptionButton = new System.Windows.Forms.Button();
            this.addSubscriptionButton = new System.Windows.Forms.Button();
            this.visitorCardsTabPage = new System.Windows.Forms.TabPage();
            this.visitorCardsDataGridView = new System.Windows.Forms.DataGridView();
            this.cardidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.client_idLastName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.client_idMiddleName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceleftcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.deleteVisitorCardButton = new System.Windows.Forms.Button();
            this.editVisitorCardButton = new System.Windows.Forms.Button();
            this.addVisitorCardButton = new System.Windows.Forms.Button();
            this.trainingsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TrainingsTableAdapter();
            this.subscriptionsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter();
            this.subscriptionsViewTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SubscriptionsViewTableAdapter();
            this.visitorCardsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsViewBindingSource)).BeginInit();
            this.tabControl.SuspendLayout();
            this.clientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.subscriptionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.visitorCardsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1044, 28);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.exitToolStripMenuItem.Text = "Вийти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // swimmingpoolDataSet
            // 
            this.swimmingpoolDataSet.DataSetName = "swimmingpoolDataSet";
            this.swimmingpoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.InstructorsTableAdapter = null;
            this.tableAdapterManager.PoolsTableAdapter = null;
            this.tableAdapterManager.SubscriptionsTableAdapter = null;
            this.tableAdapterManager.SwimLanesTableAdapter = null;
            this.tableAdapterManager.TrainingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorCardsTableAdapter = null;
            // 
            // subscriptionsViewBindingSource
            // 
            this.subscriptionsViewBindingSource.DataMember = "SubscriptionsView";
            this.subscriptionsViewBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.clientsTabPage);
            this.tabControl.Controls.Add(this.subscriptionsTabPage);
            this.tabControl.Controls.Add(this.visitorCardsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1044, 655);
            this.tabControl.TabIndex = 6;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // clientsTabPage
            // 
            this.clientsTabPage.AutoScroll = true;
            this.clientsTabPage.Controls.Add(this.clientsDataGridView);
            this.clientsTabPage.Controls.Add(this.searchGroupBox);
            this.clientsTabPage.Controls.Add(this.filterGroupBox);
            this.clientsTabPage.Controls.Add(this.panel2);
            this.clientsTabPage.Location = new System.Drawing.Point(4, 27);
            this.clientsTabPage.Name = "clientsTabPage";
            this.clientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientsTabPage.Size = new System.Drawing.Size(1036, 624);
            this.clientsTabPage.TabIndex = 0;
            this.clientsTabPage.Text = "Клієнти";
            this.clientsTabPage.UseVisualStyleBackColor = true;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.dateofbirthDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.preparationlevelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.RowHeadersWidth = 51;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.Size = new System.Drawing.Size(1030, 211);
            this.clientsDataGridView.TabIndex = 4;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn.Visible = false;
            this.clientidDataGridViewTextBoxColumn.Width = 90;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 62;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 102;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "По-батькові";
            this.middlenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.middlenameDataGridViewTextBoxColumn.Width = 122;
            // 
            // dateofbirthDataGridViewTextBoxColumn
            // 
            this.dateofbirthDataGridViewTextBoxColumn.DataPropertyName = "date_of_birth";
            this.dateofbirthDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.dateofbirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateofbirthDataGridViewTextBoxColumn.Name = "dateofbirthDataGridViewTextBoxColumn";
            this.dateofbirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateofbirthDataGridViewTextBoxColumn.Width = 147;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            this.sexDataGridViewTextBoxColumn.Width = 78;
            // 
            // preparationlevelDataGridViewTextBoxColumn
            // 
            this.preparationlevelDataGridViewTextBoxColumn.DataPropertyName = "preparation_level";
            this.preparationlevelDataGridViewTextBoxColumn.HeaderText = "Рівень підготовки";
            this.preparationlevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preparationlevelDataGridViewTextBoxColumn.Name = "preparationlevelDataGridViewTextBoxColumn";
            this.preparationlevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.preparationlevelDataGridViewTextBoxColumn.Width = 147;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Електронна адреса";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 158;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логін";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 74;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 90;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.middleNameTextBox);
            this.searchGroupBox.Controls.Add(this.lastNameTextBox);
            this.searchGroupBox.Controls.Add(this.firstNameTextBox);
            this.searchGroupBox.Controls.Add(this.firstNameLabel);
            this.searchGroupBox.Controls.Add(this.lastNameLabel);
            this.searchGroupBox.Controls.Add(this.middleNameLabel);
            this.searchGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchGroupBox.Location = new System.Drawing.Point(3, 214);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(1030, 122);
            this.searchGroupBox.TabIndex = 4;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Пошук клієнтів";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(458, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 38);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Шукати";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SetFiltering);
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameTextBox.Location = new System.Drawing.Point(825, 30);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(187, 27);
            this.middleNameTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextBox.Location = new System.Drawing.Point(437, 30);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(187, 27);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(58, 30);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(187, 27);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(8, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(44, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Ім\'я:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(337, 33);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(94, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Прізвище:";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameLabel.Location = new System.Drawing.Point(703, 33);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(116, 20);
            this.middleNameLabel.TabIndex = 3;
            this.middleNameLabel.Text = "По-батькові:";
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.filterButton);
            this.filterGroupBox.Controls.Add(this.panel5);
            this.filterGroupBox.Controls.Add(this.panel4);
            this.filterGroupBox.Controls.Add(this.filterPreparationLevelCheckBox);
            this.filterGroupBox.Controls.Add(this.filterSexCheckBox);
            this.filterGroupBox.Controls.Add(this.filterDateCheckBox);
            this.filterGroupBox.Controls.Add(this.label5);
            this.filterGroupBox.Controls.Add(this.label4);
            this.filterGroupBox.Controls.Add(this.label3);
            this.filterGroupBox.Controls.Add(this.filterToDateTimePicker);
            this.filterGroupBox.Controls.Add(this.label2);
            this.filterGroupBox.Controls.Add(this.filterFromDateTimePicker);
            this.filterGroupBox.Controls.Add(this.label1);
            this.filterGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterGroupBox.Location = new System.Drawing.Point(3, 336);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(1030, 185);
            this.filterGroupBox.TabIndex = 7;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтрація клієнтів";
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.Location = new System.Drawing.Point(431, 132);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(169, 38);
            this.filterButton.TabIndex = 18;
            this.filterButton.Text = "Фільтрувати";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.SetFiltering);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.beginnerRadioButton);
            this.panel5.Controls.Add(this.amateurRadioButton);
            this.panel5.Controls.Add(this.sportsmanRadioButton);
            this.panel5.Location = new System.Drawing.Point(648, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 46);
            this.panel5.TabIndex = 17;
            // 
            // beginnerRadioButton
            // 
            this.beginnerRadioButton.AutoSize = true;
            this.beginnerRadioButton.Location = new System.Drawing.Point(12, 12);
            this.beginnerRadioButton.Name = "beginnerRadioButton";
            this.beginnerRadioButton.Size = new System.Drawing.Size(115, 22);
            this.beginnerRadioButton.TabIndex = 10;
            this.beginnerRadioButton.TabStop = true;
            this.beginnerRadioButton.Text = "Початківець";
            this.beginnerRadioButton.UseVisualStyleBackColor = true;
            // 
            // amateurRadioButton
            // 
            this.amateurRadioButton.AutoSize = true;
            this.amateurRadioButton.Location = new System.Drawing.Point(133, 12);
            this.amateurRadioButton.Name = "amateurRadioButton";
            this.amateurRadioButton.Size = new System.Drawing.Size(100, 22);
            this.amateurRadioButton.TabIndex = 11;
            this.amateurRadioButton.TabStop = true;
            this.amateurRadioButton.Text = "Любитель";
            this.amateurRadioButton.UseVisualStyleBackColor = true;
            // 
            // sportsmanRadioButton
            // 
            this.sportsmanRadioButton.AutoSize = true;
            this.sportsmanRadioButton.Location = new System.Drawing.Point(239, 12);
            this.sportsmanRadioButton.Name = "sportsmanRadioButton";
            this.sportsmanRadioButton.Size = new System.Drawing.Size(107, 22);
            this.sportsmanRadioButton.TabIndex = 12;
            this.sportsmanRadioButton.TabStop = true;
            this.sportsmanRadioButton.Text = "Спортсмен";
            this.sportsmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.maleRadioButton);
            this.panel4.Controls.Add(this.femaleRadioButton);
            this.panel4.Location = new System.Drawing.Point(424, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 46);
            this.panel4.TabIndex = 16;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(7, 11);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(93, 22);
            this.maleRadioButton.TabIndex = 7;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Чоловіча";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(106, 11);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(79, 22);
            this.femaleRadioButton.TabIndex = 8;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Жіноча";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // filterPreparationLevelCheckBox
            // 
            this.filterPreparationLevelCheckBox.AutoSize = true;
            this.filterPreparationLevelCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterPreparationLevelCheckBox.Location = new System.Drawing.Point(698, 95);
            this.filterPreparationLevelCheckBox.Name = "filterPreparationLevelCheckBox";
            this.filterPreparationLevelCheckBox.Size = new System.Drawing.Size(254, 22);
            this.filterPreparationLevelCheckBox.TabIndex = 15;
            this.filterPreparationLevelCheckBox.Text = "Фільтрація за рівнем підготовки";
            this.filterPreparationLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterSexCheckBox
            // 
            this.filterSexCheckBox.AutoSize = true;
            this.filterSexCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterSexCheckBox.Location = new System.Drawing.Point(431, 95);
            this.filterSexCheckBox.Name = "filterSexCheckBox";
            this.filterSexCheckBox.Size = new System.Drawing.Size(177, 22);
            this.filterSexCheckBox.TabIndex = 14;
            this.filterSexCheckBox.Text = "Фільтрація за статтю";
            this.filterSexCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterDateCheckBox
            // 
            this.filterDateCheckBox.AutoSize = true;
            this.filterDateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterDateCheckBox.Location = new System.Drawing.Point(131, 95);
            this.filterDateCheckBox.Name = "filterDateCheckBox";
            this.filterDateCheckBox.Size = new System.Drawing.Size(173, 22);
            this.filterDateCheckBox.TabIndex = 13;
            this.filterDateCheckBox.Text = "Фільтрація за датою";
            this.filterDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(745, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Рівень підготовки:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(485, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стать:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(209, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "До:";
            // 
            // filterToDateTimePicker
            // 
            this.filterToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filterToDateTimePicker.Location = new System.Drawing.Point(248, 57);
            this.filterToDateTimePicker.Name = "filterToDateTimePicker";
            this.filterToDateTimePicker.Size = new System.Drawing.Size(120, 24);
            this.filterToDateTimePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Від:";
            // 
            // filterFromDateTimePicker
            // 
            this.filterFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filterFromDateTimePicker.Location = new System.Drawing.Point(71, 57);
            this.filterFromDateTimePicker.Name = "filterFromDateTimePicker";
            this.filterFromDateTimePicker.Size = new System.Drawing.Size(120, 24);
            this.filterFromDateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(129, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата народження";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteClientButton);
            this.panel2.Controls.Add(this.editClientButton);
            this.panel2.Controls.Add(this.addClientButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 100);
            this.panel2.TabIndex = 3;
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteClientButton.Location = new System.Drawing.Point(730, 26);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(163, 46);
            this.deleteClientButton.TabIndex = 2;
            this.deleteClientButton.Text = "Видалити";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // editClientButton
            // 
            this.editClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editClientButton.Location = new System.Drawing.Point(437, 27);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(163, 46);
            this.editClientButton.TabIndex = 1;
            this.editClientButton.Text = "Редагувати";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClientButton.Location = new System.Drawing.Point(141, 26);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(163, 46);
            this.addClientButton.TabIndex = 0;
            this.addClientButton.Text = "Додати";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // subscriptionsTabPage
            // 
            this.subscriptionsTabPage.Controls.Add(this.subscriptionsDataGridView);
            this.subscriptionsTabPage.Controls.Add(this.panel1);
            this.subscriptionsTabPage.Location = new System.Drawing.Point(4, 27);
            this.subscriptionsTabPage.Name = "subscriptionsTabPage";
            this.subscriptionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.subscriptionsTabPage.Size = new System.Drawing.Size(1036, 624);
            this.subscriptionsTabPage.TabIndex = 1;
            this.subscriptionsTabPage.Text = "Абонементи";
            this.subscriptionsTabPage.UseVisualStyleBackColor = true;
            // 
            // subscriptionsDataGridView
            // 
            this.subscriptionsDataGridView.AllowUserToAddRows = false;
            this.subscriptionsDataGridView.AllowUserToDeleteRows = false;
            this.subscriptionsDataGridView.AutoGenerateColumns = false;
            this.subscriptionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.subscriptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscriptionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscriptionidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.attendancecountDataGridViewTextBoxColumn,
            this.daycountDataGridViewTextBoxColumn});
            this.subscriptionsDataGridView.DataSource = this.subscriptionsViewBindingSource;
            this.subscriptionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subscriptionsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.subscriptionsDataGridView.Name = "subscriptionsDataGridView";
            this.subscriptionsDataGridView.ReadOnly = true;
            this.subscriptionsDataGridView.RowHeadersWidth = 51;
            this.subscriptionsDataGridView.RowTemplate.Height = 24;
            this.subscriptionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subscriptionsDataGridView.Size = new System.Drawing.Size(1030, 518);
            this.subscriptionsDataGridView.TabIndex = 3;
            // 
            // subscriptionidDataGridViewTextBoxColumn
            // 
            this.subscriptionidDataGridViewTextBoxColumn.DataPropertyName = "subscription_id";
            this.subscriptionidDataGridViewTextBoxColumn.HeaderText = "subscription_id";
            this.subscriptionidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subscriptionidDataGridViewTextBoxColumn.Name = "subscriptionidDataGridViewTextBoxColumn";
            this.subscriptionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subscriptionidDataGridViewTextBoxColumn.Visible = false;
            this.subscriptionidDataGridViewTextBoxColumn.Width = 136;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 67;
            // 
            // attendancecountDataGridViewTextBoxColumn
            // 
            this.attendancecountDataGridViewTextBoxColumn.DataPropertyName = "attendance_count";
            this.attendancecountDataGridViewTextBoxColumn.HeaderText = "Кількість відвідувань";
            this.attendancecountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendancecountDataGridViewTextBoxColumn.Name = "attendancecountDataGridViewTextBoxColumn";
            this.attendancecountDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendancecountDataGridViewTextBoxColumn.Width = 168;
            // 
            // daycountDataGridViewTextBoxColumn
            // 
            this.daycountDataGridViewTextBoxColumn.DataPropertyName = "day_count";
            this.daycountDataGridViewTextBoxColumn.HeaderText = "Строк дії";
            this.daycountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daycountDataGridViewTextBoxColumn.Name = "daycountDataGridViewTextBoxColumn";
            this.daycountDataGridViewTextBoxColumn.ReadOnly = true;
            this.daycountDataGridViewTextBoxColumn.Width = 92;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deleteSubscriptionButton);
            this.panel1.Controls.Add(this.editSubscriptionButton);
            this.panel1.Controls.Add(this.addSubscriptionButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 100);
            this.panel1.TabIndex = 2;
            // 
            // deleteSubscriptionButton
            // 
            this.deleteSubscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSubscriptionButton.Location = new System.Drawing.Point(729, 26);
            this.deleteSubscriptionButton.Name = "deleteSubscriptionButton";
            this.deleteSubscriptionButton.Size = new System.Drawing.Size(163, 46);
            this.deleteSubscriptionButton.TabIndex = 2;
            this.deleteSubscriptionButton.Text = "Видалити";
            this.deleteSubscriptionButton.UseVisualStyleBackColor = true;
            this.deleteSubscriptionButton.Click += new System.EventHandler(this.DeleteSubscriptionButton_Click);
            // 
            // editSubscriptionButton
            // 
            this.editSubscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSubscriptionButton.Location = new System.Drawing.Point(436, 27);
            this.editSubscriptionButton.Name = "editSubscriptionButton";
            this.editSubscriptionButton.Size = new System.Drawing.Size(163, 46);
            this.editSubscriptionButton.TabIndex = 1;
            this.editSubscriptionButton.Text = "Редагувати";
            this.editSubscriptionButton.UseVisualStyleBackColor = true;
            this.editSubscriptionButton.Click += new System.EventHandler(this.EditSubscriptionButton_Click);
            // 
            // addSubscriptionButton
            // 
            this.addSubscriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSubscriptionButton.Location = new System.Drawing.Point(140, 26);
            this.addSubscriptionButton.Name = "addSubscriptionButton";
            this.addSubscriptionButton.Size = new System.Drawing.Size(163, 46);
            this.addSubscriptionButton.TabIndex = 0;
            this.addSubscriptionButton.Text = "Додати";
            this.addSubscriptionButton.UseVisualStyleBackColor = true;
            this.addSubscriptionButton.Click += new System.EventHandler(this.AddSubscriptionButton_Click);
            // 
            // visitorCardsTabPage
            // 
            this.visitorCardsTabPage.Controls.Add(this.visitorCardsDataGridView);
            this.visitorCardsTabPage.Controls.Add(this.panel3);
            this.visitorCardsTabPage.Location = new System.Drawing.Point(4, 27);
            this.visitorCardsTabPage.Name = "visitorCardsTabPage";
            this.visitorCardsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.visitorCardsTabPage.Size = new System.Drawing.Size(1036, 624);
            this.visitorCardsTabPage.TabIndex = 2;
            this.visitorCardsTabPage.Text = "Картки відвідувачів";
            this.visitorCardsTabPage.UseVisualStyleBackColor = true;
            // 
            // visitorCardsDataGridView
            // 
            this.visitorCardsDataGridView.AllowUserToAddRows = false;
            this.visitorCardsDataGridView.AllowUserToDeleteRows = false;
            this.visitorCardsDataGridView.AutoGenerateColumns = false;
            this.visitorCardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.visitorCardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitorCardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardidDataGridViewTextBoxColumn,
            this.subscriptionidDataGridViewTextBoxColumn1,
            this.clientidDataGridViewTextBoxColumn1,
            this.client_idLastName,
            this.client_idMiddleName,
            this.startdateDataGridViewTextBoxColumn,
            this.expirydateDataGridViewTextBoxColumn,
            this.attendanceleftcountDataGridViewTextBoxColumn});
            this.visitorCardsDataGridView.DataSource = this.visitorCardsBindingSource;
            this.visitorCardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitorCardsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.visitorCardsDataGridView.Name = "visitorCardsDataGridView";
            this.visitorCardsDataGridView.ReadOnly = true;
            this.visitorCardsDataGridView.RowHeadersWidth = 51;
            this.visitorCardsDataGridView.RowTemplate.Height = 24;
            this.visitorCardsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitorCardsDataGridView.Size = new System.Drawing.Size(1030, 518);
            this.visitorCardsDataGridView.TabIndex = 7;
            // 
            // cardidDataGridViewTextBoxColumn
            // 
            this.cardidDataGridViewTextBoxColumn.DataPropertyName = "card_id";
            this.cardidDataGridViewTextBoxColumn.HeaderText = "card_id";
            this.cardidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardidDataGridViewTextBoxColumn.Name = "cardidDataGridViewTextBoxColumn";
            this.cardidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cardidDataGridViewTextBoxColumn.Visible = false;
            this.cardidDataGridViewTextBoxColumn.Width = 85;
            // 
            // subscriptionidDataGridViewTextBoxColumn1
            // 
            this.subscriptionidDataGridViewTextBoxColumn1.DataPropertyName = "subscription_id";
            this.subscriptionidDataGridViewTextBoxColumn1.DataSource = this.subscriptionsViewBindingSource;
            this.subscriptionidDataGridViewTextBoxColumn1.DisplayMember = "name";
            this.subscriptionidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.subscriptionidDataGridViewTextBoxColumn1.HeaderText = "Назва абонемента";
            this.subscriptionidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.subscriptionidDataGridViewTextBoxColumn1.Name = "subscriptionidDataGridViewTextBoxColumn1";
            this.subscriptionidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.subscriptionidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subscriptionidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subscriptionidDataGridViewTextBoxColumn1.ValueMember = "subscription_id";
            this.subscriptionidDataGridViewTextBoxColumn1.Width = 154;
            // 
            // clientidDataGridViewTextBoxColumn1
            // 
            this.clientidDataGridViewTextBoxColumn1.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn1.DataSource = this.clientsBindingSource;
            this.clientidDataGridViewTextBoxColumn1.DisplayMember = "first_name";
            this.clientidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clientidDataGridViewTextBoxColumn1.HeaderText = "Ім\'я";
            this.clientidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientidDataGridViewTextBoxColumn1.Name = "clientidDataGridViewTextBoxColumn1";
            this.clientidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clientidDataGridViewTextBoxColumn1.ValueMember = "client_id";
            this.clientidDataGridViewTextBoxColumn1.Width = 62;
            // 
            // client_idLastName
            // 
            this.client_idLastName.DataPropertyName = "client_id";
            this.client_idLastName.DataSource = this.clientsBindingSource;
            this.client_idLastName.DisplayMember = "last_name";
            this.client_idLastName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.client_idLastName.HeaderText = "Прізвище";
            this.client_idLastName.MinimumWidth = 6;
            this.client_idLastName.Name = "client_idLastName";
            this.client_idLastName.ReadOnly = true;
            this.client_idLastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.client_idLastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.client_idLastName.ValueMember = "client_id";
            this.client_idLastName.Width = 102;
            // 
            // client_idMiddleName
            // 
            this.client_idMiddleName.DataPropertyName = "client_id";
            this.client_idMiddleName.DataSource = this.clientsBindingSource;
            this.client_idMiddleName.DisplayMember = "middle_name";
            this.client_idMiddleName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.client_idMiddleName.HeaderText = "По-батькові";
            this.client_idMiddleName.MinimumWidth = 6;
            this.client_idMiddleName.Name = "client_idMiddleName";
            this.client_idMiddleName.ReadOnly = true;
            this.client_idMiddleName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.client_idMiddleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.client_idMiddleName.ValueMember = "client_id";
            this.client_idMiddleName.Width = 122;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Дата початку дії";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startdateDataGridViewTextBoxColumn.Width = 124;
            // 
            // expirydateDataGridViewTextBoxColumn
            // 
            this.expirydateDataGridViewTextBoxColumn.DataPropertyName = "expiry_date";
            this.expirydateDataGridViewTextBoxColumn.HeaderText = "Дата закінчення дії";
            this.expirydateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirydateDataGridViewTextBoxColumn.Name = "expirydateDataGridViewTextBoxColumn";
            this.expirydateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expirydateDataGridViewTextBoxColumn.Width = 142;
            // 
            // attendanceleftcountDataGridViewTextBoxColumn
            // 
            this.attendanceleftcountDataGridViewTextBoxColumn.DataPropertyName = "attendance_left_count";
            this.attendanceleftcountDataGridViewTextBoxColumn.HeaderText = "Залишилось відвідувань";
            this.attendanceleftcountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendanceleftcountDataGridViewTextBoxColumn.Name = "attendanceleftcountDataGridViewTextBoxColumn";
            this.attendanceleftcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.attendanceleftcountDataGridViewTextBoxColumn.Width = 190;
            // 
            // visitorCardsBindingSource
            // 
            this.visitorCardsBindingSource.DataMember = "VisitorCards";
            this.visitorCardsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.deleteVisitorCardButton);
            this.panel3.Controls.Add(this.editVisitorCardButton);
            this.panel3.Controls.Add(this.addVisitorCardButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 521);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 100);
            this.panel3.TabIndex = 3;
            // 
            // deleteVisitorCardButton
            // 
            this.deleteVisitorCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteVisitorCardButton.Location = new System.Drawing.Point(727, 26);
            this.deleteVisitorCardButton.Name = "deleteVisitorCardButton";
            this.deleteVisitorCardButton.Size = new System.Drawing.Size(163, 46);
            this.deleteVisitorCardButton.TabIndex = 2;
            this.deleteVisitorCardButton.Text = "Видалити";
            this.deleteVisitorCardButton.UseVisualStyleBackColor = true;
            this.deleteVisitorCardButton.Click += new System.EventHandler(this.DeleteVisitorCardButton_Click);
            // 
            // editVisitorCardButton
            // 
            this.editVisitorCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editVisitorCardButton.Location = new System.Drawing.Point(434, 27);
            this.editVisitorCardButton.Name = "editVisitorCardButton";
            this.editVisitorCardButton.Size = new System.Drawing.Size(163, 46);
            this.editVisitorCardButton.TabIndex = 1;
            this.editVisitorCardButton.Text = "Редагувати";
            this.editVisitorCardButton.UseVisualStyleBackColor = true;
            this.editVisitorCardButton.Click += new System.EventHandler(this.EditVisitorCardButton_Click);
            // 
            // addVisitorCardButton
            // 
            this.addVisitorCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVisitorCardButton.Location = new System.Drawing.Point(138, 26);
            this.addVisitorCardButton.Name = "addVisitorCardButton";
            this.addVisitorCardButton.Size = new System.Drawing.Size(163, 46);
            this.addVisitorCardButton.TabIndex = 0;
            this.addVisitorCardButton.Text = "Додати";
            this.addVisitorCardButton.UseVisualStyleBackColor = true;
            this.addVisitorCardButton.Click += new System.EventHandler(this.AddVisitorCardButton_Click);
            // 
            // trainingsTableAdapter
            // 
            this.trainingsTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsViewTableAdapter
            // 
            this.subscriptionsViewTableAdapter.ClearBeforeFill = true;
            // 
            // visitorCardsTableAdapter
            // 
            this.visitorCardsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1044, 683);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адміністратор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsViewBindingSource)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.clientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.subscriptionsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.visitorCardsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private swimmingpoolDataSet swimmingpoolDataSet;
        private BindingSource clientsBindingSource;
        private swimmingpoolDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private swimmingpoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingSource subscriptionsViewBindingSource;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TabControl tabControl;
        private TabPage clientsTabPage;
        private TabPage subscriptionsTabPage;
        private TabPage visitorCardsTabPage;
        private Panel panel1;
        private Button deleteSubscriptionButton;
        private Button editSubscriptionButton;
        private Button addSubscriptionButton;
        private Panel panel2;
        private Button deleteClientButton;
        private Button editClientButton;
        private Button addClientButton;
        private DataGridView clientsDataGridView;
        private DataGridView subscriptionsDataGridView;
        private swimmingpoolDataSetTableAdapters.TrainingsTableAdapter trainingsTableAdapter;
        private swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter subscriptionsTableAdapter;
        private Panel panel3;
        private Button deleteVisitorCardButton;
        private Button editVisitorCardButton;
        private Button addVisitorCardButton;
        private swimmingpoolDataSetTableAdapters.SubscriptionsViewTableAdapter subscriptionsViewTableAdapter;
        private DataGridViewTextBoxColumn subscriptionidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attendancecountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn daycountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preparationlevelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource visitorCardsBindingSource;
        private DataGridView visitorCardsDataGridView;
        private DataGridViewTextBoxColumn cardidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn subscriptionidDataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn clientidDataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn client_idLastName;
        private DataGridViewComboBoxColumn client_idMiddleName;
        private DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirydateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attendanceleftcountDataGridViewTextBoxColumn;
        private swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter visitorCardsTableAdapter;
        private GroupBox searchGroupBox;
        private TextBox middleNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label middleNameLabel;
        private GroupBox filterGroupBox;
        private CheckBox filterDateCheckBox;
        private RadioButton sportsmanRadioButton;
        private RadioButton amateurRadioButton;
        private RadioButton beginnerRadioButton;
        private Label label5;
        private RadioButton femaleRadioButton;
        private RadioButton maleRadioButton;
        private Label label4;
        private Label label3;
        private DateTimePicker filterToDateTimePicker;
        private Label label2;
        private DateTimePicker filterFromDateTimePicker;
        private Label label1;
        private CheckBox filterPreparationLevelCheckBox;
        private CheckBox filterSexCheckBox;
        private Panel panel5;
        private Panel panel4;
        private Button filterButton;
        private Button searchButton;
    }
}