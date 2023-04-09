using Project.Controls;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
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

        private void panelLogInContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
