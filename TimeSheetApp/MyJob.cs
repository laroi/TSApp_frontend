using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace TimeSheetApp
{
    public class MyJob : IJob
    {
        AddEntry formInstance = new AddEntry();
        APIClient objclient = new APIClient();
        public void Execute(IJobExecutionContext context)
        {
            if (!objclient.getTimeSheetEntry(DateTime.Today.ToString("yyyy-MM-dd"), null))
            {
                
                if (formInstance.Visible)
                    formInstance.Focus();
                else
                    formInstance.ShowDialog();
            }
           // Console.WriteLine("My Job is working now {0}", System.DateTime.Now.ToString("r"));
            
        }
    }
}
