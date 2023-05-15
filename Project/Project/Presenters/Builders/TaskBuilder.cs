using Project.Models;
using Project.Presenters.Interfaces;
using System;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project.Presenters.Builders
{
    public class TaskBuilder: ITaskBuilder
    {
        private DataGridViewRow taskRow;

        public DataGridViewRow GetResult()
        {
            return taskRow;
        }

        public void Reset()
        {
            this.taskRow = new DataGridViewRow();
        }

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

        public void SetDescription(string description)
        {
            DataGridViewCell descriptionCell = new DataGridViewTextBoxCell();
            descriptionCell.Value = description;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(descriptionCell);
        }

        public void SetGoToButton()
        {
            DataGridViewButtonCell btnCell = new DataGridViewButtonCell();
            btnCell.Value = "See More..";

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(btnCell);
        }

        public void SetID(string ID)
        {
            DataGridViewTextBoxCell idCell = new DataGridViewTextBoxCell();
            idCell.Value = ID;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(idCell);
        }

        public void SetProgress(int progress)
        {
            DataGridViewCell progressCell = new DataGridViewTextBoxCell();
            progressCell.Value = progress;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(progressCell);
        }

        public void SetStatus(string status)
        {
            DataGridViewCell statusCell = new DataGridViewTextBoxCell();
            statusCell.Value = status;

            //custom styling
            //..
            //

            this.taskRow.Cells.Add(statusCell);
        }

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
