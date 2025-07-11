﻿using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_System
{
    public partial class Customer_Feedback : Form
    {
        private string connectionString = "server=125.59.53.16;uid=root;database=default;pwd=6wS1Ah753ylT;Convert Zero Datetime=true;";
        public Customer_Feedback()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1250, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            UpLoadData();
        }

        private void Customer_Feedback_Load(object sender, EventArgs e)
        {
            ResetFB_Click(sender, e);
        }

        public sealed class Database
        {
            private static readonly Database instance = new Database();
            private MySqlConnection connection;
            private string connectionString = "server=125.59.53.16;uid=root;database=default;pwd=6wS1Ah753ylT;Convert Zero Datetime=true;";

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
        private void UpLoadData()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM afterservicefeedback";

                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable db = new DataTable();
                db.Load(sdr);

                ViewFBData.DataSource = db;
            }
        }
        private void CreateFB_Click(object sender, EventArgs e)
        {
            try
            {
                int newFeedbackID;

                // Fetch the next available feedbackID
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT COALESCE(MAX(feedbackID), 0) + 1 FROM afterservicefeedback";
                        newFeedbackID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO afterservicefeedback(feedbackID, clientID, orderID, feedBackType, feedbackDetail, contactType, contactInfo, ProductID, StaffID) " +
                                  "VALUES(@feedbackID, @clientID, @orderID,  @feedbackType, @feedbackDetail, @contactType, @contactInfo, @ProductID, @StaffID)";
                        cmd.Parameters.AddWithValue("@feedbackID", newFeedbackID);
                        cmd.Parameters.AddWithValue("@clientID", FBCID.Text.Trim());
                        cmd.Parameters.AddWithValue("@orderID", FBOID.Text.Trim());
                        cmd.Parameters.AddWithValue("@feedbackType", FBType.Text.Trim());
                        cmd.Parameters.AddWithValue("@feedbackDetail", FBDetail.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactType", FBCType.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactInfo", FBCInfo.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProductID", FBPID.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffID", FBSID.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Create Feedback Succesaful");
                UpLoadData();
                ResetFB_Click(sender, e);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"SQL Error : {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void ResetFB_Click(object sender, EventArgs e)
        {
            FBID.Clear();
            FBOID.Clear();
            FBPID.Clear();
            FBCID.Clear();
            FBDate.Clear();
            FBType.SelectedIndex = -1;
            FBCType.SelectedIndex = -1;
            FBCInfo.Clear();
            FBDetail.Clear();
        }

        private void FBTSConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Connected");
                    }
                    else
                    {
                        MessageBox.Show("Connection Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void ViewFBData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ViewFBData.SelectedRows.Count > 0)
                {
                    var selectedRow = ViewFBData.SelectedRows[0];

                    FBID.Text = selectedRow.Cells[0].Value?.ToString();
                    FBCID.Text = selectedRow.Cells[1].Value?.ToString();
                    FBOID.Text = selectedRow.Cells[2].Value?.ToString();
                    FBPID.Text = selectedRow.Cells[8].Value?.ToString();
                    FBDate.Text = selectedRow.Cells[4].Value?.ToString();
                    FBType.Text = selectedRow.Cells[3].Value?.ToString();
                    FBCType.Text = selectedRow.Cells[6].Value?.ToString();
                    FBCInfo.Text = selectedRow.Cells[7].Value?.ToString();
                    FBDetail.Text = selectedRow.Cells[5].Value?.ToString();
                    FBSID.Text = selectedRow.Cells[9].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "afterservicefeedback Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFB_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE afterservicefeedback SET " +
                                          "clientID = @clientID, " +
                                          "orderID = @orderID, " +
                                          "feedbackType = @feedbackType, " +
                                          "feedbackDetail = @feedbackDetail, " +
                                          "contactInfo = @contactInfo, " +
                                          "contactType = @contactType, " +
                                          "ProductID = @ProductID, " +
                                          "StaffID = @StaffID " +
                                          "WHERE feedbackID = @feedbackID";

                        cmd.Parameters.AddWithValue("@feedbackID", FBID.Text.Trim());
                        cmd.Parameters.AddWithValue("@clientID", FBCID.Text.Trim());
                        cmd.Parameters.AddWithValue("@orderID", FBOID.Text.Trim());
                        cmd.Parameters.AddWithValue("@feedbackType", FBType.Text.Trim());
                        cmd.Parameters.AddWithValue("@feedbackDetail", FBDetail.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProductID", FBPID.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffID", FBSID.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactType", FBCType.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactInfo", FBCInfo.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record was updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DeleteFB_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "DELETE FROM afterservicefeedback WHERE feedbackID = @feedbackID";
                    cmd.Parameters.AddWithValue("@feedbackID", FBID.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Delete Successful");
                        UpLoadData(); // Refresh data
                        ResetFB_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("No record found to delete");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult FBExit;
            FBExit = MessageBox.Show("Confirm Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (FBExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FBSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (FBSearchText.Text.Trim() != string.Empty)
                {
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();
                    MySqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM afterservicefeedback WHERE feedbackID = @feedbackID OR clientID = @clientID OR orderID = @orderID";
                    cmd.Parameters.AddWithValue("@feedbackID", FBSearchText.Text.Trim());
                    cmd.Parameters.AddWithValue("@clientID", FBSearchText.Text.Trim());
                    cmd.Parameters.AddWithValue("@orderID", FBSearchText.Text.Trim());

                    MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(mySqlDataReader);
                    ViewFBData.DataSource = dt;
                    con.Close();
                    if (FBSearchText.Text == "")
                    {
                        MessageBox.Show("Record Not Found", "afterservicefeedback Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                FBSearchText.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "afterservicefeedback Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadFBView_Click(object sender, EventArgs e)
        {
            UpLoadData();
        }
    }
}
