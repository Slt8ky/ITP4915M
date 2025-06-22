namespace Smile___Sunshine_Toy_System
{
    partial class Customer_Feedback
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ViewFBData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FBDate = new System.Windows.Forms.TextBox();
            this.FBCType = new System.Windows.Forms.ComboBox();
            this.FBPID = new System.Windows.Forms.TextBox();
            this.FBPIDText = new System.Windows.Forms.Label();
            this.FBOID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FBCInfo = new System.Windows.Forms.TextBox();
            this.ResetFB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FBType = new System.Windows.Forms.ComboBox();
            this.FBCID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteFB = new System.Windows.Forms.Button();
            this.UpdateFB = new System.Windows.Forms.Button();
            this.CreateFB = new System.Windows.Forms.Button();
            this.FBDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.FBSID = new System.Windows.Forms.TextBox();
            this.FBSearch = new System.Windows.Forms.Button();
            this.FBSearchText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FBID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ReloadFBView = new System.Windows.Forms.Button();
            this.FBTSConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFBData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewFBData
            // 
            this.ViewFBData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFBData.Location = new System.Drawing.Point(31, 72);
            this.ViewFBData.Name = "ViewFBData";
            this.ViewFBData.RowTemplate.Height = 24;
            this.ViewFBData.Size = new System.Drawing.Size(854, 411);
            this.ViewFBData.TabIndex = 17;
            this.ViewFBData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewFBData_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(357, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "Customer Feedback Page";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.FBDate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.FBCType);
            this.groupBox1.Controls.Add(this.FBID);
            this.groupBox1.Controls.Add(this.FBPID);
            this.groupBox1.Controls.Add(this.FBPIDText);
            this.groupBox1.Controls.Add(this.FBOID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.FBCInfo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ResetFB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.FBSID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FBType);
            this.groupBox1.Controls.Add(this.FBCID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(894, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(335, 479);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // FBDate
            // 
            this.FBDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBDate.Location = new System.Drawing.Point(28, 149);
            this.FBDate.Name = "FBDate";
            this.FBDate.Size = new System.Drawing.Size(120, 22);
            this.FBDate.TabIndex = 37;
            // 
            // FBCType
            // 
            this.FBCType.FormattingEnabled = true;
            this.FBCType.Items.AddRange(new object[] {
            "Email",
            "Phone",
            "Letter",
            "Message"});
            this.FBCType.Location = new System.Drawing.Point(28, 220);
            this.FBCType.Name = "FBCType";
            this.FBCType.Size = new System.Drawing.Size(120, 24);
            this.FBCType.TabIndex = 33;
            // 
            // FBPID
            // 
            this.FBPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBPID.Location = new System.Drawing.Point(191, 162);
            this.FBPID.Margin = new System.Windows.Forms.Padding(2);
            this.FBPID.Name = "FBPID";
            this.FBPID.Size = new System.Drawing.Size(121, 22);
            this.FBPID.TabIndex = 32;
            // 
            // FBPIDText
            // 
            this.FBPIDText.AutoSize = true;
            this.FBPIDText.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBPIDText.Location = new System.Drawing.Point(187, 144);
            this.FBPIDText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FBPIDText.Name = "FBPIDText";
            this.FBPIDText.Size = new System.Drawing.Size(72, 16);
            this.FBPIDText.TabIndex = 31;
            this.FBPIDText.Text = "Product ID";
            // 
            // FBOID
            // 
            this.FBOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBOID.Location = new System.Drawing.Point(191, 101);
            this.FBOID.Margin = new System.Windows.Forms.Padding(2);
            this.FBOID.Name = "FBOID";
            this.FBOID.Size = new System.Drawing.Size(121, 22);
            this.FBOID.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Contact Type";
            // 
            // FBCInfo
            // 
            this.FBCInfo.Location = new System.Drawing.Point(26, 298);
            this.FBCInfo.Multiline = true;
            this.FBCInfo.Name = "FBCInfo";
            this.FBCInfo.Size = new System.Drawing.Size(285, 62);
            this.FBCInfo.TabIndex = 21;
            // 
            // ResetFB
            // 
            this.ResetFB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResetFB.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFB.Location = new System.Drawing.Point(28, 390);
            this.ResetFB.Margin = new System.Windows.Forms.Padding(2);
            this.ResetFB.Name = "ResetFB";
            this.ResetFB.Size = new System.Drawing.Size(284, 61);
            this.ResetFB.TabIndex = 25;
            this.ResetFB.Text = "Reset Feedback";
            this.ResetFB.UseVisualStyleBackColor = false;
            this.ResetFB.Click += new System.EventHandler(this.ResetFB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Contact  Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data of feedback";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Client ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Feedback Type";
            // 
            // FBType
            // 
            this.FBType.FormattingEnabled = true;
            this.FBType.Items.AddRange(new object[] {
            "Quality",
            "Design",
            "Instructions ",
            "Packaging",
            "Features"});
            this.FBType.Location = new System.Drawing.Point(191, 220);
            this.FBType.Name = "FBType";
            this.FBType.Size = new System.Drawing.Size(121, 24);
            this.FBType.TabIndex = 13;
            // 
            // FBCID
            // 
            this.FBCID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBCID.Location = new System.Drawing.Point(28, 91);
            this.FBCID.Margin = new System.Windows.Forms.Padding(2);
            this.FBCID.Name = "FBCID";
            this.FBCID.Size = new System.Drawing.Size(120, 22);
            this.FBCID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order ID";
            // 
            // DeleteFB
            // 
            this.DeleteFB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DeleteFB.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFB.Location = new System.Drawing.Point(1062, 632);
            this.DeleteFB.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteFB.Name = "DeleteFB";
            this.DeleteFB.Size = new System.Drawing.Size(167, 61);
            this.DeleteFB.TabIndex = 27;
            this.DeleteFB.Text = "Delete Feedback";
            this.DeleteFB.UseVisualStyleBackColor = false;
            this.DeleteFB.Click += new System.EventHandler(this.DeleteFB_Click);
            // 
            // UpdateFB
            // 
            this.UpdateFB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UpdateFB.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFB.Location = new System.Drawing.Point(1062, 558);
            this.UpdateFB.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateFB.Name = "UpdateFB";
            this.UpdateFB.Size = new System.Drawing.Size(167, 61);
            this.UpdateFB.TabIndex = 26;
            this.UpdateFB.Text = "Update Feedback";
            this.UpdateFB.UseVisualStyleBackColor = false;
            this.UpdateFB.Click += new System.EventHandler(this.UpdateFB_Click);
            // 
            // CreateFB
            // 
            this.CreateFB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateFB.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFB.Location = new System.Drawing.Point(894, 632);
            this.CreateFB.Margin = new System.Windows.Forms.Padding(2);
            this.CreateFB.Name = "CreateFB";
            this.CreateFB.Size = new System.Drawing.Size(167, 61);
            this.CreateFB.TabIndex = 24;
            this.CreateFB.Text = "Create Feedback";
            this.CreateFB.UseVisualStyleBackColor = false;
            this.CreateFB.Click += new System.EventHandler(this.CreateFB_Click);
            // 
            // FBDetail
            // 
            this.FBDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FBDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBDetail.Location = new System.Drawing.Point(32, 508);
            this.FBDetail.Margin = new System.Windows.Forms.Padding(2);
            this.FBDetail.Multiline = true;
            this.FBDetail.Name = "FBDetail";
            this.FBDetail.Size = new System.Drawing.Size(853, 192);
            this.FBDetail.TabIndex = 23;
            this.FBDetail.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Feedback Detail";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(894, 9);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(335, 30);
            this.ExitButton.TabIndex = 31;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Staff ID";
            // 
            // FBSID
            // 
            this.FBSID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBSID.Location = new System.Drawing.Point(189, 40);
            this.FBSID.Margin = new System.Windows.Forms.Padding(2);
            this.FBSID.Name = "FBSID";
            this.FBSID.Size = new System.Drawing.Size(122, 22);
            this.FBSID.TabIndex = 40;
            // 
            // FBSearch
            // 
            this.FBSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FBSearch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.FBSearch.Location = new System.Drawing.Point(806, 9);
            this.FBSearch.Name = "FBSearch";
            this.FBSearch.Size = new System.Drawing.Size(79, 57);
            this.FBSearch.TabIndex = 42;
            this.FBSearch.Text = "Search";
            this.FBSearch.UseVisualStyleBackColor = false;
            this.FBSearch.Click += new System.EventHandler(this.FBSearch_Click);
            // 
            // FBSearchText
            // 
            this.FBSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBSearchText.Location = new System.Drawing.Point(518, 9);
            this.FBSearchText.Margin = new System.Windows.Forms.Padding(2);
            this.FBSearchText.Multiline = true;
            this.FBSearchText.Name = "FBSearchText";
            this.FBSearchText.Size = new System.Drawing.Size(283, 58);
            this.FBSearchText.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Feedback ID";
            // 
            // FBID
            // 
            this.FBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBID.Location = new System.Drawing.Point(27, 40);
            this.FBID.Margin = new System.Windows.Forms.Padding(2);
            this.FBID.Name = "FBID";
            this.FBID.ReadOnly = true;
            this.FBID.Size = new System.Drawing.Size(120, 22);
            this.FBID.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(530, 170);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 38;
            // 
            // ReloadFBView
            // 
            this.ReloadFBView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReloadFBView.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadFBView.Location = new System.Drawing.Point(894, 558);
            this.ReloadFBView.Margin = new System.Windows.Forms.Padding(2);
            this.ReloadFBView.Name = "ReloadFBView";
            this.ReloadFBView.Size = new System.Drawing.Size(167, 61);
            this.ReloadFBView.TabIndex = 44;
            this.ReloadFBView.Text = "Reload Database";
            this.ReloadFBView.UseVisualStyleBackColor = false;
            this.ReloadFBView.Click += new System.EventHandler(this.ReloadFBView_Click);
            // 
            // FBTSConnect
            // 
            this.FBTSConnect.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FBTSConnect.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBTSConnect.Location = new System.Drawing.Point(894, 43);
            this.FBTSConnect.Margin = new System.Windows.Forms.Padding(2);
            this.FBTSConnect.Name = "FBTSConnect";
            this.FBTSConnect.Size = new System.Drawing.Size(335, 29);
            this.FBTSConnect.TabIndex = 32;
            this.FBTSConnect.Text = "Test Connect";
            this.FBTSConnect.UseVisualStyleBackColor = false;
            this.FBTSConnect.Click += new System.EventHandler(this.FBTSConnect_Click);
            // 
            // Customer_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.ReloadFBView);
            this.Controls.Add(this.FBSearchText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.FBSearch);
            this.Controls.Add(this.FBTSConnect);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteFB);
            this.Controls.Add(this.UpdateFB);
            this.Controls.Add(this.CreateFB);
            this.Controls.Add(this.FBDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ViewFBData);
            this.Name = "Customer_Feedback";
            this.Text = "After Service Management Page";
            this.Load += new System.EventHandler(this.Customer_Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewFBData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewFBData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FBDate;
        private System.Windows.Forms.ComboBox FBCType;
        private System.Windows.Forms.TextBox FBPID;
        private System.Windows.Forms.Label FBPIDText;
        private System.Windows.Forms.TextBox FBOID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FBCInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FBType;
        private System.Windows.Forms.TextBox FBCID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteFB;
        private System.Windows.Forms.Button UpdateFB;
        private System.Windows.Forms.Button ResetFB;
        private System.Windows.Forms.Button CreateFB;
        private System.Windows.Forms.TextBox FBDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FBSID;
        private System.Windows.Forms.Button FBSearch;
        private System.Windows.Forms.TextBox FBSearchText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FBID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ReloadFBView;
        private System.Windows.Forms.Button FBTSConnect;
    }
}

