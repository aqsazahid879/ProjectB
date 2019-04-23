namespace ProjectB
{
    partial class StudentAttendance
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
            this.TabStudentAttendance = new System.Windows.Forms.TabControl();
            this.TabPageAddStudenAttendance = new System.Windows.Forms.TabPage();
            this.TabPageViewAttendance = new System.Windows.Forms.TabPage();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblAttendanceId = new System.Windows.Forms.Label();
            this.cmbAttendanceStatus = new System.Windows.Forms.ComboBox();
            this.cmbStudentId = new System.Windows.Forms.ComboBox();
            this.cmbattendanceID = new System.Windows.Forms.ComboBox();
            this.btnAddStudentAttendance = new System.Windows.Forms.Button();
            this.lblHide = new System.Windows.Forms.Label();
            this.btnViewStudentAttendance = new System.Windows.Forms.Button();
            this.GridStudentAttendance = new System.Windows.Forms.DataGridView();
            this.studentAttendanceDataSet = new ProjectB.StudentAttendanceDataSet();
            this.studentAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAttendanceTableAdapter = new ProjectB.StudentAttendanceDataSetTableAdapters.StudentAttendanceTableAdapter();
            this.attendanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.TabStudentAttendance.SuspendLayout();
            this.TabPageAddStudenAttendance.SuspendLayout();
            this.TabPageViewAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudentAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).BeginInit();
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.TabStudentAttendance, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1007, 330);
            this.tableLayoutPanel3.TabIndex = 22;
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
            // TabStudentAttendance
            // 
            this.TabStudentAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabStudentAttendance.Controls.Add(this.TabPageAddStudenAttendance);
            this.TabStudentAttendance.Controls.Add(this.TabPageViewAttendance);
            this.TabStudentAttendance.Location = new System.Drawing.Point(3, 3);
            this.TabStudentAttendance.Name = "TabStudentAttendance";
            this.TabStudentAttendance.SelectedIndex = 0;
            this.TabStudentAttendance.Size = new System.Drawing.Size(1001, 324);
            this.TabStudentAttendance.TabIndex = 0;
            // 
            // TabPageAddStudenAttendance
            // 
            this.TabPageAddStudenAttendance.Controls.Add(this.lblHide);
            this.TabPageAddStudenAttendance.Controls.Add(this.btnAddStudentAttendance);
            this.TabPageAddStudenAttendance.Controls.Add(this.lblAttendanceStatus);
            this.TabPageAddStudenAttendance.Controls.Add(this.lblStudentId);
            this.TabPageAddStudenAttendance.Controls.Add(this.lblAttendanceId);
            this.TabPageAddStudenAttendance.Controls.Add(this.cmbAttendanceStatus);
            this.TabPageAddStudenAttendance.Controls.Add(this.cmbStudentId);
            this.TabPageAddStudenAttendance.Controls.Add(this.cmbattendanceID);
            this.TabPageAddStudenAttendance.Location = new System.Drawing.Point(4, 22);
            this.TabPageAddStudenAttendance.Name = "TabPageAddStudenAttendance";
            this.TabPageAddStudenAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAddStudenAttendance.Size = new System.Drawing.Size(993, 298);
            this.TabPageAddStudenAttendance.TabIndex = 0;
            this.TabPageAddStudenAttendance.Text = "Add Student Attendance";
            this.TabPageAddStudenAttendance.UseVisualStyleBackColor = true;
            // 
            // TabPageViewAttendance
            // 
            this.TabPageViewAttendance.Controls.Add(this.GridStudentAttendance);
            this.TabPageViewAttendance.Controls.Add(this.btnViewStudentAttendance);
            this.TabPageViewAttendance.Location = new System.Drawing.Point(4, 22);
            this.TabPageViewAttendance.Name = "TabPageViewAttendance";
            this.TabPageViewAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageViewAttendance.Size = new System.Drawing.Size(993, 298);
            this.TabPageViewAttendance.TabIndex = 1;
            this.TabPageViewAttendance.Text = "View Student Attendance";
            this.TabPageViewAttendance.UseVisualStyleBackColor = true;
            // 
            // lblAttendanceStatus
            // 
            this.lblAttendanceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttendanceStatus.AutoSize = true;
            this.lblAttendanceStatus.Location = new System.Drawing.Point(263, 139);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(95, 13);
            this.lblAttendanceStatus.TabIndex = 11;
            this.lblAttendanceStatus.Text = "Attendance Status";
            // 
            // lblStudentId
            // 
            this.lblStudentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(263, 93);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(58, 13);
            this.lblStudentId.TabIndex = 10;
            this.lblStudentId.Text = "Student ID";
            // 
            // lblAttendanceId
            // 
            this.lblAttendanceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttendanceId.AutoSize = true;
            this.lblAttendanceId.Location = new System.Drawing.Point(263, 44);
            this.lblAttendanceId.Name = "lblAttendanceId";
            this.lblAttendanceId.Size = new System.Drawing.Size(76, 13);
            this.lblAttendanceId.TabIndex = 9;
            this.lblAttendanceId.Text = "Attendance ID";
            // 
            // cmbAttendanceStatus
            // 
            this.cmbAttendanceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAttendanceStatus.FormattingEnabled = true;
            this.cmbAttendanceStatus.Location = new System.Drawing.Point(373, 136);
            this.cmbAttendanceStatus.Name = "cmbAttendanceStatus";
            this.cmbAttendanceStatus.Size = new System.Drawing.Size(115, 21);
            this.cmbAttendanceStatus.TabIndex = 8;
            // 
            // cmbStudentId
            // 
            this.cmbStudentId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStudentId.FormattingEnabled = true;
            this.cmbStudentId.Location = new System.Drawing.Point(373, 90);
            this.cmbStudentId.Name = "cmbStudentId";
            this.cmbStudentId.Size = new System.Drawing.Size(115, 21);
            this.cmbStudentId.TabIndex = 7;
            // 
            // cmbattendanceID
            // 
            this.cmbattendanceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbattendanceID.FormattingEnabled = true;
            this.cmbattendanceID.Location = new System.Drawing.Point(373, 41);
            this.cmbattendanceID.Name = "cmbattendanceID";
            this.cmbattendanceID.Size = new System.Drawing.Size(115, 21);
            this.cmbattendanceID.TabIndex = 6;
            // 
            // btnAddStudentAttendance
            // 
            this.btnAddStudentAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudentAttendance.Location = new System.Drawing.Point(315, 177);
            this.btnAddStudentAttendance.Name = "btnAddStudentAttendance";
            this.btnAddStudentAttendance.Size = new System.Drawing.Size(147, 23);
            this.btnAddStudentAttendance.TabIndex = 12;
            this.btnAddStudentAttendance.Text = "Add Student Attendance";
            this.btnAddStudentAttendance.UseVisualStyleBackColor = true;
            this.btnAddStudentAttendance.Click += new System.EventHandler(this.btnAddStudentAttendance_Click);
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(646, 60);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(35, 13);
            this.lblHide.TabIndex = 23;
            this.lblHide.Text = "label1";
            // 
            // btnViewStudentAttendance
            // 
            this.btnViewStudentAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewStudentAttendance.Location = new System.Drawing.Point(280, 46);
            this.btnViewStudentAttendance.Name = "btnViewStudentAttendance";
            this.btnViewStudentAttendance.Size = new System.Drawing.Size(205, 23);
            this.btnViewStudentAttendance.TabIndex = 0;
            this.btnViewStudentAttendance.Text = "View Student Attendance";
            this.btnViewStudentAttendance.UseVisualStyleBackColor = true;
            this.btnViewStudentAttendance.Click += new System.EventHandler(this.btnViewStudentAttendance_Click);
            // 
            // GridStudentAttendance
            // 
            this.GridStudentAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridStudentAttendance.AutoGenerateColumns = false;
            this.GridStudentAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudentAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attendanceIdDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn,
            this.attendanceStatusDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.GridStudentAttendance.DataSource = this.studentAttendanceBindingSource;
            this.GridStudentAttendance.Location = new System.Drawing.Point(194, 118);
            this.GridStudentAttendance.Name = "GridStudentAttendance";
            this.GridStudentAttendance.Size = new System.Drawing.Size(544, 150);
            this.GridStudentAttendance.TabIndex = 1;
            this.GridStudentAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridStudentAttendance_CellContentClick);
            // 
            // studentAttendanceDataSet
            // 
            this.studentAttendanceDataSet.DataSetName = "StudentAttendanceDataSet";
            this.studentAttendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentAttendanceBindingSource
            // 
            this.studentAttendanceBindingSource.DataMember = "StudentAttendance";
            this.studentAttendanceBindingSource.DataSource = this.studentAttendanceDataSet;
            // 
            // studentAttendanceTableAdapter
            // 
            this.studentAttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceIdDataGridViewTextBoxColumn
            // 
            this.attendanceIdDataGridViewTextBoxColumn.DataPropertyName = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.HeaderText = "AttendanceId";
            this.attendanceIdDataGridViewTextBoxColumn.Name = "attendanceIdDataGridViewTextBoxColumn";
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            // 
            // attendanceStatusDataGridViewTextBoxColumn
            // 
            this.attendanceStatusDataGridViewTextBoxColumn.DataPropertyName = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.HeaderText = "AttendanceStatus";
            this.attendanceStatusDataGridViewTextBoxColumn.Name = "attendanceStatusDataGridViewTextBoxColumn";
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
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "StudentAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentAttendance";
            this.Load += new System.EventHandler(this.StudentAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.TabStudentAttendance.ResumeLayout(false);
            this.TabPageAddStudenAttendance.ResumeLayout(false);
            this.TabPageAddStudenAttendance.PerformLayout();
            this.TabPageViewAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridStudentAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceBindingSource)).EndInit();
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
        private System.Windows.Forms.TabControl TabStudentAttendance;
        private System.Windows.Forms.TabPage TabPageAddStudenAttendance;
        private System.Windows.Forms.Button btnAddStudentAttendance;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblAttendanceId;
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;
        private System.Windows.Forms.ComboBox cmbStudentId;
        private System.Windows.Forms.ComboBox cmbattendanceID;
        private System.Windows.Forms.TabPage TabPageViewAttendance;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.DataGridView GridStudentAttendance;
        private System.Windows.Forms.Button btnViewStudentAttendance;
        private StudentAttendanceDataSet studentAttendanceDataSet;
        private System.Windows.Forms.BindingSource studentAttendanceBindingSource;
        private StudentAttendanceDataSetTableAdapters.StudentAttendanceTableAdapter studentAttendanceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}