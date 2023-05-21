using Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace Project.Persistence.Interfaces
{
    public class SubtaskRepository : ISubtaskRepository
    {
        /// <summary>
        /// Class constructor. Checks the connection to the db and creates the subtasks table if it does not exist.
        /// </summary>
        public SubtaskRepository()
        {
            CheckConnection();

            CreateSubtaskTable();
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
        /// Method to create the subtasks table in the database, in case it is not created yet.
        /// </summary>
        /// <returns>Returns an exception if the statement did not execute properly.</returns>
        public Exception CreateSubtaskTable()
        {
            string stmt = "" +
                "CREATE TABLE IF NOT EXISTS subtasks (" +
                    "subtaskid          INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "subtasktitle        VARCHAR2(50) NOT NULL," +
                    "subtaskdescription  VARCHAR2(100) NOT NULL," +
                    "subtaskstatus       VARCHAR2(20) DEFAULT 'toDo'," +
                    "taskid              INTEGER NOT NULL," +
                    "employeeuuid        VARCHAR2(150) NOT NULL," +
                    "CONSTRAINT          subtasks_employees_fk FOREIGN KEY(employeeuuid) REFERENCES employees(employeeuuid )," +
                    "CONSTRAINT          subtasks_tasks_fk FOREIGN KEY(taskid ) REFERENCES tasks(taskid ) ON DELETE CASCADE" +
                ");";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new Exception(ex.Message);
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
        public Exception UpdateSubtaskDetails(int id, string subtaskName, string subtaskDescription)
        {
            string stmt = $"" +
                $"UPDATE subtasks " +
                $"SET subtasktitle = '{subtaskName}', subtaskdescription = '{subtaskDescription}'" +
                $"WHERE subtaskid = {id};";
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
        /// Method to update the subtask status.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="selectedKey"></param>
        /// <returns>Returns an exception in case an error happened while exuting the statement.</returns>
        public Exception ChangeStatus(int id, string selectedKey)
        {
            string stmt = $"" +
                $"UPDATE subtasks " +
                $"SET subtaskstatus = '{selectedKey}'" +
                $"WHERE subtaskid = '{id}';";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        /// <summary>
        /// Method to add a subtask to the database.
        /// </summary>
        /// <param name="subtask">Subtask data model.</param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception AddSubstask(Subtask subtask)
        {
            string stmt = $"INSERT INTO subtasks(subtasktitle, subtaskdescription, subtaskstatus, taskid, employeeuuid) " +
                $"VALUES ('{subtask.Title}'," +
                $" '{subtask.Description}'," +
                $" '{subtask.Status}'," +
                $" '{subtask.TaskId}'," +
                $" '{subtask.EmployeeId}')";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);

            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Method to retrieve a subtask data based on its id.
        /// </summary>
        /// <param name="id">Subtask id.</param>
        /// <returns>Returns the subtask data if it was found, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (Subtask, Exception) GetSubtaskById(int id)
        {
            string stmt = $"SELECT * FROM subtasks WHERE subtaskid = '{id}'";

            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            using (cmd)
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        Subtask subtask = null;
                        while (dataReader.Read())
                        {
                            int subtaskId = dataReader.GetInt32(0);
                            string subtaskTitle = dataReader.GetString(1);
                            string subtaskDescription = dataReader.GetString(2);
                            string subtaskStatus = dataReader.GetString(3);
                            int taskid = dataReader.GetInt32(4);
                            string employeeuuid = dataReader.GetString(5);

                            subtask = new Subtask(subtaskId, subtaskTitle, subtaskDescription, subtaskStatus, taskid, employeeuuid);
                        }
                        if (subtask == null) throw new Exception("subtask is null");
                        return (subtask, null);
                    }
                }
                catch (Exception ex)
                {
                    return (null, new Exception(ex.Message));
                }
            }
        }
        /// <summary>
        /// Method to retrieve all subtasks based on a taskId.
        /// </summary>
        /// <param name="id">TaskId id.</param>
        /// <returns>Returns all the subtasks if they were found, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (IList<Subtask>, Exception) GetSubtasksByTask(int id)
        {
            List<Subtask> subtasks = new List<Subtask>();

            string stmt = $"SELECT subtaskid FROM subtasks WHERE taskid = '{id}'";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            using (cmd)
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (dataReader.Read())
                        {
                            int taskId;
                            if (int.TryParse(dataReader.GetValue(i).ToString(), out taskId))
                            {
                                subtasks.Add(GetSubtaskById(taskId).Item1);
                            }
                        }
                        if (subtasks == null) throw new Exception("subtasks is null");
                        return (subtasks, null);
                    }
                }
                catch (Exception ex)
                {
                    return (null, new Exception(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to delete a subtask
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns an exception in case an error happened while executing the statement.</returns>
        public Exception DeleteSubtask(int id)
        {
            string stmt = $"DELETE FROM subtasks WHERE subtaskid = {id}";
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new SubtaskDeleteException(ex.Message);
            }
        }
    }

    class SubtaskDeleteException : Exception
    {
        public SubtaskDeleteException(string message)
            : base(message)
        {
        }
    }    
}