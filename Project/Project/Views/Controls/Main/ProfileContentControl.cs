using Project.Models;
using System;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class ProfileContentControl : UserControl
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public ProfileContentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Callback for the onload event. Fills the control with the employee data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileContentControl_Load(object sender, EventArgs e)
        {
            Employee employee = ((MainForm)this.TopLevelControl).CurrentEmployee;

            try
            {
                if (employee == null) throw new LogInException("you must log in first");

                this.textBoxEmployeeName.Text = employee.FirstName + " " + employee.LastName;
                this.textBoxUsername.Text = employee.Username;
                this.textBoxEmail.Text = employee.Email;
                this.textBoxPhone.Text = employee.Phone;
                this.textBoxTasksDone.Text = employee.Tasksdone.ToString();

                // continue to add data in the data grid view
                // TODO()
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    class LogInException : Exception
    {
        public LogInException(string message)
            : base(message)
        {
        }
    }
}
