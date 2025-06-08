namespace Smile___Sunshine_Toy_System.Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Feedback));
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FBCType = new System.Windows.Forms.ComboBox();
            this.FBPID = new System.Windows.Forms.TextBox();
            this.FBPIDText = new System.Windows.Forms.Label();
            this.FBOID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FBInteraction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FBCInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FBDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FBType = new System.Windows.Forms.ComboBox();
            this.FBDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FBCID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FBSID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ViewFBData = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StaffText = new System.Windows.Forms.Label();
            this.FBTSConnectBT = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFBData)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResetButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(11, 622);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(423, 61);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset Feedback";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.FBCType);
            this.groupBox1.Controls.Add(this.FBPID);
            this.groupBox1.Controls.Add(this.FBPIDText);
            this.groupBox1.Controls.Add(this.FBOID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.FBInteraction);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.FBCInfo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.FBDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.FBType);
            this.groupBox1.Controls.Add(this.FBDetail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FBCID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(894, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(329, 704);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // FBCType
            // 
            this.FBCType.FormattingEnabled = true;
            this.FBCType.Items.AddRange(new object[] {
            "Email",
            "Phone",
            "Letter",
            "Other"});
            this.FBCType.Location = new System.Drawing.Point(196, 164);
            this.FBCType.Name = "FBCType";
            this.FBCType.Size = new System.Drawing.Size(113, 24);
            this.FBCType.TabIndex = 33;
            // 
            // FBPID
            // 
            this.FBPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBPID.Location = new System.Drawing.Point(25, 101);
            this.FBPID.Margin = new System.Windows.Forms.Padding(2);
            this.FBPID.Name = "FBPID";
            this.FBPID.Size = new System.Drawing.Size(121, 22);
            this.FBPID.TabIndex = 32;
            // 
            // FBPIDText
            // 
            this.FBPIDText.AutoSize = true;
            this.FBPIDText.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBPIDText.Location = new System.Drawing.Point(21, 83);
            this.FBPIDText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FBPIDText.Name = "FBPIDText";
            this.FBPIDText.Size = new System.Drawing.Size(72, 16);
            this.FBPIDText.TabIndex = 31;
            this.FBPIDText.Text = "Product ID";
            // 
            // FBOID
            // 
            this.FBOID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBOID.Location = new System.Drawing.Point(25, 44);
            this.FBOID.Margin = new System.Windows.Forms.Padding(2);
            this.FBOID.Name = "FBOID";
            this.FBOID.Size = new System.Drawing.Size(121, 22);
            this.FBOID.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Contact Type";
            // 
            // FBInteraction
            // 
            this.FBInteraction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBInteraction.Location = new System.Drawing.Point(25, 300);
            this.FBInteraction.Multiline = true;
            this.FBInteraction.Name = "FBInteraction";
            this.FBInteraction.Size = new System.Drawing.Size(285, 123);
            this.FBInteraction.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Interaction";
            // 
            // FBCInfo
            // 
            this.FBCInfo.Location = new System.Drawing.Point(25, 231);
            this.FBCInfo.Name = "FBCInfo";
            this.FBCInfo.Size = new System.Drawing.Size(285, 22);
            this.FBCInfo.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Contact  Information";
            // 
            // FBDate
            // 
            this.FBDate.Location = new System.Drawing.Point(196, 102);
            this.FBDate.Name = "FBDate";
            this.FBDate.Size = new System.Drawing.Size(113, 22);
            this.FBDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data of feedback";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 26);
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
            this.label4.Location = new System.Drawing.Point(21, 141);
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
            this.FBType.Location = new System.Drawing.Point(24, 164);
            this.FBType.Name = "FBType";
            this.FBType.Size = new System.Drawing.Size(121, 24);
            this.FBType.TabIndex = 13;
            // 
            // FBDetail
            // 
            this.FBDetail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FBDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBDetail.Location = new System.Drawing.Point(25, 456);
            this.FBDetail.Margin = new System.Windows.Forms.Padding(2);
            this.FBDetail.Multiline = true;
            this.FBDetail.Name = "FBDetail";
            this.FBDetail.Size = new System.Drawing.Size(285, 229);
            this.FBDetail.TabIndex = 10;
            this.FBDetail.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Feedback Detail";
            // 
            // FBCID
            // 
            this.FBCID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBCID.Location = new System.Drawing.Point(197, 44);
            this.FBCID.Margin = new System.Windows.Forms.Padding(2);
            this.FBCID.Name = "FBCID";
            this.FBCID.Size = new System.Drawing.Size(113, 22);
            this.FBCID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order ID";
            // 
            // FBSID
            // 
            this.FBSID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FBSID.Location = new System.Drawing.Point(757, 61);
            this.FBSID.Margin = new System.Windows.Forms.Padding(2);
            this.FBSID.Name = "FBSID";
            this.FBSID.Size = new System.Drawing.Size(121, 22);
            this.FBSID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 25.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(449, 40);
            this.label7.TabIndex = 19;
            this.label7.Text = "Customer Feedback Page";
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(11, 557);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(423, 61);
            this.CreateButton.TabIndex = 14;
            this.CreateButton.Text = "Create Feedback";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ViewFBData
            // 
            this.ViewFBData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFBData.Location = new System.Drawing.Point(12, 89);
            this.ViewFBData.Name = "ViewFBData";
            this.ViewFBData.RowTemplate.Height = 24;
            this.ViewFBData.Size = new System.Drawing.Size(866, 463);
            this.ViewFBData.TabIndex = 16;
            this.ViewFBData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewFBData_CellClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UpdateButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(451, 557);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(428, 61);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update Feedback";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DeleteButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(451, 622);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(428, 61);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete Feedback";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1069, 9);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(154, 32);
            this.ExitButton.TabIndex = 20;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StaffText
            // 
            this.StaffText.AutoSize = true;
            this.StaffText.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffText.Location = new System.Drawing.Point(682, 63);
            this.StaffText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StaffText.Name = "StaffText";
            this.StaffText.Size = new System.Drawing.Size(54, 16);
            this.StaffText.TabIndex = 29;
            this.StaffText.Text = "Staff ID";
            // 
            // FBTSConnectBT
            // 
            this.FBTSConnectBT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FBTSConnectBT.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FBTSConnectBT.Location = new System.Drawing.Point(911, 9);
            this.FBTSConnectBT.Margin = new System.Windows.Forms.Padding(2);
            this.FBTSConnectBT.Name = "FBTSConnectBT";
            this.FBTSConnectBT.Size = new System.Drawing.Size(154, 32);
            this.FBTSConnectBT.TabIndex = 30;
            this.FBTSConnectBT.Text = "Test Connect";
            this.FBTSConnectBT.UseVisualStyleBackColor = false;
            this.FBTSConnectBT.Click += new System.EventHandler(this.FBTSConnectBT_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSend.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btnSend.Location = new System.Drawing.Point(10, 688);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(868, 61);
            this.btnSend.TabIndex = 31;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1234, 764);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.FBTSConnectBT);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.StaffText);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ViewFBData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FBSID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Feedback";
            this.Text = "Customer Feedback";
            this.Load += new System.EventHandler(this.Customer_Feedback_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFBData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FBDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FBSID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FBType;
        private System.Windows.Forms.TextBox FBDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FBCID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView ViewFBData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox FBCInfo;
        private System.Windows.Forms.TextBox FBInteraction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox FBPID;
        private System.Windows.Forms.Label FBPIDText;
        private System.Windows.Forms.TextBox FBOID;
        private System.Windows.Forms.Label StaffText;
        private System.Windows.Forms.ComboBox FBCType;
        private System.Windows.Forms.Button FBTSConnectBT;
        private System.Windows.Forms.Button btnSend;
    }
}