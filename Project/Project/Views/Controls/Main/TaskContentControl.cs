using System;
using System.Windows.Forms;
using Project.Models;

namespace Project.Controls
{
    public partial class TaskContentControl : UserControl
    {
        private Task _currentTask;
        public TaskContentControl(Task task)
        {
            InitializeComponent();
            this._currentTask = task;
        }

        private void TaskContentControl_Load(object sender, EventArgs e)
        {
            this.labelName.Text = this._currentTask.Name;
            this.labelDeadline.Text = $"Deadline: {this._currentTask.Deadline.ToString("dd/MM/yyyy")}";
            this.progressBarProgress.Value = this._currentTask.Progress;
            this.textBoxDescription.Text = this._currentTask.Description;

            (Employee assignedEmployee, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployeeByUUID(this._currentTask.EmployeeUUID);
            if(ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.labelAssignedEmployee.Text = $"ASsigned To {assignedEmployee.FirstName} {assignedEmployee.LastName}";
        }

        private void buttonAddSubtask_Click(object sender, EventArgs e)
        {

        }

        private void buttonToSubtask_Click(object sender, EventArgs e)
        {
            ((MainForm)this.TopLevelControl).LoadSubtaskContentPanel();
        }
    }
}
