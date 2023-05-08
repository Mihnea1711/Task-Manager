using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Project.Models;

namespace Project.Controls
{
    public partial class TasksContentControl : UserControl
    {
        public TasksContentControl()
        {
            InitializeComponent();
        }

        private void TasksContentControl_Load(object sender, EventArgs e)
        {
            /*
            // Step 5: Create a connection string to your database
            string connectionString = "Data Source=project.db;Version=3;";

            // Step 6: Write a SELECT statement to retrieve data
            string selectStatement = "SELECT * FROM tasks";

            Console.WriteLine(selectStatement);

            // Step 7: Create a SQLiteDataAdapter object
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectStatement, connectionString);

            // Step 8: Create a new DataTable object
            DataTable dataTable = new DataTable();

            // Step 9: Fill the DataTable with the data
            dataAdapter.Fill(dataTable);

            var comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "My ComboBox Column";
            comboBoxColumn.Name = "MyComboBoxColumn";
            comboBoxColumn.DataPropertyName = "MyComboBoxColumnData";
            comboBoxColumn.DataSource = new List<string> { "Option 1", "Option 2", "Option 3" };
            

            // Step 10: Set the DataSource property of the DataGridView control
            dataGridViewTasks.DataSource = dataTable;

            // Add the column to the DataGridView control
            dataGridViewTasks.Columns.Add(comboBoxColumn);
            */

            //(List<Task> tasks, Exception exc) = ((MainForm)this.TopLevelControl).TaskService.GetAssignedTasks();
            //(List<Task> taskss, Exception excs) = ((MainForm)this.TopLevelControl).TaskService.GetUnassignedTasks();
            (List<Task> tasks, Exception exc) = ((MainForm)this.TopLevelControl).TaskService.SearchTasksByName("task");
            //Exception exception = ((MainForm)this.TopLevelControl).TaskService.CreateTask("task1", "descriere1", new DateTime(2023, 7, 21), "2e63341a-e627-48ac-bb1a-9d56e2e9cc4f");
            //(List<Task> tasksEmp, Exception excEmp) = ((MainForm)this.TopLevelControl).TaskService.GetTasksByEmpUUID("2e63341a-e627-48ac-bb1a-9d56e2e9cc4f");
            //Exception ex = ((MainForm)this.TopLevelControl).TaskService.DeleteTask(2);
            //Exception ex = ((MainForm)this.TopLevelControl).TaskService.UnassignTasksFromEmployee("2e63341a-e627-48ac-bb1a-9d56e2e9cc4f");
            //Exception ex = ((MainForm)this.TopLevelControl).TaskService.AssignTaskToEmployee(1, "2e63341a-e627-48ac-bb1a-9d56e2e9cc4f");
            //Exception exception = ((MainForm)this.TopLevelControl).TaskService.UpdateTaskDetails(3, "task1", "descriere1", new DateTime(2023, 7, 21));
            //Exception exception = ((MainForm)this.TopLevelControl).TaskService.UpdateTaskStatus(3, "in-progress");
            //Exception exception = ((MainForm)this.TopLevelControl).TaskService.UpdateTaskProgress(3, 75);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tasks;
            dataGridViewTasks.DataSource = bindingSource;

            //gut
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

        private void dataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ((MainForm)this.TopLevelControl).LoadTaskContentPanel();
        }
    } 
}
