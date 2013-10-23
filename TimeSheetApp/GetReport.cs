using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeSheetApp.Data;
using System.Diagnostics;

namespace TimeSheetApp
{
    public partial class GetReport : Form
    {
        APIClient objApiClient = new APIClient();
        BindingSource bs = new BindingSource();
        public GetReport()
        {
            InitializeComponent();
            dateTimeReport.Format = DateTimePickerFormat.Custom;
            dateTimeReport.CustomFormat ="MMMM yyyy";
            cmbProject.DataSource = null;
            BindingList<project> bl = new BindingList<project>(UserModel.projects);
            //bl.Add(UserModel.projects);
            bs.DataSource = UserModel.projects;
            cmbProject.DataSource = bl;
            cmbProject.DisplayMember = "project_name";
            cmbProject.ValueMember = "project_pk";
            if (UserModel.projects.Count > 0)
                cmbProject.SelectedIndex = 0;
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {

            if (cmbProject.SelectedItem != null && dateTimeReport.Value != null)
            {
                string date = dateTimeReport.Value.ToString("yyyy-MM-dd");
                date = date.Remove(date.Length - 3);
                string project_pk = ((project)cmbProject.SelectedItem).project_pk.ToString();
                string URL = objApiClient.getReport(date, project_pk);
                if (URL != null)
                {
                    Process.Start(URL);
                }
                else 
                {
                    MessageBox.Show("No entries to generate report");
                }
            }
            else
            {
                MessageBox.Show("Please enter values");
            }

        }
    }
}
