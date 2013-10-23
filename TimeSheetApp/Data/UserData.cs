using System;
using System.Collections.Generic;
using System.Text;

namespace TimeSheetApp
{
    public class UserData
    {
        public int result { get; set; }
        public Value value { get; set; }
    }
    public class Value
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string user_pk {get; set;}
    }

}
