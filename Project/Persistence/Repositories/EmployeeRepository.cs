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
using System.Data.SQLite;

namespace Persistence
{
    public class EmployeeRepository : IEmployeeRepository
    {   
        /// <summary>
        /// The main connection to the database of the application
        /// </summary>
        private static SQLiteConnection dbConnection;

        /// <summary>
        /// The connection string of the db
        /// </summary>
        private static string dbConnectionString = "Data Source=project.db;Version=3;";

        /// <summary>
        /// Method of the application to connect to the db
        /// </summary>
        public static void Connect()
        {
            dbConnection = new SQLiteConnection(dbConnectionString);
            dbConnection.Open();
        }

        /// <summary>
        /// Method to check the connection to the database. If the connection is not running, it opens the connection.
        /// </summary>
        private void CheckConnection()
        {
            if (dbConnection == null)
            {
                Connect();
            }
        }

        /// <summary>
        /// Class constructor. Checks the connection to the db and creates the employee table if it does not exist.
        /// </summary>
        public EmployeeRepository() {
            CheckConnection();

            CreateEmployeeTable();
        }

        /// <summary>
        /// Method to create the employee table in the database, in case it is not created yet.
        /// </summary>
        /// <returns>Returns an exception if the statement did not execute properly.</returns>
        public Exception CreateEmployeeTable()
        {
            string stmt = "" +
                "CREATE TABLE IF NOT EXISTS employees (" +
                    "employeeuuid VARCHAR2(150) PRIMARY KEY," +
                    "username     VARCHAR2(50) UNIQUE NOT NULL," +
                    "password     VARCHAR2(50) NOT NULL," +
                    "firstname    VARCHAR2(50) NOT NULL," +
                    "lastname     VARCHAR2(50) NOT NULL," +
                    "email        VARCHAR2(50) NOT NULL," +
                    "phonenr      VARCHAR2(50) NOT NULL," +
                    "tasksdone    NUMBER(3) DEFAULT 0" +
                ");";
            SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            } catch (Exception ex)
            {
                return new EmployeeTableCreationException(ex.Message);
            }            
        }

