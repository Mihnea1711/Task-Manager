
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenters
{
    public interface ICommentBuilder: IBuilder
    {
        void SetTitle(string title);
        void SetDescription(string description);
        void SetTimeReported(int timeReported);
    }
}
