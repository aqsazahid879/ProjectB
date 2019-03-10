namespace ProjectB
{
    partial class CLO
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddCLO = new System.Windows.Forms.TabPage();
            this.tabViewCLO = new System.Windows.Forms.TabPage();
            this.btnAddCLO = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gridCLO = new System.Windows.Forms.DataGridView();
            this.btnViewCLO = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIDEnter = new System.Windows.Forms.Label();
            this.BtnDeleteStudent = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAddCLO.SuspendLayout();
            this.tabViewCLO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCLO)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddCLO);
            this.tabControl1.Controls.Add(this.tabViewCLO);
            this.tabControl1.Location = new System.Drawing.Point(75, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 312);
            this.tabControl1.TabIndex = 4;
            // 
            // tabAddCLO
            // 
            this.tabAddCLO.Controls.Add(this.lblId);
            this.tabAddCLO.Controls.Add(this.btnAddCLO);
            this.tabAddCLO.Controls.Add(this.txtName);
            this.tabAddCLO.Controls.Add(this.lblName);
            this.tabAddCLO.Location = new System.Drawing.Point(4, 22);
            this.tabAddCLO.Name = "tabAddCLO";
            this.tabAddCLO.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCLO.Size = new System.Drawing.Size(527, 264);
            this.tabAddCLO.TabIndex = 0;
            this.tabAddCLO.Text = "Add CLO";
            this.tabAddCLO.UseVisualStyleBackColor = true;
            this.tabAddCLO.Click += new System.EventHandler(this.tabAddCLO_Click);
            // 
            // tabViewCLO
            // 
            this.tabViewCLO.Controls.Add(this.BtnDeleteStudent);
            this.tabViewCLO.Controls.Add(this.txtId);
            this.tabViewCLO.Controls.Add(this.lblIDEnter);
            this.tabViewCLO.Controls.Add(this.btnViewCLO);
            this.tabViewCLO.Controls.Add(this.gridCLO);
            this.tabViewCLO.Location = new System.Drawing.Point(4, 22);
            this.tabViewCLO.Name = "tabViewCLO";
            this.tabViewCLO.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewCLO.Size = new System.Drawing.Size(596, 286);
            this.tabViewCLO.TabIndex = 1;
            this.tabViewCLO.Text = "View CLO";
            this.tabViewCLO.UseVisualStyleBackColor = true;
            // 
            // btnAddCLO
            // 
            this.btnAddCLO.Location = new System.Drawing.Point(131, 116);
            this.btnAddCLO.Name = "btnAddCLO";
            this.btnAddCLO.Size = new System.Drawing.Size(75, 23);
            this.btnAddCLO.TabIndex = 6;
            this.btnAddCLO.Text = "Add CLO";
            this.btnAddCLO.UseVisualStyleBackColor = true;
            this.btnAddCLO.Click += new System.EventHandler(this.btnAddCLO_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // gridCLO
            // 
            this.gridCLO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCLO.Location = new System.Drawing.Point(62, 116);
            this.gridCLO.Name = "gridCLO";
            this.gridCLO.Size = new System.Drawing.Size(444, 150);
            this.gridCLO.TabIndex = 0;
            this.gridCLO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCLO_CellClick);
            // 
            // btnViewCLO
            // 
            this.btnViewCLO.Location = new System.Drawing.Point(339, 72);
            this.btnViewCLO.Name = "btnViewCLO";
            this.btnViewCLO.Size = new System.Drawing.Size(75, 23);
            this.btnViewCLO.TabIndex = 1;
            this.btnViewCLO.Text = "View CLO";
            this.btnViewCLO.UseVisualStyleBackColor = true;
            this.btnViewCLO.Click += new System.EventHandler(this.btnViewCLO_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(32, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(312, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            // 
            // lblIDEnter
            // 
            this.lblIDEnter.AutoSize = true;
            this.lblIDEnter.Location = new System.Drawing.Point(88, 30);
            this.lblIDEnter.Name = "lblIDEnter";
            this.lblIDEnter.Size = new System.Drawing.Size(206, 13);
            this.lblIDEnter.TabIndex = 5;
            this.lblIDEnter.Text = "Enter The Id of Record you want to delete";
            // 
            // BtnDeleteStudent
            // 
            this.BtnDeleteStudent.Location = new System.Drawing.Point(168, 72);
            this.BtnDeleteStudent.Name = "BtnDeleteStudent";
            this.BtnDeleteStudent.Size = new System.Drawing.Size(93, 23);
            this.BtnDeleteStudent.TabIndex = 7;
            this.BtnDeleteStudent.Text = "Delete Clo";
            this.BtnDeleteStudent.UseVisualStyleBackColor = true;
            this.BtnDeleteStudent.Click += new System.EventHandler(this.BtnDeleteStudent_Click);
            // 
            // CLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "CLO";
            this.Text = "CLO";
            this.Load += new System.EventHandler(this.CLO_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAddCLO.ResumeLayout(false);
            this.tabAddCLO.PerformLayout();
            this.tabViewCLO.ResumeLayout(false);
            this.tabViewCLO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCLO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddCLO;
        private System.Windows.Forms.Button btnAddCLO;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage tabViewCLO;
        private System.Windows.Forms.DataGridView gridCLO;
        private System.Windows.Forms.Button btnViewCLO;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIDEnter;
        private System.Windows.Forms.Button BtnDeleteStudent;
    }
}