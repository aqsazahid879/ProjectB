namespace ProjectB
{
    partial class AssessmentComponent
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
            this.lnkRubricLevel = new System.Windows.Forms.LinkLabel();
            this.lnkAssessment = new System.Windows.Forms.LinkLabel();
            this.lnkAssessmentComponent = new System.Windows.Forms.LinkLabel();
            this.lnkClassAttendance = new System.Windows.Forms.LinkLabel();
            this.lnkStudentResult = new System.Windows.Forms.LinkLabel();
            this.lnkStudentAttendance = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkClo = new System.Windows.Forms.LinkLabel();
            this.lnkStudent = new System.Windows.Forms.LinkLabel();
            this.lnkRubric = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.projectBDataSet = new ProjectB.ProjectBDataSet();
            this.ErrorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabAsessmentComponent = new System.Windows.Forms.TabControl();
            this.TabAddAssessmentComponent = new System.Windows.Forms.TabPage();
            this.TabViewAssessmentComponent = new System.Windows.Forms.TabPage();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRubricId = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblAssessmentId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.cmbRubricId = new System.Windows.Forms.ComboBox();
            this.cmbAssessmentId = new System.Windows.Forms.ComboBox();
            this.btnAddAssessmentComponent = new System.Windows.Forms.Button();
            this.btnViewAssessmentComponent = new System.Windows.Forms.Button();
            this.GridAssessmentComponent = new System.Windows.Forms.DataGridView();
            this.assessmentComponentDataSet = new ProjectB.AssessmentComponentDataSet();
            this.assessmentComponentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentComponentTableAdapter = new ProjectB.AssessmentComponentDataSetTableAdapters.AssessmentComponentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubricIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblHide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.TabAsessmentComponent.SuspendLayout();
            this.TabAddAssessmentComponent.SuspendLayout();
            this.TabViewAssessmentComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAssessmentComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).BeginInit();
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
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
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
            this.tableLayoutPanel3.Controls.Add(this.TabAsessmentComponent, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 96);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1007, 330);
            this.tableLayoutPanel3.TabIndex = 22;
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
            // ErrorStatus
            // 
            this.ErrorStatus.ContainerControl = this;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // TabAsessmentComponent
            // 
            this.TabAsessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabAsessmentComponent.Controls.Add(this.TabAddAssessmentComponent);
            this.TabAsessmentComponent.Controls.Add(this.TabViewAssessmentComponent);
            this.TabAsessmentComponent.Location = new System.Drawing.Point(3, 3);
            this.TabAsessmentComponent.Name = "TabAsessmentComponent";
            this.TabAsessmentComponent.SelectedIndex = 0;
            this.TabAsessmentComponent.Size = new System.Drawing.Size(1001, 324);
            this.TabAsessmentComponent.TabIndex = 0;
            // 
            // TabAddAssessmentComponent
            // 
            this.TabAddAssessmentComponent.Controls.Add(this.lblHide);
            this.TabAddAssessmentComponent.Controls.Add(this.btnAddAssessmentComponent);
            this.TabAddAssessmentComponent.Controls.Add(this.cmbAssessmentId);
            this.TabAddAssessmentComponent.Controls.Add(this.cmbRubricId);
            this.TabAddAssessmentComponent.Controls.Add(this.txtTotalMarks);
            this.TabAddAssessmentComponent.Controls.Add(this.txtName);
            this.TabAddAssessmentComponent.Controls.Add(this.lblAssessmentId);
            this.TabAddAssessmentComponent.Controls.Add(this.lblTotalMarks);
            this.TabAddAssessmentComponent.Controls.Add(this.lblRubricId);
            this.TabAddAssessmentComponent.Controls.Add(this.lblName);
            this.TabAddAssessmentComponent.Location = new System.Drawing.Point(4, 22);
            this.TabAddAssessmentComponent.Name = "TabAddAssessmentComponent";
            this.TabAddAssessmentComponent.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddAssessmentComponent.Size = new System.Drawing.Size(993, 298);
            this.TabAddAssessmentComponent.TabIndex = 0;
            this.TabAddAssessmentComponent.Text = "Add Assessment Component";
            this.TabAddAssessmentComponent.UseVisualStyleBackColor = true;
            // 
            // TabViewAssessmentComponent
            // 
            this.TabViewAssessmentComponent.Controls.Add(this.GridAssessmentComponent);
            this.TabViewAssessmentComponent.Controls.Add(this.btnViewAssessmentComponent);
            this.TabViewAssessmentComponent.Location = new System.Drawing.Point(4, 22);
            this.TabViewAssessmentComponent.Name = "TabViewAssessmentComponent";
            this.TabViewAssessmentComponent.Padding = new System.Windows.Forms.Padding(3);
            this.TabViewAssessmentComponent.Size = new System.Drawing.Size(993, 298);
            this.TabViewAssessmentComponent.TabIndex = 1;
            this.TabViewAssessmentComponent.Text = "View Assessment Component";
            this.TabViewAssessmentComponent.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(147, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblRubricId
            // 
            this.lblRubricId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRubricId.AutoSize = true;
            this.lblRubricId.Location = new System.Drawing.Point(147, 49);
            this.lblRubricId.Name = "lblRubricId";
            this.lblRubricId.Size = new System.Drawing.Size(50, 13);
            this.lblRubricId.TabIndex = 10;
            this.lblRubricId.Text = "Rubric Id";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(147, 77);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(63, 13);
            this.lblTotalMarks.TabIndex = 11;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lblAssessmentId
            // 
            this.lblAssessmentId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssessmentId.AutoSize = true;
            this.lblAssessmentId.Location = new System.Drawing.Point(147, 104);
            this.lblAssessmentId.Name = "lblAssessmentId";
            this.lblAssessmentId.Size = new System.Drawing.Size(75, 13);
            this.lblAssessmentId.TabIndex = 12;
            this.lblAssessmentId.Text = "Assessment Id";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(273, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalMarks.Location = new System.Drawing.Point(273, 74);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(181, 20);
            this.txtTotalMarks.TabIndex = 14;
            // 
            // cmbRubricId
            // 
            this.cmbRubricId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRubricId.FormattingEnabled = true;
            this.cmbRubricId.Location = new System.Drawing.Point(273, 46);
            this.cmbRubricId.Name = "cmbRubricId";
            this.cmbRubricId.Size = new System.Drawing.Size(181, 21);
            this.cmbRubricId.TabIndex = 15;
            // 
            // cmbAssessmentId
            // 
            this.cmbAssessmentId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAssessmentId.FormattingEnabled = true;
            this.cmbAssessmentId.Location = new System.Drawing.Point(273, 101);
            this.cmbAssessmentId.Name = "cmbAssessmentId";
            this.cmbAssessmentId.Size = new System.Drawing.Size(181, 21);
            this.cmbAssessmentId.TabIndex = 16;
            // 
            // btnAddAssessmentComponent
            // 
            this.btnAddAssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAssessmentComponent.Location = new System.Drawing.Point(221, 162);
            this.btnAddAssessmentComponent.Name = "btnAddAssessmentComponent";
            this.btnAddAssessmentComponent.Size = new System.Drawing.Size(187, 23);
            this.btnAddAssessmentComponent.TabIndex = 17;
            this.btnAddAssessmentComponent.Text = "Add Assessment Component";
            this.btnAddAssessmentComponent.UseVisualStyleBackColor = true;
            this.btnAddAssessmentComponent.Click += new System.EventHandler(this.btnAddAssessmentComponent_Click);
            // 
            // btnViewAssessmentComponent
            // 
            this.btnViewAssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAssessmentComponent.Location = new System.Drawing.Point(221, 23);
            this.btnViewAssessmentComponent.Name = "btnViewAssessmentComponent";
            this.btnViewAssessmentComponent.Size = new System.Drawing.Size(179, 23);
            this.btnViewAssessmentComponent.TabIndex = 0;
            this.btnViewAssessmentComponent.Text = "View Assessment Component";
            this.btnViewAssessmentComponent.UseVisualStyleBackColor = true;
            this.btnViewAssessmentComponent.Click += new System.EventHandler(this.btnViewAssessmentComponent_Click);
            // 
            // GridAssessmentComponent
            // 
            this.GridAssessmentComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridAssessmentComponent.AutoGenerateColumns = false;
            this.GridAssessmentComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAssessmentComponent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rubricIdDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.assessmentIdDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.GridAssessmentComponent.DataSource = this.assessmentComponentBindingSource;
            this.GridAssessmentComponent.Location = new System.Drawing.Point(34, 72);
            this.GridAssessmentComponent.Name = "GridAssessmentComponent";
            this.GridAssessmentComponent.Size = new System.Drawing.Size(944, 150);
            this.GridAssessmentComponent.TabIndex = 1;
            this.GridAssessmentComponent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridAssessmentComponent_CellContentClick);
            // 
            // assessmentComponentDataSet
            // 
            this.assessmentComponentDataSet.DataSetName = "AssessmentComponentDataSet";
            this.assessmentComponentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentComponentBindingSource
            // 
            this.assessmentComponentBindingSource.DataMember = "AssessmentComponent";
            this.assessmentComponentBindingSource.DataSource = this.assessmentComponentDataSet;
            // 
            // assessmentComponentTableAdapter
            // 
            this.assessmentComponentTableAdapter.ClearBeforeFill = true;
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
            // rubricIdDataGridViewTextBoxColumn
            // 
            this.rubricIdDataGridViewTextBoxColumn.DataPropertyName = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.HeaderText = "RubricId";
            this.rubricIdDataGridViewTextBoxColumn.Name = "rubricIdDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
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
            // assessmentIdDataGridViewTextBoxColumn
            // 
            this.assessmentIdDataGridViewTextBoxColumn.DataPropertyName = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.HeaderText = "AssessmentId";
            this.assessmentIdDataGridViewTextBoxColumn.Name = "assessmentIdDataGridViewTextBoxColumn";
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
            this.lblHide.Location = new System.Drawing.Point(562, 46);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(27, 13);
            this.lblHide.TabIndex = 18;
            this.lblHide.Text = "hide";
            // 
            // AssessmentComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 449);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AssessmentComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssessmentComponent";
            this.Load += new System.EventHandler(this.AssessmentComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.TabAsessmentComponent.ResumeLayout(false);
            this.TabAddAssessmentComponent.ResumeLayout(false);
            this.TabAddAssessmentComponent.PerformLayout();
            this.TabViewAssessmentComponent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridAssessmentComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentComponentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.ErrorProvider ErrorRegistrationNumber;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider ErrorLastName;
        private System.Windows.Forms.ErrorProvider ErrorContact;
        private System.Windows.Forms.ErrorProvider ErrorFirstName;
        private System.Windows.Forms.ErrorProvider ErrorEmail;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.ErrorProvider ErrorStatus;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.TabControl TabAsessmentComponent;
        private System.Windows.Forms.TabPage TabAddAssessmentComponent;
        private System.Windows.Forms.TabPage TabViewAssessmentComponent;
        private System.Windows.Forms.Button btnAddAssessmentComponent;
        private System.Windows.Forms.ComboBox cmbAssessmentId;
        private System.Windows.Forms.ComboBox cmbRubricId;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAssessmentId;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblRubricId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView GridAssessmentComponent;
        private System.Windows.Forms.Button btnViewAssessmentComponent;
        private AssessmentComponentDataSet assessmentComponentDataSet;
        private System.Windows.Forms.BindingSource assessmentComponentBindingSource;
        private AssessmentComponentDataSetTableAdapters.AssessmentComponentTableAdapter assessmentComponentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubricIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label lblHide;
    }
}