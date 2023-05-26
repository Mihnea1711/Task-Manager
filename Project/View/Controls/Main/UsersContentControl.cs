using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Persistence;

namespace View
{
    public partial class UsersContentControl : UserControl
    {
        #region fields
        /// <summary>
        /// The employee list.
        /// </summary>
        private List<Employee> _employees = new List<Employee>();
        #endregion

        /// <summary>
        /// Default constructor. 
        /// </summary>
        public UsersContentControl()
        {
            InitializeComponent();

            this.dataGridViewEmployees.Columns.Add("username", "Username");
            this.dataGridViewEmployees.Columns.Add("fullname", "FullName");
            this.dataGridViewEmployees.Columns.Add("email", "Email");
            this.dataGridViewEmployees.Columns.Add("phonenr", "Phone Number");
            this.dataGridViewEmployees.Columns.Add("employeeSeeMore", "");
        }

        /// <summary>
        /// Constructor with the list of employees as argument. Used when searching in the search-bar. The page loads only matched employees.
        /// </summary>
        /// <param name="employees"></param>
        public UsersContentControl(List<Employee> employees)
        {
            InitializeComponent();

            this.dataGridViewEmployees.Columns.Add("username", "Username");
            this.dataGridViewEmployees.Columns.Add("fullname", "FullName");
            this.dataGridViewEmployees.Columns.Add("email", "Email");
            this.dataGridViewEmployees.Columns.Add("phonenr", "Phone Number");
            this.dataGridViewEmployees.Columns.Add("tasks-done", "Tasks Done");
            this.dataGridViewEmployees.Columns.Add("employeeSeeMore", "");

            this._employees = employees;
        }

        /// <summary>
        /// When loading control, if there are no employees in the list, retrieve all the employees from the database and render the list in the data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersContentControl_Load(object sender, EventArgs e)
        {
            if (this._employees.Count == 0)
            {
                (List<Employee> employees, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployees();
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this._employees = employees;
            }

            _employees.ForEach(employee =>
            {
                DataGridViewRow employeeRow = ((MainForm)this.TopLevelControl).Presenter.makeEmployeeRow(employee);
                this.dataGridViewEmployees.Rows.Add(employeeRow);
            });
        }

        /// <summary>
        /// Callback for the "See More" button inside the data grid view. Loads the employee data profile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checking if it's a valid row index and the button column (index 4)
            if (e.RowIndex >= 0 && e.ColumnIndex == 4) 
            {
                DataGridViewCell usernameCell = dataGridViewEmployees.Rows[e.RowIndex].Cells[0];
                string employeeUsername = usernameCell.Value.ToString();

                (Employee clickedEmployee, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployeeByUsername(employeeUsername);
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                ((MainForm)this.TopLevelControl).LoadProfilePage(clickedEmployee);
            }
        }

        /// <summary>
        /// Callback for the search bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchKey = this.textBoxSearchBar.Text;

            (List<Employee> matchingEmployees, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.SearchEmployeesByName(searchKey);
            if(ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ((MainForm)this.TopLevelControl).LoadUsersPanel(matchingEmployees);
        }
    }
}
