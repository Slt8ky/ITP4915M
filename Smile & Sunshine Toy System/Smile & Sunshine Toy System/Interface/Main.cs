using iTextSharp.text;
using iTextSharp.text.pdf;
using Material_Requirement_Form;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using Smile___Sunshine_Toy_System.Controller;
using Smile___Sunshine_Toy_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using ComboBox = System.Windows.Forms.ComboBox;
using Font = iTextSharp.text.Font;
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
        private int currentSortColumn = -1;
        private SortOrder currentSortOrder = SortOrder.None;
        private bool isOpened = false;

        public Main(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mainController = new MainController(rtbDisplay, username);
            user = mainController.GetUser(username);
            this.Text = $"Smile & Sunshine Toy System - Staff ID: {user[0]} User: {user[1]}";
            table = mainController.GetTable();
            loadTableAndColumn();
            Int32.TryParse(user[4], out dept_id);
            switch (dept_id)
            {
                case 1: //Administrator 
                    break;
                case 2: //R&D Team Member 
                    break;
                case 3: //Sales Representative 
                    break;
                case 4: //Production Manager 
                    tc1.SelectedIndex = 0;
                    break;
                case 5: //Inventory Manager 
                    break;
                case 6: //Customer Service Representative 
                    Customer_Feedback customer_Feedback = new Customer_Feedback();
                    customer_Feedback.Show();
                    this.Close(); 
                    break;
                case 7: //Logistics Coordinator 
                    break;
            }
            cbLocalization.SelectedIndex = 0;
        }

        private void loadTableAndColumn()
        {
            Boolean isWhiteList = false;
            Int32.TryParse(user[4], out dept_id);

            if (dept_id != 1)
            {
                isWhiteList = true;
            }

            switch (dept_id)
            {
                case 1: //Administrator 
                    whiteList = new List<String> {
                        "afterservicefeedback",
                        "clientinformation",
                        "customerorder",
                        "damagematerial",
                        "department",
                        "event",
                        "facilities",
                        "finishedcomponent",
                        "internaltransferform",
                        "material",
                        "materialrequirementform",
                        "product",
                        "productorder",
                        "quotation",
                        "staff",
                        "transportation",
                        "warehouse"
                    };
                    break;
                case 2: //R&D Team Member 
                    whiteList = new List<String> {
                        "facilities",
                        "finishedcomponent",
                        "product",
                        "warehouse"
                    };
                    break;
                case 3: //Sales Representative 
                    whiteList = new List<String> {
                        "clientinformation",
                        "customerorder",
                        "facilities",
                        "product",
                        "quotation",
                    };
                    break;
                case 4: //Production Manager 
                    whiteList = new List<String> {
                        "productorder"
                    };
                    tc1.SelectedIndex = 0;
                    break;
                case 5: //Inventory Manager 
                    whiteList = new List<String> {
                        "damagematerial",
                        "facilities",
                        "finishedcomponent",
                        "material",
                        "materialrequirementform",
                        "product",
                        "transportation",
                        "warehouse"
                    };
                    break;
                case 6: //Customer Service Representative 
                    whiteList = new List<String>
                    {
                    };
                    return;
                case 7: //Logistics Coordinator 
                    whiteList = new List<String> {
                        "productorder"
                    };
                    return;
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

            // Reset sort state when table changes
            currentSortColumn = -1;
            currentSortOrder = SortOrder.None;
            SetupListView();

            foreach (String c in column)
            {
                cbColumn.Items.Add(c);
            }
            if (cbColumn.Items.Count > 0)
                cbColumn.SelectedIndex = 0;
            if (cbTable.SelectedItem.ToString() == "customerorder")
            {
                gpDeliveryNote.Visible = true;
                gpMaterialRequirementForm.Size = new Size(gpMaterialRequirementForm.Size.Width, 59);
            }
            else
            {
                gpDeliveryNote.Visible = false;
                gpMaterialRequirementForm.Size = new Size(gpMaterialRequirementForm.Size.Width, 113);
            }
        }

        private void SetupListView(String criteria = null)
        {
            // Remove previous event handler to avoid duplicates
            lvTable.ColumnClick -= lvTable_ColumnClick;

            LoadPanel();
            LoadPDFView();
            LoadDisplaySetting();
            gbColumn.Text = $"Table: {cbTable.SelectedItem.ToString()}";
            lvTable.Items.Clear();
            lvTable.Columns.Clear();
            lvTable.View = View.Details;
            lvTable.MultiSelect = true;
            lvTable.FullRowSelect = true;
            lvTable.GridLines = true;

            string selectedTable = cbTable.SelectedItem.ToString();
            List<string> columnNames = column;
            lvTable.Hide();

            // Add columns without sort indicators
            foreach (string col in columnNames)
            {
                lvTable.Columns.Add(col);
            }

            // Add the column click event handler
            lvTable.ColumnClick += lvTable_ColumnClick;

            List<List<string>> items = mainController.GetRecord(selectedTable, criteria);

            foreach (List<string> row in items)
            {
                ListViewItem listViewItem = new ListViewItem(row[0]);
                for (int i = 1; i < row.Count; i++)
                {
                    Int32.TryParse(row[i], out int result);
                    Boolean hasAmount = columnNames[i] == "TotalAmount" ? true
                                        : columnNames[i] == "MaterialAmount" ? true
                                        : false;
                    if (hasAmount)
                    {
                        Color color = result > 1000 ? Color.Green
                                     : result > 500 ? Color.OrangeRed
                                     : Color.Red;
                        listViewItem.BackColor = color;
                    }
                    int width = row[i].Length * 10 > columnNames[i].Length * 10 ? row[i].Length * 10 : columnNames[i].Length * 15;
                    lvTable.Columns[0].Width = columnNames[i].Length * 10;
                    lvTable.Columns[i].Width = width;
                    listViewItem.SubItems.Add(row[i]);
                }
                lvTable.Items.Add(listViewItem);
            }
            lvTable.Show();
        }

        private void lvTable_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine the new sort order
            SortOrder newSortOrder;
            if (e.Column == currentSortColumn)
            {
                // Toggle between ascending and descending
                newSortOrder = currentSortOrder == SortOrder.Ascending ?
                    SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                // New column, default to ascending
                newSortOrder = SortOrder.Ascending;
            }

            // Update the sort indicators
            currentSortColumn = e.Column;
            currentSortOrder = newSortOrder;

            // Clear any existing sort indicators
            foreach (ColumnHeader column in lvTable.Columns)
            {
                column.Text = column.Text.Replace(" ↑", "").Replace(" ↓", "");
            }

            // Add the new sort indicator
            string sortIndicator = newSortOrder == SortOrder.Ascending ? " ↑" : " ↓";
            lvTable.Columns[e.Column].Text += sortIndicator;

            // Get the column name for SQL ORDER BY
            string columnName = column[e.Column];

            // Build the ORDER BY clause
            string orderBy = $"ORDER BY `{columnName}` {(newSortOrder == SortOrder.Ascending ? "ASC" : "DESC")}";

            // Requery the data with sorting
            if (!string.IsNullOrWhiteSpace(txtValue.Text))
            {
                SetupListView($"`{cbColumn.SelectedItem.ToString()}` = \"{txtValue.Text}\" {orderBy}");
            }
            else
            {
                SetupListView(orderBy);
            }
        }

        private void LoadDisplaySetting()
        {
            foreach (string item in column)
            {
                Label label = new Label
                {
                    Text = item,
                    AutoSize = true,
                    Location = new Point(10, 20 + (gbColumnPanel.Controls.Count / 2) * 30)
                };
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
            mainController.InsertRecord(cbTable.SelectedItem.ToString(), values);
            SetupListView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvTable.SelectedItems)
            {
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
            gbPDF_Column = new GroupBox // Assign to the class-level field
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
                    Location = new Point(tc1.Width - 40, startY),
                    AutoSize = true
                };
                gbPDF_Column.Controls.Add(label);
                gbPDF_Column.Controls.Add(checkBox);
                gbPDF_Column.Size = new Size(tc1.Width - 20, startY + 20);
                startY += gap;
            }
            tabPage2.Controls.Add(gbPDF_Column);
            Button btnExportPDF = new Button
            {
                Text = "Export",
                BackColor = Color.LightBlue,
                Location = new Point(10, 15),
                Size = new Size(tc1.Width - 40, 50)
            };
            btnExportPDF.Click += new EventHandler(btnExportPDF_Click);
            GroupBox gbPDF_Export = new GroupBox
            {
                Text = "Export",
                Location = new Point(10, tabPage2.Size.Height - 80),
                Size = new Size(tc1.Width - 20, btnExportPDF.Size.Height + 20)
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

        private void cbLocalization_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change the current culture based on selection
            switch (cbLocalization.SelectedIndex)
            {
                case 0: // English
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1: // Chinese (Hong Kong)
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-HK");
                    break;
            }

            // Force reload of resources
            Resource.Culture = System.Threading.Thread.CurrentThread.CurrentUICulture;

            // Update UI elements
            tabPage1.Text = Resource.tabPage1_Text;
            groupBox5.Text = Resource.groupBox5_Text;
            groupBox1.Text = Resource.groupBox1_Text;
            btnUpdate.Text = Resource.btnUpdate_Text;
            label2.Text = Resource.label2_Text;
            btnSearch.Text = Resource.btnSearch_Text;
            btnInsert.Text = Resource.btnInsert_Text;
            groupBox3.Text = Resource.groupBox3_Text;
            groupBox2.Text = Resource.groupBox2_Text;
            tabPage2.Text = Resource.tabPage2_Text;
            btnDelete.Text = Resource.btnDelete_Text;
            label1.Text = Resource.label1_Text;
            gbColumnPanel.Text = Resource.gbColumnPanel_Text;
            gbProfile.Text = Resource.gbProfile_Text;
            gpDeliveryNote.Text = Resource.gpDeliveryNote_Text;
            btnSwitchUser.Text = Resource.btnSwitchUser_Text;
        }

        private void btnExportToDeliveryNote_Click(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count == 1)
            {
                List<string> selectedData = new List<string>();
                foreach (ListViewSubItem item in lvTable.SelectedItems[0].SubItems)
                {
                    selectedData.Add(item.Text);
                }

                var items = new Dictionary<string, string>
                {
                    {"OrderID", null},
                    {"OrderDate", null},
                    {"ClientID", null},
                    {"ClientName", null},
                    {"ClientPhoneNum", null},
                    {"ClientEmail", null},
                    {"ClientAddress", null},
                    {"Requirement", null},
                    {"Quantity", null},
                    {"ProductID", null},
                    {"ProductName", null},
                    {"ProductPrice", null},
                    {"Descriptions", null},
                    {"TotalPrice", null},
                    {"Payment", null},
                    {"Delivertype", null}
                };

                string[] keys = { "ClientID", "ProductID" };
                var results = mainController.GetSelectedItem(
                    cbTable.SelectedItem.ToString(),
                    keys,
                    "`customerorder`.`OrderID`, " +
                    "`customerorder`.`OrderDate`, " +
                    "`customerorder`.`ClientID`, " +
                    "`clientinformation`.`ClientName`, " +
                    "`clientinformation`.`ClientPhoneNum`, " +
                    "`clientinformation`.`ClientEmail`, " +
                    "`clientinformation`.`ClientAddress`, " +
                    "`customerorder`.`Requirement`, " +
                    "`customerorder`.`Quantity`, " +
                    "`product`.`ProductID`, " +
                    "`product`.`ProductName`, " +
                    "`product`.`ProductPrice`, " +
                    "`product`.`Descriptions`, " +
                    "`customerorder`.`TotalPrice`, " +
                    "`customerorder`.`Payment`, " +
                    "`customerorder`.`Delivertype`",
                    $"WHERE `OrderID` = {selectedData[0]}"
                );

                // Assuming the results are in the same order as the dictionary keys
                int index = 0;
                foreach (var key in items.Keys.ToList())
                {
                    if (index < results.Count)
                    {
                        items[key] = results[index++];
                    }
                }

                string defaultFileName = $"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}_CILENTID-{items["OrderID"]}_deliverynote.pdf";

                using (SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = defaultFileName,
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    Title = "Save a PDF File"
                })
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        GeneratePdf(items, saveFileDialog.FileName);
                        MessageBox.Show("PDF generated successfully.");
                    }
                }
            }
        }

        private void GeneratePdf(Dictionary<string, string> items, string filePath)
        {
            PdfPTable table = new PdfPTable(3);
            Font font = FontFactory.GetFont("Arial", 28);
            PdfPCell cell = new PdfPCell(new Phrase("Smile & Sunshine", font))
            {
                PaddingTop = 40,
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Colspan = 3
            };
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Delivery Note"))
            {
                Border = Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Colspan = 3
            };
            table.AddCell(cell);

            var orderInfo = new Dictionary<string, string>
            {
                {"Order Date", items["OrderDate"]},
                {"Order #", items["OrderID"]},
                {"Customer ID", items["ClientID"]},
                {"Dispatch Date", DateTime.Now.ToString("F")},
                {"Delivery Method", items["Delivertype"]}
            };

            foreach (var item in orderInfo)
            {
                cell = new PdfPCell(new Phrase($"{item.Key}: {item.Value}"))
                {
                    Border = Rectangle.NO_BORDER,
                    Colspan = 3,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                table.AddCell(cell);
            }

            table.AddCell(new PdfPCell(new Phrase(" ")) { Border = Rectangle.NO_BORDER, Colspan = 3, PaddingBottom = 4 });

            string[] clientInfo =
            {
                "Shipping Address",
                items["ClientName"],
                items["ClientPhoneNum"],
                items["ClientEmail"],
                items["ClientAddress"]
            };

            foreach (var info in clientInfo)
            {
                cell = new PdfPCell(new Phrase(info))
                {
                    Border = Rectangle.NO_BORDER,
                    Colspan = 3,
                    HorizontalAlignment = Element.ALIGN_RIGHT
                };
                table.AddCell(cell);
            }

            table.AddCell(new PdfPCell(new Phrase(" ")) { Border = Rectangle.NO_BORDER, Colspan = 3, PaddingBottom = 4 });

            PdfPTable table2 = new PdfPTable(5);
            string[] content = { "Item #", "Product Name", "Description", "Ordered", "Price" };
            foreach (var header in content)
            {
                table2.AddCell(new PdfPCell(new Phrase(header)));
            }

            string[] product = {
                items["ProductID"],
                items["ProductName"],
                items["Descriptions"],
                items["Quantity"],
                items["ProductPrice"],
            };

            foreach (var item in product)
            {
                cell = new PdfPCell(new Phrase(item))
                {
                    HorizontalAlignment = item == "ProductPrice" ? Element.ALIGN_RIGHT : Element.ALIGN_LEFT
                };
                table2.AddCell(cell);
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            using (Document document = new Document(PageSize.A4.Rotate()))
            using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
            {
                document.Open();
                document.SetMargins(0, 0, 0, 0);
                document.Add(table);
                document.Add(table2);
                document.Close();
            }
        }

        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnAddRequirementForm_Click(object sender, EventArgs e)
        {
            MaterialRequirementForm materialRequirementForm = new MaterialRequirementForm();
            materialRequirementForm.Show();
        }
    }
}