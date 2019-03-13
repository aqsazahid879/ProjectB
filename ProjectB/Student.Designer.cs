namespace ProjectB
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectBDataSet = new ProjectB.ProjectBDataSet();
            this.ErrorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorContact = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorRegistrationNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.studentTableAdapter = new ProjectB.ProjectBDataSetTableAdapters.StudentTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lnkClo = new System.Windows.Forms.LinkLabel();
            this.lnkStudent = new System.Windows.Forms.LinkLabel();
            this.lnkRubric = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.StudentControl = new System.Windows.Forms.TabControl();
            this.TabADDStudent = new System.Windows.Forms.TabPage();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.TabViewStudent = new System.Windows.Forms.TabPage();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.gridStudentInformation = new System.Windows.Forms.DataGridView();
            this.TabUpdateStudent = new System.Windows.Forms.TabPage();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.txtStat1 = new System.Windows.Forms.TextBox();
            this.txtRegNum1 = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtContact1 = new System.Windows.Forms.TextBox();
            this.txtLast1 = new System.Windows.Forms.TextBox();
            this.txtFirst1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.StudentControl.SuspendLayout();
            this.TabADDStudent.SuspendLayout();
            this.TabViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentInformation)).BeginInit();
            this.TabUpdateStudent.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.Controls.Add(this.lnkClo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkStudent, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lnkRubric, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lnkClo
            // 
            resources.ApplyResources(this.lnkClo, "lnkClo");
            this.lnkClo.Name = "lnkClo";
            this.lnkClo.TabStop = true;
            // 
            // lnkStudent
            // 
            resources.ApplyResources(this.lnkStudent, "lnkStudent");
            this.lnkStudent.Name = "lnkStudent";
            this.lnkStudent.TabStop = true;
            // 
            // lnkRubric
            // 
            resources.ApplyResources(this.lnkRubric, "lnkRubric");
            this.lnkRubric.Name = "lnkRubric";
            this.lnkRubric.TabStop = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel3.Controls.Add(this.StudentControl, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // StudentControl
            // 
            resources.ApplyResources(this.StudentControl, "StudentControl");
            this.StudentControl.Controls.Add(this.TabADDStudent);
            this.StudentControl.Controls.Add(this.TabViewStudent);
            this.StudentControl.Controls.Add(this.TabUpdateStudent);
            this.StudentControl.Name = "StudentControl";
            this.StudentControl.SelectedIndex = 0;
            // 
            // TabADDStudent
            // 
            this.TabADDStudent.Controls.Add(this.lblID);
            this.TabADDStudent.Controls.Add(this.btnAddStudent);
            this.TabADDStudent.Controls.Add(this.txtStatus);
            this.TabADDStudent.Controls.Add(this.txtRegistrationNumber);
            this.TabADDStudent.Controls.Add(this.txtEmail);
            this.TabADDStudent.Controls.Add(this.txtContact);
            this.TabADDStudent.Controls.Add(this.txtLastName);
            this.TabADDStudent.Controls.Add(this.txtFirstName);
            this.TabADDStudent.Controls.Add(this.lblStatus);
            this.TabADDStudent.Controls.Add(this.lblRegistrationNumber);
            this.TabADDStudent.Controls.Add(this.lblEmail);
            this.TabADDStudent.Controls.Add(this.lblContact);
            this.TabADDStudent.Controls.Add(this.lblLastName);
            this.TabADDStudent.Controls.Add(this.lblFirstName);
            resources.ApplyResources(this.TabADDStudent, "TabADDStudent");
            this.TabADDStudent.Name = "TabADDStudent";
            this.TabADDStudent.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // btnAddStudent
            // 
            resources.ApplyResources(this.btnAddStudent, "btnAddStudent");
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtStatus
            // 
            resources.ApplyResources(this.txtStatus, "txtStatus");
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Leave += new System.EventHandler(this.txtStatus_Leave);
            // 
            // txtRegistrationNumber
            // 
            resources.ApplyResources(this.txtRegistrationNumber, "txtRegistrationNumber");
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Leave += new System.EventHandler(this.txtRegistrationNumber_Leave);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtContact
            // 
            resources.ApplyResources(this.txtContact, "txtContact");
            this.txtContact.Name = "txtContact";
            this.txtContact.Leave += new System.EventHandler(this.txtContact_Leave);
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // lblRegistrationNumber
            // 
            resources.ApplyResources(this.lblRegistrationNumber, "lblRegistrationNumber");
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblContact
            // 
            resources.ApplyResources(this.lblContact, "lblContact");
            this.lblContact.Name = "lblContact";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Name = "lblLastName";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            // 
            // TabViewStudent
            // 
            this.TabViewStudent.Controls.Add(this.btnViewStudent);
            this.TabViewStudent.Controls.Add(this.gridStudentInformation);
            resources.ApplyResources(this.TabViewStudent, "TabViewStudent");
            this.TabViewStudent.Name = "TabViewStudent";
            this.TabViewStudent.UseVisualStyleBackColor = true;
            // 
            // btnViewStudent
            // 
            resources.ApplyResources(this.btnViewStudent, "btnViewStudent");
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // gridStudentInformation
            // 
            resources.ApplyResources(this.gridStudentInformation, "gridStudentInformation");
            this.gridStudentInformation.AutoGenerateColumns = false;
            this.gridStudentInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudentInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudentInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Delete});
            this.gridStudentInformation.DataSource = this.studentBindingSource;
            this.gridStudentInformation.Name = "gridStudentInformation";
            this.gridStudentInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridStudentInformation_CellContentClick);
            // 
            // TabUpdateStudent
            // 
            this.TabUpdateStudent.Controls.Add(this.btnUpdateStudent);
            this.TabUpdateStudent.Controls.Add(this.txtStat1);
            this.TabUpdateStudent.Controls.Add(this.txtRegNum1);
            this.TabUpdateStudent.Controls.Add(this.txtEmail1);
            this.TabUpdateStudent.Controls.Add(this.txtContact1);
            this.TabUpdateStudent.Controls.Add(this.txtLast1);
            this.TabUpdateStudent.Controls.Add(this.txtFirst1);
            this.TabUpdateStudent.Controls.Add(this.label2);
            this.TabUpdateStudent.Controls.Add(this.label3);
            this.TabUpdateStudent.Controls.Add(this.label4);
            this.TabUpdateStudent.Controls.Add(this.label5);
            this.TabUpdateStudent.Controls.Add(this.label6);
            this.TabUpdateStudent.Controls.Add(this.label1);
            resources.ApplyResources(this.TabUpdateStudent, "TabUpdateStudent");
            this.TabUpdateStudent.Name = "TabUpdateStudent";
            this.TabUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            resources.ApplyResources(this.btnUpdateStudent, "btnUpdateStudent");
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // txtStat1
            // 
            resources.ApplyResources(this.txtStat1, "txtStat1");
            this.txtStat1.Name = "txtStat1";
            // 
            // txtRegNum1
            // 
            resources.ApplyResources(this.txtRegNum1, "txtRegNum1");
            this.txtRegNum1.Name = "txtRegNum1";
            // 
            // txtEmail1
            // 
            resources.ApplyResources(this.txtEmail1, "txtEmail1");
            this.txtEmail1.Name = "txtEmail1";
            // 
            // txtContact1
            // 
            resources.ApplyResources(this.txtContact1, "txtContact1");
            this.txtContact1.Name = "txtContact1";
            // 
            // txtLast1
            // 
            resources.ApplyResources(this.txtLast1, "txtLast1");
            this.txtLast1.Name = "txtLast1";
            // 
            // txtFirst1
            // 
            resources.ApplyResources(this.txtFirst1, "txtFirst1");
            this.txtFirst1.Name = "txtFirst1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            resources.ApplyResources(this.firstNameDataGridViewTextBoxColumn, "firstNameDataGridViewTextBoxColumn");
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            resources.ApplyResources(this.lastNameDataGridViewTextBoxColumn, "lastNameDataGridViewTextBoxColumn");
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            resources.ApplyResources(this.contactDataGridViewTextBoxColumn, "contactDataGridViewTextBoxColumn");
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            resources.ApplyResources(this.registrationNumberDataGridViewTextBoxColumn, "registrationNumberDataGridViewTextBoxColumn");
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Student
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorRegistrationNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorStatus)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.StudentControl.ResumeLayout(false);
            this.TabADDStudent.ResumeLayout(false);
            this.TabADDStudent.PerformLayout();
            this.TabViewStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentInformation)).EndInit();
            this.TabUpdateStudent.ResumeLayout(false);
            this.TabUpdateStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorEmail;
        private System.Windows.Forms.ErrorProvider ErrorFirstName;
        private System.Windows.Forms.ErrorProvider ErrorContact;
        private System.Windows.Forms.ErrorProvider ErrorLastName;
        private System.Windows.Forms.ErrorProvider ErrorRegistrationNumber;
        private System.Windows.Forms.ErrorProvider ErrorStatus;
        private ProjectBDataSet projectBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel lnkClo;
        private System.Windows.Forms.LinkLabel lnkStudent;
        private System.Windows.Forms.LinkLabel lnkRubric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabControl StudentControl;
        private System.Windows.Forms.TabPage TabADDStudent;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRegistrationNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TabPage TabViewStudent;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.DataGridView gridStudentInformation;
        private System.Windows.Forms.TabPage TabUpdateStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox txtStat1;
        private System.Windows.Forms.TextBox txtRegNum1;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtContact1;
        private System.Windows.Forms.TextBox txtLast1;
        private System.Windows.Forms.TextBox txtFirst1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}