using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presenters.Interfaces
{
    public interface ITaskBuilder: IBuilder
    {
        //....
        void SetTitle(string title);
        void SetDescription(string title);
        void SetDeadline(DateTime deadline);
        void SetProgress(int progress);
        void SetStatus(string status);
    }
}
