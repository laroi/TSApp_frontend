using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeSheetApp.Data;


namespace TimeSheetApp
{
    public partial class AddEntry : Form
    {
       // public delegate void MyEventHandler(object source, EventArgs e);
        APIClient client = new APIClient();
        BindingSource bs = new BindingSource();
        private EditProject _editProject;
        public AddEntry()
        {
            InitializeComponent();
            _editProject = new EditProject();
             //  _editProject.Feedback += new EventHandler<TextArgs>(Feedback_Received);
           EditProject.Feedback += new EventHandler<TextArgs>(Feedback_Received);
            //Feedback += 

            //Event Subscription
            //objEditProject.SourceUpdated += new EventHandler<EventArgs>(updateComboBox);
            //objEditProject.SourceUpdated += new EventHandler<EventArgs>(objEditProject_SourceUpdated);
            
        }

        public void Feedback_Received(object sender, TextArgs e) {
            updateCombo();
        }
        /*public void objEditProject_SourceUpdated(object sender, EventArgs e){
            cmbProject.DataSource = null;
          //  bs.DataSource = UserModel.projects;
          //  cmbProject.DataSource = bs;
          //  cmbProject.DisplayMember = "project_name";
          //  cmbProject.ValueMember = "project_pk";
            //cmbProject.SelectedIndex = UserModel.projects.co;
        }*/
        public void updateCombo() {
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
        private void AddEntry_Load(object sender, EventArgs e)
        {
            
            client.getProjects();
            lblUserName.Text = UserModel.first_name + " " + UserModel.last_name;
            BindingList<project> bl = new BindingList<project>(UserModel.projects);
            //bl.Add(UserModel.projects);
            bs.DataSource = UserModel.projects;
            cmbProject.DataSource = bl;
            cmbProject.DisplayMember = "project_name";
            cmbProject.ValueMember = "project_pk";
            if (UserModel.projects.Count > 0)
            cmbProject.SelectedIndex = 0;
           
            //MessageBox.Show();
        }
        public void hideAddEntry()
        {
            this.Close();
        }
       
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtHours.Text != "" && txtComment.Text != "")
            {
                int project = Convert.ToInt32(cmbProject.SelectedValue);
                string hours = txtHours.Text;
                string body = txtComment.Text;
                bool isEdit = false;
                string date = Convert.ToDateTime(addDate.Text).ToString("yyyy/MM/dd").Replace("/", "-");
                int result = client.addTimeSheetEntry(project, hours, body, date, isEdit);
                if (result > 0)
                {
                    MessageBox.Show("Your entry is successfully added");
                    txtComment.Text = "";
                }
                else if (result == -1)
                {
                    MessageBox.Show("Your entry already exists");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Your entry is not added");
                }
            }
            else
            {
                MessageBox.Show("Please fill the values");
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
