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
