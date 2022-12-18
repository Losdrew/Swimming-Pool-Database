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
            this.clearClientFilteringButton = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subscriptionsSearchButton = new System.Windows.Forms.Button();
            this.subscriptionNameTextBox = new System.Windows.Forms.TextBox();
            this.subscriptionNameLabel = new System.Windows.Forms.Label();
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
            this.clientId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientId1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientId2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subscriptionidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.printClientTrainingsButton = new System.Windows.Forms.Button();
            this.trainingsClientComboBox = new System.Windows.Forms.ComboBox();
            this.filterTrainingsButton = new System.Windows.Forms.Button();
            this.filterClientCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.deleteTrainingButton = new System.Windows.Forms.Button();
            this.editTrainingButton = new System.Windows.Forms.Button();
            this.addTrainingButton = new System.Windows.Forms.Button();
            this.trainingsDataGridView = new System.Windows.Forms.DataGridView();
            this.trainingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poolIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.swimLanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swimlaneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorsTabPage = new System.Windows.Forms.TabPage();
            this.instructorsDataGridView = new System.Windows.Forms.DataGridView();
            this.instructoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poolidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.deleteInstructorButton = new System.Windows.Forms.Button();
            this.editInstructorButton = new System.Windows.Forms.Button();
            this.addInstructorButton = new System.Windows.Forms.Button();
            this.swimLanesTabPage = new System.Windows.Forms.TabPage();
            this.swimLanesDataGridView = new System.Windows.Forms.DataGridView();
            this.swimlaneidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poolidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.deleteSwimLaneButton = new System.Windows.Forms.Button();
            this.editSwimLaneButton = new System.Windows.Forms.Button();
            this.addSwimLaneButton = new System.Windows.Forms.Button();
            this.queryTabPage = new System.Windows.Forms.TabPage();
            this.queryDataGridView = new System.Windows.Forms.DataGridView();
            this.instructorsMostClientsButton = new System.Windows.Forms.Button();
            this.clientsMostTrainingsButton = new System.Windows.Forms.Button();
            this.clientsMostMoneySpentButton = new System.Windows.Forms.Button();
            this.mostPopularSubscriptionsButton = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printVisitorCard = new System.Drawing.Printing.PrintDocument();
            this.clientsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TableAdapterManager();
            this.trainingsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TrainingsTableAdapter();
            this.subscriptionsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter();
            this.visitorCardsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter();
            this.swimLanesTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter();
            this.poolsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.PoolsTableAdapter();
            this.printClientTrainings = new System.Drawing.Printing.PrintDocument();
            this.instructorsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.InstructorsTableAdapter();
            this.poolsTabPage = new System.Windows.Forms.TabPage();
            this.poolsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.deletePoolButton = new System.Windows.Forms.Button();
            this.editPoolButton = new System.Windows.Forms.Button();
            this.addPoolButton = new System.Windows.Forms.Button();
            this.poolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poolidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox2.SuspendLayout();
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
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).BeginInit();
            this.instructorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
            this.panel10.SuspendLayout();
            this.swimLanesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesDataGridView)).BeginInit();
            this.panel11.SuspendLayout();
            this.queryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).BeginInit();
            this.poolsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poolsDataGridView)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poolsBindingSource)).BeginInit();
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
            this.tabControl.Controls.Add(this.instructorsTabPage);
            this.tabControl.Controls.Add(this.swimLanesTabPage);
            this.tabControl.Controls.Add(this.poolsTabPage);
            this.tabControl.Controls.Add(this.queryTabPage);
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
            this.filterGroupBox.Controls.Add(this.clearClientFilteringButton);
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
            // clearClientFilteringButton
            // 
            this.clearClientFilteringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearClientFilteringButton.Location = new System.Drawing.Point(648, 135);
            this.clearClientFilteringButton.Name = "clearClientFilteringButton";
            this.clearClientFilteringButton.Size = new System.Drawing.Size(190, 33);
            this.clearClientFilteringButton.TabIndex = 20;
            this.clearClientFilteringButton.Text = "Очистити фільтри";
            this.clearClientFilteringButton.UseVisualStyleBackColor = true;
            this.clearClientFilteringButton.Click += new System.EventHandler(this.ClearClientFilteringButton_Click);
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
            this.subscriptionsTabPage.Controls.Add(this.groupBox2);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.subscriptionsSearchButton);
            this.groupBox2.Controls.Add(this.subscriptionNameTextBox);
            this.groupBox2.Controls.Add(this.subscriptionNameLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 74);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пошук абонементів";
            // 
            // subscriptionsSearchButton
            // 
            this.subscriptionsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionsSearchButton.Location = new System.Drawing.Point(599, 23);
            this.subscriptionsSearchButton.Name = "subscriptionsSearchButton";
            this.subscriptionsSearchButton.Size = new System.Drawing.Size(121, 38);
            this.subscriptionsSearchButton.TabIndex = 19;
            this.subscriptionsSearchButton.Text = "Шукати";
            this.subscriptionsSearchButton.UseVisualStyleBackColor = true;
            this.subscriptionsSearchButton.Click += new System.EventHandler(this.SubscriptionsSearchButton_Click);
            // 
            // subscriptionNameTextBox
            // 
            this.subscriptionNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionNameTextBox.Location = new System.Drawing.Point(372, 29);
            this.subscriptionNameTextBox.Name = "subscriptionNameTextBox";
            this.subscriptionNameTextBox.Size = new System.Drawing.Size(187, 27);
            this.subscriptionNameTextBox.TabIndex = 4;
            // 
            // subscriptionNameLabel
            // 
            this.subscriptionNameLabel.AutoSize = true;
            this.subscriptionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subscriptionNameLabel.Location = new System.Drawing.Point(300, 32);
            this.subscriptionNameLabel.Name = "subscriptionNameLabel";
            this.subscriptionNameLabel.Size = new System.Drawing.Size(66, 20);
            this.subscriptionNameLabel.TabIndex = 1;
            this.subscriptionNameLabel.Text = "Назва:";
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
            this.clientId,
            this.clientId1,
            this.clientId2,
            this.subscriptionidDataGridViewTextBoxColumn1,
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
            this.cardidDataGridViewTextBoxColumn.Width = 85;
            // 
            // clientId
            // 
            this.clientId.DataPropertyName = "client_id";
            this.clientId.DataSource = this.clientsBindingSource;
            this.clientId.DisplayMember = "first_name";
            this.clientId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clientId.HeaderText = "Ім\'я";
            this.clientId.MinimumWidth = 6;
            this.clientId.Name = "clientId";
            this.clientId.ReadOnly = true;
            this.clientId.ValueMember = "client_id";
            this.clientId.Width = 39;
            // 
            // clientId1
            // 
            this.clientId1.DataPropertyName = "client_id";
            this.clientId1.DataSource = this.clientsBindingSource;
            this.clientId1.DisplayMember = "last_name";
            this.clientId1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clientId1.HeaderText = "Прізвище";
            this.clientId1.MinimumWidth = 6;
            this.clientId1.Name = "clientId1";
            this.clientId1.ReadOnly = true;
            this.clientId1.ValueMember = "client_id";
            this.clientId1.Width = 79;
            // 
            // clientId2
            // 
            this.clientId2.DataPropertyName = "client_id";
            this.clientId2.DataSource = this.clientsBindingSource;
            this.clientId2.DisplayMember = "middle_name";
            this.clientId2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clientId2.HeaderText = "По-батькові";
            this.clientId2.MinimumWidth = 6;
            this.clientId2.Name = "clientId2";
            this.clientId2.ReadOnly = true;
            this.clientId2.ValueMember = "client_id";
            this.clientId2.Width = 99;
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
            this.trainingsTabPage.Controls.Add(this.panel9);
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
            this.groupBox1.Controls.Add(this.printClientTrainingsButton);
            this.groupBox1.Controls.Add(this.trainingsClientComboBox);
            this.groupBox1.Controls.Add(this.filterTrainingsButton);
            this.groupBox1.Controls.Add(this.filterClientCheckBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фільтрація тренувань";
            // 
            // printClientTrainingsButton
            // 
            this.printClientTrainingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printClientTrainingsButton.Location = new System.Drawing.Point(747, 67);
            this.printClientTrainingsButton.Name = "printClientTrainingsButton";
            this.printClientTrainingsButton.Size = new System.Drawing.Size(207, 48);
            this.printClientTrainingsButton.TabIndex = 20;
            this.printClientTrainingsButton.Text = "Роздрукувати тренування клієнта";
            this.printClientTrainingsButton.UseVisualStyleBackColor = true;
            this.printClientTrainingsButton.Click += new System.EventHandler(this.PrintClientTrainingsButton_Click);
            // 
            // trainingsClientComboBox
            // 
            this.trainingsClientComboBox.DataSource = this.clientsBindingSource;
            this.trainingsClientComboBox.DisplayMember = "client_id";
            this.trainingsClientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingsClientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainingsClientComboBox.FormattingEnabled = true;
            this.trainingsClientComboBox.Location = new System.Drawing.Point(386, 43);
            this.trainingsClientComboBox.Name = "trainingsClientComboBox";
            this.trainingsClientComboBox.Size = new System.Drawing.Size(265, 28);
            this.trainingsClientComboBox.TabIndex = 19;
            this.trainingsClientComboBox.ValueMember = "client_id";
            this.trainingsClientComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.TrainingsClientComboBox_Format);
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
            // panel9
            // 
            this.panel9.Controls.Add(this.deleteTrainingButton);
            this.panel9.Controls.Add(this.editTrainingButton);
            this.panel9.Controls.Add(this.addTrainingButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 521);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1030, 100);
            this.panel9.TabIndex = 10;
            // 
            // deleteTrainingButton
            // 
            this.deleteTrainingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTrainingButton.Location = new System.Drawing.Point(730, 26);
            this.deleteTrainingButton.Name = "deleteTrainingButton";
            this.deleteTrainingButton.Size = new System.Drawing.Size(163, 46);
            this.deleteTrainingButton.TabIndex = 2;
            this.deleteTrainingButton.Text = "Видалити";
            this.deleteTrainingButton.UseVisualStyleBackColor = true;
            this.deleteTrainingButton.Click += new System.EventHandler(this.DeleteTrainingButton_Click);
            // 
            // editTrainingButton
            // 
            this.editTrainingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTrainingButton.Location = new System.Drawing.Point(437, 27);
            this.editTrainingButton.Name = "editTrainingButton";
            this.editTrainingButton.Size = new System.Drawing.Size(163, 46);
            this.editTrainingButton.TabIndex = 1;
            this.editTrainingButton.Text = "Редагувати";
            this.editTrainingButton.UseVisualStyleBackColor = true;
            this.editTrainingButton.Click += new System.EventHandler(this.EditTrainingButton_Click);
            // 
            // addTrainingButton
            // 
            this.addTrainingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTrainingButton.Location = new System.Drawing.Point(141, 26);
            this.addTrainingButton.Name = "addTrainingButton";
            this.addTrainingButton.Size = new System.Drawing.Size(163, 46);
            this.addTrainingButton.TabIndex = 0;
            this.addTrainingButton.Text = "Додати";
            this.addTrainingButton.UseVisualStyleBackColor = true;
            this.addTrainingButton.Click += new System.EventHandler(this.AddTrainingButton_Click);
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
            this.cardIdColumn.Width = 107;
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
            // swimLanesBindingSource
            // 
            this.swimLanesBindingSource.DataMember = "SwimLanes";
            this.swimLanesBindingSource.DataSource = this.swimmingpoolDataSet;
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
            // trainingsBindingSource
            // 
            this.trainingsBindingSource.DataMember = "Trainings";
            this.trainingsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // instructorsTabPage
            // 
            this.instructorsTabPage.Controls.Add(this.instructorsDataGridView);
            this.instructorsTabPage.Controls.Add(this.panel10);
            this.instructorsTabPage.Location = new System.Drawing.Point(4, 27);
            this.instructorsTabPage.Name = "instructorsTabPage";
            this.instructorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.instructorsTabPage.Size = new System.Drawing.Size(1036, 624);
            this.instructorsTabPage.TabIndex = 6;
            this.instructorsTabPage.Text = "Інструктори";
            this.instructorsTabPage.UseVisualStyleBackColor = true;
            // 
            // instructorsDataGridView
            // 
            this.instructorsDataGridView.AllowUserToAddRows = false;
            this.instructorsDataGridView.AllowUserToDeleteRows = false;
            this.instructorsDataGridView.AutoGenerateColumns = false;
            this.instructorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.instructorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instructoridDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn1,
            this.lastnameDataGridViewTextBoxColumn1,
            this.middlenameDataGridViewTextBoxColumn1,
            this.salaryDataGridViewTextBoxColumn,
            this.poolidDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1});
            this.instructorsDataGridView.DataSource = this.instructorsBindingSource;
            this.instructorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructorsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.instructorsDataGridView.Name = "instructorsDataGridView";
            this.instructorsDataGridView.ReadOnly = true;
            this.instructorsDataGridView.RowHeadersWidth = 51;
            this.instructorsDataGridView.RowTemplate.Height = 24;
            this.instructorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.instructorsDataGridView.Size = new System.Drawing.Size(1030, 515);
            this.instructorsDataGridView.TabIndex = 9;
            // 
            // instructoridDataGridViewTextBoxColumn
            // 
            this.instructoridDataGridViewTextBoxColumn.DataPropertyName = "instructor_id";
            this.instructoridDataGridViewTextBoxColumn.HeaderText = "instructor_id";
            this.instructoridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructoridDataGridViewTextBoxColumn.Name = "instructoridDataGridViewTextBoxColumn";
            this.instructoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.instructoridDataGridViewTextBoxColumn.Visible = false;
            this.instructoridDataGridViewTextBoxColumn.Width = 118;
            // 
            // firstnameDataGridViewTextBoxColumn1
            // 
            this.firstnameDataGridViewTextBoxColumn1.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn1.HeaderText = "Ім\'я";
            this.firstnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn1.Name = "firstnameDataGridViewTextBoxColumn1";
            this.firstnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn1.Width = 62;
            // 
            // lastnameDataGridViewTextBoxColumn1
            // 
            this.lastnameDataGridViewTextBoxColumn1.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn1.HeaderText = "Прізвище";
            this.lastnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn1.Name = "lastnameDataGridViewTextBoxColumn1";
            this.lastnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn1.Width = 102;
            // 
            // middlenameDataGridViewTextBoxColumn1
            // 
            this.middlenameDataGridViewTextBoxColumn1.DataPropertyName = "middle_name";
            this.middlenameDataGridViewTextBoxColumn1.HeaderText = "По-батькові";
            this.middlenameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.middlenameDataGridViewTextBoxColumn1.Name = "middlenameDataGridViewTextBoxColumn1";
            this.middlenameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.middlenameDataGridViewTextBoxColumn1.Width = 122;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 103;
            // 
            // poolidDataGridViewTextBoxColumn
            // 
            this.poolidDataGridViewTextBoxColumn.DataPropertyName = "pool_id";
            this.poolidDataGridViewTextBoxColumn.HeaderText = "Номер басейна";
            this.poolidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poolidDataGridViewTextBoxColumn.Name = "poolidDataGridViewTextBoxColumn";
            this.poolidDataGridViewTextBoxColumn.ReadOnly = true;
            this.poolidDataGridViewTextBoxColumn.Width = 133;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Електронна пошта";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn1.Width = 153;
            // 
            // instructorsBindingSource
            // 
            this.instructorsBindingSource.DataMember = "Instructors";
            this.instructorsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.deleteInstructorButton);
            this.panel10.Controls.Add(this.editInstructorButton);
            this.panel10.Controls.Add(this.addInstructorButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(3, 518);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1030, 103);
            this.panel10.TabIndex = 8;
            // 
            // deleteInstructorButton
            // 
            this.deleteInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteInstructorButton.Location = new System.Drawing.Point(728, 27);
            this.deleteInstructorButton.Name = "deleteInstructorButton";
            this.deleteInstructorButton.Size = new System.Drawing.Size(163, 46);
            this.deleteInstructorButton.TabIndex = 2;
            this.deleteInstructorButton.Text = "Видалити";
            this.deleteInstructorButton.UseVisualStyleBackColor = true;
            this.deleteInstructorButton.Click += new System.EventHandler(this.DeleteInstructorButton_Click);
            // 
            // editInstructorButton
            // 
            this.editInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editInstructorButton.Location = new System.Drawing.Point(435, 28);
            this.editInstructorButton.Name = "editInstructorButton";
            this.editInstructorButton.Size = new System.Drawing.Size(163, 46);
            this.editInstructorButton.TabIndex = 1;
            this.editInstructorButton.Text = "Редагувати";
            this.editInstructorButton.UseVisualStyleBackColor = true;
            this.editInstructorButton.Click += new System.EventHandler(this.EditInstructorButton_Click);
            // 
            // addInstructorButton
            // 
            this.addInstructorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInstructorButton.Location = new System.Drawing.Point(139, 27);
            this.addInstructorButton.Name = "addInstructorButton";
            this.addInstructorButton.Size = new System.Drawing.Size(163, 46);
            this.addInstructorButton.TabIndex = 0;
            this.addInstructorButton.Text = "Додати";
            this.addInstructorButton.UseVisualStyleBackColor = true;
            this.addInstructorButton.Click += new System.EventHandler(this.AddInstructorButton_Click);
            // 
            // swimLanesTabPage
            // 
            this.swimLanesTabPage.Controls.Add(this.swimLanesDataGridView);
            this.swimLanesTabPage.Controls.Add(this.panel11);
            this.swimLanesTabPage.Location = new System.Drawing.Point(4, 27);
            this.swimLanesTabPage.Name = "swimLanesTabPage";
            this.swimLanesTabPage.Size = new System.Drawing.Size(1036, 624);
            this.swimLanesTabPage.TabIndex = 7;
            this.swimLanesTabPage.Text = "Доріжки";
            this.swimLanesTabPage.UseVisualStyleBackColor = true;
            // 
            // swimLanesDataGridView
            // 
            this.swimLanesDataGridView.AllowUserToAddRows = false;
            this.swimLanesDataGridView.AllowUserToDeleteRows = false;
            this.swimLanesDataGridView.AutoGenerateColumns = false;
            this.swimLanesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.swimLanesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.swimLanesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.swimlaneidDataGridViewTextBoxColumn1,
            this.poolidDataGridViewTextBoxColumn1});
            this.swimLanesDataGridView.DataSource = this.swimLanesBindingSource;
            this.swimLanesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swimLanesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.swimLanesDataGridView.Name = "swimLanesDataGridView";
            this.swimLanesDataGridView.ReadOnly = true;
            this.swimLanesDataGridView.RowHeadersWidth = 51;
            this.swimLanesDataGridView.RowTemplate.Height = 24;
            this.swimLanesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.swimLanesDataGridView.Size = new System.Drawing.Size(1036, 521);
            this.swimLanesDataGridView.TabIndex = 11;
            // 
            // swimlaneidDataGridViewTextBoxColumn1
            // 
            this.swimlaneidDataGridViewTextBoxColumn1.DataPropertyName = "swimlane_id";
            this.swimlaneidDataGridViewTextBoxColumn1.HeaderText = "Номер доріжки";
            this.swimlaneidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.swimlaneidDataGridViewTextBoxColumn1.Name = "swimlaneidDataGridViewTextBoxColumn1";
            this.swimlaneidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.swimlaneidDataGridViewTextBoxColumn1.Width = 132;
            // 
            // poolidDataGridViewTextBoxColumn1
            // 
            this.poolidDataGridViewTextBoxColumn1.DataPropertyName = "pool_id";
            this.poolidDataGridViewTextBoxColumn1.HeaderText = "Номер басейна";
            this.poolidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.poolidDataGridViewTextBoxColumn1.Name = "poolidDataGridViewTextBoxColumn1";
            this.poolidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.poolidDataGridViewTextBoxColumn1.Width = 133;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.deleteSwimLaneButton);
            this.panel11.Controls.Add(this.editSwimLaneButton);
            this.panel11.Controls.Add(this.addSwimLaneButton);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 521);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1036, 103);
            this.panel11.TabIndex = 10;
            // 
            // deleteSwimLaneButton
            // 
            this.deleteSwimLaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSwimLaneButton.Location = new System.Drawing.Point(728, 27);
            this.deleteSwimLaneButton.Name = "deleteSwimLaneButton";
            this.deleteSwimLaneButton.Size = new System.Drawing.Size(163, 46);
            this.deleteSwimLaneButton.TabIndex = 2;
            this.deleteSwimLaneButton.Text = "Видалити";
            this.deleteSwimLaneButton.UseVisualStyleBackColor = true;
            this.deleteSwimLaneButton.Click += new System.EventHandler(this.DeleteSwimLaneButton_Click);
            // 
            // editSwimLaneButton
            // 
            this.editSwimLaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSwimLaneButton.Location = new System.Drawing.Point(435, 28);
            this.editSwimLaneButton.Name = "editSwimLaneButton";
            this.editSwimLaneButton.Size = new System.Drawing.Size(163, 46);
            this.editSwimLaneButton.TabIndex = 1;
            this.editSwimLaneButton.Text = "Редагувати";
            this.editSwimLaneButton.UseVisualStyleBackColor = true;
            this.editSwimLaneButton.Click += new System.EventHandler(this.EditSwimLaneButton_Click);
            // 
            // addSwimLaneButton
            // 
            this.addSwimLaneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSwimLaneButton.Location = new System.Drawing.Point(139, 27);
            this.addSwimLaneButton.Name = "addSwimLaneButton";
            this.addSwimLaneButton.Size = new System.Drawing.Size(163, 46);
            this.addSwimLaneButton.TabIndex = 0;
            this.addSwimLaneButton.Text = "Додати";
            this.addSwimLaneButton.UseVisualStyleBackColor = true;
            this.addSwimLaneButton.Click += new System.EventHandler(this.AddSwimLaneButton_Click);
            // 
            // queryTabPage
            // 
            this.queryTabPage.Controls.Add(this.queryDataGridView);
            this.queryTabPage.Controls.Add(this.instructorsMostClientsButton);
            this.queryTabPage.Controls.Add(this.clientsMostTrainingsButton);
            this.queryTabPage.Controls.Add(this.clientsMostMoneySpentButton);
            this.queryTabPage.Controls.Add(this.mostPopularSubscriptionsButton);
            this.queryTabPage.Location = new System.Drawing.Point(4, 27);
            this.queryTabPage.Name = "queryTabPage";
            this.queryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.queryTabPage.Size = new System.Drawing.Size(1036, 624);
            this.queryTabPage.TabIndex = 4;
            this.queryTabPage.Text = "Запити";
            this.queryTabPage.UseVisualStyleBackColor = true;
            // 
            // queryDataGridView
            // 
            this.queryDataGridView.AllowUserToAddRows = false;
            this.queryDataGridView.AllowUserToDeleteRows = false;
            this.queryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.queryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryDataGridView.Location = new System.Drawing.Point(30, 134);
            this.queryDataGridView.Name = "queryDataGridView";
            this.queryDataGridView.ReadOnly = true;
            this.queryDataGridView.RowHeadersWidth = 51;
            this.queryDataGridView.RowTemplate.Height = 24;
            this.queryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queryDataGridView.Size = new System.Drawing.Size(971, 459);
            this.queryDataGridView.TabIndex = 9;
            // 
            // instructorsMostClientsButton
            // 
            this.instructorsMostClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructorsMostClientsButton.Location = new System.Drawing.Point(767, 52);
            this.instructorsMostClientsButton.Name = "instructorsMostClientsButton";
            this.instructorsMostClientsButton.Size = new System.Drawing.Size(234, 48);
            this.instructorsMostClientsButton.TabIndex = 3;
            this.instructorsMostClientsButton.Text = "Інструктори, у яких зараз найбільше клієнтів";
            this.instructorsMostClientsButton.UseVisualStyleBackColor = true;
            this.instructorsMostClientsButton.Click += new System.EventHandler(this.InstructorsMostClientsButton_Click);
            // 
            // clientsMostTrainingsButton
            // 
            this.clientsMostTrainingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsMostTrainingsButton.Location = new System.Drawing.Point(518, 52);
            this.clientsMostTrainingsButton.Name = "clientsMostTrainingsButton";
            this.clientsMostTrainingsButton.Size = new System.Drawing.Size(214, 48);
            this.clientsMostTrainingsButton.TabIndex = 2;
            this.clientsMostTrainingsButton.Text = "Клієнти, що відвідали найбільше тренувань";
            this.clientsMostTrainingsButton.UseVisualStyleBackColor = true;
            this.clientsMostTrainingsButton.Click += new System.EventHandler(this.ClientsMostTrainingsButton_Click);
            // 
            // clientsMostMoneySpentButton
            // 
            this.clientsMostMoneySpentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsMostMoneySpentButton.Location = new System.Drawing.Point(257, 52);
            this.clientsMostMoneySpentButton.Name = "clientsMostMoneySpentButton";
            this.clientsMostMoneySpentButton.Size = new System.Drawing.Size(222, 48);
            this.clientsMostMoneySpentButton.TabIndex = 1;
            this.clientsMostMoneySpentButton.Text = "Клієнти, що витратили найбільше грошей";
            this.clientsMostMoneySpentButton.UseVisualStyleBackColor = true;
            this.clientsMostMoneySpentButton.Click += new System.EventHandler(this.ClientsMostMoneySpentButton_Click);
            // 
            // mostPopularSubscriptionsButton
            // 
            this.mostPopularSubscriptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mostPopularSubscriptionsButton.Location = new System.Drawing.Point(30, 52);
            this.mostPopularSubscriptionsButton.Name = "mostPopularSubscriptionsButton";
            this.mostPopularSubscriptionsButton.Size = new System.Drawing.Size(187, 48);
            this.mostPopularSubscriptionsButton.TabIndex = 0;
            this.mostPopularSubscriptionsButton.Text = "Найпопулярніші абонементи";
            this.mostPopularSubscriptionsButton.UseVisualStyleBackColor = true;
            this.mostPopularSubscriptionsButton.Click += new System.EventHandler(this.MostPopularSubscriptionsButton_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printVisitorCard
            // 
            this.printVisitorCard.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintVisitorCard_PrintPage);
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
            // printClientTrainings
            // 
            this.printClientTrainings.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintClientTrainings_BeginPrint);
            this.printClientTrainings.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintClientTrainings_EndPrint);
            this.printClientTrainings.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintClientTrainings_PrintPage);
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // poolsTabPage
            // 
            this.poolsTabPage.Controls.Add(this.poolsDataGridView);
            this.poolsTabPage.Controls.Add(this.panel12);
            this.poolsTabPage.Location = new System.Drawing.Point(4, 27);
            this.poolsTabPage.Name = "poolsTabPage";
            this.poolsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.poolsTabPage.Size = new System.Drawing.Size(1036, 624);
            this.poolsTabPage.TabIndex = 8;
            this.poolsTabPage.Text = "Басейни";
            this.poolsTabPage.UseVisualStyleBackColor = true;
            // 
            // poolsDataGridView
            // 
            this.poolsDataGridView.AllowUserToAddRows = false;
            this.poolsDataGridView.AllowUserToDeleteRows = false;
            this.poolsDataGridView.AutoGenerateColumns = false;
            this.poolsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.poolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poolsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poolidDataGridViewTextBoxColumn2,
            this.capacity});
            this.poolsDataGridView.DataSource = this.poolsBindingSource;
            this.poolsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poolsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.poolsDataGridView.Name = "poolsDataGridView";
            this.poolsDataGridView.ReadOnly = true;
            this.poolsDataGridView.RowHeadersWidth = 51;
            this.poolsDataGridView.RowTemplate.Height = 24;
            this.poolsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poolsDataGridView.Size = new System.Drawing.Size(1030, 515);
            this.poolsDataGridView.TabIndex = 13;
            this.poolsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PoolsDataGridView_CellFormatting);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.deletePoolButton);
            this.panel12.Controls.Add(this.editPoolButton);
            this.panel12.Controls.Add(this.addPoolButton);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(3, 518);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1030, 103);
            this.panel12.TabIndex = 12;
            // 
            // deletePoolButton
            // 
            this.deletePoolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePoolButton.Location = new System.Drawing.Point(728, 27);
            this.deletePoolButton.Name = "deletePoolButton";
            this.deletePoolButton.Size = new System.Drawing.Size(163, 46);
            this.deletePoolButton.TabIndex = 2;
            this.deletePoolButton.Text = "Видалити";
            this.deletePoolButton.UseVisualStyleBackColor = true;
            this.deletePoolButton.Click += new System.EventHandler(this.DeletePoolButton_Click);
            // 
            // editPoolButton
            // 
            this.editPoolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPoolButton.Location = new System.Drawing.Point(435, 28);
            this.editPoolButton.Name = "editPoolButton";
            this.editPoolButton.Size = new System.Drawing.Size(163, 46);
            this.editPoolButton.TabIndex = 1;
            this.editPoolButton.Text = "Редагувати";
            this.editPoolButton.UseVisualStyleBackColor = true;
            this.editPoolButton.Click += new System.EventHandler(this.EditPoolButton_Click);
            // 
            // addPoolButton
            // 
            this.addPoolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPoolButton.Location = new System.Drawing.Point(139, 27);
            this.addPoolButton.Name = "addPoolButton";
            this.addPoolButton.Size = new System.Drawing.Size(163, 46);
            this.addPoolButton.TabIndex = 0;
            this.addPoolButton.Text = "Додати";
            this.addPoolButton.UseVisualStyleBackColor = true;
            this.addPoolButton.Click += new System.EventHandler(this.AddPoolButton_Click);
            // 
            // poolsBindingSource
            // 
            this.poolsBindingSource.DataMember = "Pools";
            this.poolsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // poolidDataGridViewTextBoxColumn2
            // 
            this.poolidDataGridViewTextBoxColumn2.DataPropertyName = "pool_id";
            this.poolidDataGridViewTextBoxColumn2.HeaderText = "Номер басейна";
            this.poolidDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.poolidDataGridViewTextBoxColumn2.Name = "poolidDataGridViewTextBoxColumn2";
            this.poolidDataGridViewTextBoxColumn2.ReadOnly = true;
            this.poolidDataGridViewTextBoxColumn2.Width = 133;
            // 
            // capacity
            // 
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Місткість";
            this.capacity.MinimumWidth = 6;
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.Width = 102;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).EndInit();
            this.instructorsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.instructorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
            this.panel10.ResumeLayout(false);
            this.swimLanesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesDataGridView)).EndInit();
            this.panel11.ResumeLayout(false);
            this.queryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).EndInit();
            this.poolsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poolsDataGridView)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poolsBindingSource)).EndInit();
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
        private System.Drawing.Printing.PrintDocument printVisitorCard;
        private TabPage trainingsTabPage;
        private BindingSource trainingsBindingSource;
        private DataGridView trainingsDataGridView;
        private GroupBox groupBox1;
        private Button filterTrainingsButton;
        private CheckBox filterClientCheckBox;
        private Label label10;
        private ComboBox trainingsClientComboBox;
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
        private Button printClientTrainingsButton;
        private System.Drawing.Printing.PrintDocument printClientTrainings;
        private DataGridViewTextBoxColumn cardidDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn clientId;
        private DataGridViewComboBoxColumn clientId1;
        private DataGridViewComboBoxColumn clientId2;
        private DataGridViewComboBoxColumn subscriptionidDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirydateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn attendanceleftcountDataGridViewTextBoxColumn;
        private Panel panel9;
        private Button deleteTrainingButton;
        private Button editTrainingButton;
        private Button addTrainingButton;
        private Button clearClientFilteringButton;
        private TabPage queryTabPage;
        private Button mostPopularSubscriptionsButton;
        private Button clientsMostMoneySpentButton;
        private Button clientsMostTrainingsButton;
        private Button instructorsMostClientsButton;
        private DataGridView queryDataGridView;
        private swimmingpoolDataSetTableAdapters.InstructorsTableAdapter instructorsTableAdapter;
        private GroupBox groupBox2;
        private Button subscriptionsSearchButton;
        private TextBox subscriptionNameTextBox;
        private Label subscriptionNameLabel;
        private TabPage instructorsTabPage;
        private DataGridView instructorsDataGridView;
        private BindingSource instructorsBindingSource;
        private Panel panel10;
        private Button deleteInstructorButton;
        private Button editInstructorButton;
        private Button addInstructorButton;
        private DataGridViewTextBoxColumn instructoridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn poolidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private TabPage swimLanesTabPage;
        private DataGridView swimLanesDataGridView;
        private Panel panel11;
        private Button deleteSwimLaneButton;
        private Button editSwimLaneButton;
        private Button addSwimLaneButton;
        private DataGridViewTextBoxColumn swimlaneidDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn poolidDataGridViewTextBoxColumn1;
        private TabPage poolsTabPage;
        private DataGridView poolsDataGridView;
        private BindingSource poolsBindingSource;
        private Panel panel12;
        private Button deletePoolButton;
        private Button editPoolButton;
        private Button addPoolButton;
        private DataGridViewTextBoxColumn poolidDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn capacity;
    }
}