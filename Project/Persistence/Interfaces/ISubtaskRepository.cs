using System;
using System.Collections.Generic;

namespace Persistence
{
    public interface ISubtaskRepository
    {
        Exception CreateSubtaskTable();
        Exception AddSubstask(Subtask subtask);
        (Subtask, Exception) GetSubtaskById(int id);
        (IList<Subtask>, Exception) GetSubtasksByTask(int id);
        Exception DeleteSubtask(int id);
    }
}
