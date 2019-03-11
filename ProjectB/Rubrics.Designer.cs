namespace ProjectB
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddRubric = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblCLOId = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.cmbCloId = new System.Windows.Forms.ComboBox();
            this.btnAddRubric = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAddRubric.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddRubric);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(90, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 258);
            this.tabControl1.TabIndex = 0;
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
            this.tabAddRubric.Size = new System.Drawing.Size(523, 232);
            this.tabAddRubric.TabIndex = 0;
            this.tabAddRubric.Text = "Add Rubrics";
            this.tabAddRubric.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(102, 69);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(34, 13);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Detail";
            // 
            // lblCLOId
            // 
            this.lblCLOId.AutoSize = true;
            this.lblCLOId.Location = new System.Drawing.Point(102, 113);
            this.lblCLOId.Name = "lblCLOId";
            this.lblCLOId.Size = new System.Drawing.Size(34, 13);
            this.lblCLOId.TabIndex = 1;
            this.lblCLOId.Text = "Clo Id";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(220, 69);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(121, 20);
            this.txtDetail.TabIndex = 2;
            // 
            // cmbCloId
            // 
            this.cmbCloId.FormattingEnabled = true;
            this.cmbCloId.Location = new System.Drawing.Point(220, 110);
            this.cmbCloId.Name = "cmbCloId";
            this.cmbCloId.Size = new System.Drawing.Size(121, 21);
            this.cmbCloId.TabIndex = 3;
            // 
            // btnAddRubric
            // 
            this.btnAddRubric.Location = new System.Drawing.Point(175, 173);
            this.btnAddRubric.Name = "btnAddRubric";
            this.btnAddRubric.Size = new System.Drawing.Size(75, 23);
            this.btnAddRubric.TabIndex = 4;
            this.btnAddRubric.Text = "Add Rubric";
            this.btnAddRubric.UseVisualStyleBackColor = true;
            this.btnAddRubric.Click += new System.EventHandler(this.btnAddRubric_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(220, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(102, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            // 
            // Rubrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 318);
            this.Controls.Add(this.tabControl1);
            this.Name = "Rubrics";
            this.Text = "Rubrics";
            this.Load += new System.EventHandler(this.Rubrics_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAddRubric.ResumeLayout(false);
            this.tabAddRubric.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddRubric;
        private System.Windows.Forms.Button btnAddRubric;
        private System.Windows.Forms.ComboBox cmbCloId;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label lblCLOId;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
    }
}