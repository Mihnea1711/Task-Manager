using Project.Business.Services;
using Project.Controls;
using Project.Persistence.Interfaces;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginPage : Form
    {
        private EmployeeService employeeService;
        public LoginPage()
        {
            InitializeComponent();
            this.employeeService = new EmployeeService();
        }

        public EmployeeService EmployeeSRV {
           get { return employeeService; }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            this.Close();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.panelLogInContent.Controls.Clear();
            this.panelLogInContent.Controls.Add(new LogInControl());
        }

        public void ChangeToSignUp()
        {
            this.panelLogInContent.Controls.Clear();
            SignUpControl signUpControl = new SignUpControl();
            signUpControl.Dock = DockStyle.Fill;

            this.Width = signUpControl.Width + 30;
            this.panelLogInContent.Width = signUpControl.Width + 30;

            this.Height = signUpControl.Height + 30;
            this.panelLogInContent.Height = signUpControl.Height + 30;

            this.panelLogInContent.Controls.Add(signUpControl);
        }

        public void ChangeToLogIn()
        {
            this.panelLogInContent.Controls.Clear();
            LogInControl logInControl = new LogInControl();
            logInControl.Dock = DockStyle.Top;

            this.Width = logInControl.Width + 20;
            this.panelLogInContent.Width = logInControl.Width + 20;

            this.Height = logInControl.Height;
            this.panelLogInContent.Height = logInControl.Height;

            this.panelLogInContent.Controls.Add(logInControl);
        }
    }
}
