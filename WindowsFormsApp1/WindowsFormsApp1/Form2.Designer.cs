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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
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
            this.dtTable.Location = new System.Drawing.Point(12, 12);
            this.dtTable.Name = "dtTable";
            this.dtTable.ReadOnly = true;
            this.dtTable.RowTemplate.Height = 24;
            this.dtTable.Size = new System.Drawing.Size(1240, 422);
            this.dtTable.TabIndex = 0;
            // 
            // cbTableSelect
            // 
            this.cbTableSelect.FormattingEnabled = true;
            this.cbTableSelect.Location = new System.Drawing.Point(65, 440);
            this.cbTableSelect.Name = "cbTableSelect";
            this.cbTableSelect.Size = new System.Drawing.Size(200, 20);
            this.cbTableSelect.TabIndex = 1;
            // 
            // cbColumnSelect
            // 
            this.cbColumnSelect.FormattingEnabled = true;
            this.cbColumnSelect.Location = new System.Drawing.Point(65, 466);
            this.cbColumnSelect.Name = "cbColumnSelect";
            this.cbColumnSelect.Size = new System.Drawing.Size(200, 20);
            this.cbColumnSelect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Column:";
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(318, 466);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(176, 22);
            this.txtTarget.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 622);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 47);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(13, 499);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(33, 12);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "From:";
            // 
            // dtDateSelect
            // 
            this.dtDateSelect.Location = new System.Drawing.Point(65, 492);
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
            this.cbDateSelect.Location = new System.Drawing.Point(65, 520);
            this.cbDateSelect.Name = "cbDateSelect";
            this.cbDateSelect.Size = new System.Drawing.Size(121, 20);
            this.cbDateSelect.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(660, 22);
            this.textBox1.TabIndex = 11;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(176, 622);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(158, 47);
            this.btnDownload.TabIndex = 12;
            this.btnDownload.Text = "Export to PDF";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDownload;
    }
}