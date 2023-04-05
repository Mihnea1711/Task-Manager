using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Controls;

namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panelPageContent.Controls.Add(new TasksContentControl());
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new TasksContentControl());
        }

        private void buttonBacklog_Click(object sender, EventArgs e)
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new BacklogContentControl());
        }        

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new UsersContentControl());
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new AboutContentControl());
        }
    }
}
