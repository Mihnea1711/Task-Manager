using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Presenters.Interfaces
{
    public interface IEmployeeBuilder: IBuilder
    {
        void SetName(string name);
        void SetEmail(string email);
        void SetPhoneNr(string phoneNr);
    }
}
