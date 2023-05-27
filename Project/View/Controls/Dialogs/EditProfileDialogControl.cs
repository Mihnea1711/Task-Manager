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

using System.Windows.Forms;
using Persistence;

namespace View
{
    public partial class EditProfileDialogControl : UserControl
    {
        #region fields
        /// <summary>
        /// Current employee that is displayed in the edit control.
        /// </summary>
        private Employee _currentEmployee;
        #endregion

        #region getters
        public string FirstName
        {
            get
            {
                return this.textBoxFName.Text;
            }
        }

        public string LastName
        {
            get
            {
                return this.textBoxLName.Text;
            }
        }

        public string Email
        {
            get
            {
                return this.textBoxEmail.Text;
            }
        }

        public string Phone
        {
            get
            {
                return this.textBoxPhone.Text;
            }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="employee"></param>
        public EditProfileDialogControl(Employee employee)
        {
            InitializeComponent();
            this._currentEmployee = employee;
        }

        /// <summary>
        /// When the page loads, it displays the employee data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProfileDialogControl_Load(object sender, System.EventArgs e)
        {
            this.textBoxFName.Text = _currentEmployee.FirstName;
            this.textBoxLName.Text = _currentEmployee.LastName;
            this.textBoxEmail.Text = _currentEmployee.Email;
            this.textBoxPhone.Text = _currentEmployee.Phone;
        }
    }
}
