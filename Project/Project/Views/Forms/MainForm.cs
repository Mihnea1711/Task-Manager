using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project.Controls;
using Project.Models;
using Project.Presenters;

namespace Project
{
    public partial class MainForm : Form
    {
        #region
        /// <summary>
        /// Current logged in employee.
        /// </summary>
        private Employee _currentEmployee;

        /// <summary>
        /// The application presenter. Holds references to the services and controls how the data is rendered in the data grid views.
        /// </summary>
        private Presenter _presenter;
        #endregion

        #region getters|setters
        public Employee CurrentEmployee
        {
            get { return _currentEmployee; }
            set
            {
                this._currentEmployee = value;
            }
        }

        public Presenter Presenter
        {
            get
            {
                return this._presenter;
            }
        }

        public void SetLabelFullName(string fullname)
        {
            this.labelName.Text = fullname;
        }
        #endregion

        /// <summary>
        /// Constructor. Initializes the logged in employee.
        /// </summary>
        /// <param name="employee"></param>
        public MainForm(Employee employee)
        {
            InitializeComponent();
            this._currentEmployee = employee;
            this.labelUsername.Text = employee.Username;
            this.labelName.Text = employee.FullName;

            this._presenter = new Presenter();
        }

        /// <summary>
        /// When we load the control, first display the tasks page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTasksPanel();
        }

        #region private navigation callbacks
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

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            LoadProfilePage(_currentEmployee);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            ((MainForm)this.TopLevelControl).Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            ((MainForm)this.TopLevelControl).Close();
        }
        #endregion

        #region public navigation methods

        public void LoadTasksPanel()
        {
            this.panelPageContent.Controls.Clear();

            TasksContentControl tasksContentControl = new TasksContentControl();

            this.panelPageContent.Controls.Add(tasksContentControl);
        }

        public void LoadTasksPanel(List<Task> tasks)
        {
            this.panelPageContent.Controls.Clear();

            TasksContentControl tasksContentControl = new TasksContentControl(tasks);

            this.panelPageContent.Controls.Add(tasksContentControl);
        }

        public void LoadTaskPanel(Task task)
        {
            this.panelPageContent.Controls.Clear();

            TaskContentControl taskContentControl = new TaskContentControl(task);

            this.panelPageContent.Controls.Add(taskContentControl);
        }

        public void LoadSubtaskPanel(Subtask subtask)
        {
            this.panelPageContent.Controls.Clear();

            SubtaskContentControl subtaskContentControl = new SubtaskContentControl(subtask);

            this.panelPageContent.Controls.Add(subtaskContentControl);
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

        public void LoadUsersPanel(List<Employee> employees)
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new UsersContentControl(employees));
        }

        public void LoadAboutPanel()
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new AboutContentControl());
        }

        public void LoadTaskContentPanel(Task task)
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new TaskContentControl(task));
        }

        public void LoadSubtaskContentPanel(Subtask subtask)
        {
            this.panelPageContent.Controls.Clear();
            this.panelPageContent.Controls.Add(new SubtaskContentControl(subtask));
        }

        public void LoadProfilePage(Employee employee)
        {
            this.panelPageContent.Controls.Clear();
            ProfileContentControl profileContentControl = new ProfileContentControl(employee);
            profileContentControl.Dock = DockStyle.Fill;
            this.panelPageContent.Controls.Add(profileContentControl);
        }
        #endregion
    }
}
