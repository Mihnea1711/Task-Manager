using Project.Models;
using Project.Presenters.Interfaces;
using System;
using System.Windows.Forms;

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
            throw new NotImplementedException();
        }

        public void SetDeadline(DateTime deadline)
        {
            throw new NotImplementedException();
        }

        public void SetDescription(string title)
        {
            throw new NotImplementedException();
        }

        public void SetProgress(int progress)
        {
            throw new NotImplementedException();
        }

        public void SetStatus(string status)
        {
            throw new NotImplementedException();
        }

        public void SetTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
