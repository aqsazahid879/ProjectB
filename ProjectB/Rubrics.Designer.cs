﻿namespace ProjectB
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
            this.studentTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAddRubric = new System.Windows.Forms.Button();
            this.lnkRubricLevel = new System.Windows.Forms.LinkLabel();
            this.lnkAssessment = new System.Windows.Forms.LinkLabel();
            this.lnkAssessmentComponent = new System.Windows.Forms.LinkLabel();
            this.lnkClassAttendance = new System.Windows.Forms.LinkLabel();
            this.lnkStudentResult = new System.Windows.Forms.LinkLabel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tabAddRubric = new System.Windows.Forms.TabPage();
            this.cmbCloId = new System.Windows.Forms.ComboBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lblCLOId = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lnkClo = new System.Windows.Forms.LinkLabel();
            this.lnkStudent = new System.Windows.Forms.LinkLabel();
            this.tabViewRubric = new System.Windows.Forms.TabPage();
            this.btnViewRubric = new System.Windows.Forms.Button();
            this.gridViewRubrics = new System.Windows.Forms.DataGridView();
            this.lnkRubric = new System.Windows.Forms.LinkLabel();
            this.lnkStudentAttendance = new System.Windows.Forms.LinkLabel();
            this.ErrorRegistrationNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ErrorFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.projectBDataSet = new ProjectB.ProjectBDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.projectBDataSet2 = new ProjectB.ProjectBDataSet2();
            this.projectBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubricTableAdapter = new ProjectB.ProjectBDataSet2TableAdapters.RubricTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabAddRubric.SuspendLayout();
            this.tabViewRubric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubrics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(102, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            // 
            // btnAddRubric
            // 
            this.btnAddRubric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRubric.Location = new System.Drawing.Point(175, 173);
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.Size = new System.Drawing.Size(75, 23);
            this.btnAddRubric.TabIndex = 4;
            this.btnAddRubric.Text = "Add Rubric";
            this.btnAddRubric.UseVisualStyleBackColor = true;
            this.btnAddRubric.Click += new System.EventHandler(this.btnAddRubric_Click);
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
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(220, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 1;
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
            this.tabAddRubric.Size = new System.Drawing.Size(993, 298);
            this.tabAddRubric.TabIndex = 0;
            this.tabAddRubric.Text = "Add Rubrics";
            this.tabAddRubric.UseVisualStyleBackColor = true;
            // 
            // cmbCloId
            // 
            this.cmbCloId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCloId.FormattingEnabled = true;
            this.cmbCloId.Location = new System.Drawing.Point(220, 110);
            this.cmbCloId.Name = "cmbCloId";
            this.cmbCloId.Size = new System.Drawing.Size(121, 21);
            this.cmbCloId.TabIndex = 3;
            // 
            // txtDetail
            // 
            this.txtDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetail.Location = new System.Drawing.Point(220, 69);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(121, 20);
            this.txtDetail.TabIndex = 2;
            // 
            // lblCLOId
            // 
            this.lblCLOId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCLOId.AutoSize = true;
            this.lblCLOId.Location = new System.Drawing.Point(102, 113);
            this.lblCLOId.Name = "lblCLOId";
            this.lblCLOId.Size = new System.Drawing.Size(34, 13);
            this.lblCLOId.TabIndex = 1;
            this.lblCLOId.Text = "Clo Id";
            // 
            // lblDetail
            // 
            this.lblDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(102, 69);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(34, 13);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Detail";
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
            // tabViewRubric
            // 
            this.tabViewRubric.Controls.Add(this.btnViewRubric);
            this.tabViewRubric.Controls.Add(this.gridViewRubrics);
            this.tabViewRubric.Location = new System.Drawing.Point(4, 22);
            this.tabViewRubric.Name = "tabViewRubric";
            this.tabViewRubric.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewRubric.Size = new System.Drawing.Size(993, 298);
            this.tabViewRubric.TabIndex = 1;
            this.tabViewRubric.Text = "View Rubric";
            this.tabViewRubric.UseVisualStyleBackColor = true;
            // 
            // btnViewRubric
            // 
            this.btnViewRubric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRubric.Location = new System.Drawing.Point(170, 31);
            this.btnViewRubric.Name = "btnViewRubric";
            this.btnViewRubric.Size = new System.Drawing.Size(94, 23);
            this.btnViewRubric.TabIndex = 1;
            this.btnViewRubric.Text = "View Rubrics";
            this.btnViewRubric.UseVisualStyleBackColor = true;
            this.btnViewRubric.Click += new System.EventHandler(this.btnViewRubric_Click);
            // 
            // gridViewRubrics
            // 
            this.gridViewRubrics.AutoGenerateColumns = false;
            this.gridViewRubrics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.gridViewRubrics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRubrics_CellClick);
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabAddRubric);
            this.tabControl1.Controls.Add(this.tabViewRubric);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 324);
            this.tabControl1.TabIndex = 3;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
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
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectBDataSet;
            // 
            // ErrorStatus
            // 
            this.ErrorStatus.ContainerControl = this;
            // 
            // projectBDataSet2
            // 
            this.projectBDataSet2.DataSetName = "ProjectBDataSet2";
            this.projectBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectBDataSet2BindingSource
            // 
            this.projectBDataSet2BindingSource.DataSource = this.projectBDataSet2;
            this.projectBDataSet2BindingSource.Position = 0;
            // 
            // rubricBindingSource
            // 
            this.rubricBindingSource.DataMember = "Rubric";
            this.rubricBindingSource.DataSource = this.projectBDataSet2BindingSource;
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
            this.ClientSize = new System.Drawing.Size(1007, 449);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Rubrics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rubrics";
            this.Load += new System.EventHandler(this.Rubrics_Load);
            this.tabAddRubric.ResumeLayout(false);
            this.tabAddRubric.PerformLayout();
            this.tabViewRubric.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubrics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubricBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAddRubric;
        private System.Windows.Forms.LinkLabel lnkRubricLevel;
        private System.Windows.Forms.LinkLabel lnkAssessment;
        private System.Windows.Forms.LinkLabel lnkAssessmentComponent;
        private System.Windows.Forms.LinkLabel lnkClassAttendance;
        private System.Windows.Forms.LinkLabel lnkStudentResult;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TabPage tabAddRubric;
        private System.Windows.Forms.ComboBox cmbCloId;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label lblCLOId;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.LinkLabel lnkClo;
        private System.Windows.Forms.LinkLabel lnkStudent;
        private System.Windows.Forms.TabPage tabViewRubric;
        private System.Windows.Forms.Button btnViewRubric;
        private System.Windows.Forms.DataGridView gridViewRubrics;
        private System.Windows.Forms.LinkLabel lnkRubric;
        private System.Windows.Forms.LinkLabel lnkStudentAttendance;
        private System.Windows.Forms.ErrorProvider ErrorRegistrationNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider ErrorLastName;
        private System.Windows.Forms.ErrorProvider ErrorContact;
        private System.Windows.Forms.ErrorProvider ErrorFirstName;
        private System.Windows.Forms.ErrorProvider ErrorEmail;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ErrorProvider ErrorStatus;
        private System.Windows.Forms.BindingSource projectBDataSet2BindingSource;
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