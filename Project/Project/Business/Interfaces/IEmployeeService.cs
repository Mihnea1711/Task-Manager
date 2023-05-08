using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Interfaces
{
    public interface IEmployeeService
    {
        (bool, Exception) ValidateUsername(string username);

        (Employee, Exception) RegisterUser(string username, string password, string firstName, string lastName, string email, string phoneNr);

        (Employee, Exception) CheckEmployeeLogIn(string username, string password);
    }
}
