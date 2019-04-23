namespace ProjectB
{
    partial class ClassAttendance
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
            this.lnkStudentAttendance = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkRubricLevel = new System.Windows.Forms.LinkLabel();
            this.lnkAssessment = new System.Windows.Forms.LinkLabel();
            this.lnkAssessmentComponent = new System.Windows.Forms.LinkLabel();
            this.lnkClassAttendance = new System.Windows.Forms.LinkLabel();
            this.lnkStudentResult = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkClo = new System.Windows.Forms.LinkLabel();
            this.lnkStudent = new System.Windows.Forms.LinkLabel();
            this.lnkRubric = new System.Windows.Forms.LinkLabel();
            this.ErrorFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.projectBDataSet = new ProjectB.ProjectBDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabClassAttendance = new System.Windows.Forms.TabControl();
            this.TabPageAddClassAttendance = new System.Windows.Forms.TabPage();
            this.TabPageViewClassAttendance = new System.Windows.Forms.TabPage();
            this.AttendanceMarking = new System.Windows.Forms.MonthCalendar();
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.GridAttendance = new System.Windows.Forms.DataGridView();
            this.projectBDataSet5 = new ProjectB.ProjectBDataSet5();
            this.classAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classAttendanceTableAdapter = new ProjectB.ProjectBDataSet5TableAdapters.ClassAttendanceTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblHide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabClassAttendance.SuspendLayout();
            this.TabPageAddClassAttendance.SuspendLayout();
            this.TabPageViewClassAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).BeginInit();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
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
            this.lnkClassAttendance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClassAttendance_LinkClicked);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tabClassAttendance, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 96);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1007, 330);
            this.tableLayoutPanel3.TabIndex = 22;
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
            // ErrorStatus
            // 
            this.ErrorStatus.ContainerControl = this;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1007, 44);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // tabClassAttendance
            // 
            this.tabClassAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabClassAttendance.Controls.Add(this.TabPageAddClassAttendance);
            this.tabClassAttendance.Controls.Add(this.TabPageViewClassAttendance);
            this.tabClassAttendance.Location = new System.Drawing.Point(3, 3);
            this.tabClassAttendance.Name = "tabClassAttendance";
            this.tabClassAttendance.SelectedIndex = 0;
            this.tabClassAttendance.Size = new System.Drawing.Size(1001, 324);
            this.tabClassAttendance.TabIndex = 0;
            // 
            // TabPageAddClassAttendance
            // 
            this.TabPageAddClassAttendance.Controls.Add(this.btnAddAttendance);
            this.TabPageAddClassAttendance.Controls.Add(this.AttendanceMarking);
            this.TabPageAddClassAttendance.Location = new System.Drawing.Point(4, 22);
            this.TabPageAddClassAttendance.Name = "TabPageAddClassAttendance";
            this.TabPageAddClassAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAddClassAttendance.Size = new System.Drawing.Size(993, 298);
            this.TabPageAddClassAttendance.TabIndex = 0;
            this.TabPageAddClassAttendance.Text = "Add Class Attendance";
            this.TabPageAddClassAttendance.UseVisualStyleBackColor = true;
            // 
            // TabPageViewClassAttendance
            // 
            this.TabPageViewClassAttendance.Controls.Add(this.lblHide);
            this.TabPageViewClassAttendance.Controls.Add(this.GridAttendance);
            this.TabPageViewClassAttendance.Controls.Add(this.btnViewAttendance);
            this.TabPageViewClassAttendance.Location = new System.Drawing.Point(4, 22);
            this.TabPageViewClassAttendance.Name = "TabPageViewClassAttendance";
            this.TabPageViewClassAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageViewClassAttendance.Size = new System.Drawing.Size(993, 298);
            this.TabPageViewClassAttendance.TabIndex = 1;
            this.TabPageViewClassAttendance.Text = "View Class Attendance";
            this.TabPageViewClassAttendance.UseVisualStyleBackColor = true;
            // 
            // AttendanceMarking
            // 
            this.AttendanceMarking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendanceMarking.Location = new System.Drawing.Point(194, 12);
            this.AttendanceMarking.Name = "AttendanceMarking";
            this.AttendanceMarking.TabIndex = 0;
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAttendance.Location = new System.Drawing.Point(257, 196);
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.Size = new System.Drawing.Size(109, 23);
            this.btnAddAttendance.TabIndex = 1;
            this.btnAddAttendance.Text = "Add Attendance";
            this.btnAddAttendance.UseVisualStyleBackColor = true;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAttendance.Location = new System.Drawing.Point(295, 28);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(139, 23);
            this.btnViewAttendance.TabIndex = 0;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // GridAttendance
            // 
            this.GridAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GridAttendance.AutoGenerateColumns = false;
            this.GridAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.attendanceDateDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.GridAttendance.DataSource = this.classAttendanceBindingSource;
            this.GridAttendance.Location = new System.Drawing.Point(245, 69);
            this.GridAttendance.Name = "GridAttendance";
            this.GridAttendance.Size = new System.Drawing.Size(443, 124);
            this.GridAttendance.TabIndex = 1;
            this.GridAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projectBDataSet5
            // 
            this.projectBDataSet5.DataSetName = "ProjectBDataSet5";
            this.projectBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classAttendanceBindingSource
            // 
            this.classAttendanceBindingSource.DataMember = "ClassAttendance";
            this.classAttendanceBindingSource.DataSource = this.projectBDataSet5;
            // 
            // classAttendanceTableAdapter
            // 
            this.classAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDateDataGridViewTextBoxColumn
            // 
            this.attendanceDateDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.HeaderText = "AttendanceDate";
            this.attendanceDateDataGridViewTextBoxColumn.Name = "attendanceDateDataGridViewTextBoxColumn";
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
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(789, 103);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(35, 13);
            this.lblHide.TabIndex = 2;
            this.lblHide.Text = "label1";
            // 
            // ClassAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ClassAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassAttendance";
            this.Load += new System.EventHandler(this.ClassAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabClassAttendance.ResumeLayout(false);
            this.TabPageAddClassAttendance.ResumeLayout(false);
            this.TabPageViewClassAttendance.ResumeLayout(false);
            this.TabPageViewClassAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classAttendanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ErrorProvider ErrorRegistrationNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl tabClassAttendance;
        private System.Windows.Forms.TabPage TabPageAddClassAttendance;
        private System.Windows.Forms.Button btnAddAttendance;
        private System.Windows.Forms.MonthCalendar AttendanceMarking;
        private System.Windows.Forms.TabPage TabPageViewClassAttendance;
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
        private System.Windows.Forms.ErrorProvider ErrorFirstName;
        private System.Windows.Forms.ErrorProvider ErrorEmail;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ErrorProvider ErrorStatus;
        private System.Windows.Forms.DataGridView GridAttendance;
        private System.Windows.Forms.Button btnViewAttendance;
        private ProjectBDataSet5 projectBDataSet5;
        private System.Windows.Forms.BindingSource classAttendanceBindingSource;
        private ProjectBDataSet5TableAdapters.ClassAttendanceTableAdapter classAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblHide;
    }
}