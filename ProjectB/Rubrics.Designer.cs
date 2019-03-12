namespace ProjectB
{
    partial class Rubrics
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
            this.tabAddRubric = new System.Windows.Forms.TabPage();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAddRubric = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbCloId = new System.Windows.Forms.ComboBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lblCLOId = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.tabViewRubric = new System.Windows.Forms.TabPage();
            this.gridViewRubrics = new System.Windows.Forms.DataGridView();
            this.btnViewRubric = new System.Windows.Forms.Button();
            this.projectBDataSet2 = new ProjectB.ProjectBDataSet2();
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new ProjectB.ProjectBDataSet2TableAdapters.RubricTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabAddRubric.SuspendLayout();
            this.tabViewRubric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddRubric);
            this.tabControl1.Controls.Add(this.tabViewRubric);
            this.tabControl1.Location = new System.Drawing.Point(31, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 258);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAddRubric
            // 
            this.tabAddRubric.Controls.Add(this.lblId);
            this.tabAddRubric.Controls.Add(this.btnAddRubric);
            this.tabAddRubric.Controls.Add(this.txtID);
            this.tabAddRubric.Controls.Add(this.cmbCloId);
            this.tabAddRubric.Controls.Add(this.txtDetail);
            this.tabAddRubric.Controls.Add(this.lblCLOId);
            this.tabAddRubric.Controls.Add(this.lblDetail);
            this.tabAddRubric.Location = new System.Drawing.Point(4, 22);
            this.tabAddRubric.Name = "tabAddRubric";
            this.tabAddRubric.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddRubric.Size = new System.Drawing.Size(523, 232);
            this.tabAddRubric.TabIndex = 0;
            this.tabAddRubric.Text = "Add Rubrics";
            this.tabAddRubric.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(102, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            // 
            // btnAddRubric
            // 
            this.btnAddRubric.Location = new System.Drawing.Point(175, 173);
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.Size = new System.Drawing.Size(75, 23);
            this.btnAddRubric.TabIndex = 4;
            this.btnAddRubric.Text = "Add Rubric";
            this.btnAddRubric.UseVisualStyleBackColor = true;
            this.btnAddRubric.Click += new System.EventHandler(this.btnAddRubric_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(220, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 1;
            // 
            // cmbCloId
            // 
            this.cmbCloId.FormattingEnabled = true;
            this.cmbCloId.Location = new System.Drawing.Point(220, 110);
            this.cmbCloId.Name = "cmbCloId";
            this.cmbCloId.Size = new System.Drawing.Size(121, 21);
            this.cmbCloId.TabIndex = 3;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(220, 69);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(121, 20);
            this.txtDetail.TabIndex = 2;
            // 
            // lblCLOId
            // 
            this.lblCLOId.AutoSize = true;
            this.lblCLOId.Location = new System.Drawing.Point(102, 113);
            this.lblCLOId.Name = "lblCLOId";
            this.lblCLOId.Size = new System.Drawing.Size(34, 13);
            this.lblCLOId.TabIndex = 1;
            this.lblCLOId.Text = "Clo Id";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(102, 69);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(34, 13);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Detail";
            // 
            // tabViewRubric
            // 
            this.tabViewRubric.Controls.Add(this.btnViewRubric);
            this.tabViewRubric.Controls.Add(this.gridViewRubrics);
            this.tabViewRubric.Location = new System.Drawing.Point(4, 22);
            this.tabViewRubric.Name = "tabViewRubric";
            this.tabViewRubric.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewRubric.Size = new System.Drawing.Size(600, 232);
            this.tabViewRubric.TabIndex = 1;
            this.tabViewRubric.Text = "View Rubric";
            this.tabViewRubric.UseVisualStyleBackColor = true;
            // 
            // gridViewRubrics
            // 
            this.gridViewRubrics.AutoGenerateColumns = false;
            this.gridViewRubrics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRubrics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.cloIdDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.gridViewRubrics.DataSource = this.rubricBindingSource;
            this.gridViewRubrics.Location = new System.Drawing.Point(49, 76);
            this.gridViewRubrics.Name = "gridViewRubrics";
            this.gridViewRubrics.Size = new System.Drawing.Size(545, 150);
            this.gridViewRubrics.TabIndex = 0;
            this.gridViewRubrics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRubrics_CellClick);
            // 
            // btnViewRubric
            // 
            this.btnViewRubric.Location = new System.Drawing.Point(170, 31);
            this.btnViewRubric.Name = "btnViewRubric";
            this.btnViewRubric.Size = new System.Drawing.Size(94, 23);
            this.btnViewRubric.TabIndex = 1;
            this.btnViewRubric.Text = "View Rubrics";
            this.btnViewRubric.UseVisualStyleBackColor = true;
            this.btnViewRubric.Click += new System.EventHandler(this.btnViewRubric_Click);
            // 
            // projectBDataSet2
            // 
            this.projectBDataSet2.DataSetName = "ProjectBDataSet2";
            this.projectBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet2;
            // 
            // rubricTableAdapter
            // 
            this.rubricTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // cloIdDataGridViewTextBoxColumn
            // 
            this.cloIdDataGridViewTextBoxColumn.DataPropertyName = "CloId";
            this.cloIdDataGridViewTextBoxColumn.HeaderText = "CloId";
            this.cloIdDataGridViewTextBoxColumn.Name = "cloIdDataGridViewTextBoxColumn";
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
            // Rubrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 318);
            this.Controls.Add(this.tabControl1);
            this.Name = "Rubrics";
            this.Text = "Rubrics";
            this.Load += new System.EventHandler(this.Rubrics_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAddRubric.ResumeLayout(false);
            this.tabAddRubric.PerformLayout();
            this.tabViewRubric.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddRubric;
        private System.Windows.Forms.Button btnAddRubric;
        private System.Windows.Forms.ComboBox cmbCloId;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label lblCLOId;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TabPage tabViewRubric;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnViewRubric;
        private System.Windows.Forms.DataGridView gridViewRubrics;
        private ProjectBDataSet2 projectBDataSet2;
        private System.Windows.Forms.BindingSource rubricBindingSource;
        private ProjectBDataSet2TableAdapters.RubricTableAdapter rubricTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}