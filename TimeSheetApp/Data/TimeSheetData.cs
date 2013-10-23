using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSheetApp.Data
{

    public class TimeSheetData
    {
        public int result { get; set; }
        public getTimeSheet getTimeSheet { get; set; }
    }
    public class getTimeSheet
    {
        public int entry_pk { get; set; }
        public string body { get; set; }
        public string hours { get; set; }
    }

   
  
}
