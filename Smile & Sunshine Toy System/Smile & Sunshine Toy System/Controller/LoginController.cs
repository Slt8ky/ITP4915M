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

        public bool ValidateCredentials(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            var connection = Database.Instance.Connection;

            string query = "SELECT COUNT(*) FROM staff WHERE username = @username AND password = @password";

            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPassword);

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

        public List<string> GetUser(string username)
        {
            List<string> results = new List<string>();
            string query = $"SELECT * FROM STAFF WHERE `username` = @username"; // Use parameterized query to prevent SQL injection

            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    // Use parameterized query
                    command.Parameters.AddWithValue("@username", username);

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
            string query = "INSERT INTO `event` (`event_type`, `staff_id`) VALUES (@eventType, @staffId);";

            using (var connection = Database.Instance.Connection)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    // Using parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@eventType", "login");
                    command.Parameters.AddWithValue("@staffId", user[0]); // Ensure this is an integer if staff_id is an integer in the database

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
    }
}