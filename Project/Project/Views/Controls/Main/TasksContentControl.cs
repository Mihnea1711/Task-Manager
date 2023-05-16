using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Project.Models;

namespace Project.Controls
{
    public partial class TasksContentControl : UserControl
    {
        private List<Task> _tasks = new List<Task>();

        public TasksContentControl()
        {
            InitializeComponent();

            this.dataGridViewTasks.Columns.Add("taskID", "ID");
            this.dataGridViewTasks.Columns.Add("taskTitle", "Title");
            this.dataGridViewTasks.Columns.Add("taskDescription", "Description");
            this.dataGridViewTasks.Columns.Add("taskStatus", "Status");
            this.dataGridViewTasks.Columns.Add("taskProgress", "Progress");
            this.dataGridViewTasks.Columns.Add("taskDeadline", "Deadline");
            this.dataGridViewTasks.Columns.Add("taskSeeMore", "");
        }

        public TasksContentControl(List<Task> tasks)
        {
            InitializeComponent();

            this.dataGridViewTasks.Columns.Add("taskID", "ID");
            this.dataGridViewTasks.Columns.Add("taskTitle", "Title");
            this.dataGridViewTasks.Columns.Add("taskDescription", "Description");
            this.dataGridViewTasks.Columns.Add("taskStatus", "Status");
            this.dataGridViewTasks.Columns.Add("taskProgress", "Progress");
            this.dataGridViewTasks.Columns.Add("taskDeadline", "Deadline");
            this.dataGridViewTasks.Columns.Add("taskSeeMore", "");

            this._tasks = tasks;
        }

        private void TasksContentControl_Load(object sender, EventArgs e)
        {
            if(this._tasks.Count == 0)
            {
                (List<Task> availableTasks, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetAssignedTasks();
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this._tasks = availableTasks;
            }

            _tasks.ForEach(task =>
            {
                if (task.Deadline < DateTime.Now)
                {
                    ((MainForm)this.TopLevelControl).Presenter.TaskSRV.UnassignTaskFromEmployee(task.EmployeeUUID, task.ID);
                }
                else
                {
                    DataGridViewRow taskRow = ((MainForm)this.TopLevelControl).Presenter.makeTaskRow(task);
                    this.dataGridViewTasks.Rows.Add(taskRow);
                }
            });
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            (List<Employee> employees, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployees();
            if(ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Form addTaskDialog = new Form();
            AddTaskDialogControl dialog = new AddTaskDialogControl(employees, ((MainForm)this.TopLevelControl).CurrentEmployee);
            dialog.Dock = DockStyle.Fill;
            addTaskDialog.Height = dialog.Height + 50;
            addTaskDialog.Width = dialog.Width;
            addTaskDialog.Controls.Add(dialog);
            addTaskDialog.ShowDialog();

            if(addTaskDialog.DialogResult == DialogResult.OK)
            {
                string taskName = dialog.TaskName;
                string taskDescription = dialog.TaskDescription;
                string assignedEmployee = dialog.TaskEmployeeAssigned;
                DateTime taskDeadline = dialog.TaskDeadline;

                ((MainForm)this.TopLevelControl).Presenter.TaskSRV.CreateTask(taskName, taskDescription, taskDeadline, assignedEmployee);
                ((MainForm)this.TopLevelControl).LoadTasksPanel();
            }

        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6) // Checking if it's a valid row index and the button column (index 6)
            {
                DataGridViewCell idCell = dataGridViewTasks.Rows[e.RowIndex].Cells[0];
                string taskID = idCell.Value.ToString();

                (Task clickedTask, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetTaskByID(int.Parse(taskID));
                if(ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                ((MainForm)this.TopLevelControl).LoadTaskContentPanel(clickedTask);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchKey = this.textBoxSearchBar.Text;

            (List<Task> matchingTasks, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.SearchAssignedTasksByName(searchKey);
            if(ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ((MainForm)this.TopLevelControl).LoadTasksPanel(matchingTasks);
        }
    } 
}
