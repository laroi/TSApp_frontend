using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSheetApp
{
    public class Valuee
    {
        public int project_pk { get; set; }
        public string name { get; set; }
    }

    public class ProjectData
    {
        public int result { get; set; }
        public List<Valuee> valuee { get; set; }
    }
  
}
