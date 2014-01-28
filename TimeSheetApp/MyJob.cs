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
        EditProject obgEditForm = new EditProject();
        APIClient objclient = new APIClient();
        public void Execute(IJobExecutionContext context)
        {
            if (!objclient.getTimeSheetEntry(DateTime.Today.ToString("yyyy-MM-dd"), null))
            {

                if (formInstance.Visible)
                {
                    formInstance.Focus();
                }
                else
                {
                    if (UserModel.projects != null && UserModel.projects.Count > 0)
                    {
                        formInstance.ShowDialog();
                    }
                    else {
                        obgEditForm.ShowDialog();
                    }
                }
            }
           // Console.WriteLine("My Job is working now {0}", System.DateTime.Now.ToString("r"));
            
        }
    }
}
