using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_System.Controller
{
    internal class MainController
    {
        private RichTextBox rtbDisplay;
        private List<String> user;

        public MainController(RichTextBox rtbDisplay, String StaffName)
        {
            this.rtbDisplay = rtbDisplay;
        }

        public MainController()
        {
        }

        public List<string> GetUser(string StaffName)
        {
            List<string> results = new List<string>();
            string query = $"SELECT * FROM Staff WHERE `StaffName` = @StaffName";

            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffName", StaffName);

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    results.Add(reader.GetValue(i)?.ToString());
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception($"Error executing query: {ex.Message}");
                    }
                }
            }
            user = results;
            return results;
        }

        public List<string> GetTable()
        {
            List<string> results = new List<string>();
            string query = "SHOW TABLES";
            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                results.Add(reader.GetString(0));
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception($"Error executing query: {ex.Message}");
                    }
                }
            }
            return results;
        }

        public List<string> GetTableStructure(string tableName)
        {
            List<string> results = new List<string>();
            string query = $"DESCRIBE `{tableName}`";

            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                results.Add(reader.GetString(0));
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception($"Error executing query: {ex.Message}");
                    }
                }
            }
            return results;
        }

        public List<string> GetSelectedItem(string tableName, string[] key = null, string column = "*", string criteria = null)
        {
            var queryBuilder = new StringBuilder($"SELECT {column} FROM `{tableName}`");

            if (key != null)
            {
                foreach (var k in key)
                {
                    string innerTable = null;

                    if (k == "ClientID")
                    {
                        innerTable = "clientinformation";
                    }
                    else if (k == "ProductID")
                    {
                        innerTable = "product";
                    }
                    if (innerTable != null)
                    {
                        queryBuilder.Append($" INNER JOIN `{innerTable}` ON `{tableName}`.`{k}` = `{innerTable}`.`{k}`");
                    }
                }

                if (!string.IsNullOrEmpty(criteria))
                {
                    queryBuilder.Append(criteria);
                }
            }

            string query = queryBuilder.ToString();
            Console.WriteLine(query);
            var results = new List<string>();

            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    results.Add(reader[i]?.ToString() ?? string.Empty);
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        // Log the exception
                        throw new Exception($"Error executing query: {ex.Message}");
                    }
                }
            }
            return results;
        }

        public List<List<string>> GetRecord(string tableName, string criteria = null)
        {
            List<List<string>> results = new List<List<string>>();
            string query = $"SELECT * FROM `{tableName}`";

            // Check if criteria contains ORDER BY (passed from the sorting)
            if (!String.IsNullOrEmpty(criteria) && !criteria.StartsWith("ORDER BY"))
            {
                query += $" WHERE {criteria}";
                Log("lookup_item", query);
            }
            else if (!String.IsNullOrEmpty(criteria)) // This is an ORDER BY clause
    {
                query += $" {criteria}";
            }

            rtbDisplay.SelectionColor = Color.Black;
            rtbDisplay.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - ");
            rtbDisplay.SelectionColor = Color.Orange;
            rtbDisplay.AppendText($" [LOOKUP] ");
            rtbDisplay.SelectionColor = Color.Purple;
            rtbDisplay.AppendText($"{query}{Environment.NewLine}");
            rtbDisplay.SelectionStart = rtbDisplay.Text.Length;
            rtbDisplay.ScrollToCaret();
            rtbDisplay.SelectionColor = rtbDisplay.ForeColor;
            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                List<string> row = new List<string>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row.Add(reader[i]?.ToString() ?? string.Empty);
                                }
                                results.Add(row);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception($"Error executing query: {ex.Message}");
                    }
                }
            }
            return results;
        }

        public void Log(string event_type, string event_content = "")
        {
            string query = "INSERT INTO `event` (`event_type`, `event_content`, `StaffID`) VALUES (@eventType, @eventContent, @StaffID);";

            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@eventType", event_type);
                    command.Parameters.AddWithValue("@eventContent", event_content);
                    command.Parameters.AddWithValue("@StaffID", user[0]);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception($"Error executing log query: {ex.Message}");
                    }
                }
            }
        }

        public void InsertRecord(string tableName, string values)
        {
            string query = $"INSERT INTO `{tableName}` VALUES ({values})";
            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        LogError(ex);
                        return;
                    }
                    rtbDisplay.SelectionColor = Color.Black;
                    rtbDisplay.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - ");
                    rtbDisplay.SelectionColor = Color.Green;
                    rtbDisplay.AppendText($" [INSERT] ");
                    rtbDisplay.SelectionColor = Color.Purple;
                    rtbDisplay.AppendText($"{query}{Environment.NewLine}");
                    rtbDisplay.SelectionStart = rtbDisplay.Text.Length;
                    rtbDisplay.ScrollToCaret();
                    Log("insert_item", query);
                }
            }
        }

        public void DeleteRecord(string tableName, String queryString)
        {
            string query = $"DELETE FROM `{tableName}` WHERE {queryString}";
            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        LogError(ex);
                        return;
                    }
                    rtbDisplay.SelectionColor = Color.Black;
                    rtbDisplay.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - ");
                    rtbDisplay.SelectionColor = Color.Red;
                    rtbDisplay.AppendText($" [DELETE] ");
                    rtbDisplay.SelectionColor = Color.Purple;
                    rtbDisplay.AppendText($"{query}{Environment.NewLine}");
                    rtbDisplay.SelectionStart = rtbDisplay.Text.Length;
                    rtbDisplay.ScrollToCaret();
                    Log("delete_item", query);
                }
            }
        }

        public void UpdateRecord(String tableName, String setsetClause, String whereClause)
        {
            string query = $"UPDATE `{tableName}` SET {setsetClause} WHERE {whereClause}";
            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        LogError(ex);
                        return;
                    }
                    rtbDisplay.SelectionColor = Color.Black;
                    rtbDisplay.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - ");
                    rtbDisplay.SelectionColor = Color.Brown;
                    rtbDisplay.AppendText($" [UPDATE] ");
                    rtbDisplay.SelectionColor = Color.Purple;
                    rtbDisplay.AppendText($"{query}{Environment.NewLine}");
                    rtbDisplay.SelectionStart = rtbDisplay.Text.Length;
                    rtbDisplay.ScrollToCaret();
                    Log("update_item", query);
                }
            }
        }

        private void LogError(MySqlException ex)
        {
            rtbDisplay.SelectionColor = Color.Black;
            rtbDisplay.AppendText($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - ");
            rtbDisplay.SelectionColor = Color.Red;
            rtbDisplay.AppendText($" [ERROR] ");
            rtbDisplay.SelectionColor = Color.Purple;
            rtbDisplay.AppendText($"{ex.Message}{Environment.NewLine}");
            rtbDisplay.SelectionStart = rtbDisplay.Text.Length;
            rtbDisplay.ScrollToCaret();
        }

        public List<string> GetFilteredRecord(string tableName, string columns, string orderBy = "")
        {
            List<string> results = new List<string>();
            string query = $"SELECT {columns} FROM `{tableName}` {orderBy}";

            rtbDisplay.SelectionColor = rtbDisplay.ForeColor;
            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    results.Add(reader.GetValue(i)?.ToString());
                                }
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception($"Error executing query: {ex.Message}");
                    }
                }
            }
            return results;
        }
    }
}