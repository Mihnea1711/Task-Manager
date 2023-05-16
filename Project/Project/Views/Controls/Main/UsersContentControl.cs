using Project.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class UsersContentControl : UserControl
    {
        private List<Employee> _employees = new List<Employee>();
        public UsersContentControl()
        {
            InitializeComponent();

            this.dataGridViewEmployees.Columns.Add("username", "Username");
            this.dataGridViewEmployees.Columns.Add("fullname", "FullName");
            this.dataGridViewEmployees.Columns.Add("email", "Email");
            this.dataGridViewEmployees.Columns.Add("phonenr", "Phone Number");
            this.dataGridViewEmployees.Columns.Add("employeeSeeMore", "");
        }

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

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4) // Checking if it's a valid row index and the button column (index 6)
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
