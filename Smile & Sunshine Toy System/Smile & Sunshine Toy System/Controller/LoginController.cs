using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Smile___Sunshine_Toy_System.Controller
{
    internal class LoginController
    {
        List<String> user;

        public bool ValidateCredentials(string StaffName, string Password)
        {
            var hashedPassword = HashPassword(Password);
            var connection = Database.Instance.Connection;
            string query = "SELECT COUNT(*) FROM staff WHERE StaffName = @StaffName AND Password = @Password";

            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StaffName", StaffName);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                int result = Convert.ToInt32(command.ExecuteScalar());
                return result > 0; // Return true if login is successful
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant(); // Convert to hex string
            }
        }

        public List<string> GetUser(string StaffName)
        {
            List<string> results = new List<string>();
            string query = $"SELECT * FROM staff WHERE `StaffName` = @StaffName"; // Use parameterized query to prevent SQL injection

            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    // Use parameterized query
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
            Log();
            return results;
        }

        public void Log()
        {
            string query = "INSERT INTO `event` (`event_type`, `StaffID`) VALUES (@event_type, @StaffID);";

            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    // Using parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@event_type", "staff_login");
                    command.Parameters.AddWithValue("@StaffID", user[0]); // Ensure this is an integer if staff_id is an integer in the database

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        throw new Exception($"Error executing log query: {ex.StackTrace}");
                    }
                }
            }
        }
    }
}