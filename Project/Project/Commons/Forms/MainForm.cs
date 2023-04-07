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

        public void LoadTasksPanel()
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new TasksContentControl());
        }

        public void LoadBacklogPanel()
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new BacklogContentControl());
        }

        public void LoadUsersPanel()
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new UsersContentControl());
        }

        public void LoadAboutPanel()
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new AboutContentControl());
        }

        public void LoadTaskContentPanel()
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new TaskContentControl());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTasksPanel();
        }

        private void buttonTasks_Click(object sender, EventArgs e)
        {
            LoadTasksPanel();
        }

        private void buttonBacklog_Click(object sender, EventArgs e)
        {
            LoadBacklogPanel();
        }        

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            LoadUsersPanel();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            LoadAboutPanel();
        }
    }
}
