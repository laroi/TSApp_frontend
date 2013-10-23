namespace TimeSheetApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMyProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editServerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(733, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem,
            this.entryToolStripMenuItem,
            this.editServerSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMyProjectsToolStripMenuItem,
            this.addProjectsToolStripMenuItem1});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // editMyProjectsToolStripMenuItem
            // 
            this.editMyProjectsToolStripMenuItem.Name = "editMyProjectsToolStripMenuItem";
            this.editMyProjectsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.editMyProjectsToolStripMenuItem.Text = "Edit My Projects";
            this.editMyProjectsToolStripMenuItem.Click += new System.EventHandler(this.editMyProjectsToolStripMenuItem_Click);
            // 
            // addProjectsToolStripMenuItem1
            // 
            this.addProjectsToolStripMenuItem1.Name = "addProjectsToolStripMenuItem1";
            this.addProjectsToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.addProjectsToolStripMenuItem1.Text = "Add Projects";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntryToolStripMenuItem1,
            this.editEntryToolStripMenuItem1});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.entryToolStripMenuItem.Text = "Entry";
            // 
            // addEntryToolStripMenuItem1
            // 
            this.addEntryToolStripMenuItem1.Name = "addEntryToolStripMenuItem1";
            this.addEntryToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.addEntryToolStripMenuItem1.Text = "Add Entry";
            this.addEntryToolStripMenuItem1.Click += new System.EventHandler(this.addEntryToolStripMenuItem1_Click);
            // 
            // editEntryToolStripMenuItem1
            // 
            this.editEntryToolStripMenuItem1.Name = "editEntryToolStripMenuItem1";
            this.editEntryToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.editEntryToolStripMenuItem1.Text = "Edit Entry";
            this.editEntryToolStripMenuItem1.Click += new System.EventHandler(this.editEntryToolStripMenuItem1_Click);
            // 
            // editServerSettingsToolStripMenuItem
            // 
            this.editServerSettingsToolStripMenuItem.Name = "editServerSettingsToolStripMenuItem";
            this.editServerSettingsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editServerSettingsToolStripMenuItem.Text = "Edit Server Settings";
            this.editServerSettingsToolStripMenuItem.Click += new System.EventHandler(this.editServerSettingsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.monthlyReportToolStripMenuItem.Text = "Monthly Report";
            this.monthlyReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyReportToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 281);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Time Sheet App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editServerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMyProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editEntryToolStripMenuItem1;

    }
}

