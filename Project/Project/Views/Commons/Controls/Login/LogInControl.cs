using System;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class LogInControl : UserControl
    {
        public LogInControl()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ((LoginPage)this.TopLevelControl).Hide();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            ((LoginPage)this.TopLevelControl).Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        { 
            ((LoginPage)this.TopLevelControl).ChangeToSignUp();
        }
    }
}
