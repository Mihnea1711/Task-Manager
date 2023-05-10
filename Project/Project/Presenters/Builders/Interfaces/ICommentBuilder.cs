using Project.Presenters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Presenters.Builders.Interfaces
{
    public interface ICommentBuilder: IBuilder
    {
        void setTitle(string title);
        void setDescription(string description);
        void setDatePosted(DateTime datePosted);
        void setTimeReported(int timeReported);

        
    }
}
