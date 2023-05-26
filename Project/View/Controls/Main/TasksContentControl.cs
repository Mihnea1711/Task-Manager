using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Persistence;

namespace View
{
    public partial class TasksContentControl : UserControl
    {
        #region fields
        /// <summary>
        /// List of the tasks inside the control.
        /// </summary>
        private List<Task> _tasks = new List<Task>();
        #endregion

        /// <summary>
        /// Default constructor.
        /// </summary>
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

        /// <summary>
        /// Constructor with the list of tasks as argument. Used when searching with the search-bar.
        /// </summary>
        /// <param name="tasks"></param>
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

        /// <summary>
        /// When loading, if the task list is empty, we retrieve all the tasks that are available and assigned from the database and render them inside the data grid view.
        /// If any task is expired, we unnasign it and put it inisde the backlog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            foreach(Task task in _tasks)
            {
                if (task.Deadline.Day < DateTime.Now.Day)
                {
                    ((MainForm)this.TopLevelControl).Presenter.TaskSRV.UnassignTaskFromEmployee(task.EmployeeUUID, task.ID);
                }
                else
                {
                    DataGridViewRow taskRow = ((MainForm)this.TopLevelControl).Presenter.makeTaskRow(task);
                    this.dataGridViewTasks.Rows.Add(taskRow);
                }
            };
        }

        /// <summary>
        /// Callback for the button to add a task. Shows a dialog to input the task details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            (List<Employee> employees, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.EmployeeSRV.GetEmployees();
            if(ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Form addTaskDialog = new Form();
            AddTaskDialogControl dialog = new AddTaskDialogControl(employees, ((MainForm)this.TopLevelControl).CurrentEmployee)
            {
                Dock = DockStyle.Fill
            };
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

        /// <summary>
        /// Callback for the "See more" button inside the data grid view. Loads the task details page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6) // Checking if it's a valid row index and the button column (index 6)
            { 
                DataGridViewCell idCell = dataGridViewTasks.Rows[e.RowIndex].Cells[0];
                if (idCell.Value != null)
                {
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
        }

        /// <summary>
        /// Callback for the search bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
