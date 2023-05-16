using Project.Business.Interfaces;
using Project.Models;
using Project.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Project.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        /// <summary>
        /// Instance of the EmployeeRepository class that handles the database operations.
        /// </summary>
        private IEmployeeRepository employeeRepository;

        /// <summary>
        /// Constructor. Initializes the employee repository instance.
        /// </summary>
        public EmployeeService() {
            this.employeeRepository = new EmployeeRepository();
        }

        /// <summary>
        /// Calls the employee repository class to check if the username is available.
        /// </summary>
        /// <param name="username">Employee username</param>
        /// <returns>>Returns true if the username is valid, otherwise false. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (bool, Exception) ValidateUsername(string username)
        {
            return this.employeeRepository.IsValidUsername(username);
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
            Exception exception = this.employeeRepository.RegisterUser(employee);
            if (exception != null) {
                return (null, exception);
            }

            // return its uuid just to check that it is stored
            (Employee employeeFromDB, Exception ex) = this.employeeRepository.GetEmployeeByUsername(username);
            if (ex != null)
            {
                return (null, ex);
            }

            // if it doesn't match
            if(employeeFromDB.UUID != uuid.ToString()) 
            {
                return (null, new Exception("something went wrong trying to get the uuid from the db. match error"));
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

            return this.employeeRepository.CheckEmployeeLogIn(username, encyptedPass);
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

        public (List<Employee>, Exception) GetEmployees()
        {
            return this.employeeRepository.GetEmployees();
        }

        public (Employee, Exception) GetEmployeeByUUID(string uuid)
        {
            return this.employeeRepository.GetEmployeeByUuid(uuid);
        }

        public (Employee, Exception) GetEmployeeByUsername(string username)
        {
            return this.employeeRepository.GetEmployeeByUsername(username);
        }

        public (List<Employee>, Exception) SearchEmployeesByName(string name)
        {
            return this.employeeRepository.SearchEmployeesByName(name);
        }

        public Exception UpdateEmployee(string uuid, string firstName, string lastName, string email, string phoneNr)
        {
            return this.employeeRepository.UpdateEmployee(uuid, firstName, lastName, email, phoneNr);
        }

        public Exception DeleteEmployee(string uuid)
        {
            return this.employeeRepository.DeleteEmployee(uuid);
        }
    }
}
