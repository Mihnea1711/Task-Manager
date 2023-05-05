using Project.Business.Interfaces;
using Project.Models;
using Project.Persistence.Interfaces;
using System;
using System.Collections.Generic;

namespace Project.Business.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepository taskRepository;

        public TaskService() 
        {        
            this.taskRepository = new TaskRepository();
        }

        public Exception CreateTask(string taskName, string taskDescription, DateTime taskDeadline, string employeeUUID)
        {
            return this.taskRepository.CreateTask(taskName, taskDescription, taskDeadline, employeeUUID);
        }

        public (List<Task>, Exception) GetTasks()
        {
            return this.taskRepository.GetTasks();
        }

        public (List<Models.Task>, Exception) GetTasksByEmpUUID(string empUUID)
        {
            return this.taskRepository.GetTasksByEmpUUID(empUUID);
        }

        public Exception UpdateTaskDetails(int taskID, string taskTitle, string taskDescription, DateTime taskDeadline)
        {
            return this.taskRepository.UpdateTaskDetails(taskID, taskTitle, taskDescription, taskDeadline);
        }

        public Exception UpdateTaskProgress(int taskID, int progress)
        {
            return this.UpdateTaskProgress(taskID, progress);
        }

        public Exception UpdateTaskStatus(int taskID, string newStatus)
        {
            return this.taskRepository.UpdateTaskStatus(taskID, newStatus);
        }

        public Exception DeleteTask(int taskID)
        {
            return this.taskRepository.DeleteTask(taskID);
        }

        public Exception AssignTaskToEmployee(int taskID, string empUUID)
        {
            return this.taskRepository.AssignTaskToEmployee(taskID, empUUID);
        }

        public Exception UnassignTasksFromEmployee(string empUUID)
        {
            return this.taskRepository.UnassignTasksFromEmployee(empUUID);
        }
    }
}
