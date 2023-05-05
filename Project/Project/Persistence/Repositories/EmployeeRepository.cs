using Project.Models;
using System;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project.Persistence.Interfaces
{
    public class EmployeeRepository : IEmployeeRepository
    {
        /// <summary>
        /// Class constructor. Checks the connection to the db and creates the employee table if it does not exist.
        /// </summary>
        public EmployeeRepository() {
            CheckConnection();

            CreateEmployeeTable();
        }

        /// <summary>
        /// Method to check the connection to the database. If the connection is not running, it opens the connection.
        /// </summary>
        private void CheckConnection()
        {
            if(Program.DbConnection == null)
            {
                Program.Connect();
            }
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
            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
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

            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
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

            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
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
        /// Method to retrieve employee data based on its username.
        /// </summary>
        /// <param name="username">Employee username.</param>
        /// <returns>Returns the employee data if it was found, otherwise null. 
        /// Also returns an exception in case an error happened while executing the statement.</returns>
        public (Employee, Exception) GetEmployeeByUsername(string username)
        {
            string stmt = $"SELECT * FROM employees WHERE username = '{username}'";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
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

        public (Employee, Exception) GetEmployeeByUuid(string employeeUUID)
        {
            string stmt = $"SELECT * FROM employees WHERE employeeuuid = '{employeeUUID}'";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
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
        /// Method to check if there is an employee account created with the username and password provided.
        /// </summary>
        /// <param name="username">Employee username.</param>
        /// <param name="password">Employee password</param>
        /// <returns>Returns the employee data model object in case the account was found, otherwise null. 
        /// Also returns an exception in case an error happened while exuting the statement.</returns>
        public (Employee, Exception) CheckEmployeeLogIn(string username, string password)
        {
            string stmt = $"SELECT * FROM employees WHERE username = '{username}' and password = '{password}'";

            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
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
}
