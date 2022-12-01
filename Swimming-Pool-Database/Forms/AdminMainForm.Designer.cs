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
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.clientsSearchButton = new System.Windows.Forms.Button();
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
            this.subscriptionSortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortByDayCountCheckBox = new System.Windows.Forms.CheckBox();
            this.sortByAttendanceCountCheckBox = new System.Windows.Forms.CheckBox();
            this.sortByPriceCheckBox = new System.Windows.Forms.CheckBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dayCountMoreRadioButton = new System.Windows.Forms.RadioButton();
            this.dayCountLessRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.attendanceCountMoreRadioButton = new System.Windows.Forms.RadioButton();
            this.attendanceCountLessRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.priceCheapestRadioButton = new System.Windows.Forms.RadioButton();
            this.priceExpensiveRadioButton = new System.Windows.Forms.RadioButton();
            this.subscriptionsSortButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.subscriptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.subscriptionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daycount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.printVisitorCardButton = new System.Windows.Forms.Button();
            this.deleteVisitorCardButton = new System.Windows.Forms.Button();
            this.editVisitorCardButton = new System.Windows.Forms.Button();
            this.addVisitorCardButton = new System.Windows.Forms.Button();
            this.trainingsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.filterTrainingsButton = new System.Windows.Forms.Button();
            this.filterClientCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.trainingsDataGridView = new System.Windows.Forms.DataGridView();
            this.swimLanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.clientsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TableAdapterManager();
            this.trainingsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TrainingsTableAdapter();
            this.subscriptionsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter();
            this.visitorCardsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter();
            this.swimLanesTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter();
            this.poolsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.PoolsTableAdapter();
            this.trainingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poolIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.swimlaneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.clientsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.subscriptionsTabPage.SuspendLayout();
            this.subscriptionSortGroupBox.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.visitorCardsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.trainingsTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).BeginInit();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.clientsTabPage);
            this.tabControl.Controls.Add(this.subscriptionsTabPage);
            this.tabControl.Controls.Add(this.visitorCardsTabPage);
            this.tabControl.Controls.Add(this.trainingsTabPage);
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
            this.clientidDataGridViewTextBoxColumn.Width = 85;
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
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.clientsSearchButton);
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
            // clientsSearchButton
            // 
            this.clientsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsSearchButton.Location = new System.Drawing.Point(458, 69);
            this.clientsSearchButton.Name = "clientsSearchButton";
            this.clientsSearchButton.Size = new System.Drawing.Size(121, 38);
            this.clientsSearchButton.TabIndex = 19;
            this.clientsSearchButton.Text = "Шукати";
            this.clientsSearchButton.UseVisualStyleBackColor = true;
            this.clientsSearchButton.Click += new System.EventHandler(this.SetClientsFiltering);
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
            this.filterButton.Click += new System.EventHandler(this.SetClientsFiltering);
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
            this.subscriptionsTabPage.Controls.Add(this.subscriptionSortGroupBox);
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
            // subscriptionSortGroupBox
            // 
            this.subscriptionSortGroupBox.Controls.Add(this.sortByDayCountCheckBox);
            this.subscriptionSortGroupBox.Controls.Add(this.sortByAttendanceCountCheckBox);
            this.subscriptionSortGroupBox.Controls.Add(this.sortByPriceCheckBox);
            this.subscriptionSortGroupBox.Controls.Add(this.panel8);
            this.subscriptionSortGroupBox.Controls.Add(this.label8);
            this.subscriptionSortGroupBox.Controls.Add(this.panel7);
            this.subscriptionSortGroupBox.Controls.Add(this.label7);
            this.subscriptionSortGroupBox.Controls.Add(this.panel6);
            this.subscriptionSortGroupBox.Controls.Add(this.subscriptionsSortButton);
            this.subscriptionSortGroupBox.Controls.Add(this.label6);
            this.subscriptionSortGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.subscriptionSortGroupBox.Location = new System.Drawing.Point(3, 339);
            this.subscriptionSortGroupBox.Name = "subscriptionSortGroupBox";
            this.subscriptionSortGroupBox.Size = new System.Drawing.Size(1030, 182);
            this.subscriptionSortGroupBox.TabIndex = 5;
            this.subscriptionSortGroupBox.TabStop = false;
            this.subscriptionSortGroupBox.Text = "Сортування абонементів";
            // 
            // sortByDayCountCheckBox
            // 
            this.sortByDayCountCheckBox.AutoSize = true;
            this.sortByDayCountCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByDayCountCheckBox.Location = new System.Drawing.Point(758, 101);
            this.sortByDayCountCheckBox.Name = "sortByDayCountCheckBox";
            this.sortByDayCountCheckBox.Size = new System.Drawing.Size(215, 22);
            this.sortByDayCountCheckBox.TabIndex = 27;
            this.sortByDayCountCheckBox.Text = "Сортування за строком дії";
            this.sortByDayCountCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortByAttendanceCountCheckBox
            // 
            this.sortByAttendanceCountCheckBox.AutoSize = true;
            this.sortByAttendanceCountCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByAttendanceCountCheckBox.Location = new System.Drawing.Point(383, 101);
            this.sortByAttendanceCountCheckBox.Name = "sortByAttendanceCountCheckBox";
            this.sortByAttendanceCountCheckBox.Size = new System.Drawing.Size(284, 22);
            this.sortByAttendanceCountCheckBox.TabIndex = 26;
            this.sortByAttendanceCountCheckBox.Text = "Сортування за кількістю відвідувань";
            this.sortByAttendanceCountCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortByPriceCheckBox
            // 
            this.sortByPriceCheckBox.AutoSize = true;
            this.sortByPriceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortByPriceCheckBox.Location = new System.Drawing.Point(79, 101);
            this.sortByPriceCheckBox.Name = "sortByPriceCheckBox";
            this.sortByPriceCheckBox.Size = new System.Drawing.Size(175, 22);
            this.sortByPriceCheckBox.TabIndex = 25;
            this.sortByPriceCheckBox.Text = "Сортування за ціною";
            this.sortByPriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dayCountMoreRadioButton);
            this.panel8.Controls.Add(this.dayCountLessRadioButton);
            this.panel8.Location = new System.Drawing.Point(711, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(310, 42);
            this.panel8.TabIndex = 24;
            // 
            // dayCountMoreRadioButton
            // 
            this.dayCountMoreRadioButton.AutoSize = true;
            this.dayCountMoreRadioButton.Location = new System.Drawing.Point(7, 11);
            this.dayCountMoreRadioButton.Name = "dayCountMoreRadioButton";
            this.dayCountMoreRadioButton.Size = new System.Drawing.Size(139, 22);
            this.dayCountMoreRadioButton.TabIndex = 7;
            this.dayCountMoreRadioButton.TabStop = true;
            this.dayCountMoreRadioButton.Text = "Спочатку довші";
            this.dayCountMoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // dayCountLessRadioButton
            // 
            this.dayCountLessRadioButton.AutoSize = true;
            this.dayCountLessRadioButton.Location = new System.Drawing.Point(152, 11);
            this.dayCountLessRadioButton.Name = "dayCountLessRadioButton";
            this.dayCountLessRadioButton.Size = new System.Drawing.Size(154, 22);
            this.dayCountLessRadioButton.TabIndex = 8;
            this.dayCountLessRadioButton.TabStop = true;
            this.dayCountLessRadioButton.Text = "Спочатку коротші";
            this.dayCountLessRadioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(797, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "За строком дії:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.attendanceCountMoreRadioButton);
            this.panel7.Controls.Add(this.attendanceCountLessRadioButton);
            this.panel7.Location = new System.Drawing.Point(364, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 42);
            this.panel7.TabIndex = 22;
            // 
            // attendanceCountMoreRadioButton
            // 
            this.attendanceCountMoreRadioButton.AutoSize = true;
            this.attendanceCountMoreRadioButton.Location = new System.Drawing.Point(7, 11);
            this.attendanceCountMoreRadioButton.Name = "attendanceCountMoreRadioButton";
            this.attendanceCountMoreRadioButton.Size = new System.Drawing.Size(147, 22);
            this.attendanceCountMoreRadioButton.TabIndex = 7;
            this.attendanceCountMoreRadioButton.TabStop = true;
            this.attendanceCountMoreRadioButton.Text = "Спочатку більше";
            this.attendanceCountMoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // attendanceCountLessRadioButton
            // 
            this.attendanceCountLessRadioButton.AutoSize = true;
            this.attendanceCountLessRadioButton.Location = new System.Drawing.Point(160, 11);
            this.attendanceCountLessRadioButton.Name = "attendanceCountLessRadioButton";
            this.attendanceCountLessRadioButton.Size = new System.Drawing.Size(153, 22);
            this.attendanceCountLessRadioButton.TabIndex = 8;
            this.attendanceCountLessRadioButton.TabStop = true;
            this.attendanceCountLessRadioButton.Text = "Спочатку меньше";
            this.attendanceCountLessRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(414, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "За кількістю відвідувань:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.priceCheapestRadioButton);
            this.panel6.Controls.Add(this.priceExpensiveRadioButton);
            this.panel6.Location = new System.Drawing.Point(6, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(328, 42);
            this.panel6.TabIndex = 20;
            // 
            // priceCheapestRadioButton
            // 
            this.priceCheapestRadioButton.AutoSize = true;
            this.priceCheapestRadioButton.Location = new System.Drawing.Point(7, 11);
            this.priceCheapestRadioButton.Name = "priceCheapestRadioButton";
            this.priceCheapestRadioButton.Size = new System.Drawing.Size(157, 22);
            this.priceCheapestRadioButton.TabIndex = 7;
            this.priceCheapestRadioButton.TabStop = true;
            this.priceCheapestRadioButton.Text = "Спочатку дешевші";
            this.priceCheapestRadioButton.UseVisualStyleBackColor = true;
            // 
            // priceExpensiveRadioButton
            // 
            this.priceExpensiveRadioButton.AutoSize = true;
            this.priceExpensiveRadioButton.Location = new System.Drawing.Point(170, 11);
            this.priceExpensiveRadioButton.Name = "priceExpensiveRadioButton";
            this.priceExpensiveRadioButton.Size = new System.Drawing.Size(156, 22);
            this.priceExpensiveRadioButton.TabIndex = 8;
            this.priceExpensiveRadioButton.TabStop = true;
            this.priceExpensiveRadioButton.Text = "Спочатку дорожчі";
            this.priceExpensiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // subscriptionsSortButton
            // 
            this.subscriptionsSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionsSortButton.Location = new System.Drawing.Point(459, 132);
            this.subscriptionsSortButton.Name = "subscriptionsSortButton";
            this.subscriptionsSortButton.Size = new System.Drawing.Size(121, 38);
            this.subscriptionsSortButton.TabIndex = 19;
            this.subscriptionsSortButton.Text = "Сортувати";
            this.subscriptionsSortButton.UseVisualStyleBackColor = true;
            this.subscriptionsSortButton.Click += new System.EventHandler(this.SubscriptionsSortButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(121, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "За ціною:";
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
            this.name,
            this.price,
            this.attendancecount,
            this.daycount});
            this.subscriptionsDataGridView.DataSource = this.subscriptionsBindingSource;
            this.subscriptionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subscriptionsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.subscriptionsDataGridView.Name = "subscriptionsDataGridView";
            this.subscriptionsDataGridView.ReadOnly = true;
            this.subscriptionsDataGridView.RowHeadersWidth = 51;
            this.subscriptionsDataGridView.RowTemplate.Height = 24;
            this.subscriptionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subscriptionsDataGridView.Size = new System.Drawing.Size(1030, 518);
            this.subscriptionsDataGridView.TabIndex = 3;
            this.subscriptionsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.SubscriptionsDataGridView_CellFormatting);
            // 
            // subscriptionidDataGridViewTextBoxColumn
            // 
            this.subscriptionidDataGridViewTextBoxColumn.DataPropertyName = "subscription_id";
            this.subscriptionidDataGridViewTextBoxColumn.HeaderText = "subscription_id";
            this.subscriptionidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subscriptionidDataGridViewTextBoxColumn.Name = "subscriptionidDataGridViewTextBoxColumn";
            this.subscriptionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subscriptionidDataGridViewTextBoxColumn.Visible = false;
            this.subscriptionidDataGridViewTextBoxColumn.Width = 126;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Назва";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 80;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Ціна";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 67;
            // 
            // attendancecount
            // 
            this.attendancecount.DataPropertyName = "attendance_count";
            this.attendancecount.HeaderText = "Кількість відвідувань";
            this.attendancecount.MinimumWidth = 6;
            this.attendancecount.Name = "attendancecount";
            this.attendancecount.ReadOnly = true;
            this.attendancecount.Width = 168;
            // 
            // daycount
            // 
            this.daycount.DataPropertyName = "day_count";
            this.daycount.HeaderText = "Строк дії";
            this.daycount.MinimumWidth = 6;
            this.daycount.Name = "daycount";
            this.daycount.ReadOnly = true;
            this.daycount.Width = 92;
            // 
            // subscriptionsBindingSource
            // 
            this.subscriptionsBindingSource.DataMember = "Subscriptions";
            this.subscriptionsBindingSource.DataSource = this.swimmingpoolDataSet;
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
            this.visitorCardsDataGridView.Size = new System.Drawing.Size(1030, 478);
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
            this.cardidDataGridViewTextBoxColumn.Width = 81;
            // 
            // subscriptionidDataGridViewTextBoxColumn1
            // 
            this.subscriptionidDataGridViewTextBoxColumn1.DataPropertyName = "subscription_id";
            this.subscriptionidDataGridViewTextBoxColumn1.DataSource = this.subscriptionsBindingSource;
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
            this.panel3.Controls.Add(this.printVisitorCardButton);
            this.panel3.Controls.Add(this.deleteVisitorCardButton);
            this.panel3.Controls.Add(this.editVisitorCardButton);
            this.panel3.Controls.Add(this.addVisitorCardButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1030, 140);
            this.panel3.TabIndex = 3;
            // 
            // printVisitorCardButton
            // 
            this.printVisitorCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printVisitorCardButton.Location = new System.Drawing.Point(377, 78);
            this.printVisitorCardButton.Name = "printVisitorCardButton";
            this.printVisitorCardButton.Size = new System.Drawing.Size(269, 48);
            this.printVisitorCardButton.TabIndex = 4;
            this.printVisitorCardButton.Text = "Роздрукувати обрану картку";
            this.printVisitorCardButton.UseVisualStyleBackColor = true;
            this.printVisitorCardButton.Click += new System.EventHandler(this.PrintVisitorCardButton_Click);
            // 
            // deleteVisitorCardButton
            // 
            this.deleteVisitorCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteVisitorCardButton.Location = new System.Drawing.Point(727, 15);
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
            this.editVisitorCardButton.Location = new System.Drawing.Point(434, 16);
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
            this.addVisitorCardButton.Location = new System.Drawing.Point(138, 15);
            this.addVisitorCardButton.Name = "addVisitorCardButton";
            this.addVisitorCardButton.Size = new System.Drawing.Size(163, 46);
            this.addVisitorCardButton.TabIndex = 0;
            this.addVisitorCardButton.Text = "Додати";
            this.addVisitorCardButton.UseVisualStyleBackColor = true;
            this.addVisitorCardButton.Click += new System.EventHandler(this.AddVisitorCardButton_Click);
            // 
            // trainingsTabPage
            // 
            this.trainingsTabPage.Controls.Add(this.groupBox1);
            this.trainingsTabPage.Controls.Add(this.trainingsDataGridView);
            this.trainingsTabPage.Location = new System.Drawing.Point(4, 27);
            this.trainingsTabPage.Name = "trainingsTabPage";
            this.trainingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trainingsTabPage.Size = new System.Drawing.Size(1036, 624);
            this.trainingsTabPage.TabIndex = 3;
            this.trainingsTabPage.Text = "Тренування";
            this.trainingsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientComboBox);
            this.groupBox1.Controls.Add(this.filterTrainingsButton);
            this.groupBox1.Controls.Add(this.filterClientCheckBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтрація тренувань";
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientsBindingSource;
            this.clientComboBox.DisplayMember = "client_id";
            this.clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(386, 43);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(265, 28);
            this.clientComboBox.TabIndex = 19;
            this.clientComboBox.ValueMember = "client_id";
            this.clientComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientComboBox_Format);
            // 
            // filterTrainingsButton
            // 
            this.filterTrainingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterTrainingsButton.Location = new System.Drawing.Point(431, 119);
            this.filterTrainingsButton.Name = "filterTrainingsButton";
            this.filterTrainingsButton.Size = new System.Drawing.Size(169, 38);
            this.filterTrainingsButton.TabIndex = 18;
            this.filterTrainingsButton.Text = "Фільтрувати";
            this.filterTrainingsButton.UseVisualStyleBackColor = true;
            this.filterTrainingsButton.Click += new System.EventHandler(this.FilterTrainingsButton_Click);
            // 
            // filterClientCheckBox
            // 
            this.filterClientCheckBox.AutoSize = true;
            this.filterClientCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterClientCheckBox.Location = new System.Drawing.Point(420, 81);
            this.filterClientCheckBox.Name = "filterClientCheckBox";
            this.filterClientCheckBox.Size = new System.Drawing.Size(192, 22);
            this.filterClientCheckBox.TabIndex = 14;
            this.filterClientCheckBox.Text = "Фільтрація за клієнтом";
            this.filterClientCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(483, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Клієнт:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trainingsDataGridView
            // 
            this.trainingsDataGridView.AllowUserToAddRows = false;
            this.trainingsDataGridView.AllowUserToDeleteRows = false;
            this.trainingsDataGridView.AutoGenerateColumns = false;
            this.trainingsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.trainingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainingidDataGridViewTextBoxColumn,
            this.cardIdColumn,
            this.poolIdColumn,
            this.swimlaneidDataGridViewTextBoxColumn,
            this.datetimestartDataGridViewTextBoxColumn,
            this.datetimeendDataGridViewTextBoxColumn,
            this.lockeridDataGridViewTextBoxColumn});
            this.trainingsDataGridView.DataSource = this.trainingsBindingSource;
            this.trainingsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.trainingsDataGridView.Name = "trainingsDataGridView";
            this.trainingsDataGridView.ReadOnly = true;
            this.trainingsDataGridView.RowHeadersWidth = 51;
            this.trainingsDataGridView.RowTemplate.Height = 24;
            this.trainingsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainingsDataGridView.Size = new System.Drawing.Size(1030, 618);
            this.trainingsDataGridView.TabIndex = 8;
            this.trainingsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TrainingsDataGridView_CellFormatting);
            // 
            // swimLanesBindingSource
            // 
            this.swimLanesBindingSource.DataMember = "SwimLanes";
            this.swimLanesBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // trainingsBindingSource
            // 
            this.trainingsBindingSource.DataMember = "Trainings";
            this.trainingsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
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
            // trainingsTableAdapter
            // 
            this.trainingsTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // visitorCardsTableAdapter
            // 
            this.visitorCardsTableAdapter.ClearBeforeFill = true;
            // 
            // swimLanesTableAdapter
            // 
            this.swimLanesTableAdapter.ClearBeforeFill = true;
            // 
            // poolsTableAdapter
            // 
            this.poolsTableAdapter.ClearBeforeFill = true;
            // 
            // trainingidDataGridViewTextBoxColumn
            // 
            this.trainingidDataGridViewTextBoxColumn.DataPropertyName = "training_id";
            this.trainingidDataGridViewTextBoxColumn.HeaderText = "training_id";
            this.trainingidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainingidDataGridViewTextBoxColumn.Name = "trainingidDataGridViewTextBoxColumn";
            this.trainingidDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainingidDataGridViewTextBoxColumn.Visible = false;
            this.trainingidDataGridViewTextBoxColumn.Width = 103;
            // 
            // cardIdColumn
            // 
            this.cardIdColumn.DataPropertyName = "card_id";
            this.cardIdColumn.HeaderText = "ПІБ клієнта";
            this.cardIdColumn.MinimumWidth = 6;
            this.cardIdColumn.Name = "cardIdColumn";
            this.cardIdColumn.ReadOnly = true;
            this.cardIdColumn.Width = 116;
            // 
            // poolIdColumn
            // 
            this.poolIdColumn.DataPropertyName = "swimlane_id";
            this.poolIdColumn.DataSource = this.swimLanesBindingSource;
            this.poolIdColumn.DisplayMember = "pool_id";
            this.poolIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.poolIdColumn.HeaderText = "Номер басейна";
            this.poolIdColumn.MinimumWidth = 6;
            this.poolIdColumn.Name = "poolIdColumn";
            this.poolIdColumn.ReadOnly = true;
            this.poolIdColumn.ValueMember = "swimlane_id";
            this.poolIdColumn.Width = 110;
            // 
            // swimlaneidDataGridViewTextBoxColumn
            // 
            this.swimlaneidDataGridViewTextBoxColumn.DataPropertyName = "swimlane_id";
            this.swimlaneidDataGridViewTextBoxColumn.HeaderText = "Номер доріжки";
            this.swimlaneidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.swimlaneidDataGridViewTextBoxColumn.Name = "swimlaneidDataGridViewTextBoxColumn";
            this.swimlaneidDataGridViewTextBoxColumn.ReadOnly = true;
            this.swimlaneidDataGridViewTextBoxColumn.Width = 132;
            // 
            // datetimestartDataGridViewTextBoxColumn
            // 
            this.datetimestartDataGridViewTextBoxColumn.DataPropertyName = "datetime_start";
            this.datetimestartDataGridViewTextBoxColumn.HeaderText = "Час початку";
            this.datetimestartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datetimestartDataGridViewTextBoxColumn.Name = "datetimestartDataGridViewTextBoxColumn";
            this.datetimestartDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimestartDataGridViewTextBoxColumn.Width = 112;
            // 
            // datetimeendDataGridViewTextBoxColumn
            // 
            this.datetimeendDataGridViewTextBoxColumn.DataPropertyName = "datetime_end";
            this.datetimeendDataGridViewTextBoxColumn.HeaderText = "Час закінчення";
            this.datetimeendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datetimeendDataGridViewTextBoxColumn.Name = "datetimeendDataGridViewTextBoxColumn";
            this.datetimeendDataGridViewTextBoxColumn.ReadOnly = true;
            this.datetimeendDataGridViewTextBoxColumn.Width = 130;
            // 
            // lockeridDataGridViewTextBoxColumn
            // 
            this.lockeridDataGridViewTextBoxColumn.DataPropertyName = "locker_id";
            this.lockeridDataGridViewTextBoxColumn.HeaderText = "Номер шкафчика";
            this.lockeridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lockeridDataGridViewTextBoxColumn.Name = "lockeridDataGridViewTextBoxColumn";
            this.lockeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.lockeridDataGridViewTextBoxColumn.Width = 146;
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
            this.tabControl.ResumeLayout(false);
            this.clientsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
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
            this.subscriptionSortGroupBox.ResumeLayout(false);
            this.subscriptionSortGroupBox.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.visitorCardsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.trainingsTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private swimmingpoolDataSet swimmingpoolDataSet;
        private BindingSource clientsBindingSource;
        private swimmingpoolDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private swimmingpoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingSource subscriptionsBindingSource;
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
        private Button clientsSearchButton;
        private GroupBox subscriptionSortGroupBox;
        private Button subscriptionsSortButton;
        private Label label6;
        private Panel panel6;
        private RadioButton priceCheapestRadioButton;
        private RadioButton priceExpensiveRadioButton;
        private Panel panel8;
        private RadioButton dayCountMoreRadioButton;
        private RadioButton dayCountLessRadioButton;
        private Label label8;
        private Panel panel7;
        private RadioButton attendanceCountMoreRadioButton;
        private RadioButton attendanceCountLessRadioButton;
        private Label label7;
        private CheckBox sortByDayCountCheckBox;
        private CheckBox sortByAttendanceCountCheckBox;
        private CheckBox sortByPriceCheckBox;
        private DataGridViewTextBoxColumn subscriptionidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn attendancecount;
        private DataGridViewTextBoxColumn daycount;
        private Button printVisitorCardButton;
        private PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private TabPage trainingsTabPage;
        private BindingSource trainingsBindingSource;
        private DataGridView trainingsDataGridView;
        private DataGridViewTextBoxColumn maxdurationDataGridViewTextBoxColumn;
        private GroupBox groupBox1;
        private Button filterTrainingsButton;
        private CheckBox filterClientCheckBox;
        private Label label10;
        private ComboBox clientComboBox;
        private BindingSource swimLanesBindingSource;
        private swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter swimLanesTableAdapter;
        private swimmingpoolDataSetTableAdapters.PoolsTableAdapter poolsTableAdapter;
        private DataGridViewTextBoxColumn trainingidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardIdColumn;
        private DataGridViewComboBoxColumn poolIdColumn;
        private DataGridViewTextBoxColumn swimlaneidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datetimestartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datetimeendDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lockeridDataGridViewTextBoxColumn;
    }
}