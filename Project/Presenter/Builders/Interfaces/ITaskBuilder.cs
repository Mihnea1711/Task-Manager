using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenters
{
    public interface ITaskBuilder: IBuilder
    {
        void SetID(string ID);
        void SetTitle(string title);
        void SetDescription(string description);
        void SetDeadline(DateTime deadline);
        void SetProgress(int progress);
        void SetStatus(string status);
        void SetGoToButton();
    }
}
