using Project.Business.Interfaces;
using Project.Models;
using Project.Persistence.Interfaces;
using System;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class TaskService : ITaskService
    {
        /// <summary>
        /// Instance of the TaskRepository class that handles the database operations.
        /// </summary>
        private ITaskRepository taskRepository;

        /// <summary>
        /// Constructor. Initializes the task repository instance.
        /// </summary>
        public TaskService() 
        {        
            this.taskRepository = new TaskRepository();
        }

        /// <summary>
        /// Method to create a task.
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="taskDescription"></param>
        /// <param name="taskDeadline"></param>
        /// <param name="employeeUUID"></param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception CreateTask(string taskName, string taskDescription, DateTime taskDeadline, string employeeUUID)
        {
            return this.taskRepository.CreateTask(taskName, taskDescription, taskDeadline, employeeUUID);
        }

        /// <summary>
        /// Method to retrieve task data from db based on its id.
        /// </summary>
        /// <param name="taskID"></param>
        /// <returns>Returns the task object model if found, otherwise null. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (Task, Exception) GetTaskByID(int taskID)
        {
            return this.taskRepository.GetTaskByID(taskID);
        }

        /// <summary>
        /// Method to retrieve all tasks that are assigned to an employee from db.
        /// </summary>
        /// <returns>Returns the task models if any, otherwise an empty list. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (List<Task>, Exception) GetAssignedTasks()
        {
            return this.taskRepository.GetAssignedTasks();
        }

        /// <summary>
        /// Method to retrieve all tasks that are not assigned to an employee from db.
        /// </summary>
        /// <returns>Returns the task models if any, otherwise an empty list. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (List<Task>, Exception) GetUnassignedTasks()
        {
            return this.taskRepository.GetUnassignedTasks();
        }

        /// <summary>
        /// Method to search assigned tasks based on an input task title. The search in case-insensitive.
        /// </summary>
        /// <param name="title"></param>
        /// <returns>Returns the task models if any, otherwise an empty list. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (List<Task>, Exception) SearchAssignedTasksByName(string title)
        {
            return this.taskRepository.SearchAssignedTasksByName(title);
        }

        /// <summary>
        /// Method to search unassigned tasks based on an input task title. The search in case-insensitive.
        /// </summary>
        /// <param name="title"></param>
        /// <returns>Returns the task models if any, otherwise an empty list. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (List<Task>, Exception) SearchUnassignedTasksByName(string title)
        {
            return this.taskRepository.SearchUnassignedTasksByName(title);
        }

        /// <summary>
        /// Method to retrieve all tasks assigned to a specific employee.
        /// </summary>
        /// <param name="empUUID"></param>
        /// <returns>Returns the task models if any, otherwise an empty list. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (List<Task>, Exception) GetTasksByEmpUUID(string empUUID)
        {
            return this.taskRepository.GetTasksByEmpUUID(empUUID);
        }

        /// <summary>
        /// Method to update the task details.
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="taskTitle"></param>
        /// <param name="taskDescription"></param>
        /// <param name="taskDeadline"></param>
        /// <param name="assignedEmployeeUUID"></param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception UpdateTaskDetails(int taskID, string taskTitle, string taskDescription, DateTime taskDeadline, string assignedEmployeeUUID)
        {
            return this.taskRepository.UpdateTaskDetails(taskID, taskTitle, taskDescription, taskDeadline, assignedEmployeeUUID);
        }

        /// <summary>
        /// Method to update the task progress.
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="progress"></param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception UpdateTaskProgress(int taskID, int progress)
        {
            return this.taskRepository.UpdateTaskProgress(taskID, progress);
        }

        /// <summary>
        /// Method to update the task status.
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="newStatus"></param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception UpdateTaskStatus(int taskID, string newStatus)
        {
            return this.taskRepository.UpdateTaskStatus(taskID, newStatus);
        }

        /// <summary>
        /// Method to delete a task.
        /// </summary>
        /// <param name="taskID"></param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception DeleteTask(int taskID)
        {
            return this.taskRepository.DeleteTask(taskID);
        }

        /// <summary>
        /// Method to assign a task to an employee.
        /// </summary>
        /// <param name="taskID"></param>
        /// <param name="empUUID"></param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception AssignTaskToEmployee(int taskID, string empUUID, DateTime deadline)
        {
            return this.taskRepository.AssignTaskToEmployee(taskID, empUUID, deadline);
        }

        /// <summary>
        /// MEthod to unaasign a specific task from an employee.
        /// </summary>
        /// <param name="empUUID"></param>
        /// <param name="taskID"></param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception UnassignTaskFromEmployee(string empUUID, int taskID)
        {
            return this.taskRepository.UnassignTaskFromEmployee(empUUID, taskID);
        }

        /// <summary>
        /// Method to unassign all tasks of an employee.
        /// </summary>
        /// <param name="empUUID"></param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception UnassignTasksFromEmployee(string empUUID)
        {
            return this.taskRepository.UnassignTasksFromEmployee(empUUID);
        }

        public Exception CheckSubtasksStatus(List<Subtask> subtasks)
        {
            if(subtasks == null)
            {
                return new NullSubtasksException("Subtask list is null");
            }
            if(subtasks.Count == 0)
            {
                return new SubtasksEmptyException("Subtask list is empty");
            }

            int taskId = subtasks[0].TaskId;

            double doneSubtasks = 0;
            double toDoSubtasks = 0;

            foreach (Subtask subtask in subtasks)
            {
                if (subtask.Status == "toDo")
                {
                    toDoSubtasks++;
                }
                if (subtask.Status == "inProgress")
                {
                    Exception exc = UpdateTaskStatus(taskId, "inProgress");
                    if (exc != null)
                    {
                        return exc;
                    }
                }
                if (subtask.Status == "done")
                {
                    doneSubtasks++;
                }
            }

            if (toDoSubtasks == subtasks.Count)
            {
                Exception exc = UpdateTaskStatus(taskId, "toDo");
                if (exc != null)
                {
                    return exc;
                }
            }

            if (doneSubtasks == subtasks.Count)
            {
                Exception exc = UpdateTaskStatus(taskId, "done");
                if (exc != null)
                {
                    return exc;
                }
            }

            int progress = (int)(doneSubtasks / subtasks.Count * 100);
            Exception ex = UpdateTaskProgress(taskId, progress);
            if (ex != null)
            {
                return ex;
            }

            return null;
        }
    }

    class NullSubtasksException : Exception
    {
        public NullSubtasksException(string message)
            : base(message)
        {
        }
    }

    class SubtasksEmptyException : Exception
    {
        public SubtasksEmptyException(string message)
            : base(message)
        {
        }
    }
}
