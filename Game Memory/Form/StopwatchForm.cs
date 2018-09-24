using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Memory
{
    class StopwatchForm
    {
        private DateTime dateTime;
        public static TimeSpan timeSpan;
        private System.Threading.Timer timer;

        public void start(int timeSeconds)
        {
            setTime(timeSeconds);
            if(timer != null)
                timer.Dispose();
            timer = new System.Threading.Timer(UpdateTime, 10, 1, 1000);
        }

        public void setTime(int timeseconds)
        {
            dateTime = DateTime.Now.AddSeconds(timeseconds);
        }

        delegate void timestopwatch(string seconds);

        private void timeThreading(string seconds)
        {
            if (MainForm.form.InvokeRequired)
            {
                timestopwatch callback = timeThreading;
                MainForm.form.Invoke(callback, seconds);
            }
            else
            {
                MainForm.form.labelTime.Text = seconds;
            }
        }

        private void UpdateTime(object args)
        {
            timeSpan = DateTime.Now.Subtract(dateTime);
            MainForm.seconds = timeSpan.TotalSeconds * -1;

            timeThreading(MainForm.seconds.ToString("0."));
            if (MainForm.seconds <= 0)
                timer.Dispose();
        }

        public void end()
        {
            timer.Dispose();
        }
    }
}
