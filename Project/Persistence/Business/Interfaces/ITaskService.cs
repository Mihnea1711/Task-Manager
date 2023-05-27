/**************************************************************************
 *                                                                        *
 *  Description: Task Management Tool                    		          *
 *  Website Mihnea: https://github.com/Mihnea1711               	      *
 *  Website Robert: https://github.com/cioocan               	          *
 *  Copyright:   (c) 2023, Mihnea Bejinaru, Robert Ciocan                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;

namespace Persistence
{
    public interface ITaskService
    {
        Exception CreateTask(string taskName, string taskDescription, DateTime taskDeadline, string employeeUUID);

        (Task, Exception) GetTaskByID(int taskID);

        (List<Task>, Exception) GetAssignedTasks();

        (List<Task>, Exception) GetUnassignedTasks();

        (int, Exception) GetTasksDoneCount(string empUUID);

        (List<Task>, Exception) SearchAssignedTasksByName(string title);

        (List<Task>, Exception) SearchUnassignedTasksByName(string title);

        (List<Task>, Exception) GetTasksByEmpUUID(string empUUID);

        Exception UpdateTaskDetails(int taskID, string taskTitle, string taskDescription, DateTime taskDeadline, string assignedEmployeeUUID);

        Exception UpdateTaskStatus(int taskID, string newStatus);

        Exception UpdateTaskProgress(int taskID, int progress);

        Exception DeleteTask(int taskID);

        Exception UnassignTaskFromEmployee(string empUUID, int taskID);

        Exception UnassignTasksFromEmployee(string empUUID);

        Exception AssignTaskToEmployee(int taskID, string empUUID, DateTime deadline);

        Exception CheckSubtasksStatus(List<Subtask> subtasks);
    }
}