        /// <summary>
        /// Method to check if there is already an employee with this username in the database.
        /// </summary>
        /// <param name="username">Employee username.</param>
        /// <returns>Returns true if the username is valid, otherwise false. 
        /// Also returns an exception if an error happened while executing the statement.</returns>
        public (bool, Exception) IsValidUsername(string username) 
        {
            string stmt = $"SELECT * FROM employees where username = '{username}'";

            using (SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        return (!dataReader.HasRows, null);
                    }
                } catch (Exception ex)
                {
                    return (false, new ValidateUsernameException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to add an employee to the database.
        /// </summary>
        /// <param name="employee">Employee data model.</param>
        /// <returns>Returns an exception if an error happened while executing the statement.</returns>
        public Exception RegisterUser(Employee employee)
        {
            string stmt = $"INSERT INTO employees(employeeuuid, username, password, firstname, lastname, email, phonenr) VALUES ('{employee.UUID}', '{employee.Username}', '{employee.Password}', '{employee.FirstName}', " +
                $"'{employee.LastName}', '{employee.Email}', '{employee.Phone}')";

            using (SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection))
            {
                try
                {
                    cmd.ExecuteNonQuery();

                    return null;
                }
                catch (Exception ex)
                {
                    return new RegisterEmployeeException(ex.Message);
                }
            }
        }

        /// <summary>
        /// Method to retrieve all employees from db
        /// </summary>
        /// <returns>Returns the employees objects if any, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (List<Employee>, Exception) GetEmployees()
        {
            string stmt = $"SELECT * FROM employees";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        List<Employee> employees = new List<Employee>();
                        while (dataReader.Read())
                        {
                            string employeeUUID = dataReader.GetString(0);
                            string employeeUsername = dataReader.GetString(1);
                            string employeePassword = dataReader.GetString(2);
                            string employeeFName = dataReader.GetString(3);
                            string employeeLName = dataReader.GetString(4);
                            string employeeEmail = dataReader.GetString(5);
                            string employeePhoneNr = dataReader.GetString(6);
                            int employeeTasksDone = dataReader.GetInt32(7);

                            Employee employee = new Employee(employeeUUID, employeeUsername, employeePassword, employeeFName, employeeLName, employeeEmail, employeePhoneNr, employeeTasksDone);
                            employees.Add(employee);
                        }
                        return (employees, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForEmployeeException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to retrieve employee data based on its username.
        /// </summary>
        /// <param name="username">Employee username.</param>
        /// <returns>Returns the employee data if it was found, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (Employee, Exception) GetEmployeeByUsername(string username)
        {
            string stmt = $"SELECT * FROM employees WHERE username = '{username}'";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        Employee employee = null;
                        while (dataReader.Read())
                        {
                            string employeeUUID = dataReader.GetString(0);
                            string employeeUsername = dataReader.GetString(1);
                            string employeePassword = dataReader.GetString(2);
                            string employeeFName = dataReader.GetString(3);
                            string employeeLName = dataReader.GetString(4);
                            string employeeEmail = dataReader.GetString(5);
                            string employeePhoneNr = dataReader.GetString(6);
                            int employeeTasksDone = dataReader.GetInt32(7);

                            employee = new Employee(employeeUUID, employeeUsername, employeePassword, employeeFName, employeeLName, employeeEmail, employeePhoneNr, employeeTasksDone);
                        }
                        if (employee == null) throw new Exception("employee is null");
                        return (employee, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForEmployeeException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to retrieve an employee data model based on its uuid.
        /// </summary>
        /// <param name="uuid"></param>
        /// <returns>Returns the employee data object if found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (Employee, Exception) GetEmployeeByUuid(string employeeUUID)
        {
            string stmt = $"SELECT * FROM employees WHERE employeeuuid = '{employeeUUID}'";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        Employee employee = null;
                        while (dataReader.Read())
                        {
                            string employeeUsername = dataReader.GetString(1);
                            string employeePassword = dataReader.GetString(2);
                            string employeeFName = dataReader.GetString(3);
                            string employeeLName = dataReader.GetString(4);
                            string employeeEmail = dataReader.GetString(5);
                            string employeePhoneNr = dataReader.GetString(6);
                            int employeeTasksDone = dataReader.GetInt32(7);

                            employee = new Employee(employeeUUID, employeeUsername, employeePassword, employeeFName, employeeLName, employeeEmail, employeePhoneNr, employeeTasksDone);
                        }
                        if (employee == null) throw new Exception("employee is null");
                        return (employee, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForEmployeeException(ex.Message));
                }
            }
        }

        /// <summary>
        /// Method to retrieve all employees from db matching the string given as parameter. The search is case-insensitive.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns the employees objects if any, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (List<Employee>, Exception) SearchEmployeesByName(string name)
        {
            string stmt = $"SELECT * FROM employees WHERE LOWER(firstname) || ' ' || LOWER(lastname) LIKE '%{name}%';";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        List<Employee> employees = new List<Employee>();
                        while (dataReader.Read())
                        {
                            string employeeUUID = dataReader.GetString(0);
                            string employeeUsername = dataReader.GetString(1);
                            string employeePassword = dataReader.GetString(2);
                            string employeeFName = dataReader.GetString(3);
                            string employeeLName = dataReader.GetString(4);
                            string employeeEmail = dataReader.GetString(5);
                            string employeePhoneNr = dataReader.GetString(6);
                            int employeeTasksDone = dataReader.GetInt32(7);

                            Employee employee = new Employee(employeeUUID, employeeUsername, employeePassword, employeeFName, employeeLName, employeeEmail, employeePhoneNr, employeeTasksDone);
                            employees.Add(employee);
                        }
                        return (employees, null);
                    }

                }
                catch (Exception ex)
                {
                    return (null, new QueryForEmployeeException(ex.Message));
                }
            }
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
            string stmt = $"" +
                $"UPDATE employees " +
                $"SET firstname = '{firstName}', lastname = '{lastName}', email = '{email}', phonenr = '{phoneNr}' " +
                $"WHERE employeeuuid = '{uuid}';";
            SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new EmployeeUpdateException(ex.Message);
            }
        }

        /// <summary>
        /// Method to delete an employee account.
        /// </summary>
        /// <param name="uuid"></param>
        /// <returns>Returns an exception in case an error happened while exuting the statement.</returns>
        public Exception DeleteEmployee(string uuid)
        {
            string stmt = $"" +
            $"DELETE FROM employees " +
                $"WHERE employeeuuid = '{uuid}';";
            SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new EmployeeDeleteException(ex.Message);
            }
        }

        /// <summary>
        /// Method to check if there is an employee account created with the username and password provided.
        /// </summary>
        /// <param name="username">Employee username.</param>
        /// <param name="password">Employee password</param>
        /// <returns>Returns the employee data model object in case the account was found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (Employee, Exception) CheckEmployeeLogIn(string username, string password)
        {
            string stmt = $"SELECT * FROM employees WHERE username = '{username}' and password = '{password}'";

            using (SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        Employee employee = null;
                        while (dataReader.Read())
                        {
                            string employeeUUID = dataReader.GetString(0);
                            string employeeUsername = dataReader.GetString(1);
                            string employeePassword = dataReader.GetString(2);
                            string employeeFName = dataReader.GetString(3);
                            string employeeLName = dataReader.GetString(4);
                            string employeeEmail = dataReader.GetString(5);
                            string employeePhoneNr = dataReader.GetString(6);
                            int employeeTasksDone = dataReader.GetInt32(7);

                            employee = new Employee(employeeUUID, employeeUsername, employeePassword, employeeFName, employeeLName, employeeEmail, employeePhoneNr, employeeTasksDone);
                        }
                        if (employee == null) throw new Exception("employee is null");
                        return (employee, null);
                    }
                }
                catch (Exception ex)
                {
                    return (null, new LogInException(ex.Message));
                }
            }
        }

        public Exception UpdateEmployeeTasksDone(string uuid, int tasksDone)
        {
            string stmt = $"" +
                $"UPDATE employees " +
                $"SET tasksdone = {tasksDone} " +
                $"WHERE employeeuuid = '{uuid}';";
            SQLiteCommand cmd = new SQLiteCommand(stmt, dbConnection);
            try
            {
                cmd.ExecuteNonQuery();

                return null;
            }
            catch (Exception ex)
            {
                return new EmployeeTasksDoneException(ex.Message);
            }
        }
    }


    class EmployeeTableCreationException : Exception
    {
        public EmployeeTableCreationException(string message)
            : base(message)
        {
        }
    }

    class ValidateUsernameException : Exception
    {
        public ValidateUsernameException(string message)
            : base(message)
        {
        }
    }

    class LogInException: Exception
    {
        public LogInException(string message)
            : base(message)
        {
        }
    }

    class RegisterEmployeeException : Exception
    {
        public RegisterEmployeeException(string message)
            : base(message)
        {
        }
    }

    class QueryForEmployeeException : Exception
    {
        public QueryForEmployeeException(string message)
            : base(message)
        {
        }
    }

    class GetTasksException : Exception
    {
        public GetTasksException(string message)
            : base(message)
        {
        }
    }

    class EmployeeUpdateException : Exception
    {
        public EmployeeUpdateException(string message)
            : base(message)
        {
        }
    }

    class EmployeeTasksDoneException : Exception
    {
        public EmployeeTasksDoneException(string message)
            : base(message)
        {
        }
    }    

    class EmployeeDeleteException : Exception
    {
        public EmployeeDeleteException(string message)
            : base(message)
        {
        }
    }
}

