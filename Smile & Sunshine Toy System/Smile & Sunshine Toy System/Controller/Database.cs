using MySql.Data.MySqlClient;
using System;

namespace Smile___Sunshine_Toy_System
{
    public sealed class Database
    {
        private static readonly Database instance = new Database();
        private MySqlConnection connection;
        private string connectionString = "server=125.59.53.16;uid=root;database=default;Convert Zero Datetime=true;";

        private Database()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Database connection error: {ex.Message}");
            }
        }

        public static Database Instance => instance;

        public MySqlConnection Connection => connection;

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}