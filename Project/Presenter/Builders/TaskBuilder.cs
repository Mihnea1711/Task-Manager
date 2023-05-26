using System;
using System.Windows.Forms;

namespace Presenters
{
    public class TaskBuilder: ITaskBuilder
    {
        /// <summary>
        /// The final "product" of the builder.
        /// </summary>
        private DataGridViewRow taskRow;

        /// <summary>
        /// Method to retrieve the "product".
        /// </summary>
        /// <returns>Returns the actual data grid view row.</returns>
        public DataGridViewRow GetResult()
        {
            return taskRow;
        }

        /// <summary>
        /// Method to reset the data grid view row and to create a new one.
        /// </summary>
        public void Reset()
        {
            this.taskRow = new DataGridViewRow();
        }

        /// <summary>
        /// Method to set the task deadline in the row.
        /// </summary>
        /// <param name="deadline"></param>
        public void SetDeadline(DateTime deadline)
        {
            DataGridViewTextBoxColumn deadlineColumn = new DataGridViewTextBoxColumn();
            DataGridViewCell deadlineCell = new DataGridViewTextBoxCell();
            deadlineCell.Value = deadline.ToString("dd/MM/yyyy");

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(deadlineCell);
        }

        /// <summary>
        /// Method to set the task description in the row.
        /// </summary>
        /// <param name="description"></param>
        public void SetDescription(string description)
        {
            DataGridViewCell descriptionCell = new DataGridViewTextBoxCell();
            descriptionCell.Value = description;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(descriptionCell);
        }

        /// <summary>
        /// Method to set the task "See more" button in the row.
        /// </summary>
        public void SetGoToButton()
        {
            DataGridViewButtonCell btnCell = new DataGridViewButtonCell();
            btnCell.Value = "See More..";

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(btnCell);
        }

        /// <summary>
        /// Method to set the task ID in the row.
        /// </summary>
        /// <param name="ID"></param>
        public void SetID(string ID)
        {
            DataGridViewTextBoxCell idCell = new DataGridViewTextBoxCell();
            idCell.Value = ID;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(idCell);
        }

        /// <summary>
        /// Method to set the task progress in the row.
        /// </summary>
        /// <param name="progress"></param>
        public void SetProgress(int progress)
        {
            DataGridViewCell progressCell = new DataGridViewTextBoxCell();
            progressCell.Value = progress;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(progressCell);
        }

        /// <summary>
        /// Method to set the task status in the row.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatus(string status)
        {
            DataGridViewCell statusCell = new DataGridViewTextBoxCell();
            statusCell.Value = status;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(statusCell);
        }

        /// <summary>
        /// Method to set the task title in the row.
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title)
        {
            DataGridViewCell titleCell = new DataGridViewTextBoxCell();
            titleCell.Value = title;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(titleCell);
        }
    }
}
