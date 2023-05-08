using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Project
{
    public static class Program
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
        /// Method of the application to close the db connection
        /// </summary>
        public static void CloseConnection()
        {
            if(dbConnection != null)
            {
                dbConnection.Close();
            }
        }

        /// <summary>
        /// Getter -> retrieves the on-going db connection
        /// </summary>
        public static SQLiteConnection DbConnection
        {
            get { return dbConnection; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            try
            {
                // open connection to db
                Connect();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginPage());
            }
            finally
            {
                // at the end, close the connection
                CloseConnection();
            }
        }


    }
}
