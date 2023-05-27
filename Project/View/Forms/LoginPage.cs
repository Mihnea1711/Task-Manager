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

using System;
using System.Windows.Forms;
using Persistence;

namespace View
{
    public partial class LoginPage : Form
    {
        #region fields
        /// <summary>
        /// Instance of the employee service that will handle all the employee related operations.
        /// </summary>
        private EmployeeService _employeeService;
        #endregion

        /// <summary>
        /// Constructor. Initializes the employee service.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            this._employeeService = new EmployeeService();
        }

        /// <summary>
        /// Getter for the employee service.
        /// </summary>
        public EmployeeService EmployeeSRV {
           get { return _employeeService; }
        }

        /// <summary>
        /// Callback for the onload event of the form. Adds the login control when the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.panelLogInContent.Controls.Clear();
            this.panelLogInContent.Controls.Add(new LogInControl());
        }

        /// <summary>
        /// Method to change the content panel to the signup control.
        /// </summary>
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

        /// <summary>
        /// Method to change the content panel to the login control.
        /// </summary>
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
