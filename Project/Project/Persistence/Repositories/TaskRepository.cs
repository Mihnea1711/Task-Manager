using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Project.Models;

namespace Project.Persistence.Interfaces
{
    internal class TaskRepository : ITaskRepository
    {
        /// <summary>
        /// Constructor for the Task class.
        /// </summary>
        public TaskRepository() 
        {
            CheckConnection();

            CreateTaskTable();
        }

        /// <summary>
        /// Method to check the connection to the database. If the connection is not running, it opens the connection.
        /// </summary>
        private void CheckConnection()
        {
            if (Program.DbConnection == null)
            {
                Program.Connect();
            }
        }

        /// <summary>
        /// Method to create the task table in the database, in case it is not created yet.
        /// </summary>
        /// <returns>Returns an exception if the statement did not execute properly.</returns>
        public Exception CreateTaskTable()
        {
            string stmt = "" +
                "CREATE TABLE IF NOT EXISTS tasks (" +
                    "taskid INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "tasktitle VARCHAR2(50) NOT NULL, " +
                    "taskdescription VARCHAR2(100) NOT NULL, " +
                    "taskstatus VARCHAR2(20) DEFAULT 'toDo'," +
                    "taskprogress NUMBER(2) DEFAULT 0, " +
                    "taskdeadline datetime NOT NULL, " +
                    "employeeuuid VARCHAR2(150) NOT NULL, " +
                    "CONSTRAINT tasks_employees_fk FOREIGN KEY ( employeeuuid ) REFERENCES employees ( employeeuuid )" +
                ");";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskTableCreationException(ex.Message);
            }
        }

