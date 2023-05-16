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

        public (Task, Exception) GetTaskByID(int taskID)
        {
            return this.taskRepository.GetTaskByID(taskID);
        }

        public (List<Task>, Exception) GetAssignedTasks()
        {
            return this.taskRepository.GetAssignedTasks();
        }

        public (List<Task>, Exception) GetUnassignedTasks()
        {
            return this.taskRepository.GetUnassignedTasks();
        }

        public (List<Task>, Exception) SearchAssignedTasksByName(string title)
        {
            return this.taskRepository.SearchAssignedTasksByName(title);
        }

        public (List<Task>, Exception) SearchUnassignedTasksByName(string title)
        {
            return this.taskRepository.SearchUnassignedTasksByName(title);
        }

        public (List<Task>, Exception) GetTasksByEmpUUID(string empUUID)
        {
            return this.taskRepository.GetTasksByEmpUUID(empUUID);
        }

        public Exception UpdateTaskDetails(int taskID, string taskTitle, string taskDescription, DateTime taskDeadline)
        {
            return this.taskRepository.UpdateTaskDetails(taskID, taskTitle, taskDescription, taskDeadline);
        }

        public Exception UpdateTaskProgress(int taskID, int progress)
        {
            return this.taskRepository.UpdateTaskProgress(taskID, progress);
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

        public Exception UnassignTaskFromEmployee(string empUUID, int taskID)
        {
            return this.taskRepository.UnassignTaskFromEmployee(empUUID, taskID);
        }

        public Exception UnassignTasksFromEmployee(string empUUID)
        {
            return this.taskRepository.UnassignTasksFromEmployee(empUUID);
        }
    }
}
