using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeSheetApp.Data;
using System.Globalization;

namespace TimeSheetApp
{
    public partial class EditTimeSheet : Form
    {
        APIClient client = new APIClient();
        string project_pk;
        public EditTimeSheet()
        {
            InitializeComponent();
        }

        private void EditTimeSheet_Load(object sender, EventArgs e)
        {
            cmbProjects.DataSource = new BindingSource(UserModel.projects, null);
            cmbProjects.DisplayMember = "project_name";
            cmbProjects.ValueMember = "project_pk";
           
        }

        private void btnGetEntry_Click(object sender, EventArgs e)
        {
            project_pk = ((project)cmbProjects.SelectedItem).project_pk.ToString();
            txtEntry.Text = "";
            txtHours.Text = "";
            string date = Convert.ToDateTime(projectDate.Text).ToString("yyyy/MM/dd").Replace("/","-");
            //DateTime dt = DateTime.ParseExact(date, "MM/dd/yyyy",CultureInfo.InvariantCulture);
           
            client.getTimeSheetEntry(date,project_pk);
            if (UserModel.time_sheet_entry != null)
            {
                txtEntry.Text = UserModel.time_sheet_entry;
                txtHours.Text = UserModel.hours;
            }
            else
            {
                MessageBox.Show("Searched Entry Not Found");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEntry.Text != "" && txtHours.Text != "")
            {
                if (UserModel.entry_pk != null)
                {
                    string hours = txtHours.Text;
                    string body = txtEntry.Text;
                    int result = client.EditTimeSheetEntry(project_pk, hours, body, UserModel.entry_pk);
                    if (result > 0)
                    {
                        UserModel.time_sheet_entry = null;
                        UserModel.entry_pk = null;
                        UserModel.hours = null;
                        MessageBox.Show("Your entry is successfully updated");
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Something went wrong. Your entry is not updated");
                    }
                }
                else {
                    MessageBox.Show("Please get the value to be updated");
                }
            }
            else
            {
                MessageBox.Show("Please fill the values");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserModel.time_sheet_entry = null;
            UserModel.entry_pk = null;
            UserModel.hours = null;
            this.Close();
        }
    }
}
