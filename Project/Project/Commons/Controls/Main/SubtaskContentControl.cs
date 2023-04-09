using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class SubtaskContentControl : UserControl
    {
        public SubtaskContentControl()
        {
            InitializeComponent();
        }

        private void SubtaskContentControl_Load(object sender, EventArgs e)
        {
            // Step 5: Create a connection string to your database
            string connectionString = "Data Source=project.db;Version=3;";

            // Step 6: Write a SELECT statement to retrieve data
            string selectStatement = "SELECT * FROM comments";

            Console.WriteLine(selectStatement);

            // Step 7: Create a SQLiteDataAdapter object
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectStatement, connectionString);

            // Step 8: Create a new DataTable object
            DataTable dataTable = new DataTable();

            // Step 9: Fill the DataTable with the data
            dataAdapter.Fill(dataTable);

            // Step 10: Set the DataSource property of the DataGridView control
            dataGridViewComments.DataSource = dataTable;
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {

        }
    }
}
