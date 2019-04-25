namespace ProjectB
{
    partial class StudentResult
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
            this.studentTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.ErrorRegistrationNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkAssessmentComponent = new System.Windows.Forms.LinkLabel();
            this.lnkClassAttendance = new System.Windows.Forms.LinkLabel();
            this.lnkStudentResult = new System.Windows.Forms.LinkLabel();
            this.lnkStudentAttendance = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TabStudentResult = new System.Windows.Forms.TabControl();
            this.TabPageAddStudentResult = new System.Windows.Forms.TabPage();
            this.btnaddStudentResult = new System.Windows.Forms.Button();
            this.lblRubricLevelId = new System.Windows.Forms.Label();
            this.cmbRubricLevel = new System.Windows.Forms.ComboBox();
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblAssessmentComponent = new System.Windows.Forms.Label();
            this.lblAssessmentTitle = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.cmbMeasurementLevel = new System.Windows.Forms.ComboBox();
            this.cmbDetails = new System.Windows.Forms.ComboBox();
            this.cmbAssessmentComponentId = new System.Windows.Forms.ComboBox();
            this.cmbAssessmentTitle = new System.Windows.Forms.ComboBox();
            this.cmbStudentId = new System.Windows.Forms.ComboBox();
            this.TabPageViewStudentResult = new System.Windows.Forms.TabPage();
            this.GridStudentResult = new System.Windows.Forms.DataGridView();
            this.studentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet6 = new ProjectB.ProjectBDataSet6();
            this.btnViewStudentResult = new System.Windows.Forms.Button();
            this.lnkAssessment = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkClo = new System.Windows.Forms.LinkLabel();
            this.lnkStudent = new System.Windows.Forms.LinkLabel();
            this.lnkRubric = new System.Windows.Forms.LinkLabel();
            this.lnkRubricLevel = new System.Windows.Forms.LinkLabel();
            this.ErrorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.projectBDataSet = new ProjectB.ProjectBDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentResultTableAdapter = new ProjectB.ProjectBDataSet6TableAdapters.StudentResultTableAdapter();
            this.ObtainedMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.TabStudentResult.SuspendLayout();
            this.TabPageAddStudentResult.SuspendLayout();
            this.TabPageViewStudentResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudentResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ErrorRegistrationNumber
            // 
            this.ErrorRegistrationNumber.ContainerControl = this;
            // 
            // ErrorLastName
            // 
            this.ErrorLastName.ContainerControl = this;
            // 
            // ErrorContact
            // 
            this.ErrorContact.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 55);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(547, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 42);
            this.label7.TabIndex = 0;
            this.label7.Text = "PROJECTB";
            // 
            // lnkAssessmentComponent
            // 
            this.lnkAssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAssessmentComponent.AutoSize = true;
            this.lnkAssessmentComponent.Location = new System.Drawing.Point(698, 15);
            this.lnkAssessmentComponent.Name = "lnkAssessmentComponent";
            this.lnkAssessmentComponent.Size = new System.Drawing.Size(133, 13);
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
            this.lnkClassAttendance.Location = new System.Drawing.Point(837, 15);
            this.lnkClassAttendance.Name = "lnkClassAttendance";
            this.lnkClassAttendance.Size = new System.Drawing.Size(133, 13);
            this.lnkClassAttendance.TabIndex = 5;
            this.lnkClassAttendance.TabStop = true;
            this.lnkClassAttendance.Text = "Class Attendance";
            this.lnkClassAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkClassAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClassAttendance_LinkClicked);
            // 
            // lnkStudentResult
            // 
            this.lnkStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStudentResult.AutoSize = true;
            this.lnkStudentResult.Location = new System.Drawing.Point(976, 15);
            this.lnkStudentResult.Name = "lnkStudentResult";
            this.lnkStudentResult.Size = new System.Drawing.Size(133, 13);
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
            this.lnkStudentAttendance.Location = new System.Drawing.Point(1115, 15);
            this.lnkStudentAttendance.Name = "lnkStudentAttendance";
            this.lnkStudentAttendance.Size = new System.Drawing.Size(141, 13);
            this.lnkStudentAttendance.TabIndex = 7;
            this.lnkStudentAttendance.TabStop = true;
            this.lnkStudentAttendance.Text = "Student Attendance";
            this.lnkStudentAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkStudentAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStudentAttendance_LinkClicked);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.TabStudentResult, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1259, 282);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // TabStudentResult
            // 
            this.TabStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabStudentResult.Controls.Add(this.TabPageAddStudentResult);
            this.TabStudentResult.Controls.Add(this.TabPageViewStudentResult);
            this.TabStudentResult.Location = new System.Drawing.Point(3, 3);
            this.TabStudentResult.Name = "TabStudentResult";
            this.TabStudentResult.SelectedIndex = 0;
            this.TabStudentResult.Size = new System.Drawing.Size(1253, 276);
            this.TabStudentResult.TabIndex = 0;
            // 
            // TabPageAddStudentResult
            // 
            this.TabPageAddStudentResult.Controls.Add(this.btnaddStudentResult);
            this.TabPageAddStudentResult.Controls.Add(this.lblRubricLevelId);
            this.TabPageAddStudentResult.Controls.Add(this.cmbRubricLevel);
            this.TabPageAddStudentResult.Controls.Add(this.lblMeasurementLevel);
            this.TabPageAddStudentResult.Controls.Add(this.lblDetails);
            this.TabPageAddStudentResult.Controls.Add(this.lblAssessmentComponent);
            this.TabPageAddStudentResult.Controls.Add(this.lblAssessmentTitle);
            this.TabPageAddStudentResult.Controls.Add(this.lblStudentId);
            this.TabPageAddStudentResult.Controls.Add(this.cmbMeasurementLevel);
            this.TabPageAddStudentResult.Controls.Add(this.cmbDetails);
            this.TabPageAddStudentResult.Controls.Add(this.cmbAssessmentComponentId);
            this.TabPageAddStudentResult.Controls.Add(this.cmbAssessmentTitle);
            this.TabPageAddStudentResult.Controls.Add(this.cmbStudentId);
            this.TabPageAddStudentResult.Location = new System.Drawing.Point(4, 22);
            this.TabPageAddStudentResult.Name = "TabPageAddStudentResult";
            this.TabPageAddStudentResult.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAddStudentResult.Size = new System.Drawing.Size(1048, 250);
            this.TabPageAddStudentResult.TabIndex = 0;
            this.TabPageAddStudentResult.Text = "Add Student Result";
            this.TabPageAddStudentResult.UseVisualStyleBackColor = true;
            // 
            // btnaddStudentResult
            // 
            this.btnaddStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddStudentResult.Location = new System.Drawing.Point(421, 209);
            this.btnaddStudentResult.Name = "btnaddStudentResult";
            this.btnaddStudentResult.Size = new System.Drawing.Size(213, 23);
            this.btnaddStudentResult.TabIndex = 26;
            this.btnaddStudentResult.Text = "Add Student Result";
            this.btnaddStudentResult.UseVisualStyleBackColor = true;
            this.btnaddStudentResult.Click += new System.EventHandler(this.btnaddStudentResult_Click);
            // 
            // lblRubricLevelId
            // 
            this.lblRubricLevelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRubricLevelId.AutoSize = true;
            this.lblRubricLevelId.Location = new System.Drawing.Point(333, 180);
            this.lblRubricLevelId.Name = "lblRubricLevelId";
            this.lblRubricLevelId.Size = new System.Drawing.Size(79, 13);
            this.lblRubricLevelId.TabIndex = 25;
            this.lblRubricLevelId.Text = "Rubric Level Id";
            // 
            // cmbRubricLevel
            // 
            this.cmbRubricLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRubricLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubricLevel.FormattingEnabled = true;
            this.cmbRubricLevel.Location = new System.Drawing.Point(490, 172);
            this.cmbRubricLevel.Name = "cmbRubricLevel";
            this.cmbRubricLevel.Size = new System.Drawing.Size(221, 21);
            this.cmbRubricLevel.TabIndex = 24;
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(333, 153);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lblMeasurementLevel.TabIndex = 23;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(333, 126);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 22;
            this.lblDetails.Text = "Details";
            // 
            // lblAssessmentComponent
            // 
            this.lblAssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssessmentComponent.AutoSize = true;
            this.lblAssessmentComponent.Location = new System.Drawing.Point(333, 99);
            this.lblAssessmentComponent.Name = "lblAssessmentComponent";
            this.lblAssessmentComponent.Size = new System.Drawing.Size(132, 13);
            this.lblAssessmentComponent.TabIndex = 21;
            this.lblAssessmentComponent.Text = "Assessment Component Id";
            // 
            // lblAssessmentTitle
            // 
            this.lblAssessmentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssessmentTitle.AutoSize = true;
            this.lblAssessmentTitle.Location = new System.Drawing.Point(333, 72);
            this.lblAssessmentTitle.Name = "lblAssessmentTitle";
            this.lblAssessmentTitle.Size = new System.Drawing.Size(86, 13);
            this.lblAssessmentTitle.TabIndex = 20;
            this.lblAssessmentTitle.Text = "Assessment Title";
            // 
            // lblStudentId
            // 
            this.lblStudentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(333, 45);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(56, 13);
            this.lblStudentId.TabIndex = 19;
            this.lblStudentId.Text = "Student Id";
            // 
            // cmbMeasurementLevel
            // 
            this.cmbMeasurementLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMeasurementLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasurementLevel.FormattingEnabled = true;
            this.cmbMeasurementLevel.Location = new System.Drawing.Point(490, 145);
            this.cmbMeasurementLevel.Name = "cmbMeasurementLevel";
            this.cmbMeasurementLevel.Size = new System.Drawing.Size(221, 21);
            this.cmbMeasurementLevel.TabIndex = 18;
            this.cmbMeasurementLevel.SelectedIndexChanged += new System.EventHandler(this.cmbMeasurementLevel_SelectedIndexChanged);
            // 
            // cmbDetails
            // 
            this.cmbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetails.FormattingEnabled = true;
            this.cmbDetails.Location = new System.Drawing.Point(490, 118);
            this.cmbDetails.Name = "cmbDetails";
            this.cmbDetails.Size = new System.Drawing.Size(221, 21);
            this.cmbDetails.TabIndex = 17;
            this.cmbDetails.SelectedIndexChanged += new System.EventHandler(this.cmbDetails_SelectedIndexChanged);
            // 
            // cmbAssessmentComponentId
            // 
            this.cmbAssessmentComponentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAssessmentComponentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssessmentComponentId.FormattingEnabled = true;
            this.cmbAssessmentComponentId.Location = new System.Drawing.Point(490, 91);
            this.cmbAssessmentComponentId.Name = "cmbAssessmentComponentId";
            this.cmbAssessmentComponentId.Size = new System.Drawing.Size(221, 21);
            this.cmbAssessmentComponentId.TabIndex = 16;
            this.cmbAssessmentComponentId.SelectedIndexChanged += new System.EventHandler(this.cmbAssessmentComponentId_SelectedIndexChanged);
            // 
            // cmbAssessmentTitle
            // 
            this.cmbAssessmentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAssessmentTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssessmentTitle.FormattingEnabled = true;
            this.cmbAssessmentTitle.Location = new System.Drawing.Point(490, 64);
            this.cmbAssessmentTitle.Name = "cmbAssessmentTitle";
            this.cmbAssessmentTitle.Size = new System.Drawing.Size(221, 21);
            this.cmbAssessmentTitle.TabIndex = 15;
            this.cmbAssessmentTitle.SelectedIndexChanged += new System.EventHandler(this.cmbAssessmentTitle_SelectedIndexChanged);
            // 
            // cmbStudentId
            // 
            this.cmbStudentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStudentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentId.FormattingEnabled = true;
            this.cmbStudentId.Location = new System.Drawing.Point(490, 37);
            this.cmbStudentId.Name = "cmbStudentId";
            this.cmbStudentId.Size = new System.Drawing.Size(221, 21);
            this.cmbStudentId.TabIndex = 14;
            // 
            // TabPageViewStudentResult
            // 
            this.TabPageViewStudentResult.Controls.Add(this.GridStudentResult);
            this.TabPageViewStudentResult.Controls.Add(this.btnViewStudentResult);
            this.TabPageViewStudentResult.Location = new System.Drawing.Point(4, 22);
            this.TabPageViewStudentResult.Name = "TabPageViewStudentResult";
            this.TabPageViewStudentResult.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageViewStudentResult.Size = new System.Drawing.Size(1245, 250);
            this.TabPageViewStudentResult.TabIndex = 1;
            this.TabPageViewStudentResult.Text = "View Student Result";
            this.TabPageViewStudentResult.UseVisualStyleBackColor = true;
            // 
            // GridStudentResult
            // 
            this.GridStudentResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridStudentResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudentResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObtainedMarks,
            this.Delete,
            this.StudentId});
            this.GridStudentResult.Location = new System.Drawing.Point(138, 65);
            this.GridStudentResult.Name = "GridStudentResult";
            this.GridStudentResult.Size = new System.Drawing.Size(911, 150);
            this.GridStudentResult.TabIndex = 1;
            this.GridStudentResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridStudentResult_CellContentClick);
            // 
            // studentResultBindingSource
            // 
            this.studentResultBindingSource.DataMember = "StudentResult";
            this.studentResultBindingSource.DataSource = this.projectBDataSet6;
            // 
            // projectBDataSet6
            // 
            this.projectBDataSet6.DataSetName = "ProjectBDataSet6";
            this.projectBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnViewStudentResult
            // 
            this.btnViewStudentResult.Location = new System.Drawing.Point(359, 17);
            this.btnViewStudentResult.Name = "btnViewStudentResult";
            this.btnViewStudentResult.Size = new System.Drawing.Size(142, 23);
            this.btnViewStudentResult.TabIndex = 0;
            this.btnViewStudentResult.Text = "View Student Result";
            this.btnViewStudentResult.UseVisualStyleBackColor = true;
            this.btnViewStudentResult.Click += new System.EventHandler(this.btnViewStudentResult_Click);
            // 
            // lnkAssessment
            // 
            this.lnkAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAssessment.AutoSize = true;
            this.lnkAssessment.Location = new System.Drawing.Point(559, 15);
            this.lnkAssessment.Name = "lnkAssessment";
            this.lnkAssessment.Size = new System.Drawing.Size(133, 13);
            this.lnkAssessment.TabIndex = 3;
            this.lnkAssessment.TabStop = true;
            this.lnkAssessment.Text = "Assessment";
            this.lnkAssessment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkAssessment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAssessment_LinkClicked);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1259, 44);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // lnkClo
            // 
            this.lnkClo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClo.AutoSize = true;
            this.lnkClo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkClo.Location = new System.Drawing.Point(142, 15);
            this.lnkClo.Name = "lnkClo";
            this.lnkClo.Size = new System.Drawing.Size(133, 13);
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
            this.lnkStudent.Size = new System.Drawing.Size(133, 13);
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
            this.lnkRubric.Location = new System.Drawing.Point(281, 15);
            this.lnkRubric.Name = "lnkRubric";
            this.lnkRubric.Size = new System.Drawing.Size(133, 13);
            this.lnkRubric.TabIndex = 2;
            this.lnkRubric.TabStop = true;
            this.lnkRubric.Text = "Rubric";
            this.lnkRubric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRubric.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRubric_LinkClicked);
            // 
            // lnkRubricLevel
            // 
            this.lnkRubricLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRubricLevel.AutoSize = true;
            this.lnkRubricLevel.Location = new System.Drawing.Point(420, 15);
            this.lnkRubricLevel.Name = "lnkRubricLevel";
            this.lnkRubricLevel.Size = new System.Drawing.Size(133, 13);
            this.lnkRubricLevel.TabIndex = 0;
            this.lnkRubricLevel.TabStop = true;
            this.lnkRubricLevel.Text = "Rubric Level";
            this.lnkRubricLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkRubricLevel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRubricLevel_LinkClicked);
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.ContainerControl = this;
            // 
            // ErrorFirstName
            // 
            this.ErrorFirstName.ContainerControl = this;
            // 
            // ErrorEmail
            // 
            this.ErrorEmail.ContainerControl = this;
            // 
            // projectBDataSet
            // 
            this.projectBDataSet.DataSetName = "ProjectBDataSet";
            this.projectBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // studentResultTableAdapter
            // 
            this.studentResultTableAdapter.ClearBeforeFill = true;
            // 
            // ObtainedMarks
            // 
            this.ObtainedMarks.DataPropertyName = "StudentId";
            this.ObtainedMarks.HeaderText = "ObtainedMarks";
            this.ObtainedMarks.Name = "ObtainedMarks";
            this.ObtainedMarks.ToolTipText = "ObtainedMarks";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 375);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "StudentResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentResult";
            this.Load += new System.EventHandler(this.StudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.TabStudentResult.ResumeLayout(false);
            this.TabPageAddStudentResult.ResumeLayout(false);
            this.TabPageAddStudentResult.PerformLayout();
            this.TabPageViewStudentResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridStudentResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet6)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ErrorProvider ErrorRegistrationNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
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
        private System.Windows.Forms.ErrorProvider ErrorLastName;
        private System.Windows.Forms.ErrorProvider ErrorContact;
        private System.Windows.Forms.ErrorProvider ErrorStatus;
        private System.Windows.Forms.ErrorProvider ErrorFirstName;
        private System.Windows.Forms.ErrorProvider ErrorEmail;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TabControl TabStudentResult;
        private System.Windows.Forms.TabPage TabPageAddStudentResult;
        private System.Windows.Forms.Button btnaddStudentResult;
        private System.Windows.Forms.Label lblRubricLevelId;
        private System.Windows.Forms.ComboBox cmbRubricLevel;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblAssessmentComponent;
        private System.Windows.Forms.Label lblAssessmentTitle;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.ComboBox cmbMeasurementLevel;
        private System.Windows.Forms.ComboBox cmbDetails;
        private System.Windows.Forms.ComboBox cmbAssessmentComponentId;
        private System.Windows.Forms.ComboBox cmbAssessmentTitle;
        private System.Windows.Forms.ComboBox cmbStudentId;
        private System.Windows.Forms.TabPage TabPageViewStudentResult;
        private System.Windows.Forms.DataGridView GridStudentResult;
        private System.Windows.Forms.Button btnViewStudentResult;
        private ProjectBDataSet6 projectBDataSet6;
        private System.Windows.Forms.BindingSource studentResultBindingSource;
        private ProjectBDataSet6TableAdapters.StudentResultTableAdapter studentResultTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObtainedMarks;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
    }
}