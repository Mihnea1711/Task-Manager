using Project.Models;
using Project.Views.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class ProfileContentControl : UserControl
    {
        private Employee _employee;

        /// <summary>
        /// Constructor.
        /// </summary>
        public ProfileContentControl(Employee employee)
        {
            InitializeComponent();
            this._employee = employee;

            this.dataGridViewEmployeeTasks.Columns.Add("taskID", "ID");
            this.dataGridViewEmployeeTasks.Columns.Add("taskTitle", "Title");
            this.dataGridViewEmployeeTasks.Columns.Add("taskDescription", "Description");
            this.dataGridViewEmployeeTasks.Columns.Add("taskStatus", "Status");
            this.dataGridViewEmployeeTasks.Columns.Add("taskProgress", "Progress");
            this.dataGridViewEmployeeTasks.Columns.Add("taskDeadline", "Deadline");
            this.dataGridViewEmployeeTasks.Columns.Add("taskSeeMore", "");
        }

        /// <summary>
        /// Callback for the onload event. Fills the control with the employee data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileContentControl_Load(object sender, EventArgs e)
        {
            try
            {
                if (_employee == null) throw new LogInException("you must log in first");

                this.textBoxEmployeeName.Text = _employee.FirstName + " " + _employee.LastName;
                this.textBoxUsername.Text = _employee.Username;
                this.textBoxEmail.Text = _employee.Email;
                this.textBoxPhone.Text = _employee.Phone;
                this.textBoxTasksDone.Text = _employee.Tasksdone.ToString();

                if (_employee.UUID == ((MainForm)this.TopLevelControl).CurrentEmployee.UUID)
                {
                    this.buttonEdit.Visible = true;
                    this.buttonDelete.Visible = true;
                }

                // continue to add data in the data grid view
                (List<Task> assignedTasks, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetTasksByEmpUUID(this._employee.UUID);
                if(ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                assignedTasks.ForEach(task =>
                {
                    DataGridViewRow taskRow = ((MainForm)this.TopLevelControl).Presenter.makeTaskRow(task);
                    this.dataGridViewEmployeeTasks.Rows.Add(taskRow);
                });
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewEmployeeTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6) // Checking if it's a valid row index and the button column (index 6)
            {
                DataGridViewCell idCell = dataGridViewEmployeeTasks.Rows[e.RowIndex].Cells[0];
                string taskID = idCell.Value.ToString();

                (Task clickedTask, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetTaskByID(int.Parse(taskID));
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                ((MainForm)this.TopLevelControl).LoadTaskContentPanel(clickedTask);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Form editProfileDialog = new Form();
            EditProfileDialogControl dialog = new EditProfileDialogControl(((MainForm)this.TopLevelControl).CurrentEmployee);
            dialog.Dock = DockStyle.Fill;
            editProfileDialog.Height = dialog.Height + 50;
            editProfileDialog.Width = dialog.Width + 20;
            editProfileDialog.Controls.Add(dialog);
            editProfileDialog.ShowDialog();

            if (editProfileDialog.DialogResult == DialogResult.OK)
            {
                string fName = dialog.FirstName;
                string lName = dialog.LastName;
                string email = dialog.Email;
                string phone = dialog.Phone;

                ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.UpdateEmployee(((MainForm)this.TopLevelControl).CurrentEmployee.UUID, fName, lName, email, phone);
                ((MainForm)this.TopLevelControl).SetLabelFullName($"{fName} {lName}");
                (Employee newEmployee, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployeeByUUID(((MainForm)this.TopLevelControl).CurrentEmployee.UUID);
                if(ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                ((MainForm)this.TopLevelControl).CurrentEmployee = newEmployee;
                ((MainForm)this.TopLevelControl).LoadTasksPanel();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ((MainForm)this.TopLevelControl).Presenter.TaskSRV.UnassignTasksFromEmployee(((MainForm)this.TopLevelControl).CurrentEmployee.UUID);
            ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.DeleteEmployee(((MainForm)this.TopLevelControl).CurrentEmployee.UUID);

            ((MainForm)this.TopLevelControl).Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            ((MainForm)this.TopLevelControl).Close();
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
