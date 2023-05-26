using Project.Models;
using Project.Views.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class ProfileContentControl : UserControl
    {
        #region fields
        /// <summary>
        /// The employee data model that needs to be loaded inside the profile content control.
        /// </summary>
        private Employee _employee;
        #endregion

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
                

                (int tasksDone, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetTasksDoneCount(_employee.UUID);
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this.textBoxTasksDone.Text = tasksDone.ToString();

                if (_employee.UUID == ((MainForm)this.TopLevelControl).CurrentEmployee.UUID)
                {
                    this.buttonEdit.Visible = true;
                    this.buttonDelete.Visible = true;
                }

                // continue to add data in the data grid view
                (List<Task> assignedTasks, Exception exception) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetTasksByEmpUUID(this._employee.UUID);
                if(exception != null)
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

        /// <summary>
        /// Callback for the "See More" button inside the data grid view. Loads the task data control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Callback for the edit button. Shows an edit dialog to edit user data if the current logged in user is the same as _employee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Callback for the delete button. it asks for confrmation and then deletes the employee from the db.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // confirmation
            Form dialogBox = new Form();
            dialogBox.Text = "Confirmation";
            dialogBox.ClientSize = new System.Drawing.Size(300, 120);
            dialogBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialogBox.MaximizeBox = false;

            Label label = new System.Windows.Forms.Label();
            label.Text = "Are you sure you want to delete your account?";
            label.Location = new System.Drawing.Point(20, 20);
            label.AutoSize = true;

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Location = new System.Drawing.Point(110, 70);
            okButton.DialogResult = DialogResult.OK;

            dialogBox.Controls.Add(label);
            dialogBox.Controls.Add(okButton);

            dialogBox.ShowDialog();
            //

            if (dialogBox.DialogResult == DialogResult.OK)
            {
                ((MainForm)this.TopLevelControl).Presenter.TaskSRV.UnassignTasksFromEmployee(((MainForm)this.TopLevelControl).CurrentEmployee.UUID);
                ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.DeleteEmployee(((MainForm)this.TopLevelControl).CurrentEmployee.UUID);

                ((MainForm)this.TopLevelControl).Hide();
                LoginPage loginPage = new LoginPage();
                loginPage.ShowDialog();
                ((MainForm)this.TopLevelControl).Close();
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
