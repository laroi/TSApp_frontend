using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSheetApp.Data
{
    public class Settings
    {
        public string server_url { get; set; }
        public string time { get; set; }
    }

    public class settingsItem
    {
        public Settings settings { get; set; }
    }
}
