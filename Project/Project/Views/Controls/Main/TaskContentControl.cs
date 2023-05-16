using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project.Models;
using Project.Persistence.Interfaces;

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
            this.labelDeadline.Text = $"Deadline: {this._currentTask.Deadline:dd/MM/yyyy}";
            this.progressBarProgress.Value = this._currentTask.Progress;
            this.textBoxDescription.Text = this._currentTask.Description;

            if (_currentTask.EmployeeUUID != "")
            {
                (Employee assignedEmployee, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployeeByUUID(this._currentTask.EmployeeUUID);
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                if (assignedEmployee != null)
                {
                    this.labelAssignedEmployee.Text = $"Assigned To {assignedEmployee.FirstName} {assignedEmployee.LastName}";
                    this.buttonUnassign.Visible = true;
                }
            }
            else
            {
                this.labelAssignedEmployee.Text = "Unassigned";
                this.buttonAssignToMe.Visible = true;
            }
            (IList<Subtask> subtasks, Exception exception) = ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.GetSubtasksByTask(this._currentTask.ID);
            this.dataGridViewSubtasks.DataSource = subtasks;
        
        }

        private void buttonAddSubtask_Click(object sender, EventArgs e)
        {

        }

        private void buttonToSubtask_Click(object sender, EventArgs e)
        {
            ((MainForm)this.TopLevelControl).LoadSubtaskContentPanel();
        }

        private void buttonAssignToMe_Click(object sender, EventArgs e)
        {
            Exception ex = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.AssignTaskToEmployee(this._currentTask.ID, ((MainForm)this.TopLevelControl).CurrentEmployee.UUID);
            if(ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ((MainForm)this.TopLevelControl).LoadTasksPanel();
        }

        private void buttonUnassign_Click(object sender, EventArgs e)
        {
            Exception ex = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.UnassignTaskFromEmployee(((MainForm)this.TopLevelControl).CurrentEmployee.UUID, this._currentTask.ID);
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            ((MainForm)this.TopLevelControl).LoadTasksPanel();
        }
    }
}
