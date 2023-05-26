using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Persistence;

namespace View
{
    public partial class BacklogContentControl : UserControl
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
        public BacklogContentControl()
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
        public BacklogContentControl(List<Task> tasks)
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
        /// When loading, if the task list is empty, we retrieve all the tasks that are expired or unnasigned from the database 
        /// and render them inside the data grid view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BacklogContentControl_Load(object sender, EventArgs e)
        {
            if (this._tasks.Count == 0)
            {
                (List<Task> availableTasks, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetUnassignedTasks();
                if (ex != null)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this._tasks = availableTasks;
            }

            _tasks.ForEach(task =>
            {
                DataGridViewRow taskRow = ((MainForm)this.TopLevelControl).Presenter.makeTaskRow(task);
                this.dataGridViewTasks.Rows.Add(taskRow);
            });
        }

        /// <summary>
        /// Callback for the "See more" button inside the data grid view. Loads the task details page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
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

            (List<Task> matchingTasks, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.SearchUnassignedTasksByName(searchKey);
            if (ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ((MainForm)this.TopLevelControl).LoadTasksPanel(matchingTasks);
        }
    }
}
