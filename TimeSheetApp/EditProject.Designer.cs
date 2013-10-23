using System.Windows.Forms;
namespace TimeSheetApp
{
    partial class EditProject
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
            this.listMyProjects = new System.Windows.Forms.ListBox();
            this.listAllProjects = new System.Windows.Forms.ListBox();
            this.btnAddToMyProjects = new System.Windows.Forms.Button();
            this.btnRemoveFromMyProjects = new System.Windows.Forms.Button();
            this.lblAllProjects = new System.Windows.Forms.Label();
            this.lblMyProjects = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMyProjects
            // 
            this.listMyProjects.FormattingEnabled = true;
            this.listMyProjects.Location = new System.Drawing.Point(27, 38);
            this.listMyProjects.Name = "listMyProjects";
            this.listMyProjects.Size = new System.Drawing.Size(116, 147);
            this.listMyProjects.TabIndex = 0;
            // 
            // listAllProjects
            // 
            this.listAllProjects.FormattingEnabled = true;
            this.listAllProjects.Location = new System.Drawing.Point(302, 38);
            this.listAllProjects.Name = "listAllProjects";
            this.listAllProjects.Size = new System.Drawing.Size(121, 147);
            this.listAllProjects.TabIndex = 1;
            // 
            // btnAddToMyProjects
            // 
            this.btnAddToMyProjects.Location = new System.Drawing.Point(198, 78);
            this.btnAddToMyProjects.Name = "btnAddToMyProjects";
            this.btnAddToMyProjects.Size = new System.Drawing.Size(46, 23);
            this.btnAddToMyProjects.TabIndex = 2;
            this.btnAddToMyProjects.Text = "<<";
            this.btnAddToMyProjects.UseVisualStyleBackColor = true;
            this.btnAddToMyProjects.Click += new System.EventHandler(this.btnAddToMyProjects_Click);
            // 
            // btnRemoveFromMyProjects
            // 
            this.btnRemoveFromMyProjects.Location = new System.Drawing.Point(198, 107);
            this.btnRemoveFromMyProjects.Name = "btnRemoveFromMyProjects";
            this.btnRemoveFromMyProjects.Size = new System.Drawing.Size(46, 23);
            this.btnRemoveFromMyProjects.TabIndex = 3;
            this.btnRemoveFromMyProjects.Text = ">>";
            this.btnRemoveFromMyProjects.UseVisualStyleBackColor = true;
            this.btnRemoveFromMyProjects.Click += new System.EventHandler(this.btnRemoveFromMyProjects_Click);
            // 
            // lblAllProjects
            // 
            this.lblAllProjects.AutoSize = true;
            this.lblAllProjects.Location = new System.Drawing.Point(299, 9);
            this.lblAllProjects.Name = "lblAllProjects";
            this.lblAllProjects.Size = new System.Drawing.Size(59, 13);
            this.lblAllProjects.TabIndex = 5;
            this.lblAllProjects.Text = "All Projects";
            // 
            // lblMyProjects
            // 
            this.lblMyProjects.AutoSize = true;
            this.lblMyProjects.Location = new System.Drawing.Point(26, 14);
            this.lblMyProjects.Name = "lblMyProjects";
            this.lblMyProjects.Size = new System.Drawing.Size(62, 13);
            this.lblMyProjects.TabIndex = 6;
            this.lblMyProjects.Text = "My Projects";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(348, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 238);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMyProjects);
            this.Controls.Add(this.lblAllProjects);
            this.Controls.Add(this.btnRemoveFromMyProjects);
            this.Controls.Add(this.btnAddToMyProjects);
            this.Controls.Add(this.listAllProjects);
            this.Controls.Add(this.listMyProjects);
            this.Name = "EditProject";
            this.Text = "EditProject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProject_onFormClosed);
            this.Load += new System.EventHandler(this.EditProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMyProjects;
        private System.Windows.Forms.ListBox listAllProjects;
        private System.Windows.Forms.Button btnAddToMyProjects;
        private System.Windows.Forms.Button btnRemoveFromMyProjects;
        private System.Windows.Forms.Label lblAllProjects;
        private System.Windows.Forms.Label lblMyProjects;
        private Button btnCancel;
        private Button btnSave;

    }
}