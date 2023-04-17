using System;
using System.Windows.Forms;
using Project.Controls;
using Project.Models;

namespace Project
{
    public partial class MainForm : Form
    {
        private Employee currrentEmployee;

        public Employee CurrentEmployee { get { return currrentEmployee; } }

        public MainForm(Employee employee)
        {
            InitializeComponent();
            this.currrentEmployee = employee;
            this.labelUsername.Text = employee.Username;
        }

        public void LoadTasksPanel()
        {
            this.panelPageContent.Controls.Clear();
            TasksContentControl tasksContentControl = new TasksContentControl();
            this.panelPageContent.Controls.Add(tasksContentControl);
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

        public void LoadSubtaskContentPanel()
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new SubtaskContentControl());
        }

        public void LoadProfilePage()
        {
            this.panelPageContent.Controls.Clear();
            ProfileContentControl profileContentControl = new ProfileContentControl();
            profileContentControl.Dock = DockStyle.Fill;
            this.panelPageContent.Controls.Add(profileContentControl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoadTasksPanel();
            LoadProfilePage();
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
