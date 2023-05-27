﻿/**************************************************************************
 *                                                                        *
 *  Description: Task Management Tool                    		          *
 *  Website Mihnea: https://github.com/Mihnea1711               	      *
 *  Website Robert: https://github.com/cioocan               	          *
 *  Copyright:   (c) 2023, Mihnea Bejinaru, Robert Ciocan                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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
