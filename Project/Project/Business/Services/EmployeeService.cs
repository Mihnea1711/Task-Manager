using Project.Models;
using Project.Persistence.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Project.Business.Services
{
    public class EmployeeService
    {
        private EmployeeRepository employeeRepository;
        public EmployeeService() {
            this.employeeRepository = new EmployeeRepository();
        }

        public (bool, Exception) ValidateUsername(string username)
        {
            return this.employeeRepository.IsValidUsername(username);
        }

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

        public (string, Exception) RegisterUser(string username, string password, string firstName, string lastName, string email, string phoneNr)
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
                return ("", exception);
            }

            // return its uuid just to check that it is stored
            (string dbUUID, Exception ex) = this.employeeRepository.GetUUIDByUsername(username);
            if (ex != null)
            {
                return ("", ex);
            }

            // if it doesn't match
            if(dbUUID != uuid.ToString()) 
            {
                return ("", new Exception("something went wrong trying to get the uuid from the db. match error"));
            }

            return (dbUUID, null);
        }
    }
}
