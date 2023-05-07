using System;

namespace Project.Models
{
    public class Subtask
    {
        /// <summary>
        /// The class contains the fields stored inside the db so it is easier to build the model inside the application.
        /// </summary>
        #region fields
        private int _id;
        private string _title;
        private string _description;
        private string _status;
        private DateTime _deadline;
        private int _taskId;
        private string _employeeId;
        #endregion

        /// <summary>
        /// Getters and setters for the fields.
        /// </summary>
        #region getters/setters
        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime Deadline { get => _deadline; set => _deadline = value; }
        public int TaskId { get => _taskId; set => _taskId = value; }
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="deadline"></param>
        /// <param name="taskId"></param>
        /// <param name="employeeId"></param>
        public Subtask(int id, string title, string description, string status, DateTime deadline, int taskId, string employeeId)
        {
            this._id = id;
            this._title = title;
            this._description = description;
            this._status = status;
            this._deadline = deadline;
            this._taskId = taskId;
            this._employeeId = employeeId;
        }
    }
}
