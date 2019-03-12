namespace ProjectB
{
    partial class CLO
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddCLO = new System.Windows.Forms.TabPage();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAddCLO = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabViewCLO = new System.Windows.Forms.TabPage();
            this.btnViewCLO = new System.Windows.Forms.Button();
            this.gridCLO = new System.Windows.Forms.DataGridView();
            this.projectBDataSet1 = new ProjectB.ProjectBDataSet1();
            this.cloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cloTableAdapter = new ProjectB.ProjectBDataSet1TableAdapters.CloTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabAddCLO.SuspendLayout();
            this.tabViewCLO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCLO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddCLO);
            this.tabControl1.Controls.Add(this.tabViewCLO);
            this.tabControl1.Location = new System.Drawing.Point(75, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 312);
            this.tabControl1.TabIndex = 4;
            // 
            // tabAddCLO
            // 
            this.tabAddCLO.Controls.Add(this.lblId);
            this.tabAddCLO.Controls.Add(this.btnAddCLO);
            this.tabAddCLO.Controls.Add(this.txtName);
            this.tabAddCLO.Controls.Add(this.lblName);
            this.tabAddCLO.Location = new System.Drawing.Point(4, 22);
            this.tabAddCLO.Name = "tabAddCLO";
            this.tabAddCLO.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCLO.Size = new System.Drawing.Size(689, 286);
            this.tabAddCLO.TabIndex = 0;
            this.tabAddCLO.Text = "Add CLO";
            this.tabAddCLO.UseVisualStyleBackColor = true;
            this.tabAddCLO.Click += new System.EventHandler(this.tabAddCLO_Click);
            
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID";
            // 
            // btnAddCLO
            // 
            this.btnAddCLO.Location = new System.Drawing.Point(131, 116);
            this.btnAddCLO.Name = "btnAddCLO";
            this.btnAddCLO.Size = new System.Drawing.Size(75, 23);
            this.btnAddCLO.TabIndex = 6;
            this.btnAddCLO.Text = "Add CLO";
            this.btnAddCLO.UseVisualStyleBackColor = true;
            this.btnAddCLO.Click += new System.EventHandler(this.btnAddCLO_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // tabViewCLO
            // 
            this.tabViewCLO.Controls.Add(this.btnViewCLO);
            this.tabViewCLO.Controls.Add(this.gridCLO);
            this.tabViewCLO.Location = new System.Drawing.Point(4, 22);
            this.tabViewCLO.Name = "tabViewCLO";
            this.tabViewCLO.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewCLO.Size = new System.Drawing.Size(689, 286);
            this.tabViewCLO.TabIndex = 1;
            this.tabViewCLO.Text = "View CLO";
            this.tabViewCLO.UseVisualStyleBackColor = true;
            // 
            // btnViewCLO
            // 
            this.btnViewCLO.Location = new System.Drawing.Point(339, 72);
            this.btnViewCLO.Name = "btnViewCLO";
            this.btnViewCLO.Size = new System.Drawing.Size(75, 23);
            this.btnViewCLO.TabIndex = 1;
            this.btnViewCLO.Text = "View CLO";
            this.btnViewCLO.UseVisualStyleBackColor = true;
            this.btnViewCLO.Click += new System.EventHandler(this.btnViewCLO_Click);
            // 
            // gridCLO
            // 
            this.gridCLO.AutoGenerateColumns = false;
            this.gridCLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCLO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.gridCLO.DataSource = this.cloBindingSource;
            this.gridCLO.Location = new System.Drawing.Point(6, 116);
            this.gridCLO.Name = "gridCLO";
            this.gridCLO.Size = new System.Drawing.Size(643, 150);
            this.gridCLO.TabIndex = 0;
            this.gridCLO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCLO_CellClick);
            // 
            // projectBDataSet1
            // 
            this.projectBDataSet1.DataSetName = "ProjectBDataSet1";
            this.projectBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cloBindingSource
            // 
            this.cloBindingSource.DataMember = "Clo";
            this.cloBindingSource.DataSource = this.projectBDataSet1;
            // 
            // cloTableAdapter
            // 
            this.cloTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "DateUpdated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // CLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "CLO";
            this.Text = "CLO";
            this.Load += new System.EventHandler(this.CLO_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAddCLO.ResumeLayout(false);
            this.tabAddCLO.PerformLayout();
            this.tabViewCLO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCLO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddCLO;
        private System.Windows.Forms.Button btnAddCLO;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabViewCLO;
        private System.Windows.Forms.DataGridView gridCLO;
        private System.Windows.Forms.Button btnViewCLO;
        private System.Windows.Forms.Label lblId;
        private ProjectBDataSet1 projectBDataSet1;
        private System.Windows.Forms.BindingSource cloBindingSource;
        private ProjectBDataSet1TableAdapters.CloTableAdapter cloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}