using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Rectangle = iTextSharp.text.Rectangle;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private MySqlConnection conn;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConnectDatabase(); // Connect to the database and load tables and columns
            cbDateSelect.SelectedIndex = 1; // Set the default selection for cbDateSelect
        }

        private void ConnectDatabase()
        {
            string myConnectionString = "server=127.0.0.1;uid=root;database=default;Convert Zero Datetime=True";

            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                LoadTableData(); // Load tables, columns, and initial data
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTableData()
        {
            if (conn == null || conn.State != ConnectionState.Open) return;

            try
            {
                // Load tables
                string tableQuery = "SHOW TABLES;";
                MySqlCommand tableCmd = new MySqlCommand(tableQuery, conn);
                MySqlDataReader tableReader = tableCmd.ExecuteReader();

                cbTableSelect.Items.Clear(); // Clear existing items in cbTableSelect

                // Whitelist of tables to include
                string[] whitelistItems = { "report", "product", "warehouse" };
                HashSet<string> whitelistSet = new HashSet<string>(whitelistItems);

                while (tableReader.Read())
                {
                    string tableName = tableReader.GetString(0);
                    if (whitelistSet.Contains(tableName))
                    {
                        cbTableSelect.Items.Add(tableName);
                    }
                }

                tableReader.Close();

                // Optionally set the default selection for tables
                if (cbTableSelect.Items.Count > 0)
                {
                    cbTableSelect.SelectedIndex = 0;
                    LoadColumnsAndData(cbTableSelect.SelectedItem.ToString()); // Load columns and data for the first table
                }

                // Event handler for table selection change
                cbTableSelect.SelectedIndexChanged += (s, e) =>
                {
                    if (cbTableSelect.SelectedItem != null)
                    {
                        LoadColumnsAndData(cbTableSelect.SelectedItem.ToString()); // Load columns and data
                    }
                };
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadColumnsAndData(string tableName)
        {
            if (conn == null || conn.State != ConnectionState.Open) return;

            try
            {
                // Load columns
                string columnQuery = $"DESCRIBE `{tableName}`;";
                MySqlCommand columnCmd = new MySqlCommand(columnQuery, conn);
                MySqlDataReader columnReader = columnCmd.ExecuteReader();

                cbColumnSelect.Items.Clear(); // Clear existing items in cbColumnSelect

                bool hasDate = false;
                while (columnReader.Read())
                {
                    string columnName = columnReader.GetString(0);
                    cbColumnSelect.Items.Add(columnName);

                    if (columnName == "created_at")
                        hasDate = true;
                }
                columnReader.Close();

                // Show or hide date controls based on presence of 'created_at'
                if (hasDate)
                {
                    lbDate.Show();
                    dtDateSelect.Show();
                    cbDateSelect.Show();
                }
                else
                {
                    lbDate.Hide();
                    dtDateSelect.Hide();
                    cbDateSelect.Hide();
                }
                LoadDataToDataGridView($"SELECT * FROM `{tableName}`;");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataToDataGridView(String queryString)
        {
            // Load data into DataGridView
            string query = queryString;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Create a list to hold columns that need to be modified
            List<DataColumn> columnsToModify = new List<DataColumn>();

            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.DataType == typeof(byte[])) // Check if the column is a BLOB
                {
                    columnsToModify.Add(column); // Add to the list
                }
            }

            // Now process the columns after the enumeration
            foreach (DataColumn column in columnsToModify)
            {
                // Optionally remove the original BLOB column
                dataTable.Columns.Remove(column.ColumnName);
            }

            dtTable.DataSource = dataTable; // Set the DataSource of DataGridView to the DataTable
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string columnQuery = $"DESCRIBE `{cbTableSelect.SelectedItem.ToString()}`;"; // Use backticks for table names
            MySqlCommand columnCmd = new MySqlCommand(columnQuery, conn);
            MySqlDataReader columnReader = columnCmd.ExecuteReader();

            Boolean hasDate = false;
            while (columnReader.Read())
            {
                if (columnReader.GetString(0) == "created_at")
                    hasDate = true;
            }
            columnReader.Close();

            string query = $"SELECT * FROM `{cbTableSelect.SelectedItem}`"; // Use backticks for table names

            // Format the date correctly for SQL
            if (hasDate)
            {
                string formattedDate = dtDateSelect.Value.ToString("yyyy-MM-dd");
                string symbol;
                switch (cbDateSelect.SelectedIndex)
                {
                    case 0:
                        symbol = ">=";
                        break;
                    case 1:
                        symbol = "<=";
                        break;
                    default:
                        symbol = "=";
                        break;
                }
                query += $" WHERE `created_at` {symbol} '{formattedDate}'"; // Use single quotes for date values
            }

            // Check if a target text is provided
            if (!string.IsNullOrWhiteSpace(txtTarget.Text))
            {
                if (hasDate)
                    query += " AND ";
                else
                    query += "WHERE ";
                query += $"`{cbColumnSelect.SelectedItem}` LIKE '{txtTarget.Text}'"; // Use single quotes for string values
            }
            textBox1.Text = query; // Display the query in textBox1

            // Load data into DataGridView
            LoadDataToDataGridView(query);
        }

        private void DownloadFileFromDatabase(string dateTime)
        {
            if (conn == null || conn.State != ConnectionState.Open)
                return;

            try
            {
                string query = "SELECT report_name, report_file FROM report WHERE created_at = @dateTime;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dateTime", dateTime);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fileName = reader.GetString(0);
                            byte[] fileData = (byte[])reader["report_file"];

                            // Prompt user to save the file
                            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                            {
                                saveFileDialog.FileName = fileName;

                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    File.WriteAllBytes(saveFileDialog.FileName, fileData);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("File not found.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string filePath = $"{cbTableSelect.SelectedItem.ToString()}.pdf"; // Specify the path to save the PDF

            // Step 1: Export DataGridView to PDF
            using (Document document = new Document(PageSize.A4))
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                // Create a table with the same number of columns as the DataGridView
                PdfPTable pdfTable = new PdfPTable(dtTable.Columns.Count);
                float[] columnWidths = new float[dtTable.Columns.Count];
                for (int i = 0; i < dtTable.Columns.Count; i++)
                {
                    columnWidths[i] = dtTable.Columns[i].Width; // Get the width of each column
                }

                // Set column widths (convert to percentages)
                pdfTable.SetWidths(columnWidths);
                // Add headers
                PdfPTable header = new PdfPTable(1);
                header.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                header.AddCell(new PdfPCell(new Phrase("Smile & Sunshine - Report", FontFactory.GetFont(FontFactory.HELVETICA, 20)))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    Border = Rectangle.NO_BORDER
                });

                string[] textString = { $"Table: {cbTableSelect.SelectedItem.ToString()}" };
                for (int i = 0; i < textString.Length; i++)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(textString[i]))
                    {
                        Colspan = dtTable.Columns.Count,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    pdfTable.AddCell(headerCell);
                }

                foreach (DataGridViewColumn column in dtTable.Columns)
                {
                    pdfTable.AddCell(new PdfPCell(new Phrase(column.HeaderText)));
                }

                // Add footer
                PdfPTable footer = new PdfPTable(1);
                footer.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                footer.AddCell(new PdfPCell(new Phrase($"Generated at: {DateTime.Now.ToString()}"))
                {
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    Border = Rectangle.NO_BORDER
                });
                // Add rows
                foreach (DataGridViewRow row in dtTable.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(new PdfPCell(new Phrase(cell.Value?.ToString() ?? string.Empty)));
                    }
                }

                document.Add(header);
                document.Add(pdfTable);
                document.Add(footer);
                document.Close();
            }

            // Step 2: Upload PDF to Database
            if (conn == null || conn.State != ConnectionState.Open)
                return;

            try
            {
                byte[] fileData = File.ReadAllBytes(filePath);
                string fileName = Path.GetFileName(filePath);
                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string query = "INSERT INTO report (report_name, report_file, created_at) VALUES (@reportName, @reportFile, @created_at);";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@reportName", fileName);
                    cmd.Parameters.AddWithValue("@reportFile", fileData);
                    cmd.Parameters.AddWithValue("@created_at", dateTime);

                    cmd.ExecuteNonQuery();
                }
                DownloadFileFromDatabase(dateTime);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (dtTable.SelectedRows.Count>0)
            {
                string[] items = new string[dtTable.SelectedRows.Count];
                string textString = "";
                int i = 0;
                for (int row = dtTable.SelectedRows.Count - 1; row >= 0; row--)
                {
                    items[i] = dtTable.SelectedRows[row].Cells[0].Value.ToString();
                    i++;
                }
                for (i = 0; i < items.Length; i++)
                {
                    textString += items[i];
                    if (i != items.Length - 1)
                    {
                        textString += ", ";
                    }
                }
                MessageBox.Show(textString);
                try
                {
                    string query = $"DELETE FROM `{cbTableSelect.SelectedItem.ToString()}` WHERE `{cbColumnSelect.Items[0]}` IN ({textString})";
                    MessageBox.Show(query);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    LoadColumnsAndData(cbTableSelect.SelectedItem.ToString());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("You must select at least one row of record");
            }
        }
    }
}