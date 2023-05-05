using Project.Models;
using System;

namespace Project.Persistence.Interfaces
{
    public interface IEmployeeRepository
    {
        Exception CreateEmployeeTable();
        (bool, Exception) IsValidUsername(string username);
        Exception RegisterUser(Employee employee);
        (Employee, Exception) GetEmployeeByUuid(string employeeUUID);
        (Employee, Exception) GetEmployeeByUsername(string username);
        (Employee, Exception) CheckEmployeeLogIn(string username, string password);
    }
}
