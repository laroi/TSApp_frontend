using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeSheetApp
{
    public partial class EditServer : Form
    {
        public EditServer()
        {
            InitializeComponent();
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "HH:mm:ss"; // Only use hours and minutes
            dateTime.ShowUpDown = true;
            string[] times = UserModel.time.Split(',');
           // DateTime.ParseExact("12/02/12 10:56:09", "yy/MM/dd HH:mm:ss");
            var dt = DateTime.ParseExact(times[0].ToString() + ":" + times[1].ToString() + ":" + times[2].ToString(), "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            dateTime.Value = dt;
            txtServer.Text = UserModel.server;
        }
    }
}
