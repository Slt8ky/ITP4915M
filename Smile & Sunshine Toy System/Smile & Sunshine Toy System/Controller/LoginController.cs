using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Smile___Sunshine_Toy_System.Controller
{
    internal class LoginController
    {
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
    }
}