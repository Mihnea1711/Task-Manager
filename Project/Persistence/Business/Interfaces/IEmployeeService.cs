
using System;
using System.Collections.Generic;

namespace Persistence
{
    public interface IEmployeeService
    {
        (bool, Exception) ValidateUsername(string username);
        (Employee, Exception) RegisterUser(string username, string password, string firstName, string lastName, string email, string phoneNr);
        (Employee, Exception) CheckEmployeeLogIn(string username, string password);
        (List<Employee>, Exception) GetEmployees();
        (Employee, Exception) GetEmployeeByUUID(string uuid);
        (Employee, Exception) GetEmployeeByUsername(string username);
        (List<Employee>, Exception) SearchEmployeesByName(string name);
        Exception UpdateEmployee(string uuid, string firstName, string lastName, string email, string phoneNr);
        Exception DeleteEmployee(string uuid);
    }
}
