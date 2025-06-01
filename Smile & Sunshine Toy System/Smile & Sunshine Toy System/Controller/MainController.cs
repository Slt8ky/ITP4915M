using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_System.Controller
{
    public class MainController
    {
        // Method to get table names
        public string[] GetTableNames()
        {
            List<string> tables = new List<string>();
            var connection = Database.Instance.GetConnection();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Open the connection if it is closed
                }

                string query = "SHOW TABLES;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tables.Add(reader[0].ToString());
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle database exceptions (optional)
                throw new Exception($"Error retrieving table names: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Close the connection
                }
            }

            return tables.ToArray();
        }

        // Method to get column names from a specific table
        public string[] GetColumnNames(string tableName)
        {
            List<string> columns = new List<string>();
            var connection = Database.Instance.GetConnection();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Open the connection if it is closed
                }

                string query = $"SHOW COLUMNS FROM `{tableName}`;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columns.Add(reader["Field"].ToString());
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle database exceptions (optional)
                throw new Exception($"Error retrieving column names from {tableName}: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); // Close the connection
                }
            }

            return columns.ToArray();
        }

        // Method to load data from a specified table
        public DataTable LoadData(string tableName)
        {
            var dataTable = new DataTable();
            var connection = Database.Instance.GetConnection();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = $"SELECT * FROM `{tableName}`;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable); // Fill the DataTable with the fetched data
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(tableName + " " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return dataTable; // Return the populated DataTable
        }

        public void DeleteRecord(string tableName, string column, string id)
        {
            var connection = Database.Instance.GetConnection();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Use the column name directly in the query
                string query = $"DELETE FROM `{tableName}` WHERE `{column}` = @id;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(tableName + " " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void UpdateRecord(string tableName, string[] columns, string[] values, string id)
        {
            var connection = Database.Instance.GetConnection();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Construct the SET part of the query
                string setClause = string.Join(", ", columns.Select((col, index) => $"{col} = @value{index}"));

                string query = $"UPDATE `{tableName}` SET {setClause} WHERE `{columns[0]}` = @id;"; // Assuming first column is the primary key

                using (var command = new MySqlCommand(query, connection))
                {
                    // Add parameters for the values
                    for (int i = 0; i < values.Length; i++)
                    {
                        command.Parameters.AddWithValue($"@value{i}", values[i]);
                    }
                    command.Parameters.AddWithValue("@id", id); // Primary key parameter
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(tableName + " " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void InsertRecord(string tableName, string[] columns, string[] values)
        {
            var connection = Database.Instance.GetConnection();

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Construct the SET part of the query
                string setColumn = string.Join(", ", columns);
                string setValue = string.Join(", ", values);


                string query = $"INSERT INTO `{tableName}` ({setColumn}) VALUES ({setValue})"; // Assuming first column is the primary key
                Console.WriteLine(query); // Debugging line to check the query
                using (var command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(tableName + " " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}