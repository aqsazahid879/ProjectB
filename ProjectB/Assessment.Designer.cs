namespace ProjectB
{
    partial class Assessment
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
            this.ErrorContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorRegistrationNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.studentTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.TabAssesement = new System.Windows.Forms.TabControl();
            this.tabAddAssessment = new System.Windows.Forms.TabPage();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.txtTotalWeightage = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTotalWeightage = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabViewAssessment = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectBDataSet4 = new ProjectB.ProjectBDataSet4();
            this.assessmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentTableAdapter = new ProjectB.ProjectBDataSet4TableAdapters.AssessmentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnviewassessment = new System.Windows.Forms.Button();
            this.lblHide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).BeginInit();
            this.TabAssesement.SuspendLayout();
            this.tabAddAssessment.SuspendLayout();
            this.tabViewAssessment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.lnkClo.Location = new System.Drawing.Point(338, 15);
            this.lnkClo.Name = "lnkClo";
            this.lnkClo.Size = new System.Drawing.Size(329, 13);
            this.lnkClo.TabIndex = 1;
            this.lnkClo.TabStop = true;
            this.lnkClo.Text = "Clo";
            this.lnkClo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkStudent
            // 
            this.lnkStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStudent.AutoSize = true;
            this.lnkStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkStudent.Location = new System.Drawing.Point(3, 15);
            this.lnkStudent.Name = "lnkStudent";
            this.lnkStudent.Size = new System.Drawing.Size(329, 13);
            this.lnkStudent.TabIndex = 0;
            this.lnkStudent.TabStop = true;
            this.lnkStudent.Text = "Student";
            this.lnkStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkRubric
            // 
            this.lnkRubric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkRubric.AutoSize = true;
            this.lnkRubric.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lnkRubric.Location = new System.Drawing.Point(673, 15);
            this.lnkRubric.Name = "lnkRubric";
            this.lnkRubric.Size = new System.Drawing.Size(331, 13);
            this.lnkRubric.TabIndex = 2;
            this.lnkRubric.TabStop = true;
            this.lnkRubric.Text = "Rubric";
            this.lnkRubric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.TabAssesement, 0, 0);
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
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Controls.Add(this.lnkClo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkStudent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkRubric, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1007, 44);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // ErrorContact
            // 
            this.ErrorContact.ContainerControl = this;
            // 
            // ErrorLastName
            // 
            this.ErrorLastName.ContainerControl = this;
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
            // TabAssesement
            // 
            this.TabAssesement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabAssesement.Controls.Add(this.tabAddAssessment);
            this.TabAssesement.Controls.Add(this.tabViewAssessment);
            this.TabAssesement.Location = new System.Drawing.Point(3, 3);
            this.TabAssesement.Name = "TabAssesement";
            this.TabAssesement.SelectedIndex = 0;
            this.TabAssesement.Size = new System.Drawing.Size(1001, 324);
            this.TabAssesement.TabIndex = 2;
            // 
            // tabAddAssessment
            // 
            this.tabAddAssessment.Controls.Add(this.lblHide);
            this.tabAddAssessment.Controls.Add(this.btnAddAssessment);
            this.tabAddAssessment.Controls.Add(this.txtTotalWeightage);
            this.tabAddAssessment.Controls.Add(this.txtMarks);
            this.tabAddAssessment.Controls.Add(this.txtTitle);
            this.tabAddAssessment.Controls.Add(this.lblTotalWeightage);
            this.tabAddAssessment.Controls.Add(this.lblTotalMarks);
            this.tabAddAssessment.Controls.Add(this.lblTitle);
            this.tabAddAssessment.Location = new System.Drawing.Point(4, 22);
            this.tabAddAssessment.Name = "tabAddAssessment";
            this.tabAddAssessment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddAssessment.Size = new System.Drawing.Size(993, 298);
            this.tabAddAssessment.TabIndex = 0;
            this.tabAddAssessment.Text = "Add Assessment";
            this.tabAddAssessment.UseVisualStyleBackColor = true;
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAssessment.Location = new System.Drawing.Point(124, 156);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(108, 23);
            this.btnAddAssessment.TabIndex = 6;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseVisualStyleBackColor = true;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // txtTotalWeightage
            // 
            this.txtTotalWeightage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalWeightage.Location = new System.Drawing.Point(175, 90);
            this.txtTotalWeightage.Name = "txtTotalWeightage";
            this.txtTotalWeightage.Size = new System.Drawing.Size(100, 20);
            this.txtTotalWeightage.TabIndex = 5;
            // 
            // txtMarks
            // 
            this.txtMarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarks.Location = new System.Drawing.Point(175, 57);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 20);
            this.txtMarks.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(175, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTotalWeightage
            // 
            this.lblTotalWeightage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalWeightage.AutoSize = true;
            this.lblTotalWeightage.Location = new System.Drawing.Point(43, 93);
            this.lblTotalWeightage.Name = "lblTotalWeightage";
            this.lblTotalWeightage.Size = new System.Drawing.Size(86, 13);
            this.lblTotalWeightage.TabIndex = 2;
            this.lblTotalWeightage.Text = "Total Weightage";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(43, 60);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(63, 13);
            this.lblTotalMarks.TabIndex = 1;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(43, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // tabViewAssessment
            // 
            this.tabViewAssessment.Controls.Add(this.btnviewassessment);
            this.tabViewAssessment.Controls.Add(this.dataGridView1);
            this.tabViewAssessment.Location = new System.Drawing.Point(4, 22);
            this.tabViewAssessment.Name = "tabViewAssessment";
            this.tabViewAssessment.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAssessment.Size = new System.Drawing.Size(993, 298);
            this.tabViewAssessment.TabIndex = 1;
            this.tabViewAssessment.Text = "View Assessment";
            this.tabViewAssessment.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.totalMarksDataGridViewTextBoxColumn,
            this.totalWeightageDataGridViewTextBoxColumn,
            this.Update,
            this.Delete});
            this.dataGridView1.DataSource = this.assessmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(103, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projectBDataSet4
            // 
            this.projectBDataSet4.DataSetName = "ProjectBDataSet4";
            this.projectBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentBindingSource
            // 
            this.assessmentBindingSource.DataMember = "Assessment";
            this.assessmentBindingSource.DataSource = this.projectBDataSet4;
            // 
            // assessmentTableAdapter
            // 
            this.assessmentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // totalMarksDataGridViewTextBoxColumn
            // 
            this.totalMarksDataGridViewTextBoxColumn.DataPropertyName = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.HeaderText = "TotalMarks";
            this.totalMarksDataGridViewTextBoxColumn.Name = "totalMarksDataGridViewTextBoxColumn";
            // 
            // totalWeightageDataGridViewTextBoxColumn
            // 
            this.totalWeightageDataGridViewTextBoxColumn.DataPropertyName = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.HeaderText = "TotalWeightage";
            this.totalWeightageDataGridViewTextBoxColumn.Name = "totalWeightageDataGridViewTextBoxColumn";
            // 
            // Update
            // 
            this.Update.DataPropertyName = "(none)";
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.ToolTipText = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "(none)";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnviewassessment
            // 
            this.btnviewassessment.Location = new System.Drawing.Point(243, 22);
            this.btnviewassessment.Name = "btnviewassessment";
            this.btnviewassessment.Size = new System.Drawing.Size(115, 23);
            this.btnviewassessment.TabIndex = 1;
            this.btnviewassessment.Text = "View Assessment";
            this.btnviewassessment.UseVisualStyleBackColor = true;
            this.btnviewassessment.Click += new System.EventHandler(this.btnviewassessment_Click);
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(553, 132);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(39, 13);
            this.lblHide.TabIndex = 7;
            this.lblHide.Text = "lblHide";
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Assessment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessment";
            this.Load += new System.EventHandler(this.Assessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).EndInit();
            this.TabAssesement.ResumeLayout(false);
            this.tabAddAssessment.ResumeLayout(false);
            this.tabAddAssessment.PerformLayout();
            this.tabViewAssessment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.ErrorProvider ErrorEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel lnkClo;
        private System.Windows.Forms.LinkLabel lnkStudent;
        private System.Windows.Forms.LinkLabel lnkRubric;
        private System.Windows.Forms.ErrorProvider ErrorFirstName;
        private System.Windows.Forms.ErrorProvider ErrorContact;
        private System.Windows.Forms.ErrorProvider ErrorLastName;
        private System.Windows.Forms.ErrorProvider ErrorRegistrationNumber;
        private System.Windows.Forms.ErrorProvider ErrorStatus;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TabControl TabAssesement;
        private System.Windows.Forms.TabPage tabAddAssessment;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.TextBox txtTotalWeightage;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTotalWeightage;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tabViewAssessment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectBDataSet4 projectBDataSet4;
        private System.Windows.Forms.BindingSource assessmentBindingSource;
        private ProjectBDataSet4TableAdapters.AssessmentTableAdapter assessmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnviewassessment;
        private System.Windows.Forms.Label lblHide;
    }
}