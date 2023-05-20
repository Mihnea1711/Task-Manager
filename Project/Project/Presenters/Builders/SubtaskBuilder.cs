using Project.Presenters.Interfaces;
using System;
using System.Windows.Forms;

namespace Project.Presenters.Builders
{
    public class SubtaskBuilder : ISubtaskBuilder
    {
        // <summary>
        /// The final "product" of the builder.
        /// </summary>
        private DataGridViewRow subtaskRow;

        /// <summary>
        /// Method to retrieve the "product".
        /// </summary>
        /// <returns>Returns the actual data grid view row.</returns>
        public DataGridViewRow GetResult()
        {
            return subtaskRow;
        }

        /// <summary>
        /// Method to reset the data grid view row and to create a new one.
        /// </summary>
        public void Reset()
        {
            this.subtaskRow = new DataGridViewRow();
        }
        /// <summary>
        /// Method to set the subtask description in the row.
        /// </summary>
        /// <param name="description"></param>
        public void SetDescription(string description)
        {
            DataGridViewCell descriptionCell = new DataGridViewTextBoxCell();
            descriptionCell.Value = description;

            //custom styling
            //..
            //

            this.subtaskRow.Cells.Add(descriptionCell);
        }

        /// <summary>
        /// Method to set the subtask "See more" button in the row.
        /// </summary>
        public void SetGoToButton()
        {
            DataGridViewButtonCell btnCell = new DataGridViewButtonCell();
            btnCell.Value = "See More..";

            //custom styling
            //..
            //

            this.subtaskRow.Cells.Add(btnCell);
        }

        /// <summary>
        /// Method to set the subtask ID in the row.
        /// </summary>
        /// <param name="ID"></param>
        public void SetID(string ID)
        {
            DataGridViewTextBoxCell idCell = new DataGridViewTextBoxCell();
            idCell.Value = ID;

            //custom styling
            //..
            //

            this.subtaskRow.Cells.Add(idCell);
        }
        /// <summary>
        /// Method to set the subtask status in the row.
        /// </summary>
        /// <param name="status"></param>
        public void SetStatus(string status)
        {
            DataGridViewCell statusCell = new DataGridViewTextBoxCell();
            statusCell.Value = status;

            //custom styling
            //..
            //

            this.subtaskRow.Cells.Add(statusCell);
        }

        /// <summary>
        /// Method to set the subtask title in the row.
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title)
        {
            DataGridViewCell titleCell = new DataGridViewTextBoxCell();
            titleCell.Value = title;

            //custom styling
            //..
            //

            this.subtaskRow.Cells.Add(titleCell);
        }
    }
}
