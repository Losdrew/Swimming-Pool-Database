namespace Swimming_Pool_Database.Forms
{
    partial class EditForm
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
            this.swimmingpoolDataSet = new Swimming_Pool_Database.swimmingpoolDataSet();
            this.clientsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.ClientsTableAdapter();
            this.coachesTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.CoachesTableAdapter();
            this.groupsTableAdapter = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.GroupsTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // coachesTableAdapter
            // 
            this.coachesTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // coachesBindingSource
            // 
            this.coachesBindingSource.DataMember = "Coaches";
            this.coachesBindingSource.DataSource = this.swimmingpoolDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.CoachesTableAdapter = this.coachesTableAdapter;
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Swimming_Pool_Database.swimmingpoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.swimmingpoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected swimmingpoolDataSet swimmingpoolDataSet;
        protected swimmingpoolDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        protected swimmingpoolDataSetTableAdapters.CoachesTableAdapter coachesTableAdapter;
        protected swimmingpoolDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        protected System.Windows.Forms.BindingSource clientsBindingSource;
        protected System.Windows.Forms.BindingSource groupsBindingSource;
        protected System.Windows.Forms.BindingSource coachesBindingSource;
        protected swimmingpoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}