        /// <summary>
        /// Method to create a new task and store it inside the database.
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="taskDescription"></param>
        /// <param name="taskDeadline"></param>
        /// <param name="employeeUUID"></param>
        /// <returns></returns>
        public Exception CreateTask(string taskName, string taskDescription, DateTime taskDeadline, string employeeUUID)
        {
            string stmt = $"INSERT INTO tasks (tasktitle, taskdescription, taskdeadline, employeeuuid) " +
                $"VALUES ('{taskName}', '{taskDescription}', '{taskDeadline}', '{employeeUUID}');";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskInsertException(ex.Message);
            }
        }

        /// <summary>
        /// Method to get specific task data by ID
        /// </summary>
        /// <param name="taskID"></param>
        /// <returns></returns>
        public (Task, Exception) GetTaskByID(int taskID)
        {
            string stmt = $"SELECT * FROM tasks WHERE taskid = {taskID}";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        Task task = null;
                        while (dataReader.Read())
                        {
                            string taskTitle = dataReader.GetString(1);
                            string taskDescription = dataReader.GetString(2);
                            string taskStatus = dataReader.GetString(3);
                            int taskProgress = dataReader.GetInt32(4);
                            string taskDeadline = dataReader.GetString(5);
                            DateTime deadline = DateTime.Parse(taskDeadline);
                            string employeeUUID = dataReader.GetString(6);

                            task = new Task(taskID, taskTitle, taskDescription, taskStatus, taskProgress, deadline, employeeUUID);
                        }
                        if (task == null) throw new Exception("task is null");
                        return (task, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForTaskException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to retrieve all tasks from the database.
        /// </summary>
        /// <returns>Returns the tasks if there are any, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (List<Task>, Exception) GetAssignedTasks()
        {
            string stmt = "SELECT * FROM tasks WHERE employeeuuid != '';";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        List<Task> tasks = new List<Task>();
                        while (dataReader.Read())
                        {
                            int taskID = dataReader.GetInt32(0);
                            string taskTitle = dataReader.GetString(1);
                            string taskDescription = dataReader.GetString(2);
                            string taskStatus = dataReader.GetString(3);
                            int taskProgress = dataReader.GetInt32(4);
                            string taskDeadline = dataReader.GetString(5);
                            DateTime deadline = DateTime.Parse(taskDeadline);
                            string employeeUUID = dataReader.GetString(6);

                            Task task = new Task(taskID, taskTitle, taskDescription, taskStatus, taskProgress, deadline, employeeUUID);
                            tasks.Add(task);
                        }
                        if (tasks == null) throw new Exception("tasks is null");
                        return (tasks, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForAllTasksException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to retrieve all tasks from the database.
        /// </summary>
        /// <returns>Returns the tasks if there are any, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (List<Task>, Exception) GetUnassignedTasks()
        {
            string stmt = "SELECT * FROM tasks WHERE employeeuuid == '';";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        List<Task> tasks = new List<Task>();
                        while (dataReader.Read())
                        {
                            int taskID = dataReader.GetInt32(0);
                            string taskTitle = dataReader.GetString(1);
                            string taskDescription = dataReader.GetString(2);
                            string taskStatus = dataReader.GetString(3);
                            int taskProgress = dataReader.GetInt32(4);
                            string taskDeadline = dataReader.GetString(5);
                            DateTime deadline = DateTime.Parse(taskDeadline);
                            string employeeUUID = dataReader.GetString(6);

                            Task task = new Task(taskID, taskTitle, taskDescription, taskStatus, taskProgress, deadline, employeeUUID);
                            tasks.Add(task);
                        }
                        if (tasks == null) throw new Exception("tasks is null");
                        return (tasks, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForAllTasksException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to case-insensitive search for assigned tasks by title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public (List<Task>, Exception) SearchAssignedTasksByName(string title)
        {
            string stmt = $"SELECT * FROM tasks WHERE employeeUUID != '' and LOWER(tasktitle) LIKE '%{title}%';";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        List<Task> tasks = new List<Task>();
                        while (dataReader.Read())
                        {
                            int taskID = dataReader.GetInt32(0);
                            string taskTitle = dataReader.GetString(1);
                            string taskDescription = dataReader.GetString(2);
                            string taskStatus = dataReader.GetString(3);
                            int taskProgress = dataReader.GetInt32(4);
                            string taskDeadline = dataReader.GetString(5);
                            DateTime deadline = DateTime.Parse(taskDeadline);
                            string employeeUUID = dataReader.GetString(6);

                            Task task = new Task(taskID, taskTitle, taskDescription, taskStatus, taskProgress, deadline, employeeUUID);
                            tasks.Add(task);
                        }
                        if (tasks == null) throw new Exception("tasks is null");
                        return (tasks, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForAllTasksException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to case-insensitive search for unassigned tasks by title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public (List<Task>, Exception) SearchUnassignedTasksByName(string title)
        {
            string stmt = $"SELECT * FROM tasks WHERE employeeUUID == '' and LOWER(tasktitle) LIKE '%{title}%';";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        List<Task> tasks = new List<Task>();
                        while (dataReader.Read())
                        {
                            int taskID = dataReader.GetInt32(0);
                            string taskTitle = dataReader.GetString(1);
                            string taskDescription = dataReader.GetString(2);
                            string taskStatus = dataReader.GetString(3);
                            int taskProgress = dataReader.GetInt32(4);
                            string taskDeadline = dataReader.GetString(5);
                            DateTime deadline = DateTime.Parse(taskDeadline);
                            string employeeUUID = dataReader.GetString(6);

                            Task task = new Task(taskID, taskTitle, taskDescription, taskStatus, taskProgress, deadline, employeeUUID);
                            tasks.Add(task);
                        }
                        if (tasks == null) throw new Exception("tasks is null");
                        return (tasks, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForAllTasksException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to retrieve all tasks from the database which are assigned to a specific employee.
        /// </summary>
        /// <param name="empUUID">Employee UUID.</param>
        /// <returns>Returns the tasks if there are any, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (List<Task>, Exception) GetTasksByEmpUUID(string empUUID)
        {
            string stmt = $"SELECT * FROM tasks WHERE employeeuuid = '{empUUID}';";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        List<Task> tasks = new List<Task>();
                        while (dataReader.Read())
                        {
                            int taskID = dataReader.GetInt32(0);
                            string taskTitle = dataReader.GetString(1);
                            string taskDescription = dataReader.GetString(2);
                            string taskStatus = dataReader.GetString(3);
                            int taskProgress = dataReader.GetInt32(4);
                            string taskDeadline = dataReader.GetString(5);
                            DateTime deadline = DateTime.Parse(taskDeadline);

                            Task task = new Task(taskID, taskTitle, taskDescription, taskStatus, taskProgress, deadline, empUUID);
                            tasks.Add(task);
                        }
                        if (tasks == null) throw new Exception("tasks is null");
                        return (tasks, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForAllTasksException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to update the task's significant details.
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="taskTitle"></param>
        /// <param name="taskDescription"></param>
        /// <param name="taskDeadline"></param>
        /// <returns></returns>
        public Exception UpdateTaskDetails(int taskID, string taskTitle, string taskDescription, DateTime taskDeadline, string assignedEmployeeUUID)
        {
            string stmt = $"" +
                $"UPDATE tasks " +
                $"SET tasktitle = '{taskTitle}', taskdescription = '{taskDescription}', taskdeadline = '{taskDeadline}', employeeuuid = '{assignedEmployeeUUID}'" +
                $"WHERE taskid = {taskID};";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskUpdateException(ex.Message);
            }
        }

        /// <summary>
        /// Method to update the task's status.
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="newStatus"></param>
        /// <returns></returns>
        public Exception UpdateTaskStatus(int taskID, string newStatus)
        {
            string stmt = $"" +
                $"UPDATE tasks " +
                $"SET taskstatus = '{newStatus}' " +
                $"WHERE taskid = {taskID};";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskUpdateException(ex.Message);
            }
        }

        /// <summary>
        /// Method to update the task's progress.
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        public Exception UpdateTaskProgress(int taskID, int progress)
        {
            string stmt = $"" +
                $"UPDATE tasks " +
                $"SET taskprogress = {progress} " +
                $"WHERE taskid = {taskID};";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskUpdateException(ex.Message);
            }
        }

        /// <summary>
        /// Method to delete a certain task from the database by its ID.
        /// </summary>
        /// <param name="taskID"></param>
        /// <returns></returns>
        public Exception DeleteTask(int taskID)
        {
            string stmt = $"DELETE FROM tasks WHERE taskid = {taskID}";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskDeleteException(ex.Message);
            }
        }

        /// <summary>
        /// Method to assign a task to a certain employee based on the task id and on the employee uuid.
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="empUUID"></param>
        /// <returns></returns>
        public Exception AssignTaskToEmployee(int taskID, string empUUID, DateTime deadline)
        {
            string stmt = $"" +
            $"UPDATE tasks " +
            $"SET employeeuuid = '{empUUID}', taskdeadline = '{deadline}' " +
            $"WHERE taskid = {taskID};";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskAssignException(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empUUID"></param>
        /// <param name="taskID"></param>
        /// <returns></returns>
        public Exception UnassignTaskFromEmployee(string empUUID, int taskID)
        {
            string stmt = $"" +
            $"UPDATE tasks " +
            $"SET employeeuuid = '' " +
            $"WHERE taskid = {taskID} and employeeuuid = '{empUUID}';";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskAssignException(ex.Message);
            }
        }

        /// <summary>
        /// Method to unassign all tasks from an employee based on its uuid.
        /// </summary>
        /// <param name="empUUID"></param>
        /// <returns></returns>
        public Exception UnassignTasksFromEmployee(string empUUID)
        {
            string stmt = $"" +
            $"UPDATE tasks " +
            $"SET employeeuuid = '' " +
            $"WHERE employeeuuid = '{empUUID}';";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new TaskUnassignException(ex.Message);
            }
        }

        /// <summary>
        /// Method to retrieve all done tasks by an employee.
        /// </summary>
        /// <param name="empUUID"></param>
        /// <returns></returns>
        public (int, Exception) GetTasksDoneCount(string empUUID)
        {
            string stmt = $"SELECT COUNT(*) FROM tasks WHERE employeeuuid = '{empUUID}' and taskstatus = 'done'";
            using (SQLiteCommand command = new SQLiteCommand(stmt, Program.DbConnection))
            {
                try
                {
                    // Execute the query and get the count
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return (count, null);

                } catch (Exception ex)
                {
                    return (0, ex);
                }
            }
        }
    }

    class TaskTableCreationException : Exception
    {
        public TaskTableCreationException(string message)
            : base(message)
        {
        }
    }

    class QueryForTaskException : Exception
    {
        public QueryForTaskException(string message)
            : base(message)
        {
        }
    }

    class QueryForAllTasksException : Exception
    {
        public QueryForAllTasksException(string message)
            : base(message)
        {
        }
    }

    class TaskInsertException : Exception
    {
        public TaskInsertException(string message)
            : base(message)
        {
        }
    }

    class TaskDeleteException : Exception
    {
        public TaskDeleteException(string message)
            : base(message)
        {
        }
    }

    class TaskUpdateException : Exception
    {
        public TaskUpdateException(string message)
            : base(message)
        {
        }
    }

    class TaskAssignException : Exception
    {
        public TaskAssignException(string message)
            : base(message)
        {
        }
    }

    class TaskUnassignException : Exception
    {
        public TaskUnassignException(string message)
            : base(message)
        {
        }
    }
}

