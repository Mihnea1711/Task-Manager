using Project.Models;
using System;
using System.Collections.Generic;

namespace Project.Persistence.Interfaces
{
    public interface IEmployeeRepository
    {
        Exception CreateEmployeeTable();
        (bool, Exception) IsValidUsername(string username);
        Exception RegisterUser(Employee employee);
        (List<Employee>, Exception) GetEmployees();
        (Employee, Exception) GetEmployeeByUuid(string employeeUUID);
        (Employee, Exception) GetEmployeeByUsername(string username);
        (Employee, Exception) CheckEmployeeLogIn(string username, string password);
        (List<Employee>, Exception) SearchEmployeesByName(string name);
        Exception UpdateEmployee(string uuid, string firstName, string lastName, string email, string phoneNr);
        Exception DeleteEmployee(string uuid);
        //(int, Exception) UpdateTasksDone(string uuid);
    }
}
