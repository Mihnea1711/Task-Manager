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
    public interface ISubtaskService
    {
        (bool, Exception) AddSubstask(string title, string description, string status, int taskId, string employeeId);

        (Subtask, Exception) GetSubtaskById(int subtaskId);

        (IList<Subtask>, Exception) GetSubtasksByTask(int taskId);

        Exception DeleteSubtask(int id);
    }
}
