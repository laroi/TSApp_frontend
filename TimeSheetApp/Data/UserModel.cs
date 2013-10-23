using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeSheetApp.Data;


namespace TimeSheetApp
{
	public static class UserModel
	{
        public static string first_name { get; set; }
        public static string last_name { get; set; }
        public static string user_pk { get; set; }
        public static List<project> projects { get; set; }
        public static string time_sheet_entry { get; set; }
        public static string entry_pk { get; set; }
        public static string hours { get; set; }
        public static List<project> all_projects { get; set; }
        public static string server { get; set; }
        public static string time { get; set; }
	}
}
