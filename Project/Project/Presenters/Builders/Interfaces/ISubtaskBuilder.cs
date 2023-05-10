using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Presenters.Interfaces
{
    public interface ISubtaskBuilder: IBuilder
    {
        void SetTitle(string title);
        void SetDescription(string title);
    }
}
