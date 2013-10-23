using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl;

namespace TimeSheetApp
{

    public class TaskTrayApp : ApplicationContext
    {
        private Register _register;
        NotifyIcon notifyIcon = new NotifyIcon();
        Form1 formInstance = new Form1();
        Register objRegister = new Register();
        APIClient objApiClient = new APIClient();
        public TaskTrayApp()
        {
            _register = new Register();
            Register.Complete += new EventHandler<TextArgs>(completeRegistration);
            RunTaskApp();
        }
        public void completeRegistration(object sender, TextArgs e) 
        {
            RunTaskApp();
        }
        void ShowMessage(object sender, EventArgs e)
        {
            // Only show the message if the settings say we can.
           // if (TaskTrayApplication.Properties.Settings.Default.ShowMessage)
            if (formInstance.Visible)
                formInstance.Focus();
            else
                formInstance.ShowDialog();
        }
        void Exit(object sender, EventArgs e)
        {
   
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            notifyIcon.Visible = false;

            Application.Exit();
        }
        void ShowConfig(object sender, EventArgs e)
        {
            // If we are already showing the window meerly focus it.
            if (formInstance.Visible)
                formInstance.Focus();
            else
                formInstance.ShowDialog();
        }
        void RunTaskApp()
        {
            objApiClient.getUser();
            if (UserModel.user_pk != null)
            {
                string[] times = UserModel.time.Split(',');
                MenuItem configMenuItem = new MenuItem("Launch App", new EventHandler(ShowConfig));
                MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));
                notifyIcon.Icon = TimeSheetApp.Properties.Resources.Icon1;
                notifyIcon.DoubleClick += new EventHandler(ShowMessage);
                notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem });
                notifyIcon.Visible = true;
                ISchedulerFactory sf = new StdSchedulerFactory();
                IScheduler sched = sf.GetScheduler();
                DateTimeOffset runTime = DateBuilder.EvenMinuteDate(DateTimeOffset.UtcNow);
                IJobDetail job = JobBuilder.Create<MyJob>()
                    .WithIdentity("job1", "group1")
                    .Build();
                var trigger = TriggerBuilder.Create()
                                            .StartAt(DateBuilder.DateOf(Convert.ToInt32(times[0]), Convert.ToInt32(times[1]), Convert.ToInt32(times[2])))
                                            .WithSimpleSchedule(x => x
                                            .WithInterval(TimeSpan.FromMilliseconds(0))
                                            .WithRepeatCount(0))
                                            .ForJob(job)
                                            .Build();
                sched.ScheduleJob(job, trigger);
                sched.Start();
            }
            else
            {
                objRegister.Show();
            }
        }
    }
}
