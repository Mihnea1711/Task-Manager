using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Presenters.Interfaces
{
    public interface IEmployeeBuilder: IBuilder
    {

        void SetUsername(string username);
        void SetName(string name);
        void SetEmail(string email);
        void SetPhoneNr(string phoneNr);
        void SetGoToButton();
    }
}
