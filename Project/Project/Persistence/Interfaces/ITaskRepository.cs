﻿using System;
using System.Collections.Generic;
using Project.Models;

namespace Project.Persistence.Interfaces
{
    public interface ITaskRepository
    {
        Exception CreateTaskTable();

        Exception CreateTask(string taskName, string taskDescription, DateTime taskDeadline, string employeeUUID);

        (Task, Exception) GetTask(int taskID);

        (List<Task>, Exception) GetTasks();

        (List<Task>, Exception) GetTasksByEmpUUID(string empUUID);

        Exception UpdateTaskDetails(int taskID, string taskTitle, string taskDescription, DateTime taskDeadline);

        Exception UpdateTaskStatus(int taskID, string newStatus);

        Exception UpdateTaskProgress(int taskID, int progress);

        Exception DeleteTask(int taskID);

        Exception UnassignTasksFromEmployee(string empUUID);

        Exception AssignTaskToEmployee(int taskID, string empUUID);
    }
}
