using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        MySqlConnection conn;
        public Form3()
        {
            InitializeComponent();
        }

        private void ConnectDatabase()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=127.0.0.1;uid=root;database=default";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                this.conn = conn;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UploadMessageToDatabase(string message)
        {
            string queryString = "INSERT INTO MESSAGE (`message_content`, `created_at`, `staff_id`) VALUES ()";
            MySqlCommand command = new MySqlCommand(queryString, conn);
            command.ExecuteNonQuery();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ConnectDatabase();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtInput.Text.ToString();
            UploadMessageToDatabase(message);
        }
    }
}
