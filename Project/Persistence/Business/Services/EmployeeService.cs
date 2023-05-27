/**************************************************************************
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
using System.Security.Cryptography;
using System.Text;

namespace Persistence
{
    public class EmployeeService : IEmployeeService
    {
        /// <summary>
        /// Instance of the EmployeeRepository class that handles the database operations.
        /// </summary>
        private IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Constructor. Initializes the employee repository instance.
        /// </summary>
        public EmployeeService() {
            this._employeeRepository = new EmployeeRepository();
        }

        /// <summary>
        /// Calls the employee repository class to check if the username is available.
        /// </summary>
        /// <param name="username">Employee username</param>
        /// <returns>>Returns true if the username is valid, otherwise false. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (bool, Exception) ValidateUsername(string username)
        {
            return this._employeeRepository.IsValidUsername(username);
        }

        /// <summary>
        /// Method to register the employee. Creates an uuid for the employee and hashes the password.
        /// </summary>
        /// <param name="username">Employee username.</param>
        /// <param name="password">Employee not hashed password.</param>
        /// <param name="firstName">Employee first name.</param>
        /// <param name="lastName">Employee last name.</param>
        /// <param name="email">Employee email.</param>
        /// <param name="phoneNr">Employee phone number.</param>
        /// <returns>Returns the employee from the database after it is stored 
        /// and an exception in case an error happened while executing the statements.</returns>
        public (Employee, Exception) RegisterUser(string username, string password, string firstName, string lastName, string email, string phoneNr)
        {
            // create the uuid for the employee
            Guid uuid = Guid.NewGuid();

            // encrypt the password
            string encryptedPassword = EncryptPassword(password);

            // create the actual employee model
            Employee employee = new Employee(uuid.ToString(), username, encryptedPassword, firstName, lastName, email, phoneNr);

            // store employee in db
            Exception exception = this._employeeRepository.RegisterUser(employee);
            if (exception != null) {
                return (null, exception);
            }

            // return its uuid just to check that it is stored
            (Employee employeeFromDB, Exception ex) = this._employeeRepository.GetEmployeeByUsername(username);
            if (ex != null)
            {
                return (null, ex);
            }

            // if it doesn't match, throw exception
            if(employeeFromDB.UUID != uuid.ToString()) 
            {
                return (null, new EmployeeUUIDMacthException("something went wrong trying to get the uuid from the db. match error"));
            }

            return (employeeFromDB, null);
        }

        /// <summary>
        /// Method to check if there is an employee account created with the username and password provided. Encrypts the password and then checks the database.
        /// </summary>
        /// <param name="username">Employee username.</param>
        /// <param name="password">Employee not hashed password.</param>
        /// <returns>Returns the employee data model object in case the account was found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (Employee, Exception) CheckEmployeeLogIn(string username, string password)
        {
            string encyptedPass = EncryptPassword(password);

            return this._employeeRepository.CheckEmployeeLogIn(username, encyptedPass);
        }

        /// <summary>
        /// Method used to encrypt a password using SHA256 algorithm.
        /// </summary>
        /// <param name="password">Input password</param>
        /// <returns>Returns the hashed password.</returns>
        private string EncryptPassword(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (SHA256 sha256 = SHA256Managed.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                string hash = Convert.ToBase64String(hashBytes);

                return hash;
            }
        }

        /// <summary>
        /// Method to retrieve all employees from db
        /// </summary>
        /// <returns>Returns the employees objects if any, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (List<Employee>, Exception) GetEmployees()
        {
            return this._employeeRepository.GetEmployees();
        }

        /// <summary>
        /// Method to retrieve an employee data model based on its uuid.
        /// </summary>
        /// <param name="uuid"></param>
        /// <returns>Returns the employee data object if found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (Employee, Exception) GetEmployeeByUUID(string uuid)
        {
            return this._employeeRepository.GetEmployeeByUuid(uuid);
        }

        /// <summary>
        /// Method to retrieve an employee data model based on its username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Returns the employee data object if found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (Employee, Exception) GetEmployeeByUsername(string username)
        {
            return this._employeeRepository.GetEmployeeByUsername(username);
        }

        /// <summary>
        /// Method to retrieve all employees from db matching the string given as parameter. The search is case-insensitive.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns the employees objects if any, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (List<Employee>, Exception) SearchEmployeesByName(string name)
        {
            return this._employeeRepository.SearchEmployeesByName(name);
        }

        /// <summary>
        /// Method to update the employee details.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNr"></param>
        /// <returns>Returns an exception in case an error happened while exuting the statement.</returns>
        public Exception UpdateEmployee(string uuid, string firstName, string lastName, string email, string phoneNr)
        {
            return this._employeeRepository.UpdateEmployee(uuid, firstName, lastName, email, phoneNr);
        }

        /// <summary>
        /// Method to delete an employee account.
        /// </summary>
        /// <param name="uuid"></param>
        /// <returns>Returns an exception in case an error happened while exuting the statement.</returns>
        public Exception DeleteEmployee(string uuid)
        {
            return this._employeeRepository.DeleteEmployee(uuid);
        }
    }

    class EmployeeNameException : Exception
    {
        public EmployeeNameException(string message)
            : base(message)
        {
        }
    }

    class EmployeeEmailException : Exception
    {
        public EmployeeEmailException(string message)
            : base(message)
        {
        }
    }

    class EmployeeUUIDMacthException : Exception
    {
        public EmployeeUUIDMacthException(string message)
            : base(message)
        {
        }
    }
}

