using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Project.Models;

namespace Project.Controls
{
    public partial class TasksContentControl : UserControl
    {
        //private List<Task> _availableTasks;
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

        private void TasksContentControl_Load(object sender, EventArgs e)
        {
            //(List<Task> tasks, Exception exc) = ((MainForm)this.TopLevelControl).TaskService.GetAssignedTasks();
            //(List<Task> taskss, Exception excs) = ((MainForm)this.TopLevelControl).TaskService.GetUnassignedTasks();
            //(List<Task> tasks, Exception exc) = ((MainForm)this.TopLevelControl).TaskService.SearchTasksByName("task");
            //Exception exception = ((MainForm)this.TopLevelControl).TaskService.CreateTask("task1", "descriere1", new DateTime(2023, 7, 21), "2e63341a-e627-48ac-bb1a-9d56e2e9cc4f");
            //(List<Task> tasksEmp, Exception excEmp) = ((MainForm)this.TopLevelControl).TaskService.GetTasksByEmpUUID("2e63341a-e627-48ac-bb1a-9d56e2e9cc4f");
            //Exception ex = ((MainForm)this.TopLevelControl).TaskService.DeleteTask(2);
            //Exception ex = ((MainForm)this.TopLevelControl).TaskService.UnassignTasksFromEmployee("2e63341a-e627-48ac-bb1a-9d56e2e9cc4f");
            //Exception ex = ((MainForm)this.TopLevelControl).TaskService.AssignTaskToEmployee(1, "2e63341a-e627-48ac-bb1a-9d56e2e9cc4f");
            //Exception exception = ((MainForm)this.TopLevelControl).TaskService.UpdateTaskDetails(3, "task1", "descriere1", new DateTime(2023, 7, 21));
            //Exception exception = ((MainForm)this.TopLevelControl).TaskService.UpdateTaskStatus(3, "in-progress");
            //Exception exception = ((MainForm)this.TopLevelControl).TaskService.UpdateTaskProgress(3, 75);

            (List<Task> availableTasks, Exception ex) = ((MainForm)this.TopLevelControl).Presenter.TaskSRV.GetAssignedTasks();
            if(ex != null)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            availableTasks.ForEach(task =>
            {
                DataGridViewRow taskRow = ((MainForm)this.TopLevelControl).Presenter.makeTaskRow(task);
                this.dataGridViewTasks.Rows.Add(taskRow);
            });
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            Form addTaskDialog = new Form();
            AddTaskDialogControl dialog = new AddTaskDialogControl();
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
                int deadlineDays = dialog.TaskDeadlineInDays;

                // working
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
    } 
}
