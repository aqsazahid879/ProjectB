namespace ProjectB
{
    partial class Checking
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtIDTab = new System.Windows.Forms.TextBox();
            this.lblIDEnter = new System.Windows.Forms.Label();
            this.BtnDeleteStudent = new System.Windows.Forms.Button();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.gridStudentInformation = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.StudentControl.SuspendLayout();
            this.TabADDStudent.SuspendLayout();
            this.TabViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentInformation)).BeginInit();
            this.TabUpdateStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROJECTB";
            // 
            // StudentControl
            // 
            this.StudentControl.Controls.Add(this.TabADDStudent);
            this.StudentControl.Controls.Add(this.TabViewStudent);
            this.StudentControl.Controls.Add(this.TabUpdateStudent);
            this.StudentControl.Location = new System.Drawing.Point(-2, 124);
            this.StudentControl.Name = "StudentControl";
            this.StudentControl.SelectedIndex = 0;
            this.StudentControl.Size = new System.Drawing.Size(918, 337);
            this.StudentControl.TabIndex = 14;
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
            this.TabADDStudent.Location = new System.Drawing.Point(4, 22);
            this.TabADDStudent.Name = "TabADDStudent";
            this.TabADDStudent.Padding = new System.Windows.Forms.Padding(3);
            this.TabADDStudent.Size = new System.Drawing.Size(910, 311);
            this.TabADDStudent.TabIndex = 0;
            this.TabADDStudent.Text = "Add Student";
            this.TabADDStudent.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 50);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(202, 207);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(87, 23);
            this.btnAddStudent.TabIndex = 25;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(281, 168);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 24;
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(281, 138);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationNumber.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(281, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(281, 78);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 20);
            this.txtContact.TabIndex = 21;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(281, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(281, 21);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(101, 171);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Location = new System.Drawing.Point(101, 141);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(103, 13);
            this.lblRegistrationNumber.TabIndex = 17;
            this.lblRegistrationNumber.Text = "Registration Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(101, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(101, 81);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 15;
            this.lblContact.Text = "Contact";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(101, 53);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(101, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name";
            // 
            // TabViewStudent
            // 
            this.TabViewStudent.Controls.Add(this.txtIDTab);
            this.TabViewStudent.Controls.Add(this.lblIDEnter);
            this.TabViewStudent.Controls.Add(this.BtnDeleteStudent);
            this.TabViewStudent.Controls.Add(this.btnViewStudent);
            this.TabViewStudent.Controls.Add(this.gridStudentInformation);
            this.TabViewStudent.Location = new System.Drawing.Point(4, 22);
            this.TabViewStudent.Name = "TabViewStudent";
            this.TabViewStudent.Padding = new System.Windows.Forms.Padding(3);
            this.TabViewStudent.Size = new System.Drawing.Size(910, 311);
            this.TabViewStudent.TabIndex = 1;
            this.TabViewStudent.Text = "View Student";
            this.TabViewStudent.UseVisualStyleBackColor = true;
            // 
            // txtIDTab
            // 
            this.txtIDTab.Location = new System.Drawing.Point(280, 38);
            this.txtIDTab.Name = "txtIDTab";
            this.txtIDTab.Size = new System.Drawing.Size(100, 20);
            this.txtIDTab.TabIndex = 4;
            // 
            // lblIDEnter
            // 
            this.lblIDEnter.AutoSize = true;
            this.lblIDEnter.Location = new System.Drawing.Point(56, 41);
            this.lblIDEnter.Name = "lblIDEnter";
            this.lblIDEnter.Size = new System.Drawing.Size(206, 13);
            this.lblIDEnter.TabIndex = 3;
            this.lblIDEnter.Text = "Enter The Id of Record you want to delete";
            // 
            // BtnDeleteStudent
            // 
            this.BtnDeleteStudent.Location = new System.Drawing.Point(142, 80);
            this.BtnDeleteStudent.Name = "BtnDeleteStudent";
            this.BtnDeleteStudent.Size = new System.Drawing.Size(93, 23);
            this.BtnDeleteStudent.TabIndex = 2;
            this.BtnDeleteStudent.Text = "Delete Student";
            this.BtnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Location = new System.Drawing.Point(280, 80);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(95, 23);
            this.btnViewStudent.TabIndex = 1;
            this.btnViewStudent.Text = "View Student";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            // 
            // gridStudentInformation
            // 
            this.gridStudentInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudentInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.gridStudentInformation.Location = new System.Drawing.Point(9, 136);
            this.gridStudentInformation.Name = "gridStudentInformation";
            this.gridStudentInformation.Size = new System.Drawing.Size(843, 150);
            this.gridStudentInformation.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
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
            this.TabUpdateStudent.Controls.Add(this.label7);
            this.TabUpdateStudent.Location = new System.Drawing.Point(4, 22);
            this.TabUpdateStudent.Name = "TabUpdateStudent";
            this.TabUpdateStudent.Padding = new System.Windows.Forms.Padding(3);
            this.TabUpdateStudent.Size = new System.Drawing.Size(910, 311);
            this.TabUpdateStudent.TabIndex = 2;
            this.TabUpdateStudent.Text = "Update Student";
            this.TabUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(251, 207);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(95, 23);
            this.btnUpdateStudent.TabIndex = 38;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // txtStat1
            // 
            this.txtStat1.Location = new System.Drawing.Point(341, 168);
            this.txtStat1.Name = "txtStat1";
            this.txtStat1.Size = new System.Drawing.Size(100, 20);
            this.txtStat1.TabIndex = 37;
            // 
            // txtRegNum1
            // 
            this.txtRegNum1.Location = new System.Drawing.Point(341, 138);
            this.txtRegNum1.Name = "txtRegNum1";
            this.txtRegNum1.Size = new System.Drawing.Size(100, 20);
            this.txtRegNum1.TabIndex = 36;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(341, 108);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(100, 20);
            this.txtEmail1.TabIndex = 35;
            // 
            // txtContact1
            // 
            this.txtContact1.Location = new System.Drawing.Point(341, 78);
            this.txtContact1.Name = "txtContact1";
            this.txtContact1.Size = new System.Drawing.Size(100, 20);
            this.txtContact1.TabIndex = 34;
            // 
            // txtLast1
            // 
            this.txtLast1.Location = new System.Drawing.Point(341, 50);
            this.txtLast1.Name = "txtLast1";
            this.txtLast1.Size = new System.Drawing.Size(100, 20);
            this.txtLast1.TabIndex = 33;
            // 
            // txtFirst1
            // 
            this.txtFirst1.Location = new System.Drawing.Point(341, 21);
            this.txtFirst1.Name = "txtFirst1";
            this.txtFirst1.Size = new System.Drawing.Size(100, 20);
            this.txtFirst1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Registration Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "First Name";
            // 
            // Checking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(915, 585);
            this.Controls.Add(this.StudentControl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Checking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.StudentControl.ResumeLayout(false);
            this.TabADDStudent.ResumeLayout(false);
            this.TabADDStudent.PerformLayout();
            this.TabViewStudent.ResumeLayout(false);
            this.TabViewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudentInformation)).EndInit();
            this.TabUpdateStudent.ResumeLayout(false);
            this.TabUpdateStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox txtIDTab;
        private System.Windows.Forms.Label lblIDEnter;
        private System.Windows.Forms.Button BtnDeleteStudent;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.DataGridView gridStudentInformation;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
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
        private System.Windows.Forms.Label label7;
    }
}