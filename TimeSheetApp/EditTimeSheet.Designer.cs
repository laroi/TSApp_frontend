namespace TimeSheetApp
{
    partial class EditTimeSheet
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
            this.lblProject = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnGetEntry = new System.Windows.Forms.Button();
            this.cmbProjects = new System.Windows.Forms.ComboBox();
            this.projectDate = new System.Windows.Forms.DateTimePicker();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(217, 22);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(73, 13);
            this.lblProject.TabIndex = 9;
            this.lblProject.Text = "Select Project";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(42, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Select Date";
            // 
            // btnGetEntry
            // 
            this.btnGetEntry.Location = new System.Drawing.Point(452, 12);
            this.btnGetEntry.Name = "btnGetEntry";
            this.btnGetEntry.Size = new System.Drawing.Size(75, 23);
            this.btnGetEntry.TabIndex = 7;
            this.btnGetEntry.Text = "Get Entry";
            this.btnGetEntry.UseVisualStyleBackColor = true;
            this.btnGetEntry.Click += new System.EventHandler(this.btnGetEntry_Click);
            // 
            // cmbProjects
            // 
            this.cmbProjects.FormattingEnabled = true;
            this.cmbProjects.Location = new System.Drawing.Point(309, 14);
            this.cmbProjects.Name = "cmbProjects";
            this.cmbProjects.Size = new System.Drawing.Size(121, 21);
            this.cmbProjects.TabIndex = 6;
            // 
            // projectDate
            // 
            this.projectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.projectDate.Location = new System.Drawing.Point(118, 16);
            this.projectDate.Name = "projectDate";
            this.projectDate.Size = new System.Drawing.Size(83, 20);
            this.projectDate.TabIndex = 5;
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(29, 40);
            this.txtEntry.Multiline = true;
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(482, 60);
            this.txtEntry.TabIndex = 10;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(425, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 111);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(412, 16);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 13;
            this.lblHours.Text = "Hours";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(471, 14);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(40, 20);
            this.txtHours.TabIndex = 14;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.txtHours);
            this.grpUpdate.Controls.Add(this.btnCancel);
            this.grpUpdate.Controls.Add(this.lblHours);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.txtEntry);
            this.grpUpdate.Location = new System.Drawing.Point(27, 64);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(538, 140);
            this.grpUpdate.TabIndex = 15;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Updat Values";
            // 
            // EditTimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 216);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnGetEntry);
            this.Controls.Add(this.cmbProjects);
            this.Controls.Add(this.projectDate);
            this.Name = "EditTimeSheet";
            this.Text = "EditTimeSheet";
            this.Load += new System.EventHandler(this.EditTimeSheet_Load);
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnGetEntry;
        private System.Windows.Forms.ComboBox cmbProjects;
        private System.Windows.Forms.DateTimePicker projectDate;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.GroupBox grpUpdate;
    }
}