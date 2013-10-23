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
    public class TextArgss : EventArgs
    {
        private string szMessage;
        public TextArgss(string TextMessage)
        {
            szMessage = TextMessage;
        }
        public string Message
        {
            get { return szMessage; }
            set { szMessage = value; }
        }

    }
    
    public partial class Register : Form
    {
        APIClient objApiClient = new APIClient();
        public static event EventHandler<TextArgs> Complete;
        //TaskTrayApp objTaskTrayApp = new TaskTrayApp();
        public Register()
        {
            InitializeComponent();
        }

        private static void RaiseComplete(string p)
        {
            EventHandler<TextArgs> handler = Complete;
            if (handler != null)
            {
                handler(null, new TextArgs(p));
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (objApiClient.Join(txtFirstName.Text, txtLastName.Text)) { 
                MessageBox.Show("Registration Complete");
                this.Close();
                RaiseComplete("Registration Complete");
                //objTaskTrayApp.MinimizeToTray();
            }
            else 
            {
                MessageBox.Show("Registration Incomplete");
            }
        }
    }
}
