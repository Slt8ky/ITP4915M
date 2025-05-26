using MySql.Data.MySqlClient; // Ensure you have MySQL.Data package installed
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Convert to hex
                }
                return builder.ToString();
            }
        }

        private MySqlConnection ConnectSql()
        {
            string connectionString = "server=localhost;user=root;database=default"; // Update with your MySQL credentials
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        private void PerformSql(string sqlQuery)
        {
            using (MySqlConnection connection = ConnectSql())
            {
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM staff";

            using (MySqlConnection connection = ConnectSql())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                string username = null;
                string password = null;
                while (reader.Read())
                {
                    username = reader.GetString("username");
                    password = reader.GetString("password");
                    if (txtUsername.Text == username && HashPassword(txtPassword.Text) == password)
                    {
                        this.Hide(); // Hide the login form
                        PerformSql($"INSERT INTO `event` (`event_id`, `event_type`, `event_date`, `event_content`) VALUES (NULL, 'login', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{username} is logged in');");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check your username and password.");
                        txtPassword.Clear(); // Clear the password field
                        txtPassword.Focus(); // Set focus back to the password field
                        return;
                    }
                }
                reader.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true; // Prevents the "ding" sound on Enter
            }
        }
    }
}