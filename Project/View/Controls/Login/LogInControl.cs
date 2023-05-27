/**************************************************************************
 *                                                                        *
 *  Description: Task Management Tool                    		          *
 *  Website Mihnea: https://github.com/Mihnea1711               	      *
 *  Website Robert: https://github.com/cioocan               	          *
 *  Copyright:   (c) 2023, Mihnea Bejinaru, Robert Ciocan                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using Persistence;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class LogInControl : UserControl
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public LogInControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Callback for the click event on the "LogIn" button. Checks the existence of the account based on username and password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // get input from user
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                // check input textboxes
                if (username == "" || password == "") { throw new FieldsEmptyException("please fill in the fields"); }

                // check if username/password combo is good
                (Employee employee, Exception ex) = ((LoginPage)this.TopLevelControl).EmployeeSRV.CheckEmployeeLogIn(username, password);
                if(employee == null)
                {
                    throw new Exception("user not found");
                }
                if(ex != null)
                {
                    throw ex;
                }

                // login user if everything is right
                ((LoginPage)this.TopLevelControl).Hide();
                MainForm mainForm = new MainForm(employee);
                mainForm.ShowDialog();
                ((LoginPage)this.TopLevelControl).Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Callback for the click event on the "Create new account" button. Renders the sign up control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        { 
            ((LoginPage)this.TopLevelControl).ChangeToSignUp();
        }
    }
}
