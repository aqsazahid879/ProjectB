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
            this.TabAssesement = new System.Windows.Forms.TabControl();
            this.tabAddAssessment = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblTotalWeightage = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtTotalWeightage = new System.Windows.Forms.TextBox();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.TabAssesement.SuspendLayout();
            this.tabAddAssessment.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabAssesement
            // 
            this.TabAssesement.Controls.Add(this.tabAddAssessment);
            this.TabAssesement.Controls.Add(this.tabPage2);
            this.TabAssesement.Location = new System.Drawing.Point(47, 30);
            this.TabAssesement.Name = "TabAssesement";
            this.TabAssesement.SelectedIndex = 0;
            this.TabAssesement.Size = new System.Drawing.Size(522, 264);
            this.TabAssesement.TabIndex = 0;
            // 
            // tabAddAssessment
            // 
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
            this.tabAddAssessment.Size = new System.Drawing.Size(514, 238);
            this.tabAddAssessment.TabIndex = 0;
            this.tabAddAssessment.Text = "Add Assessment";
            this.tabAddAssessment.UseVisualStyleBackColor = true;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(43, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(43, 60);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(63, 13);
            this.lblTotalMarks.TabIndex = 1;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lblTotalWeightage
            // 
            this.lblTotalWeightage.AutoSize = true;
            this.lblTotalWeightage.Location = new System.Drawing.Point(43, 93);
            this.lblTotalWeightage.Name = "lblTotalWeightage";
            this.lblTotalWeightage.Size = new System.Drawing.Size(86, 13);
            this.lblTotalWeightage.TabIndex = 2;
            this.lblTotalWeightage.Text = "Total Weightage";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(175, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(175, 57);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(100, 20);
            this.txtMarks.TabIndex = 4;
            // 
            // txtTotalWeightage
            // 
            this.txtTotalWeightage.Location = new System.Drawing.Point(175, 90);
            this.txtTotalWeightage.Name = "txtTotalWeightage";
            this.txtTotalWeightage.Size = new System.Drawing.Size(100, 20);
            this.txtTotalWeightage.TabIndex = 5;
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Location = new System.Drawing.Point(124, 156);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(108, 23);
            this.btnAddAssessment.TabIndex = 6;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseVisualStyleBackColor = true;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 306);
            this.Controls.Add(this.TabAssesement);
            this.Name = "Assessment";
            this.Text = "Assessment";
            this.TabAssesement.ResumeLayout(false);
            this.tabAddAssessment.ResumeLayout(false);
            this.tabAddAssessment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabAssesement;
        private System.Windows.Forms.TabPage tabAddAssessment;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.TextBox txtTotalWeightage;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTotalWeightage;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tabPage2;
    }
}