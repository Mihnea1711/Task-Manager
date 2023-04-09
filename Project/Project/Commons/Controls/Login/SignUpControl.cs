using System;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class SignUpControl : UserControl
    {
        public SignUpControl()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

            ((Form)this.TopLevelControl).Close();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.panelLogIn.Controls.Clear();
            LogInControl logInControl = new LogInControl();

            this.panelLogIn.Controls.Add(logInControl);
        }
    }
}
