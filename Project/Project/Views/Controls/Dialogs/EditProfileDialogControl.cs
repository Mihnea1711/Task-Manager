using Project.Models;
using System.Windows.Forms;

namespace Project.Views.Controls.Dialogs
{
    public partial class EditProfileDialogControl : UserControl
    {
        private Employee _currentEmployee;
        public EditProfileDialogControl(Employee employee)
        {
            InitializeComponent();
            this._currentEmployee = employee;
        }

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

        private void EditProfileDialogControl_Load(object sender, System.EventArgs e)
        {
            this.textBoxFName.Text = _currentEmployee.FirstName;
            this.textBoxLName.Text = _currentEmployee.LastName;
            this.textBoxEmail.Text = _currentEmployee.Email;
            this.textBoxPhone.Text = _currentEmployee.Phone;
        }
    }
}
