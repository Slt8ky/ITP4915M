using MySql.Data.MySqlClient; // Ensure you have MySQL.Data package installed
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Account
        {
            public Dictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool isLogined = false;

                using (MySqlConnection conn = ConnectSql())
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM STAFF WHERE username = @username AND password = @password;", conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text));
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isLogined = count > 0;
                    }

                    if (isLogined)
                    {
                        List<string> columnName = new List<string>();
                        List<string> data = new List<string>();

                        using (MySqlCommand cmd = new MySqlCommand("SHOW COLUMNS FROM STAFF", conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    columnName.Add(reader.GetString(0));
                                }
                            }
                        }

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM STAFF WHERE username = @username", conn))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    for (int i = 0; i < columnName.Count; i++)
                                    {
                                        data.Add(reader[i].ToString());
                                    }
                                }
                            }
                        }

                        Account currentUser = new Account();
                        for (int i = 0; i < columnName.Count; i++)
                        {
                            currentUser.Data[columnName[i]] = data[i];
                        }

                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO event (event_type, event_content, staff_id) VALUES (@event_type, @event_content, @staff_id)", conn))
                        {
                            cmd.Parameters.AddWithValue("@event_type", "login");
                            cmd.Parameters.AddWithValue("@event_content", "User logged in");
                            cmd.Parameters.AddWithValue("@staff_id", currentUser.Data["staff_id"].ToString());
                            cmd.ExecuteNonQuery(); // Execute the insert command
                        }

                        MessageBox.Show("Login successful!");
                        Form2 form2 = new Form2(currentUser);
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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