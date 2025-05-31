namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtTable = new System.Windows.Forms.DataGridView();
            this.cbTableSelect = new System.Windows.Forms.ComboBox();
            this.cbColumnSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtDateSelect = new System.Windows.Forms.DateTimePicker();
            this.cbDateSelect = new System.Windows.Forms.ComboBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtUserInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTable
            // 
            this.dtTable.AllowUserToAddRows = false;
            this.dtTable.AllowUserToDeleteRows = false;
            this.dtTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTable.Location = new System.Drawing.Point(12, 33);
            this.dtTable.Name = "dtTable";
            this.dtTable.ReadOnly = true;
            this.dtTable.RowTemplate.Height = 24;
            this.dtTable.Size = new System.Drawing.Size(876, 422);
            this.dtTable.TabIndex = 0;
            // 
            // cbTableSelect
            // 
            this.cbTableSelect.FormattingEnabled = true;
            this.cbTableSelect.Location = new System.Drawing.Point(62, 478);
            this.cbTableSelect.Name = "cbTableSelect";
            this.cbTableSelect.Size = new System.Drawing.Size(200, 20);
            this.cbTableSelect.TabIndex = 1;
            // 
            // cbColumnSelect
            // 
            this.cbColumnSelect.FormattingEnabled = true;
            this.cbColumnSelect.Location = new System.Drawing.Point(62, 504);
            this.cbColumnSelect.Name = "cbColumnSelect";
            this.cbColumnSelect.Size = new System.Drawing.Size(200, 20);
            this.cbColumnSelect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Column:";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(315, 504);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(176, 22);
            this.txtTarget.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 600);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(479, 47);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(10, 537);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(33, 12);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "From:";
            // 
            // dtDateSelect
            // 
            this.dtDateSelect.Location = new System.Drawing.Point(62, 530);
            this.dtDateSelect.Name = "dtDateSelect";
            this.dtDateSelect.Size = new System.Drawing.Size(200, 22);
            this.dtDateSelect.TabIndex = 9;
            // 
            // cbDateSelect
            // 
            this.cbDateSelect.FormattingEnabled = true;
            this.cbDateSelect.Items.AddRange(new object[] {
            ">= (After and equle)",
            "<= (Before and equle)",
            "= (Exact)"});
            this.cbDateSelect.Location = new System.Drawing.Point(62, 558);
            this.cbDateSelect.Name = "cbDateSelect";
            this.cbDateSelect.Size = new System.Drawing.Size(200, 20);
            this.cbDateSelect.TabIndex = 10;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(13, 653);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(236, 47);
            this.btnDownload.TabIndex = 12;
            this.btnDownload.Text = "Export to PDF";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(255, 653);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(236, 47);
            this.btnDeleteRecord.TabIndex = 13;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // panelInsert
            // 
            this.panelInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInsert.Location = new System.Drawing.Point(894, 33);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(358, 369);
            this.panelInsert.TabIndex = 14;
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(894, 408);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(358, 47);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert Record";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtUserInfo
            // 
            this.txtUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUserInfo.Location = new System.Drawing.Point(894, 460);
            this.txtUserInfo.Name = "txtUserInfo";
            this.txtUserInfo.Padding = new System.Windows.Forms.Padding(10);
            this.txtUserInfo.Size = new System.Drawing.Size(358, 240);
            this.txtUserInfo.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 715);
            this.Controls.Add(this.txtUserInfo);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.cbDateSelect);
            this.Controls.Add(this.dtDateSelect);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbColumnSelect);
            this.Controls.Add(this.cbTableSelect);
            this.Controls.Add(this.dtTable);
            this.Controls.Add(this.panelInsert);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtTable;
        private System.Windows.Forms.ComboBox cbTableSelect;
        private System.Windows.Forms.ComboBox cbColumnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dtDateSelect;
        private System.Windows.Forms.ComboBox cbDateSelect;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label txtUserInfo;
    }
}