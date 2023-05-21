using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Project.Models;
using Project.Persistence.Interfaces;
using Project.Views.Controls.Dialogs;

namespace Project.Controls
{
    public partial class TaskContentControl : UserControl
    {
        private Task _currentTask;

        public TaskContentControl(Task task)
        {
            InitializeComponent();

            this.dataGridViewSubtasks.Columns.Add("subtaskID", "ID");
            this.dataGridViewSubtasks.Columns.Add("subtaskTitle", "Title");
            this.dataGridViewSubtasks.Columns.Add("subtaskDescription", "Description");
            this.dataGridViewSubtasks.Columns.Add("subtaskStatus", "Status");
            this.dataGridViewSubtasks.Columns.Add("subtaskSeeMore", "");

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
            if (exception != null)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            subtasks.ToList().ForEach(comment =>
            {
                DataGridViewRow subtaskRow = ((MainForm)this.TopLevelControl).Presenter.makeSubtaskRow(comment);
                this.dataGridViewSubtasks.Rows.Add(subtaskRow);
            });
        }

        private void buttonAddSubtask_Click(object sender, EventArgs e)
        {
            Form addSubtaskDialog = new Form();
            AddSubtaskDialogControl dialog = new AddSubtaskDialogControl();

            dialog.Dock = DockStyle.Fill;
            addSubtaskDialog.Height = dialog.Height + 50;
            addSubtaskDialog.Width = dialog.Width;
            addSubtaskDialog.Controls.Add(dialog);
            addSubtaskDialog.ShowDialog();

            if (addSubtaskDialog.DialogResult == DialogResult.OK)
            {
                string subtaskName = dialog.SubtaskName;
                string subtaskDescription = dialog.SubtaskDescription;

                ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.AddSubstask(subtaskName, subtaskDescription, "toDo", _currentTask.ID, _currentTask.EmployeeUUID);
                (IList<Subtask> taskSubtasks, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.GetSubtasksByTask(_currentTask.ID);
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                }
                ((MainForm)this.TopLevelControl).Presenter.TaskSRV.CheckSubtasksStatus(taskSubtasks.ToList());
                ((MainForm)this.TopLevelControl).LoadTasksPanel();
            }
        }

        private void buttonAssignToMe_Click(object sender, EventArgs e)
        {
            Form assignToMeDialog = new Form();
            AskForDeadlineDialogControl deadlineDialogControl = new AskForDeadlineDialogControl
            {
                Dock = DockStyle.Fill 
            };
            assignToMeDialog.Width = deadlineDialogControl.Width;
            assignToMeDialog.Height = deadlineDialogControl.Height + 50;
            assignToMeDialog.Controls.Add(deadlineDialogControl);
            assignToMeDialog.ShowDialog();

            if(assignToMeDialog.DialogResult == DialogResult.OK)
            {
                DateTime deadline = deadlineDialogControl.Deadline;
                Exception ex = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.AssignTaskToEmployee(this._currentTask.ID, ((MainForm)this.TopLevelControl).CurrentEmployee.UUID, deadline);
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                ((MainForm)this.TopLevelControl).LoadTasksPanel();
            }            
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            (List<Employee> employees, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployees();
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Form addTaskDialog = new Form();
            AddTaskDialogControl dialog = new AddTaskDialogControl(employees, ((MainForm)this.TopLevelControl).CurrentEmployee);
            dialog.TaskName = this._currentTask.Name;
            dialog.TaskDescription = this._currentTask.Description;
            dialog.TaskDeadline = this._currentTask.Deadline;
            dialog.TaskEmployeeAssigned = this._currentTask.EmployeeUUID;
            dialog.SetLabelTitle("Update Task Details");
            dialog.SetSubmitBtnText("Save");
            dialog.Dock = DockStyle.Fill;

            addTaskDialog.Height = dialog.Height + 50;
            addTaskDialog.Width = dialog.Width;
            addTaskDialog.Controls.Add(dialog);
            addTaskDialog.ShowDialog();

            if (addTaskDialog.DialogResult == DialogResult.OK)
            {
                string taskName = dialog.TaskName;
                string taskDescription = dialog.TaskDescription;
                string assignedEmployee = dialog.TaskEmployeeAssigned;
                DateTime taskDeadline = dialog.TaskDeadline;

                ex = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.UpdateTaskDetails(_currentTask.ID, taskName, taskDescription, taskDeadline, assignedEmployee);
                if(ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                ((MainForm)this.TopLevelControl).LoadTasksPanel();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // TODO()
            // Delete all subtask and comments if necessary from deleted task
            //
            ((MainForm)this.TopLevelControl).Presenter.TaskSRV.DeleteTask(_currentTask.ID);
            ((MainForm)this.TopLevelControl).LoadTasksPanel();
        }

        private void dataGridViewSubtasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DataGridViewCell idCell = dataGridViewSubtasks.Rows[e.RowIndex].Cells[0];

                if (idCell.Value != null)
                {
                    string subtaskID = idCell.Value.ToString();

                    (Subtask clickedSubtask, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.SubtaskSRV.GetSubtaskById(int.Parse(subtaskID));
                    if (ex != null)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    ((MainForm)this.TopLevelControl).LoadSubtaskContentPanel(clickedSubtask);
                }
            }
        }
    }
}
