using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Project.Controls
{
    public partial class TasksContentControl : UserControl
    {
        public TasksContentControl()
        {
            InitializeComponent();
        }

        private void TasksContentControl_Load(object sender, EventArgs e)
        {
            // Step 5: Create a connection string to your database
            string connectionString = "Data Source=beer.db;Version=3;";

            // Step 6: Write a SELECT statement to retrieve data
            string selectStatement = "SELECT * FROM beers";

            // Step 7: Create a SQLiteDataAdapter object
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectStatement, connectionString);

            // Step 8: Create a new DataTable object
            DataTable dataTable = new DataTable();

            // Step 9: Fill the DataTable with the data
            dataAdapter.Fill(dataTable);

            var comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "My ComboBox Column";
            comboBoxColumn.Name = "MyComboBoxColumn";
            comboBoxColumn.DataPropertyName = "MyComboBoxColumnData";
            comboBoxColumn.DataSource = new List<string> { "Option 1", "Option 2", "Option 3" };

            // Step 10: Set the DataSource property of the DataGridView control
            dataGridView1.DataSource = dataTable;

            // Add the column to the DataGridView control
            dataGridView1.Columns.Add(comboBoxColumn);
        }
    }
}
