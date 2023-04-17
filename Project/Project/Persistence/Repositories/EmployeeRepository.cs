using Project.Models;
using System;
using System.Data.SQLite;
using System.Diagnostics;

namespace Project.Persistence.Interfaces
{
    public class EmployeeRepository
    {
        public EmployeeRepository() {
            CheckConnection();

            CreateEmployeeTable();
        }

        private void CheckConnection()
        {
            if(Program.DbConnection == null)
            {
                Program.Connect();
            }
        }

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

        public Exception RegisterUser(Employee employee)
        {
            string stmt = $"INSERT INTO employees(employeeuuid, username, password, firstname, lastname, email, phonenr) VALUES ('{employee.UUID}', '{employee.Username}', '{employee.Password}', '{employee.FirstName}', " +
                $"'{employee.LastName}', '{employee.Email}', '{employee.Phone}')";

            SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection);
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

        public (string, Exception) GetUUIDByUsername(string username)
        {
            string stmt = $"SELECT employeeuuid FROM employees WHERE username = '{username}'";
            using (SQLiteCommand cmd = new SQLiteCommand(stmt, Program.DbConnection))
            {
                try
                {
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        string uuid = "";
                        while (dataReader.Read())
                        {
                            uuid = dataReader.GetString(0);
                        }
                        if (uuid == "") return ("", new QueryForUUIDException("uuid is empty"));
                        return (uuid, null);
                    }

                }
                catch (Exception ex)
                {
                    return ("", new QueryForUUIDException(ex.Message));
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

        class RegisterEmployeeException : Exception
        {
            public RegisterEmployeeException(string message)
                : base(message)
            {
            }
        }

        class QueryForUUIDException : Exception
        {
            public QueryForUUIDException(string message)
                : base(message)
            {
            }
        }
    }
}
