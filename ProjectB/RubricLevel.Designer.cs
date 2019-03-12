namespace ProjectB
{
    partial class RubricLevel
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
            this.TabAddRubricLevel = new System.Windows.Forms.TabPage();
            this.cmbRubricID = new System.Windows.Forms.ComboBox();
            this.txtMeasurementLevel = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblRubricID = new System.Windows.Forms.Label();
            this.lblMeasurementLevel = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.TabViewRubricLevel = new System.Windows.Forms.TabPage();
            this.btnAddRubricLevel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabAddRubricLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabAddRubricLevel);
            this.tabControl1.Controls.Add(this.TabViewRubricLevel);
            this.tabControl1.Location = new System.Drawing.Point(167, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 244);
            this.tabControl1.TabIndex = 6;
            // 
            // TabAddRubricLevel
            // 
            this.TabAddRubricLevel.Controls.Add(this.btnAddRubricLevel);
            this.TabAddRubricLevel.Controls.Add(this.cmbRubricID);
            this.TabAddRubricLevel.Controls.Add(this.txtMeasurementLevel);
            this.TabAddRubricLevel.Controls.Add(this.txtDetails);
            this.TabAddRubricLevel.Controls.Add(this.lblRubricID);
            this.TabAddRubricLevel.Controls.Add(this.lblMeasurementLevel);
            this.TabAddRubricLevel.Controls.Add(this.lblDetail);
            this.TabAddRubricLevel.Location = new System.Drawing.Point(4, 22);
            this.TabAddRubricLevel.Name = "TabAddRubricLevel";
            this.TabAddRubricLevel.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddRubricLevel.Size = new System.Drawing.Size(457, 218);
            this.TabAddRubricLevel.TabIndex = 0;
            this.TabAddRubricLevel.Text = "Add Rubric Level";
            this.TabAddRubricLevel.UseVisualStyleBackColor = true;
            // 
            // cmbRubricID
            // 
            this.cmbRubricID.FormattingEnabled = true;
            this.cmbRubricID.Location = new System.Drawing.Point(200, 99);
            this.cmbRubricID.Name = "cmbRubricID";
            this.cmbRubricID.Size = new System.Drawing.Size(121, 21);
            this.cmbRubricID.TabIndex = 11;
            // 
            // txtMeasurementLevel
            // 
            this.txtMeasurementLevel.Location = new System.Drawing.Point(200, 62);
            this.txtMeasurementLevel.Name = "txtMeasurementLevel";
            this.txtMeasurementLevel.Size = new System.Drawing.Size(121, 20);
            this.txtMeasurementLevel.TabIndex = 10;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(200, 28);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(121, 20);
            this.txtDetails.TabIndex = 9;
            // 
            // lblRubricID
            // 
            this.lblRubricID.AutoSize = true;
            this.lblRubricID.Location = new System.Drawing.Point(84, 102);
            this.lblRubricID.Name = "lblRubricID";
            this.lblRubricID.Size = new System.Drawing.Size(50, 13);
            this.lblRubricID.TabIndex = 8;
            this.lblRubricID.Text = "Rubric Id";
            // 
            // lblMeasurementLevel
            // 
            this.lblMeasurementLevel.AutoSize = true;
            this.lblMeasurementLevel.Location = new System.Drawing.Point(84, 65);
            this.lblMeasurementLevel.Name = "lblMeasurementLevel";
            this.lblMeasurementLevel.Size = new System.Drawing.Size(100, 13);
            this.lblMeasurementLevel.TabIndex = 7;
            this.lblMeasurementLevel.Text = "Measurement Level";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(84, 31);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(39, 13);
            this.lblDetail.TabIndex = 6;
            this.lblDetail.Text = "Details";
            // 
            // TabViewRubricLevel
            // 
            this.TabViewRubricLevel.Location = new System.Drawing.Point(4, 22);
            this.TabViewRubricLevel.Name = "TabViewRubricLevel";
            this.TabViewRubricLevel.Padding = new System.Windows.Forms.Padding(3);
            this.TabViewRubricLevel.Size = new System.Drawing.Size(457, 218);
            this.TabViewRubricLevel.TabIndex = 1;
            this.TabViewRubricLevel.Text = "View Rubric Level";
            this.TabViewRubricLevel.UseVisualStyleBackColor = true;
            // 
            // btnAddRubricLevel
            // 
            this.btnAddRubricLevel.Location = new System.Drawing.Point(118, 152);
            this.btnAddRubricLevel.Name = "btnAddRubricLevel";
            this.btnAddRubricLevel.Size = new System.Drawing.Size(116, 23);
            this.btnAddRubricLevel.TabIndex = 13;
            this.btnAddRubricLevel.Text = "Add Rubric Level";
            this.btnAddRubricLevel.UseVisualStyleBackColor = true;
            this.btnAddRubricLevel.Click += new System.EventHandler(this.btnAddRubricLevel_Click);
            // 
            // RubricLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 305);
            this.Controls.Add(this.tabControl1);
            this.Name = "RubricLevel";
            this.Text = "RubricLevel";
            this.Load += new System.EventHandler(this.RubricLevel_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabAddRubricLevel.ResumeLayout(false);
            this.TabAddRubricLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabAddRubricLevel;
        private System.Windows.Forms.ComboBox cmbRubricID;
        private System.Windows.Forms.TextBox txtMeasurementLevel;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblRubricID;
        private System.Windows.Forms.Label lblMeasurementLevel;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TabPage TabViewRubricLevel;
        private System.Windows.Forms.Button btnAddRubricLevel;
    }
}