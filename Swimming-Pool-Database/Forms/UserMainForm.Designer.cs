namespace Swimming_Pool_Database.Forms
{
    partial class UserMainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.subscriptionsTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.subscriptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.subscriptionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendancecount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daycount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editClientButton = new System.Windows.Forms.Button();
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
            this.visitorCardTabPage = new System.Windows.Forms.TabPage();
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
            this.trainingsTabPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.printClientTrainingsButton = new System.Windows.Forms.Button();
            this.trainingsDataGridView = new System.Windows.Forms.DataGridView();
            this.swimLanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.ClientsTableAdapter();
            this.subscriptionsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter();
            this.visitorCardsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printVisitorCard = new System.Drawing.Printing.PrintDocument();
            this.trainingsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TrainingsTableAdapter();
            this.poolsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.PoolsTableAdapter();
            this.swimLanesTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter();
            this.printClientTrainings = new System.Drawing.Printing.PrintDocument();
            this.trainingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.swimlane_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.swimlaneidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            this.tabControl.SuspendLayout();
            this.subscriptionsTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).BeginInit();
            this.profileTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.visitorCardTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.trainingsTabPage.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(999, 28);
            this.menuStrip.TabIndex = 0;
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.subscriptionsTabPage);
            this.tabControl.Controls.Add(this.profileTabPage);
            this.tabControl.Controls.Add(this.visitorCardTabPage);
            this.tabControl.Controls.Add(this.trainingsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(999, 422);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // subscriptionsTabPage
            // 
            this.subscriptionsTabPage.Controls.Add(this.panel1);
            this.subscriptionsTabPage.Controls.Add(this.subscriptionsDataGridView);
            this.subscriptionsTabPage.Location = new System.Drawing.Point(4, 27);
            this.subscriptionsTabPage.Name = "subscriptionsTabPage";
            this.subscriptionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.subscriptionsTabPage.Size = new System.Drawing.Size(991, 391);
            this.subscriptionsTabPage.TabIndex = 0;
            this.subscriptionsTabPage.Text = "Абонементи";
            this.subscriptionsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 100);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(406, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Оформити абонемент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OrderButton_Click);
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
            this.subscriptionsDataGridView.Size = new System.Drawing.Size(985, 385);
            this.subscriptionsDataGridView.TabIndex = 0;
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
            this.subscriptionidDataGridViewTextBoxColumn.Width = 136;
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
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.panel2);
            this.profileTabPage.Controls.Add(this.clientsDataGridView);
            this.profileTabPage.Location = new System.Drawing.Point(4, 27);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.profileTabPage.Size = new System.Drawing.Size(991, 391);
            this.profileTabPage.TabIndex = 1;
            this.profileTabPage.Text = "Профіль";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editClientButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 100);
            this.panel2.TabIndex = 4;
            // 
            // editClientButton
            // 
            this.editClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editClientButton.Location = new System.Drawing.Point(386, 30);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(236, 46);
            this.editClientButton.TabIndex = 1;
            this.editClientButton.Text = "Редагувати інформацію";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
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
            this.clientsDataGridView.Size = new System.Drawing.Size(985, 385);
            this.clientsDataGridView.TabIndex = 1;
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
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // visitorCardTabPage
            // 
            this.visitorCardTabPage.Controls.Add(this.visitorCardsDataGridView);
            this.visitorCardTabPage.Controls.Add(this.panel3);
            this.visitorCardTabPage.Location = new System.Drawing.Point(4, 27);
            this.visitorCardTabPage.Name = "visitorCardTabPage";
            this.visitorCardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.visitorCardTabPage.Size = new System.Drawing.Size(991, 391);
            this.visitorCardTabPage.TabIndex = 2;
            this.visitorCardTabPage.Text = "Картка відвідувача";
            this.visitorCardTabPage.UseVisualStyleBackColor = true;
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
            this.visitorCardsDataGridView.Size = new System.Drawing.Size(985, 285);
            this.visitorCardsDataGridView.TabIndex = 6;
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
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 100);
            this.panel3.TabIndex = 5;
            // 
            // printVisitorCardButton
            // 
            this.printVisitorCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printVisitorCardButton.Location = new System.Drawing.Point(208, 26);
            this.printVisitorCardButton.Name = "printVisitorCardButton";
            this.printVisitorCardButton.Size = new System.Drawing.Size(259, 46);
            this.printVisitorCardButton.TabIndex = 3;
            this.printVisitorCardButton.Text = "Роздрукувати обрану картку";
            this.printVisitorCardButton.UseVisualStyleBackColor = true;
            this.printVisitorCardButton.Click += new System.EventHandler(this.PrintVisitorCardButton_Click);
            // 
            // deleteVisitorCardButton
            // 
            this.deleteVisitorCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteVisitorCardButton.Location = new System.Drawing.Point(544, 26);
            this.deleteVisitorCardButton.Name = "deleteVisitorCardButton";
            this.deleteVisitorCardButton.Size = new System.Drawing.Size(245, 46);
            this.deleteVisitorCardButton.TabIndex = 2;
            this.deleteVisitorCardButton.Text = "Видалити поточну картку";
            this.deleteVisitorCardButton.UseVisualStyleBackColor = true;
            this.deleteVisitorCardButton.Click += new System.EventHandler(this.DeleteVisitorCardButton_Click);
            // 
            // trainingsTabPage
            // 
            this.trainingsTabPage.Controls.Add(this.panel4);
            this.trainingsTabPage.Controls.Add(this.trainingsDataGridView);
            this.trainingsTabPage.Location = new System.Drawing.Point(4, 27);
            this.trainingsTabPage.Name = "trainingsTabPage";
            this.trainingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trainingsTabPage.Size = new System.Drawing.Size(991, 391);
            this.trainingsTabPage.TabIndex = 4;
            this.trainingsTabPage.Text = "Тренування";
            this.trainingsTabPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.printClientTrainingsButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(985, 100);
            this.panel4.TabIndex = 8;
            // 
            // printClientTrainingsButton
            // 
            this.printClientTrainingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printClientTrainingsButton.Location = new System.Drawing.Point(352, 27);
            this.printClientTrainingsButton.Name = "printClientTrainingsButton";
            this.printClientTrainingsButton.Size = new System.Drawing.Size(301, 46);
            this.printClientTrainingsButton.TabIndex = 4;
            this.printClientTrainingsButton.Text = "Роздрукувати історію тренувань";
            this.printClientTrainingsButton.UseVisualStyleBackColor = true;
            this.printClientTrainingsButton.Click += new System.EventHandler(this.PrintClientTrainingsButton_Click);
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
            this.swimlane_id,
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
            this.trainingsDataGridView.Size = new System.Drawing.Size(985, 385);
            this.trainingsDataGridView.TabIndex = 7;
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
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // visitorCardsTableAdapter
            // 
            this.visitorCardsTableAdapter.ClearBeforeFill = true;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printVisitorCard
            // 
            this.printVisitorCard.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintVisitorCard_PrintPage);
            // 
            // trainingsTableAdapter
            // 
            this.trainingsTableAdapter.ClearBeforeFill = true;
            // 
            // poolsTableAdapter
            // 
            this.poolsTableAdapter.ClearBeforeFill = true;
            // 
            // swimLanesTableAdapter
            // 
            this.swimLanesTableAdapter.ClearBeforeFill = true;
            // 
            // printClientTrainings
            // 
            this.printClientTrainings.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintClientTrainings_BeginPrint);
            this.printClientTrainings.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintClientTrainings_PrintPage);
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
            this.cardIdColumn.DataSource = this.visitorCardsBindingSource;
            this.cardIdColumn.DisplayMember = "card_id";
            this.cardIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cardIdColumn.HeaderText = "ПІБ клієнта";
            this.cardIdColumn.MinimumWidth = 6;
            this.cardIdColumn.Name = "cardIdColumn";
            this.cardIdColumn.ReadOnly = true;
            this.cardIdColumn.ValueMember = "card_id";
            this.cardIdColumn.Visible = false;
            this.cardIdColumn.Width = 93;
            // 
            // swimlane_id
            // 
            this.swimlane_id.DataPropertyName = "swimlane_id";
            this.swimlane_id.DataSource = this.swimLanesBindingSource;
            this.swimlane_id.DisplayMember = "pool_id";
            this.swimlane_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.swimlane_id.HeaderText = "Номер басейна";
            this.swimlane_id.MinimumWidth = 6;
            this.swimlane_id.Name = "swimlane_id";
            this.swimlane_id.ReadOnly = true;
            this.swimlane_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.swimlane_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.swimlane_id.ValueMember = "swimlane_id";
            this.swimlane_id.Width = 133;
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
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "UserMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Користувач";
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.subscriptionsTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).EndInit();
            this.profileTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.visitorCardTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCardsBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.trainingsTabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimLanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private swimmingpoolDataSet swimmingpoolDataSet;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage subscriptionsTabPage;
        private System.Windows.Forms.TabPage profileTabPage;
        private System.Windows.Forms.DataGridView subscriptionsDataGridView;
        private System.Windows.Forms.BindingSource subscriptionsBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparationlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.TabPage visitorCardTabPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button deleteVisitorCardButton;
        private System.Windows.Forms.DataGridView visitorCardsDataGridView;
        private swimmingpoolDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private swimmingpoolDataSetTableAdapters.SubscriptionsTableAdapter subscriptionsTableAdapter;
        private System.Windows.Forms.BindingSource visitorCardsBindingSource;
        private swimmingpoolDataSetTableAdapters.VisitorCardsTableAdapter visitorCardsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendancecount;
        private System.Windows.Forms.DataGridViewTextBoxColumn daycount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn subscriptionidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn clientidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn client_idLastName;
        private System.Windows.Forms.DataGridViewComboBoxColumn client_idMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceleftcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printVisitorCard;
        private System.Windows.Forms.Button printVisitorCardButton;
        private System.Windows.Forms.TabPage trainingsTabPage;
        private System.Windows.Forms.DataGridView trainingsDataGridView;
        private System.Windows.Forms.BindingSource trainingsBindingSource;
        private swimmingpoolDataSetTableAdapters.TrainingsTableAdapter trainingsTableAdapter;
        private swimmingpoolDataSetTableAdapters.PoolsTableAdapter poolsTableAdapter;
        private System.Windows.Forms.BindingSource swimLanesBindingSource;
        private swimmingpoolDataSetTableAdapters.SwimLanesTableAdapter swimLanesTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button printClientTrainingsButton;
        private System.Drawing.Printing.PrintDocument printClientTrainings;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cardIdColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn swimlane_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn swimlaneidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockeridDataGridViewTextBoxColumn;
    }
}