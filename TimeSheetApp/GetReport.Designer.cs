namespace TimeSheetApp
{
    partial class GetReport
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
            this.dateTimeReport = new System.Windows.Forms.DateTimePicker();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimeReport
            // 
            this.dateTimeReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeReport.Location = new System.Drawing.Point(181, 71);
            this.dateTimeReport.Name = "dateTimeReport";
            this.dateTimeReport.Size = new System.Drawing.Size(156, 20);
            this.dateTimeReport.TabIndex = 0;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(262, 177);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 1;
            this.btnGetReport.Text = "Generate";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(181, 109);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(156, 21);
            this.cmbProject.TabIndex = 2;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(72, 77);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(70, 13);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Select Month";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(69, 117);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(73, 13);
            this.lblProject.TabIndex = 4;
            this.lblProject.Text = "Select Project";
            // 
            // GetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 262);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.dateTimeReport);
            this.Name = "GetReport";
            this.Text = "GetReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeReport;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblProject;
    }
}