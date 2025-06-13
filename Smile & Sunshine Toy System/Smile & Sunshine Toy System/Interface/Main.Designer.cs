namespace Smile___Sunshine_Toy_System.Interface
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.lvTable = new System.Windows.Forms.ListView();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.gbColumn = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbColumnPanel = new System.Windows.Forms.GroupBox();
            this.tc1 = new System.Windows.Forms.TabControl();
            this.btnExportToDeliveryNote = new System.Windows.Forms.Button();
            this.gbPreference = new System.Windows.Forms.GroupBox();
            this.cbLocalization = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpDeliveryNote = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbColumn.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tc1.SuspendLayout();
            this.gbPreference.SuspendLayout();
            this.gpDeliveryNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbTable);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            resources.ApplyResources(this.cbTable, "cbTable");
            this.cbTable.Name = "cbTable";
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtValue);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbColumn);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnReload
            // 
            resources.ApplyResources(this.btnReload, "btnReload");
            this.btnReload.Name = "btnReload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtValue
            // 
            resources.ApplyResources(this.txtValue, "txtValue");
            this.txtValue.Name = "txtValue";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbColumn
            // 
            this.cbColumn.FormattingEnabled = true;
            resources.ApplyResources(this.cbColumn, "cbColumn");
            this.cbColumn.Name = "cbColumn";
            // 
            // lvTable
            // 
            this.lvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTable.HideSelection = false;
            resources.ApplyResources(this.lvTable, "lvTable");
            this.lvTable.Name = "lvTable";
            this.lvTable.UseCompatibleStateImageBehavior = false;
            this.lvTable.SelectedIndexChanged += new System.EventHandler(this.lvTable_SelectedIndexChanged);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.BackColor = System.Drawing.Color.White;
            this.rtbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbDisplay, "rtbDisplay");
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            // 
            // gbColumn
            // 
            this.gbColumn.BackColor = System.Drawing.Color.White;
            this.gbColumn.Controls.Add(this.lvTable);
            resources.ApplyResources(this.gbColumn, "gbColumn");
            this.gbColumn.Name = "gbColumn";
            this.gbColumn.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.rtbDisplay);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.gbColumnPanel);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInsert);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnDelete);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbColumnPanel
            // 
            this.gbColumnPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.gbColumnPanel, "gbColumnPanel");
            this.gbColumnPanel.Name = "gbColumnPanel";
            this.gbColumnPanel.TabStop = false;
            // 
            // tc1
            // 
            this.tc1.Controls.Add(this.tabPage1);
            this.tc1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tc1, "tc1");
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            // 
            // btnExportToDeliveryNote
            // 
            resources.ApplyResources(this.btnExportToDeliveryNote, "btnExportToDeliveryNote");
            this.btnExportToDeliveryNote.Name = "btnExportToDeliveryNote";
            this.btnExportToDeliveryNote.UseVisualStyleBackColor = true;
            this.btnExportToDeliveryNote.Click += new System.EventHandler(this.btnExportToDeliveryNote_Click);
            // 
            // gbPreference
            // 
            this.gbPreference.Controls.Add(this.cbLocalization);
            this.gbPreference.Controls.Add(this.label3);
            resources.ApplyResources(this.gbPreference, "gbPreference");
            this.gbPreference.Name = "gbPreference";
            this.gbPreference.TabStop = false;
            // 
            // cbLocalization
            // 
            this.cbLocalization.FormattingEnabled = true;
            this.cbLocalization.Items.AddRange(new object[] {
            resources.GetString("cbLocalization.Items"),
            resources.GetString("cbLocalization.Items1")});
            resources.ApplyResources(this.cbLocalization, "cbLocalization");
            this.cbLocalization.Name = "cbLocalization";
            this.cbLocalization.SelectedIndexChanged += new System.EventHandler(this.cbLocalization_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // gpDeliveryNote
            // 
            this.gpDeliveryNote.Controls.Add(this.btnExportToDeliveryNote);
            resources.ApplyResources(this.gpDeliveryNote, "gpDeliveryNote");
            this.gpDeliveryNote.Name = "gpDeliveryNote";
            this.gpDeliveryNote.TabStop = false;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gpDeliveryNote);
            this.Controls.Add(this.gbPreference);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tc1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbColumn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbColumn.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tc1.ResumeLayout(false);
            this.gbPreference.ResumeLayout(false);
            this.gbPreference.PerformLayout();
            this.gpDeliveryNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvTable;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.GroupBox gbColumn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbColumnPanel;
        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox gbPreference;
        private System.Windows.Forms.ComboBox cbLocalization;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpDeliveryNote;
        public System.Windows.Forms.Button btnExportToDeliveryNote;
    }
}