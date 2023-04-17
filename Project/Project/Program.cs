using System;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Project
{
    public static class Program
    {
        private static SQLiteConnection dbConnection;
        private static string dbConnectionString = "Data Source=project.db;Version=3;";

        public static void Connect()
        {
            dbConnection = new SQLiteConnection(dbConnectionString);
            dbConnection.Open();
        }

        public static void CloseConnection()
        {
            if(dbConnection != null)
            {
                dbConnection.Close();
            }
        }

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
            // open connection to db
            try
            {
                Connect();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginPage());
            }
            finally
            {
                CloseConnection();
            }
        }


    }
}
