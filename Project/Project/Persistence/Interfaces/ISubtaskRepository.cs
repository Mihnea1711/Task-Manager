using System;
using Project.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
