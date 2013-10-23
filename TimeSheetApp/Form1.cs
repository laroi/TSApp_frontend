using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeSheetApp
{
    public partial class Form1 : Form
    {
       APIClient objApiClient = new APIClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AddEntry objAddEntry = new AddEntry();
            AddEntry objAddEntry = new AddEntry();
            objAddEntry.MdiParent = this;
            objAddEntry.Show();
            objApiClient.LoadJson();
           
            
        }




        private Form isFormRunning(string formName)
        {
            FormCollection fc = Application.OpenForms;
            Form result = null;
            for (int i = 0; i < fc.Count; i++)
            {
                Form frm = fc[i];
                if (frm.Text == formName)
                {
                    result = frm;
                }
               
            }
            return result;
        }

        private void editServerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditServer objEditServer = new EditServer();
            objEditServer.MdiParent = this;
            objEditServer.Show();
        }

        private void editMyProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProject objEditProject = new EditProject();
            objEditProject.MdiParent = this;
            objEditProject.Show();
            /*Form runnig_form = isFormRunning("AddEntry");
            if (runnig_form != null)
                runnig_form.Close();*/
            /*FormCollection fc = Application.OpenForms;

            for (int i = 0; i < fc.Count; i++)
            {
                Form frm = fc[i];
                if (frm.Text == "AddEntry")
                {
                    frm.Close();
                }
            }*/
        }

        private void editEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditTimeSheet ObjEditTimeSheet = new EditTimeSheet();
            ObjEditTimeSheet.MdiParent = this;
            ObjEditTimeSheet.Show();
        }

        private void addEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form runnig_form = isFormRunning("AddEntry");
            if (runnig_form != null)
                runnig_form.Close();
            Form runnig_form1 = isFormRunning("EditProject");
            if (runnig_form1 != null)
                runnig_form1.Close();
           /* FormCollection fc = Application.OpenForms;

            for (int i = 0; i < fc.Count; i++)
            {
                Form frm = fc[i];
                if (frm.Text == "AddEntry" || frm.Text == "EditProject")
                {
                    frm.Close();
                }
            }*/
           // showAddEntry();
           AddEntry objAddEntry = new AddEntry();
           objAddEntry.MdiParent = this;
           objAddEntry.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthlyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetReport objGetReport = new GetReport();
            objGetReport.MdiParent = this;
            objGetReport.Show();
        }
    }
}
