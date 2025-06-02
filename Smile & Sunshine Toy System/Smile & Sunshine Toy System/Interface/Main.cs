using MySql.Data.MySqlClient;
using Smile___Sunshine_Toy_System.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types;

namespace Smile___Sunshine_Toy_System.Interface
{
    public partial class Main : Form
    {
        private MainController mainController;
        public Main()
        {
            InitializeComponent();
            mainController = new MainController();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadTableNames();
        }

        private void LoadTableNames()
        {
            string[] allowedTables = { "item", "product", "warehouse" }; // Whitelist of table names
            string[] allTables = mainController.GetTableNames();

            // Filter and add allowed tables to cbTable
            cbTable.Items.Clear(); // Clear existing items
            foreach (var table in allTables)
            {
                //cbTable.Items.Add(table);

                if (allowedTables.Contains(table))
                {
                    cbTable.Items.Add(table);
                }
            }

            // Optionally, select the first item if any
            if (cbTable.Items.Count > 0)
            {
                cbTable.SelectedIndex = 0;
                LoadColumnNames(cbTable.SelectedItem.ToString()); // Load columns for the first selected table
                LoadDataIntoDataGridView(cbTable.SelectedItem.ToString()); // Load data into DataGridView
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load columns when the selected table changes
            if (cbTable.SelectedItem != null)
            {
                LoadColumnNames(cbTable.SelectedItem.ToString());
                LoadDataIntoDataGridView(cbTable.SelectedItem.ToString()); // Load data into DataGridView
                CreateColumns(cbTable.SelectedItem.ToString());
            }
        }

        private void LoadColumnNames(string tableName)
        {
            string[] columnNames = mainController.GetColumnNames(tableName);
            cbColumn.Items.Clear(); // Clear existing items
            cbColumn.Items.AddRange(columnNames); // Add new column names
            if (cbColumn.Items.Count > 0)
            {
                cbColumn.SelectedIndex = 0;
            }
        }

        private void CreateColumns(string tableName)
        {
            // Clear existing controls in the panel
            panel1.Controls.Clear();

            // Get column names for the selected table
            string[] columnNames = mainController.GetColumnNames(tableName);
            int numberOfBoxes = columnNames.Length; // Number of TextBoxes based on column count
            int startingY = 10; // Starting Y position
            int spacing = 40; // Spacing between TextBoxes

            // Calculate maximum length for labels
            int maxLabelWidth = 0;
            foreach (var columnName in columnNames)
            {
                // Measure the width of the column name
                using (Graphics g = panel1.CreateGraphics())
                {
                    int width = (int)g.MeasureString(columnName, panel1.Font).Width;
                    maxLabelWidth = Math.Max(maxLabelWidth, width);
                }
            }

            for (int i = 0; i < numberOfBoxes; i++)
            {
                // Create a new Label
                Label dynamicLabel = new Label
                {
                    Text = columnNames[i], // Set the text for the label to the column name
                    Location = new System.Drawing.Point(10, startingY + (i * spacing) + 3), // Adjust Y position for each Label
                    Size = new System.Drawing.Size(maxLabelWidth + 10, 30) // Set width based on max length
                };

                // Add the Label to the panel
                panel1.Controls.Add(dynamicLabel);

                // Create a new TextBox with fixed width
                TextBox dynamicTextBox = new TextBox
                {
                    Location = new System.Drawing.Point(maxLabelWidth + 20, startingY + (i * spacing)), // Adjust X position to fit TextBox
                    Size = new System.Drawing.Size(200, 30) // Fixed width of 200
                };

                // Add the TextBox to the panel
                panel1.Controls.Add(dynamicTextBox);
            }
        }
        private void LoadDataIntoDataGridView(string tableName)
        {
            try
            {
                dgvData.DataSource = null; // Clear existing data
                DataTable data = mainController.LoadData(tableName); // Call the method from MainController
                dgvData.DataSource = data; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tableName = cbTable.SelectedItem.ToString();
            string columnName = cbColumn.SelectedItem.ToString();
            string v = txtValue.Text; // Assuming txtValue is the TextBox for search input
            LoadDataWithSearch(tableName, columnName, v);
        }

        private void LoadDataWithSearch(string tableName, string columnName, string txtValue)
        {
            try
            {
                dgvData.DataSource = null; // Clear existing data
                string query = $"SELECT * FROM `{tableName}`";

                if (!string.IsNullOrEmpty(txtValue))
                {
                    query += $" WHERE `{columnName}` LIKE @value";
                }

                var dataTable = new DataTable();
                using (var connection = Database.Instance.GetConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(txtValue))
                        {
                            command.Parameters.AddWithValue("@value", txtValue);
                        }

                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable); // Fill the DataTable with the fetched data
                        }
                    }
                }

