using System;
using System.Windows.Forms;

namespace Project.Views.Controls.Dialogs
{
    public partial class HelperDialogControl : UserControl
    {
        public DateTime timeStarted;
        public DateTime timeStopped;

        public HelperDialogControl()
        {
            InitializeComponent();
            timeStarted = new DateTime();
            timeStopped = new DateTime();
        }
        public TimeSpan CalculateTimeSpan(DateTime timeStarted, DateTime timeStopped)
        {
            if (timeStarted == DateTime.MinValue)
            {
                throw new Exception("Time started is not set.");
            }

            if (timeStarted > timeStopped)
            {
                throw new Exception("Time started is greater than time stopped.");
            }

            return timeStopped - timeStarted;
        }

        public void buttonRun_Click(object sender, EventArgs e)
        {
            this.textBoxStopped.Text = string.Empty;
            this.labelTime.Text = string.Empty;
            if (timeStarted == new DateTime())
            {
                timeStarted = DateTime.Now;
            }
            this.textBoxStarted.Text = timeStarted.ToString("HH:mm:ss");
            this.labelTime.Visible = true;
            this.labelTime.Text = "\t\t\tRunning...";
        }

        public void buttonStop_Click(object sender, EventArgs e)
        {
            timeStopped = DateTime.Now;
            this.textBoxStopped.Text = timeStopped.ToString("HH:mm:ss");
            TimeSpan timeSpan = CalculateTimeSpan(timeStarted, timeStopped);
            this.labelTime.Text = $"Time passed: {timeSpan.Hours} hours, {timeSpan.Minutes} minutes, and {timeSpan.Seconds} seconds.";
            this.labelTime.Visible = true;
        }

        public void buttonReset_Click(object sender, EventArgs e)
        {
            timeStarted = DateTime.Now;
            this.textBoxStarted.Text = string.Empty;
            this.textBoxStopped.Text = string.Empty;
            this.labelTime.Visible = false;
        }
    }
}
