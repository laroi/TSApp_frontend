namespace TimeSheetApp
{
    partial class EditServer
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
            this.lblServer = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(64, 52);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(63, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server URL";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(64, 84);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Update Time";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(179, 49);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(180, 20);
            this.txtServer.TabIndex = 3;
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(179, 84);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(100, 20);
            this.dateTime.TabIndex = 4;
            // 
            // EditServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 262);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblServer);
            this.Name = "EditServer";
            this.Text = "EditServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.DateTimePicker dateTime;
        
    }
}