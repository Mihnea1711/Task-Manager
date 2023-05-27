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
    public class SubtaskService : ISubtaskService
    {
        /// <summary>
        /// Instance of the SubtaskRepository class that handles the database operations.
        /// </summary>
        private SubtaskRepository subtaskRepository;

        /// <summary>
        /// Constructor. Initializes the subtask repository instance.
        /// </summary>
        public SubtaskService()
        {
            this.subtaskRepository = new SubtaskRepository();
        }

        /// <summary>
        /// Calls the subtask repository class to add a subtask.
        /// </summary>
        /// <param name="title">Subtask title</param>
        /// <param name="description">Subtask description</param>
        /// <param name="status">Subtask status</param>
        /// <param name="taskId">Subtask's parent(task) id</param>
        /// <param name="employeeId">The employee id of the given subtask</param>
        /// <returns>>Returns true if the subtask was added successfully , otherwise false. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (bool, Exception) AddSubstask(string title, string description, string status, int taskId, string employeeId)
        {
            // create the subtask model
            Subtask subtask = new Subtask(0,title, description, status, taskId, employeeId);

            // store subtask in db
            Exception exception = this.subtaskRepository.AddSubstask(subtask);
            if (exception != null)
            {
                return (false, exception);
            }

            return (true, null);
        }

        /// <summary>
        /// Method to retrieve a subtask data model based on its id.
        /// </summary>
        /// <param name="subtaskId"></param>
        /// <returns>Returns the subtask data object if found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (Subtask, Exception) GetSubtaskById(int subtaskId)
        {
            (Subtask subtask, Exception exception) = subtaskRepository.GetSubtaskById(subtaskId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (subtask, null);
        }

        /// <summary>
        /// Method to retrieve all the subtask data models based on its (parent)task id.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns>Returns a list of subtask data objects if found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (IList<Subtask>, Exception) GetSubtasksByTask(int taskId)
        {
            (IList<Subtask> subtasks, Exception exception) = subtaskRepository.GetSubtasksByTask(taskId);

            if (exception != null)
            {
                return (null, exception);
            }

            return (subtasks, null);
        }

        /// <summary>
        /// Method to change a subtask status based on its id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="selectedKey"></param>
        /// <returns>Returns true if the change was successfully done. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public Exception ChangeStatus(int id, string selectedKey)
        {
            return subtaskRepository.ChangeStatus(id, selectedKey);
        }

        /// <summary>
        /// Method to change the subtask details(name, description) based on its id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subtaskName"></param>
        /// <param name="subtaskDescription"></param>
        /// <returns>Returns true if the change was successfully done. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public Exception UpdateSubtaskDetails(int id, string subtaskName, string subtaskDescription)
        {
            return subtaskRepository.UpdateSubtaskDetails(id, subtaskName, subtaskDescription);
        }

        /// <summary>
        /// Method to delete a subtask based on its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns true if the delete was successfully done. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public Exception DeleteSubtask(int id)
        {
            return this.subtaskRepository.DeleteSubtask(id);
        }
    }
}