                dgvData.DataSource = dataTable; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure the user has selected rows
            if (dgvData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one row to delete.");
                return;
            }

            // Confirm deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete the selected row(s)?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes)
            {
                return; // User cancelled the deletion
            }

            // Get the selected table name
            string tableName = cbTable.SelectedItem.ToString();
            string column = cbColumn.SelectedItem.ToString(); // Get the selected column name for the primary key

            // Loop through selected rows and delete them
            foreach (DataGridViewRow row in dgvData.SelectedRows)
            {
                // Assuming the first cell contains the primary key
                string id = row.Cells[0].Value.ToString(); // Adjust this based on your primary key column
                                                           // Call the method to delete the record
                mainController.DeleteRecord(tableName, column, id);
            }

            // Reload data to reflect changes
            LoadDataIntoDataGridView(tableName);
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            // Populate textboxes with the selected row values
            if (dgvData.SelectedRows.Count == 1)
            {
                var selectedRow = dgvData.SelectedRows[0];
                for (int i = 0; i < panel1.Controls.Count; i += 2) // Assuming labels and textboxes are added in pairs
                {
                    TextBox textBox = (TextBox)panel1.Controls[i + 1]; // TextBox is the next control after Label
                    textBox.Text = selectedRow.Cells[i / 2].Value?.ToString(); // Populate text box with the cell value
                }
            } else
            {
                for (int i = 0; i < panel1.Controls.Count; i += 2) // Assuming labels and textboxes are added in pairs
                {
                    TextBox textBox = (TextBox)panel1.Controls[i + 1]; // TextBox is the next control after Label
                    textBox.Text = ""; // Populate text box with the cell value
                }
            }
        }

        private void GetTextBoxValues(out List<string> values)
        {

            values = new List<string>();
            for (int i = 0; i < panel1.Controls.Count; i += 2) // Assuming labels and textboxes are added in pairs
            {
                TextBox textBox = (TextBox)panel1.Controls[i + 1]; // TextBox is the next control after Label
                string result = (string.IsNullOrEmpty(textBox.Text)) ? "Null" :
                                (textBox.Text.All(char.IsDigit)) ? textBox.Text :
                                $"\"{textBox.Text}\"";
                values.Add(result); // Collect values from textboxes
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                // Get the selected row and its ID
                var selectedRow = dgvData.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString(); // Assuming the first cell is the ID
                string table = cbTable.SelectedItem.ToString();

                string[] columns = mainController.GetColumnNames(table); // Get column names
                GetTextBoxValues(out List<string> values); // Get values from textboxes

                // Call the method to update the record
                mainController.UpdateRecord(table, columns, values.ToArray(), id);

                // Reload data to reflect changes
                LoadDataIntoDataGridView(table);
                MessageBox.Show("Record updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string table = cbTable.SelectedItem.ToString();
            string[] columns = mainController.GetColumnNames(table); // Get column names
            GetTextBoxValues(out List<string> values);
            mainController.InsertRecord(table, columns, values.ToArray());
            LoadDataIntoDataGridView(table); // Reload data to reflect changes
        }
    }
}