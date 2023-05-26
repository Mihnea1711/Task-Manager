using System;
using System.Collections.Generic;

namespace Persistence
{
    public interface ISubtaskService
    {
        (bool, Exception) AddSubstask(string title, string description, string status, int taskId, string employeeId);

        (Subtask, Exception) GetSubtaskById(int subtaskId);

        (IList<Subtask>, Exception) GetSubtasksByTask(int taskId);

        Exception DeleteSubtask(int id);
    }
}
