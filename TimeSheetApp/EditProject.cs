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
    
    public class TextArgs : EventArgs
    {
        private string szMessage;
        public TextArgs(string TextMessage)
        {
            szMessage = TextMessage;
        }
        public string Message
        {
            get { return szMessage; }
            set { szMessage = value; }
        }

    }
    public partial class EditProject : Form
    {
        private List<project> tempProjectList;
        //AddEntry objAddEntry = new AddEntry();
        Form1 objFrm = new Form1();
        APIClient client = new APIClient();
        //public delegate void ComboBoxUpdateHandler(object sender, EventArgs e);
        public static event EventHandler<TextArgs> Feedback;
        
        private static void RaiseFeedback(string p)
        {
            EventHandler<TextArgs> handler = Feedback;
            if (handler != null)
            {
                handler(null, new TextArgs(p));
            }
        }
        
        public EditProject()
        {
            if (UserModel.projects!= null && UserModel.projects.Count != 0)
            {
                tempProjectList = new List<project>(UserModel.projects);
            }
            InitializeComponent();
           
        }
        
        private void btnAddToMyProjects_Click(object sender, EventArgs e)
        {
            //tempProjectList = UserModel.projects;
            string to = ((project)listAllProjects.SelectedItem).project_name;
            int to_pk =  ((project)listAllProjects.SelectedItem).project_pk;
            bool isProjectExists = true;
            for(int i =0 ; i < listMyProjects.Items.Count;i++)
            //foreach (project prjct in listMyProjects.Items)
            {
                project prjct = (project)listMyProjects.Items[i];
                if (prjct.project_name == to)
                {
                    isProjectExists = false;
                    MessageBox.Show("Project already exists");
                }
            }

            if (isProjectExists)
            {
                project prjct = new project();
                prjct.project_pk=to_pk;
                prjct.project_name = to;
                UserModel.projects.Add(prjct);
                listMyProjects.DataSource = null;
                listMyProjects.DataSource = new BindingSource(UserModel.projects, null);
                listMyProjects.DisplayMember = "project_name";
                listMyProjects.ValueMember = "project_pk";
                if (listMyProjects.Items.Count > 0)
                {
                    btnRemoveFromMyProjects.Enabled = true;
                }
            }
        }

        private void btnRemoveFromMyProjects_Click(object sender, EventArgs e)
        {
            if (listMyProjects.Items.Count != 0)
            {
                int project_pk = ((project)listMyProjects.SelectedItem).project_pk;
                for (int i = 0; i < UserModel.projects.Count; i++ )
                    //foreach (project prjectpk in UserModel.projects.ToList())
                    {
                        project prjectpk = UserModel.projects[i];
                        if (prjectpk.project_pk == project_pk)
                        {

                            UserModel.projects.Remove(prjectpk);
                        }
                    }
                listMyProjects.DataSource = null;
                listMyProjects.DataSource = new BindingSource(UserModel.projects, null);
                listMyProjects.DisplayMember = "project_name";
                listMyProjects.ValueMember = "project_pk";
                if (listMyProjects.Items.Count == 0) {
                    btnRemoveFromMyProjects.Enabled = false;
                }
            }
            
            //Console.Write("test");
            //listMyProjects.Items.RemoveAt(listMyProjects.SelectedIndex);
        }

        private void EditProject_Load(object sender, EventArgs e)
        {
           
            client.getAllProjects();
            listAllProjects.DataSource = new BindingSource(UserModel.all_projects, null);
            listAllProjects.DisplayMember = "project_name";
            listAllProjects.ValueMember = "project_pk";

            listMyProjects.DataSource = new BindingSource(UserModel.projects, null);
            listMyProjects.DisplayMember = "project_name";
            listMyProjects.ValueMember = "project_pk";
            
        }

        private void EditProject_onFormClosed(object sender, EventArgs e)
        {
           // Console.Write(e);
           // objAddEntry.Show();
           // objAddEntry.MdiParent = this.MdiParent;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           // objAddEntry.Show();
           // objAddEntry.MdiParent = this.MdiParent;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var added = new List<project>();
            var deleted = new List<project>(); 
            if (tempProjectList!=null && tempProjectList.Count > 0)
            {
                added = UserModel.projects.Except(tempProjectList).ToList();
                deleted = tempProjectList.Except(UserModel.projects).ToList();
            }
            else 
            {
                added = UserModel.projects;
            }
            
            if (added.Count != 0 || deleted.Count != 0) 
            {
                client.updateMyProjects(added, deleted);
            }
          
            RaiseFeedback("combobox updated");
          
                this.Close();
        }

        

       
    }
}
