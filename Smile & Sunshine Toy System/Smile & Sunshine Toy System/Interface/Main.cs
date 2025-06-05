using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;
using Smile___Sunshine_Toy_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Smile___Sunshine_Toy_System.Interface
{
    public partial class Main : Form
    {
        private MainController mainController;
        private String username;
        private List<String> user;
        private List<String> table;
        private List<String> column;
        private List<String> selectedRow;

        public Main(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mainController = new MainController(rtbDisplay, username);
            user = mainController.GetUser(username);
            table = mainController.GetTable();
            loadTableAndColumn();
        }

        private void loadTableAndColumn()
        {
            Boolean isWhiteList = false;
            List<String> whiteList = new List<string> {"item", "product", "warehouse"};
            foreach (String t in table)
            {
                if (whiteList.Contains(t) && isWhiteList)
                {
                    cbTable.Items.Add(t);
                } else if (!isWhiteList)
                    cbTable.Items.Add(t);
            }
            if (cbTable.Items.Count > 0)
            {
                cbTable.SelectedIndex = 0;
                column = mainController.GetTableStructure(cbTable.SelectedItem.ToString());
                foreach (String c in column)
                {
                    cbColumn.Items.Add(c);
                }
                if (cbColumn.Items.Count > 0)
                    cbColumn.SelectedIndex = 0;
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbColumn.Items.Clear();
            column = mainController.GetTableStructure(cbTable.SelectedItem.ToString());
            SetupListView();
            foreach (String c in column)
            {
                cbColumn.Items.Add(c);
            }
            if (cbColumn.Items.Count > 0)
                cbColumn.SelectedIndex = 0;
        }

        private void SetupListView(String criteria = null)
        {
            LoadPanel();
            gbColumn.Text = $"Table: {cbTable.SelectedItem.ToString()}";
            // Clear existing items and columns
            lvTable.Items.Clear();
            lvTable.Columns.Clear();

            // Set ListView properties
            lvTable.View = View.Details; // Set the view to details
            lvTable.MultiSelect = true; // Allow multiple selection
            lvTable.FullRowSelect = true; // Select full row
            lvTable.GridLines = true; // Show grid lines
            // Define columns based on the selected table
            string selectedTable = cbTable.SelectedItem.ToString(); // Get the selected table name
            List<string> columnNames = column; // Retrieve column names for the selected table

            foreach (string col in columnNames)
            {
                lvTable.Columns.Add(col, col.Length*10);
            }

            // Retrieve data from the database
            List<List<string>> items = mainController.GetRecord(selectedTable, criteria); // Get records from the selected table

            // Populate the ListView with the retrieved data
            foreach (var row in items)
            {
                ListViewItem listViewItem = new ListViewItem(row[0]); // First column value
                for (int i = 1; i < row.Count; i++)
                {
                    listViewItem.SubItems.Add(row[i]); // Add subsequent column values
                }
                lvTable.Items.Add(listViewItem); // Add the complete row to the ListView
            }
        }

        private void lvTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count == 1)
            {
                List<string> row = new List<string>();

                // Get the first selected item
                ListViewItem selectedItem = lvTable.SelectedItems[0];
                int startIndex = 1;
                // Use a for loop to iterate over sub-items of the selected item
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    row.Add(selectedItem.SubItems[i].Text); // Add the text of each sub-item to the list
                    pnlColumn.Controls[startIndex].Text = selectedItem.SubItems[i].Text;
                    startIndex += 2;
                }
            } else
            {
                // Use a for loop to iterate over sub-items of the selected item
                for (int i = 1; i < pnlColumn.Controls.Count; i+=2)
                {
                    pnlColumn.Controls[i].Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValue.Text))
            {
                SetupListView($"`{cbColumn.SelectedItem.ToString()}` = \"{txtValue.Text}\"");
            } else
            {
                MessageBox.Show("Please enter a value to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPanel()
        {
            pnlColumn.Controls.Clear();
            int startY = 10;
            int gap = 40; // Adjusted gap for better spacing

            foreach (string item in column)
            {
                // Create and configure the label
                Label lblColumn = new Label
                {
                    Text = item,
                    Location = new Point(10, startY),
                    AutoSize = true
                };

                // Create and configure the textbox
                TextBox txtRecord = new TextBox
                {
                    Name = item,
                    Location = new Point(120, startY), // Position next to the label
                    Width = 200, // Set the width
                    Height = 30 // Set the height
                };

                if (item.Contains(column[0])||item.Contains("created_at"))
                {
                    txtRecord.ReadOnly = true;
                    txtRecord.BackColor = Color.LightGray; // Make it read-only and visually distinct
                }
                // Add controls to the panel
                pnlColumn.Controls.Add(lblColumn);
                pnlColumn.Controls.Add(txtRecord);

                // Update the starting Y position for the next control
                startY += gap;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string values = string.Join(", ",
                pnlColumn.Controls.OfType<TextBox>()
                .Select(tb => string.IsNullOrWhiteSpace(tb.Text) ? "NULL" : $"\"{tb.Text}\""));
            Console.WriteLine(values);
            mainController.InsertRecord(cbTable.SelectedItem.ToString(), values);
            SetupListView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvTable.SelectedItems)
            {
                Console.WriteLine(item.Text);
                mainController.DeleteRecord(cbTable.SelectedItem.ToString(), $"`{pnlColumn.Controls[0].Text}` = {item.Text}");
            }
            SetupListView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count == 1)
            {
                string setClause = string.Join(", ",
                    pnlColumn.Controls.OfType<TextBox>()
                    .Select(tb => $"`{tb.Name}` = {(string.IsNullOrWhiteSpace(tb.Text) ? "NULL" : $"\"{tb.Text}\"")}"));

                string whereClause = $"`{pnlColumn.Controls[0].Text}` = {lvTable.SelectedItems[0].Text}"; // Assuming the first column is the primary key
                mainController.UpdateRecord(cbTable.SelectedItem.ToString(), setClause, whereClause);
                SetupListView();
            }
            else
            {
                MessageBox.Show("Please select exactly one row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
