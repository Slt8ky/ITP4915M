using iTextSharp.text;
using iTextSharp.text.pdf;
using Smile___Sunshine_Toy_System.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using GroupBox = System.Windows.Forms.GroupBox;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;
using Rectangle = iTextSharp.text.Rectangle;
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
        private GroupBox gbPDF_Column;
        private int dept_id;
        List<String> whiteList;

        public Main(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mainController = new MainController(rtbDisplay, username);
            user = mainController.GetUser(username);
            this.Text = $"Smile & Sunshine Toy System - [Staff ID: {user[0]}] [User: {user[1]}]";
            table = mainController.GetTable();
            loadTableAndColumn();
            Int32.TryParse(user[user.Count - 1], out dept_id);
            switch (dept_id)
            {
                case 1:
                    break;
                case 2:
                    tc1.TabPages.RemoveAt(0);
                    tc1.SelectedIndex = 0;
                    break;
                case 3:
                    btnDelete.Visible = false;
                    btnInsert.Visible = false;
                    btnUpdate.Size = new Size(btnInsert.Size.Width, btnInsert.Size.Height);
                    groupBox3.Location = new Point(groupBox3.Location.X, 640);
                    groupBox3.Size = new Size(groupBox3.Size.Width, 60);
                    gbColumnPanel.Size = new Size(gbColumnPanel.Size.Width, tc1.Size.Height - groupBox3.Size.Height);
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Customer_Feedback customer_Feedback = new Customer_Feedback();
                    customer_Feedback.Show();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Invalid department ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Console.WriteLine(dept_id);
        }

        private void loadTableAndColumn()
        {
            Boolean isWhiteList = false;
            Int32.TryParse(user[user.Count - 1], out dept_id);

            if (dept_id != 1)
            {
                isWhiteList = true;
            }

            switch (dept_id)
            {
                case 1:
                    whiteList = new List<String> { "afterservicefeedback", "department", "event", "item", "product", "report", "staff", "warehouse" };
                    break;
                case 2:
                    whiteList = new List<String> { "item", "product" };
                    break;
                case 3:
                    whiteList = new List<String> { "product", "warehouse" };
                    break;
                case 4:
                    whiteList = new List<String> { "item", "product", "warehouse" };
                    break;
                case 5:
                    whiteList = new List<String> { "item", "product", "warehouse" };
                    break;
                case 6:
                    whiteList = new List<String> { };
                    break;
                default:
                    MessageBox.Show("Invalid department ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            foreach (String t in table)
            {
                if (whiteList.Contains(t) && isWhiteList)
                {
                    cbTable.Items.Add(t);
                }
                else if (!isWhiteList)
                {
                    cbTable.Items.Add(t);
                }
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
            LoadPDFView();
            gbColumn.Text = $"Table: {cbTable.SelectedItem.ToString()}";
            lvTable.Items.Clear();
            lvTable.Columns.Clear();
            lvTable.View = View.Details;
            lvTable.MultiSelect = true;
            lvTable.FullRowSelect = true;
            lvTable.GridLines = true;
            string selectedTable = cbTable.SelectedItem.ToString();
            List<string> columnNames = column;

            foreach (string col in columnNames)
            {
                lvTable.Columns.Add(col, col.Length * 10);
            }

            List<List<string>> items = mainController.GetRecord(selectedTable, criteria);

            foreach (var row in items)
            {
                ListViewItem listViewItem = new ListViewItem(row[0]);
                for (int i = 1; i < row.Count; i++)
                {
                    listViewItem.SubItems.Add(row[i]);
                }
                lvTable.Items.Add(listViewItem);
            }
        }

        private void lvTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count == 1)
            {
                List<string> row = new List<string>();
                ListViewItem selectedItem = lvTable.SelectedItems[0];
                int startIndex = 1;
                for (int i = 0; i < selectedItem.SubItems.Count; i++)
                {
                    row.Add(selectedItem.SubItems[i].Text);
                    gbColumnPanel.Controls[startIndex].Text = selectedItem.SubItems[i].Text;
                    startIndex += 2;
                }
            }
            else
            {
                for (int i = 1; i < gbColumnPanel.Controls.Count; i += 2)
                {
                    gbColumnPanel.Controls[i].Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtValue.Text))
            {
                SetupListView($"`{cbColumn.SelectedItem.ToString()}` = \"{txtValue.Text}\"");
            }
            else
            {
                MessageBox.Show("Please enter a value to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPanel()
        {
            gbColumnPanel.Controls.Clear();
            int startY = 25;
            int gap = 40;

            foreach (string item in column)
            {
                Label lblColumn = new Label
                {
                    Text = item,
                    Location = new Point(10, startY),
                    AutoSize = true
                };

                TextBox txtRecord = new TextBox
                {
                    Name = item,
                    Location = new Point(120, startY),
                    Width = 200,
                    Height = 30
                };

                if (item.Contains(column[0]) || item.Contains("created_at"))
                {
                    txtRecord.ReadOnly = true;
                    txtRecord.BackColor = Color.LightGray;
                }
                if (dept_id == 3 && !item.Contains("price"))
                {
                    txtRecord.ReadOnly = true;
                    txtRecord.BackColor = Color.LightGray;
                }

                gbColumnPanel.Controls.Add(lblColumn);
                gbColumnPanel.Controls.Add(txtRecord);
                startY += gap;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string values = string.Join(", ",
                gbColumnPanel.Controls.OfType<TextBox>()
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
                mainController.DeleteRecord(cbTable.SelectedItem.ToString(), $"`{gbColumnPanel.Controls[0].Text}` = {item.Text}");
            }
            SetupListView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count == 1)
            {
                string setClause = string.Join(", ",
                    gbColumnPanel.Controls.OfType<TextBox>()
                    .Select(tb => $"`{tb.Name}` = {(string.IsNullOrWhiteSpace(tb.Text) ? "NULL" : $"\"{tb.Text}\"")}"));

                string whereClause = $"`{gbColumnPanel.Controls[0].Text}` = {lvTable.SelectedItems[0].Text}";
                mainController.UpdateRecord(cbTable.SelectedItem.ToString(), setClause, whereClause);
                SetupListView();
            }
            else
            {
                MessageBox.Show("Please select exactly one row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPDFView()
        {
            int startY = 15;
            int gap = 20;
            tabPage2.Controls.Clear();
            gbPDF_Column = new GroupBox
            {
                Text = "PDF Columns",
                Location = new Point(10, 10),
            };
            foreach (string column in column)
            {
                Label label = new Label
                {
                    Text = column,
                    Location = new Point(10, startY),
                    AutoSize = true
                };
                CheckBox checkBox = new CheckBox
                {
                    Name = column,
                    Checked = true,
                    Location = new Point(300 - 30, startY),
                    AutoSize = true
                };
                gbPDF_Column.Controls.Add(label);
                gbPDF_Column.Controls.Add(checkBox);
                gbPDF_Column.Size = new Size(300, startY + 20);
                startY += gap;
            }
            tabPage2.Controls.Add(gbPDF_Column);
            Button btnExportPDF = new Button
            {
                Text = "Export",
                BackColor = Color.LightBlue,
                Location = new Point(10, 15),
                Size = new Size(300 - 20, 50)
            };
            btnExportPDF.Click += new EventHandler(btnExportPDF_Click);
            GroupBox gbPDF_Export = new GroupBox
            {
                Text = "Export",
                Location = new Point(10, tabPage2.Size.Height - 80),
                Size = new Size(300, btnExportPDF.Size.Height + 30)
            };
            gbPDF_Export.Controls.Add(btnExportPDF);
            tabPage2.Controls.Add(gbPDF_Export);
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            string defaultFileName = $"{cbTable.SelectedItem.ToString()}.pdf";

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = defaultFileName,
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Save a PDF File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document document = new Document(PageSize.A4.Rotate()))
                using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
                {
                    document.Open();
                    document.SetMargins(0, 0, 0, 0);
                    int colcount = 0;
                    List<string> selectedColumns = new List<string>();
                    foreach (Control control in gbPDF_Column.Controls)
                    {
                        if (control is CheckBox checkBox && checkBox.Checked)
                        {
                            selectedColumns.Add(checkBox.Name);
                            colcount++;
                        }
                    }
                    PdfPTable table = new PdfPTable(colcount);
                    foreach (string column in selectedColumns)
                    {
                        table.AddCell(column);
                    }
                    List<String> records = mainController.GetFilteredRecord(cbTable.SelectedItem.ToString(), String.Join(", ", selectedColumns.Select(column => $"`{column}`")));
                    foreach (String record in records)
                    {
                        table.AddCell(record);
                    }
                    PdfPCell total_record = new PdfPCell(new Phrase($"Total Records: {records.Count / column.Count}"));
                    total_record.HorizontalAlignment = Element.ALIGN_RIGHT;
                    total_record.Border = Rectangle.NO_BORDER;
                    total_record.Colspan = 3;
                    table.AddCell(total_record);
                    document.Add(table);
                    document.Close();
                }
                mainController.Log("generate_report");
                MessageBox.Show("PDF generated successfully.", "System");
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            tc1.SelectedIndex = 1;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            SetupListView();
        }
    }
}