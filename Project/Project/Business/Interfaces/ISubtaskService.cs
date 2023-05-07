using System;
using System.Collections.Generic;
using Project.Models;

namespace Project.Business.Interfaces
{
    internal interface ISubtaskService
    {
        (bool, Exception) AddSubstask(string title, string description, string status, DateTime deadline, int taskId, string employeeId);

        (Subtask, Exception) GetSubtaskById(int subtaskId);

        (IList<Subtask>, Exception) GetSubtasksByTask(int taskId);
    }
}
