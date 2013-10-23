namespace TimeSheetApp
{
    partial class AddEntry
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
            this.lblComments = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(27, 79);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 17;
            this.lblComments.Text = "Comments";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(323, 48);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(37, 20);
            this.txtHours.TabIndex = 16;
            this.txtHours.Text = "8";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(24, 51);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 15;
            this.lblProject.Text = "Project";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(451, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(27, 98);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(496, 44);
            this.txtComment.TabIndex = 12;
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(70, 48);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(172, 21);
            this.cmbProject.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(436, 22);
            this.lblUserName.MinimumSize = new System.Drawing.Size(100, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 20);
            this.lblUserName.TabIndex = 10;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(282, 51);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 18;
            this.lblHours.Text = "Hours";
            // 
            // AddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 189);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbProject);
            this.Controls.Add(this.lblUserName);
            this.Name = "AddEntry";
            this.Text = "AddEntry";
            this.Load += new System.EventHandler(this.AddEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblHours;
    }
}