using System;
using System.Windows.Forms;
using Project.Business.Interfaces;
using Project.Business.Services;
using Project.Controls;
using Project.Models;
using Project.Presenters;
using Project.Presenters.Interfaces;

namespace Project
{
    public partial class MainForm : Form
    {
        private Employee currrentEmployee;
        private Presenter presenter;

        public Employee CurrentEmployee { get { return currrentEmployee; } }

        public Presenter Presenter
        {
            get
            {
                return this.presenter;
            }
        }

        public MainForm(Employee employee)
        {
            InitializeComponent();
            this.currrentEmployee = employee;
            this.labelUsername.Text = employee.Username;

            this.presenter = new Presenter();
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
