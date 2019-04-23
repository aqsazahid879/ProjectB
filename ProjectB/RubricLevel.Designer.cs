namespace ProjectB
{
    partial class RubricLevel
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
            this.ErrorRegistrationNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.studentTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.TabAddRubricLevel = new System.Windows.Forms.TabPage();
            this.lblHide = new System.Windows.Forms.Label();
            this.btnAddRubricLevel = new System.Windows.Forms.Button();
            this.cmbRubricID = new System.Windows.Forms.ComboBox();
            this.txtMeasurementLevel = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblRubricID = new System.Windows.Forms.Label();
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.TabViewRubricLevel = new System.Windows.Forms.TabPage();
            this.btnViewRubricLevel = new System.Windows.Forms.Button();
            this.gridRubricLevel = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rubricLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricLevelData = new ProjectB.RubricLevelData();
            this.ErrorLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new ProjectB.ProjectBDataSet();
            this.ErrorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkClo = new System.Windows.Forms.LinkLabel();
            this.lnkStudent = new System.Windows.Forms.LinkLabel();
            this.lnkRubric = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkRubricLevel = new System.Windows.Forms.LinkLabel();
            this.lnkAssessment = new System.Windows.Forms.LinkLabel();
            this.lnkAssessmentComponent = new System.Windows.Forms.LinkLabel();
            this.lnkClassAttendance = new System.Windows.Forms.LinkLabel();
            this.lnkStudentResult = new System.Windows.Forms.LinkLabel();
            this.lnkStudentAttendance = new System.Windows.Forms.LinkLabel();
            this.rubricLevelTableAdapter = new ProjectB.RubricLevelDataTableAdapters.RubricLevelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).BeginInit();
            this.TabAddRubricLevel.SuspendLayout();
            this.TabViewRubricLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRubricLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorRegistrationNumber
            // 
            this.ErrorRegistrationNumber.ContainerControl = this;
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.ContainerControl = this;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // TabAddRubricLevel
            // 
            this.TabAddRubricLevel.Controls.Add(this.lblHide);
            this.TabAddRubricLevel.Controls.Add(this.btnAddRubricLevel);
            this.TabAddRubricLevel.Controls.Add(this.cmbRubricID);
            this.TabAddRubricLevel.Controls.Add(this.txtMeasurementLevel);
            this.TabAddRubricLevel.Controls.Add(this.txtDetails);
            this.TabAddRubricLevel.Controls.Add(this.lblRubricID);
            this.TabAddRubricLevel.Controls.Add(this.lblMeasurementLevel);
            this.TabAddRubricLevel.Controls.Add(this.lblDetail);
            this.TabAddRubricLevel.Location = new System.Drawing.Point(4, 22);
            this.TabAddRubricLevel.Name = "TabAddRubricLevel";
            this.TabAddRubricLevel.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddRubricLevel.Size = new System.Drawing.Size(993, 298);
            this.TabAddRubricLevel.TabIndex = 0;
            this.TabAddRubricLevel.Text = "Add Rubric Level";
            this.TabAddRubricLevel.UseVisualStyleBackColor = true;
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(471, 99);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(18, 13);
            this.lblHide.TabIndex = 14;
            this.lblHide.Text = "ID";
            // 
            // btnAddRubricLevel
            // 
            this.btnAddRubricLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRubricLevel.Location = new System.Drawing.Point(118, 152);
            this.btnAddRubricLevel.Name = "btnAddRubricLevel";
            this.btnAddRubricLevel.Size = new System.Drawing.Size(116, 23);
            this.btnAddRubricLevel.TabIndex = 13;
            this.btnAddRubricLevel.Text = "Add Rubric Level";
            this.btnAddRubricLevel.UseVisualStyleBackColor = true;
            this.btnAddRubricLevel.Click += new System.EventHandler(this.btnAddRubricLevel_Click);
            // 
            // cmbRubricID
            // 
            this.cmbRubricID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRubricID.FormattingEnabled = true;
            this.cmbRubricID.Location = new System.Drawing.Point(200, 99);
            this.cmbRubricID.Name = "cmbRubricID";
            this.cmbRubricID.Size = new System.Drawing.Size(121, 21);
            this.cmbRubricID.TabIndex = 11;
            // 
            // txtMeasurementLevel
            // 
            this.txtMeasurementLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeasurementLevel.Location = new System.Drawing.Point(200, 62);
            this.txtMeasurementLevel.Name = "txtMeasurementLevel";
            this.txtMeasurementLevel.Size = new System.Drawing.Size(121, 20);
            this.txtMeasurementLevel.TabIndex = 10;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.Location = new System.Drawing.Point(200, 28);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(121, 20);
            this.txtDetails.TabIndex = 9;
            // 
            // lblRubricID
            // 
            this.lblRubricID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRubricID.AutoSize = true;
            this.lblRubricID.Location = new System.Drawing.Point(84, 102);
            this.lblRubricID.Name = "lblRubricID";
            this.lblRubricID.Size = new System.Drawing.Size(50, 13);
            this.lblRubricID.TabIndex = 8;
            this.lblRubricID.Text = "Rubric Id";
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(84, 65);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lblMeasurementLevel.TabIndex = 7;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // lblDetail
            // 
            this.lblDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(84, 31);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(39, 13);
            this.lblDetail.TabIndex = 6;
            this.lblDetail.Text = "Details";
            // 
            // TabViewRubricLevel
            // 
            this.TabViewRubricLevel.Controls.Add(this.btnViewRubricLevel);
            this.TabViewRubricLevel.Controls.Add(this.gridRubricLevel);
            this.TabViewRubricLevel.Location = new System.Drawing.Point(4, 22);
            this.TabViewRubricLevel.Name = "TabViewRubricLevel";
            this.TabViewRubricLevel.Padding = new System.Windows.Forms.Padding(3);
            this.TabViewRubricLevel.Size = new System.Drawing.Size(993, 298);
            this.TabViewRubricLevel.TabIndex = 1;
            this.TabViewRubricLevel.Text = "View Rubric Level";
            this.TabViewRubricLevel.UseVisualStyleBackColor = true;
            // 
            // btnViewRubricLevel
            // 
            this.btnViewRubricLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRubricLevel.Location = new System.Drawing.Point(191, 45);
            this.btnViewRubricLevel.Name = "btnViewRubricLevel";
            this.btnViewRubricLevel.Size = new System.Drawing.Size(136, 23);
            this.btnViewRubricLevel.TabIndex = 1;
            this.btnViewRubricLevel.Text = "View Rubric Level";
            this.btnViewRubricLevel.UseVisualStyleBackColor = true;
            this.btnViewRubricLevel.Click += new System.EventHandler(this.btnViewRubricLevel_Click);
            // 
            // gridRubricLevel
            // 
            this.gridRubricLevel.AutoGenerateColumns = false;
            this.gridRubricLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRubricLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.measurementLevelDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.gridRubricLevel.DataSource = this.rubricLevelBindingSource;
            this.gridRubricLevel.Location = new System.Drawing.Point(147, 90);
            this.gridRubricLevel.Name = "gridRubricLevel";
            this.gridRubricLevel.Size = new System.Drawing.Size(643, 150);
            this.gridRubricLevel.TabIndex = 0;
            this.gridRubricLevel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRubricLevel_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // measurementLevelDataGridViewTextBoxColumn
            // 
            this.measurementLevelDataGridViewTextBoxColumn.DataPropertyName = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.HeaderText = "MeasurementLevel";
            this.measurementLevelDataGridViewTextBoxColumn.Name = "measurementLevelDataGridViewTextBoxColumn";
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
            // rubricLevelBindingSource
            // 
            this.rubricLevelBindingSource.DataMember = "RubricLevel";
            this.rubricLevelBindingSource.DataSource = this.rubricLevelData;
            // 
            // rubricLevelData
            // 
            this.rubricLevelData.DataSetName = "RubricLevelData";
            this.rubricLevelData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ErrorLastName
            // 
            this.ErrorLastName.ContainerControl = this;
            // 
            // ErrorContact
            // 
            this.ErrorContact.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TabAddRubricLevel);
            this.tabControl1.Controls.Add(this.TabViewRubricLevel);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 324);
            this.tabControl1.TabIndex = 9;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ErrorEmail
            // 
            this.ErrorEmail.ContainerControl = this;
            // 
            // ErrorFirstName
            // 
            this.ErrorFirstName.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 55);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(421, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "PROJECTB";
            // 
            // lnkClo
            // 
            this.lnkClo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClo.AutoSize = true;
            this.lnkClo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkClo.Location = new System.Drawing.Point(114, 15);
            this.lnkClo.Name = "lnkClo";
            this.lnkClo.Size = new System.Drawing.Size(105, 13);
            this.lnkClo.TabIndex = 1;
            this.lnkClo.TabStop = true;
            this.lnkClo.Text = "Clo";
            this.lnkClo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkClo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClo_LinkClicked);
            // 
            // lnkStudent
            // 
            this.lnkStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStudent.AutoSize = true;
            this.lnkStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkStudent.Location = new System.Drawing.Point(3, 15);
            this.lnkStudent.Name = "lnkStudent";
            this.lnkStudent.Size = new System.Drawing.Size(105, 13);
            this.lnkStudent.TabIndex = 0;
            this.lnkStudent.TabStop = true;
            this.lnkStudent.Text = "Student";
            this.lnkStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStudent_LinkClicked);
            // 
            // lnkRubric
            // 
            this.lnkRubric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRubric.AutoSize = true;
            this.lnkRubric.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkRubric.Location = new System.Drawing.Point(225, 15);
            this.lnkRubric.Name = "lnkRubric";
            this.lnkRubric.Size = new System.Drawing.Size(105, 13);
            this.lnkRubric.TabIndex = 2;
            this.lnkRubric.TabStop = true;
            this.lnkRubric.Text = "Rubric";
            this.lnkRubric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRubric.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRubric_LinkClicked);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1007, 330);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Controls.Add(this.lnkClo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkStudent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkRubric, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkRubricLevel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkAssessment, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkAssessmentComponent, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkClassAttendance, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkStudentResult, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkStudentAttendance, 8, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1007, 44);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // lnkRubricLevel
            // 
            this.lnkRubricLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRubricLevel.AutoSize = true;
            this.lnkRubricLevel.Location = new System.Drawing.Point(336, 15);
            this.lnkRubricLevel.Name = "lnkRubricLevel";
            this.lnkRubricLevel.Size = new System.Drawing.Size(105, 13);
            this.lnkRubricLevel.TabIndex = 0;
            this.lnkRubricLevel.TabStop = true;
            this.lnkRubricLevel.Text = "Rubric Level";
            this.lnkRubricLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRubricLevel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRubricLevel_LinkClicked);
            // 
            // lnkAssessment
            // 
            this.lnkAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAssessment.AutoSize = true;
            this.lnkAssessment.Location = new System.Drawing.Point(447, 15);
            this.lnkAssessment.Name = "lnkAssessment";
            this.lnkAssessment.Size = new System.Drawing.Size(105, 13);
            this.lnkAssessment.TabIndex = 3;
            this.lnkAssessment.TabStop = true;
            this.lnkAssessment.Text = "Assessment";
            this.lnkAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkAssessment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAssessment_LinkClicked);
            // 
            // lnkAssessmentComponent
            // 
            this.lnkAssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAssessmentComponent.AutoSize = true;
            this.lnkAssessmentComponent.Location = new System.Drawing.Point(558, 9);
            this.lnkAssessmentComponent.Name = "lnkAssessmentComponent";
            this.lnkAssessmentComponent.Size = new System.Drawing.Size(105, 26);
            this.lnkAssessmentComponent.TabIndex = 4;
            this.lnkAssessmentComponent.TabStop = true;
            this.lnkAssessmentComponent.Text = "Assessment Component";
            this.lnkAssessmentComponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkAssessmentComponent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAssessmentComponent_LinkClicked);
            // 
            // lnkClassAttendance
            // 
            this.lnkClassAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClassAttendance.AutoSize = true;
            this.lnkClassAttendance.Location = new System.Drawing.Point(669, 15);
            this.lnkClassAttendance.Name = "lnkClassAttendance";
            this.lnkClassAttendance.Size = new System.Drawing.Size(105, 13);
            this.lnkClassAttendance.TabIndex = 5;
            this.lnkClassAttendance.TabStop = true;
            this.lnkClassAttendance.Text = "Class Attendance";
            this.lnkClassAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkClassAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClassAttendance_LinkClicked_1);
            // 
            // lnkStudentResult
            // 
            this.lnkStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStudentResult.AutoSize = true;
            this.lnkStudentResult.Location = new System.Drawing.Point(780, 15);
            this.lnkStudentResult.Name = "lnkStudentResult";
            this.lnkStudentResult.Size = new System.Drawing.Size(105, 13);
            this.lnkStudentResult.TabIndex = 6;
            this.lnkStudentResult.TabStop = true;
            this.lnkStudentResult.Text = "Student Result";
            this.lnkStudentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkStudentResult.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStudentResult_LinkClicked);
            // 
            // lnkStudentAttendance
            // 
            this.lnkStudentAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStudentAttendance.AutoSize = true;
            this.lnkStudentAttendance.Location = new System.Drawing.Point(891, 15);
            this.lnkStudentAttendance.Name = "lnkStudentAttendance";
            this.lnkStudentAttendance.Size = new System.Drawing.Size(113, 13);
            this.lnkStudentAttendance.TabIndex = 7;
            this.lnkStudentAttendance.TabStop = true;
            this.lnkStudentAttendance.Text = "Student Attendance";
            this.lnkStudentAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkStudentAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStudentAttendance_LinkClicked);
            // 
            // rubricLevelTableAdapter
            // 
            this.rubricLevelTableAdapter.ClearBeforeFill = true;
            // 
            // RubricLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "RubricLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.Load += new System.EventHandler(this.RubricLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).EndInit();
            this.TabAddRubricLevel.ResumeLayout(false);
            this.TabAddRubricLevel.PerformLayout();
            this.TabViewRubricLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRubricLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricLevelData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorRegistrationNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabAddRubricLevel;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Button btnAddRubricLevel;
        private System.Windows.Forms.ComboBox cmbRubricID;
        private System.Windows.Forms.TextBox txtMeasurementLevel;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblRubricID;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TabPage TabViewRubricLevel;
        private System.Windows.Forms.Button btnViewRubricLevel;
        private System.Windows.Forms.DataGridView gridRubricLevel;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel lnkClo;
        private System.Windows.Forms.LinkLabel lnkStudent;
        private System.Windows.Forms.LinkLabel lnkRubric;
        private System.Windows.Forms.LinkLabel lnkRubricLevel;
        private System.Windows.Forms.LinkLabel lnkAssessment;
        private System.Windows.Forms.LinkLabel lnkAssessmentComponent;
        private System.Windows.Forms.LinkLabel lnkClassAttendance;
        private System.Windows.Forms.LinkLabel lnkStudentResult;
        private System.Windows.Forms.LinkLabel lnkStudentAttendance;
        private System.Windows.Forms.ErrorProvider ErrorStatus;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ErrorProvider ErrorLastName;
        private System.Windows.Forms.ErrorProvider ErrorContact;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ErrorProvider ErrorEmail;
        private System.Windows.Forms.ErrorProvider ErrorFirstName;
        private RubricLevelData rubricLevelData;
        private System.Windows.Forms.BindingSource rubricLevelBindingSource;
        private RubricLevelDataTableAdapters.RubricLevelTableAdapter rubricLevelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}