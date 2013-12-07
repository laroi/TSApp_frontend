using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;
using TimeSheetApp.Data;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Security.Principal;


namespace TimeSheetApp
{
    public class APIClient : Form
    {
        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            } 
            return sMacAddress;
        }

        public APIClient() {
            LoadJson();
        }
        public string baseUrl;// = http://localhost/projects/timesheetapp/index.php/";//user/login
        //public string time;
        //string mac_id = "{mac:'testmac'}";
       
        WebClient syncClient = new WebClient();

        public bool Join(string first_name, string last_name) {
            string mac_id = GetMACAddress();
            string url = baseUrl + "user/join";
            string parm = "first_name=" + first_name + "&last_name=" + last_name + "&mac=" + mac_id;
             syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            var content = syncClient.UploadString(url, parm);
            var o = JsonConvert.DeserializeObject<Result>(content);
            if (o.value != null)
            {
                getUser();
                return true;
            }
            return false;
        }
        public void getUser()
        {
            
                if (baseUrl != "" && baseUrl != null)
                {
                    string mac_id = GetMACAddress();
                    string url = baseUrl + "user/login";
                    string parm = "mac=" + mac_id;
                    // Specialized.NameValueCollection parm = New Specialized.NameValueCollection();
                    syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    var content = syncClient.UploadString(url, parm);
                    var o = JsonConvert.DeserializeObject<UserData>(content);
                    if (o.value != null)
                    {
                        UserModel.first_name = o.value.first_name;
                        UserModel.last_name = o.value.last_name;
                        UserModel.user_pk = o.value.user_pk;
                    }
                }
           
        }

        public List<project> getProjects()
        {
            try
            {
                if (baseUrl != "" && baseUrl != null)
                {
                    string url = baseUrl + "user/GetProjects";
                    string parm = "user_pk=" + UserModel.user_pk.ToString();
                    syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    var content = syncClient.UploadString(url, parm);
                    var o = JsonConvert.DeserializeObject<ProjectData>(content);
                    UserModel.projects = new List<project>();
                    if (UserModel.projects != null && UserModel.projects.Count != 0)
                    {
                        foreach (Valuee project in o.valuee)
                        {
                            project _project = new project();
                            _project.project_name = project.name;
                            _project.project_pk = project.project_pk;
                            UserModel.projects.Add(_project);

                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error retriving data");
                Application.Exit();
            }
            return UserModel.projects;
        }

        /*public updateProject(){
        
        }*/
        public int addTimeSheetEntry(int project_fk,string hours, string body,string date, bool isEdit) {
            if (baseUrl != "" && baseUrl != null)
            {
                string url = baseUrl + "user/AddTimeSheetEntry";
                string parm = "project_fk=" + project_fk + "&" + "hours=" + hours + "&body=" + body + "&date=" + date + "&user_pk=" + UserModel.user_pk.ToString() + "&isEdit=" + isEdit;
                syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                var content = syncClient.UploadString(url, parm);
                var o = JsonConvert.DeserializeObject<List<int>>(content);

                if (o[0] > 0)
                {
                    return 1;
                }
                else if (o[0] == -1)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
            return 0;
            
        }

        public bool getTimeSheetEntry(string date, string project) {
            if (baseUrl != "" && baseUrl != null)
            {
                if (project != "")
                {
                    UserModel.time_sheet_entry = null;
                    UserModel.entry_pk = null;
                    UserModel.hours = null;
                }
                string url = baseUrl + "user/getTimeSheetEntry";
                string parm = "";
                parm += "date=" + date;
                if (project != "")
                {
                    parm += "&" + "project=" + project;
                }
                parm += "&user_pk=" + UserModel.user_pk;
                syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                var content = syncClient.UploadString(url, parm);
                var o = JsonConvert.DeserializeObject<TimeSheetData>(content);
                if (o.getTimeSheet != null && o.getTimeSheet.body != null && o.getTimeSheet.entry_pk != 0)
                {

                    UserModel.time_sheet_entry = o.getTimeSheet.body;
                    UserModel.entry_pk = o.getTimeSheet.entry_pk.ToString();
                    UserModel.hours = o.getTimeSheet.hours;
                    return true;
                }
            }
                return false;
            
        }

        public void getAllProjects() {
            try
            {
                if (baseUrl != "" && baseUrl != null)
                {

                string url = baseUrl + "user/GetAllProjects";

                syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                var content = syncClient.DownloadString(url);
                var o = JsonConvert.DeserializeObject<ProjectData>(content);
                UserModel.all_projects = new List<project>();

                foreach (Valuee project in o.valuee)
                {
                    project _project = new project();
                    _project.project_name = project.name;
                    _project.project_pk = project.project_pk;
                    UserModel.all_projects.Add(_project);
                }
            }
        }
            catch (Exception e)
            {
                MessageBox.Show("Error retriving data");
                Application.Exit();
            }
        }

        public void updateMyProjects(List<project> added, List<project> deleted)
        {
            try
            {
                if (baseUrl != "" && baseUrl != null)
                {
                    string url = baseUrl + "user/updateMyProjects";
                    string added_project = "";
                    for (int i = 0; i < added.Count; i++)
                    {
                        added_project += added[i].project_pk.ToString();
                        if (i != added.Count - 1)
                        {
                            added_project += ",";
                        }
                    }
                    string deleted_project = "";
                    for (int i = 0; i < deleted.Count; i++)
                    {
                        deleted_project += deleted[i].project_pk.ToString();
                        if (i != deleted.Count - 1)
                        {
                            deleted_project += ",";
                        }
                    }
                    string parm = "user_pk=" + UserModel.user_pk + "&added=" + added_project + "&deleted=" + deleted_project;
                    syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                    var content = syncClient.UploadString(url, parm);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error retriving data");
                Application.Exit();
            }
        }

        public int EditTimeSheetEntry(string project_fk, string hours, string body, string entry_pk)
        {
            if (baseUrl != "" && baseUrl != null)
            {
                string url = baseUrl + "user/AddTimeSheetEntry";
                string parm = "entry_pk=" + entry_pk + "&project_fk=" + project_fk + "&" + "hours=" + hours + "&body=" + body + "&" + "user_pk=" + UserModel.user_pk.ToString() + "&isEdit=true";
                syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                var content = syncClient.UploadString(url, parm);
                var o = JsonConvert.DeserializeObject<List<int>>(content);
                if (o[0] > 0)
                {
                    return 1;
                }
                else if (o[0] == -1)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
            return 0;


        }

        public string getReport(string date, string project_pk) 
        {
            if (baseUrl != "" && baseUrl != null)
            {
                string url = baseUrl + "user/CreatePDF";
                string parm = "user_pk=" + UserModel.user_pk + "&project_pk=" + project_pk + "&date=" + date;
                syncClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                var content = syncClient.UploadString(url, parm);
                var o = JsonConvert.DeserializeObject<Result>(content);
                return o.value;
            }
            return "";
        }

        public void LoadJson()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/TimeSheetApp";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if(File.Exists(path + "/settings.json"))
            {
                DirectorySecurity sec = Directory.GetAccessControl(path + "./settings.json");
                // Using this instead of the "Everyone" string means we work on non-English systems.
                SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
                sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.Modify | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
                Directory.SetAccessControl(path , sec);
            using (StreamReader r = new StreamReader(path +"./settings.json"))
            {
                try
                {
                    string json = r.ReadToEnd();
                    var jsonobj = JsonConvert.DeserializeObject<settingsItem>(json);
                    if (jsonobj != null)
                    {
                        UserModel.server = jsonobj.settings.server_url;
                        baseUrl = UserModel.server;
                        UserModel.time = jsonobj.settings.time;
                    }
                    else 
                    {
                        MessageBox.Show("Please edit server settings");
                        return;
                    }
                }
                catch (Exception e) {
                    MessageBox.Show("An Error reading the settings file");
                    Application.Exit();
                }
            }
        }
        }
    }
}