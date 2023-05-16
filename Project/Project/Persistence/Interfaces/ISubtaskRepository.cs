using System;
using Project.Models;
using System.Collections.Generic;

namespace Project.Persistence.Interfaces
{
    internal interface ISubtaskRepository
    {
        Exception CreateSubtaskTable();
        Exception AddSubstask(Subtask subtask);
        (Subtask, Exception) GetSubtaskById(int id);
        (IList<Subtask>, Exception) GetSubtasksByTask(int id);
    }
}
