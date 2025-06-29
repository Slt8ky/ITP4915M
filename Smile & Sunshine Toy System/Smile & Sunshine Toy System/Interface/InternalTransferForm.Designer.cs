namespace Smile___Sunshine_Toy_System.Interface
{
    partial class InternalTransferForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MRFDestinationLable = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.ResetMRForm = new System.Windows.Forms.Button();
            this.SubmitITForm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TransferItemName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ITReason = new System.Windows.Forms.TextBox();
            this.ITFSpecification = new System.Windows.Forms.TextBox();
            this.ITFDescriptions = new System.Windows.Forms.TextBox();
            this.TransferItemType = new System.Windows.Forms.ComboBox();
            this.TransferAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TSource = new System.Windows.Forms.Label();
            this.ITSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ITDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DestinationDepartment = new System.Windows.Forms.TextBox();
            this.MRFStaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label13.Location = new System.Drawing.Point(1006, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "Staff ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MRFDestinationLable);
            this.groupBox1.Controls.Add(this.OrderID);
            this.groupBox1.Controls.Add(this.ResetMRForm);
            this.groupBox1.Controls.Add(this.SubmitITForm);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TransferItemName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ITReason);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ITFSpecification);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ITFDescriptions);
            this.groupBox1.Controls.Add(this.TransferItemType);
            this.groupBox1.Controls.Add(this.TransferAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TSource);
            this.groupBox1.Controls.Add(this.ITSource);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ITDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DestinationDepartment);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1145, 657);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Internal Transfer Form";
            // 
            // MRFDestinationLable
            // 
            this.MRFDestinationLable.AutoSize = true;
            this.MRFDestinationLable.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRFDestinationLable.Location = new System.Drawing.Point(466, 58);
            this.MRFDestinationLable.Name = "MRFDestinationLable";
            this.MRFDestinationLable.Size = new System.Drawing.Size(73, 20);
            this.MRFDestinationLable.TabIndex = 32;
            this.MRFDestinationLable.Text = "Order ID";
            // 
            // OrderID
            // 
            this.OrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderID.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.OrderID.Location = new System.Drawing.Point(545, 53);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(133, 27);
            this.OrderID.TabIndex = 31;
            // 
            // ResetMRForm
            // 
            this.ResetMRForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResetMRForm.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetMRForm.Location = new System.Drawing.Point(903, 605);
            this.ResetMRForm.Margin = new System.Windows.Forms.Padding(2);
            this.ResetMRForm.Name = "ResetMRForm";
            this.ResetMRForm.Size = new System.Drawing.Size(167, 42);
            this.ResetMRForm.TabIndex = 30;
            this.ResetMRForm.TabStop = false;
            this.ResetMRForm.Text = "Reset ";
            this.ResetMRForm.UseVisualStyleBackColor = false;
            this.ResetMRForm.Click += new System.EventHandler(this.ResetMRForm_Click);
            // 
            // SubmitITForm
            // 
            this.SubmitITForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SubmitITForm.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitITForm.Location = new System.Drawing.Point(694, 605);
            this.SubmitITForm.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitITForm.Name = "SubmitITForm";
            this.SubmitITForm.Size = new System.Drawing.Size(167, 41);
            this.SubmitITForm.TabIndex = 29;
            this.SubmitITForm.Text = "Submit";
            this.SubmitITForm.UseVisualStyleBackColor = false;
            this.SubmitITForm.Click += new System.EventHandler(this.SubmitITForm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label9.Location = new System.Drawing.Point(60, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Transfer Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label8.Location = new System.Drawing.Point(60, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Transfer Item Name";
            // 
            // TransferItemName
            // 
            this.TransferItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransferItemName.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.TransferItemName.Location = new System.Drawing.Point(247, 293);
            this.TransferItemName.Name = "TransferItemName";
            this.TransferItemName.Size = new System.Drawing.Size(214, 27);
            this.TransferItemName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label7.Location = new System.Drawing.Point(60, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Transfer Reason";
            // 
            // ITReason
            // 
            this.ITReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ITReason.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.ITReason.Location = new System.Drawing.Point(64, 456);
            this.ITReason.Multiline = true;
            this.ITReason.Name = "ITReason";
            this.ITReason.Size = new System.Drawing.Size(1014, 133);
            this.ITReason.TabIndex = 19;
            // 
            // ITFSpecification
            // 
            this.ITFSpecification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ITFSpecification.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.ITFSpecification.Location = new System.Drawing.Point(499, 148);
            this.ITFSpecification.Multiline = true;
            this.ITFSpecification.Name = "ITFSpecification";
            this.ITFSpecification.Size = new System.Drawing.Size(579, 112);
            this.ITFSpecification.TabIndex = 17;
            // 
            // ITFDescriptions
            // 
            this.ITFDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ITFDescriptions.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.ITFDescriptions.Location = new System.Drawing.Point(498, 295);
            this.ITFDescriptions.Multiline = true;
            this.ITFDescriptions.Name = "ITFDescriptions";
            this.ITFDescriptions.Size = new System.Drawing.Size(580, 112);
            this.ITFDescriptions.TabIndex = 15;
            // 
            // TransferItemType
            // 
            this.TransferItemType.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.TransferItemType.FormattingEnabled = true;
            this.TransferItemType.Items.AddRange(new object[] {
            "CompletedProduct",
            "Material"});
            this.TransferItemType.Location = new System.Drawing.Point(247, 209);
            this.TransferItemType.Name = "TransferItemType";
            this.TransferItemType.Size = new System.Drawing.Size(214, 28);
            this.TransferItemType.TabIndex = 14;
            // 
            // TransferAmount
            // 
            this.TransferAmount.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.TransferAmount.Location = new System.Drawing.Point(247, 366);
            this.TransferAmount.Name = "TransferAmount";
            this.TransferAmount.Size = new System.Drawing.Size(214, 27);
            this.TransferAmount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label3.Location = new System.Drawing.Point(60, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Transfer Item Type";
            // 
            // TSource
            // 
            this.TSource.AutoSize = true;
            this.TSource.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.TSource.Location = new System.Drawing.Point(690, 57);
            this.TSource.Name = "TSource";
            this.TSource.Size = new System.Drawing.Size(120, 20);
            this.TSource.TabIndex = 10;
            this.TSource.Text = "Transfer Source";
            // 
            // ITSource
            // 
            this.ITSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ITSource.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.ITSource.Location = new System.Drawing.Point(816, 53);
            this.ITSource.Name = "ITSource";
            this.ITSource.Size = new System.Drawing.Size(262, 27);
            this.ITSource.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label2.Location = new System.Drawing.Point(60, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination Department";
            // 
            // ITDate
            // 
            this.ITDate.CalendarFont = new System.Drawing.Font("新細明體", 14F);
            this.ITDate.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.ITDate.Location = new System.Drawing.Point(247, 57);
            this.ITDate.Name = "ITDate";
            this.ITDate.Size = new System.Drawing.Size(200, 27);
            this.ITDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date of Initiation";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // DestinationDepartment
            // 
            this.DestinationDepartment.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DestinationDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationDepartment.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.DestinationDepartment.Location = new System.Drawing.Point(247, 134);
            this.DestinationDepartment.Name = "DestinationDepartment";
            this.DestinationDepartment.Size = new System.Drawing.Size(214, 27);
            this.DestinationDepartment.TabIndex = 0;
            // 
            // MRFStaffID
            // 
            this.MRFStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MRFStaffID.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRFStaffID.Location = new System.Drawing.Point(1073, 10);
            this.MRFStaffID.Name = "MRFStaffID";
            this.MRFStaffID.Size = new System.Drawing.Size(117, 27);
            this.MRFStaffID.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label5.Location = new System.Drawing.Point(495, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descriptions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label6.Location = new System.Drawing.Point(496, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Specification";
            // 
            // internaltransferform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MRFStaffID);
            this.Name = "internaltransferform";
            this.Text = "internaltransferform";
            this.Load += new System.EventHandler(this.internaltransferform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransferAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MRFDestinationLable;
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.Button ResetMRForm;
        private System.Windows.Forms.Button SubmitITForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TransferItemName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ITReason;
        private System.Windows.Forms.TextBox ITFSpecification;
        private System.Windows.Forms.TextBox ITFDescriptions;
        private System.Windows.Forms.ComboBox TransferItemType;
        private System.Windows.Forms.NumericUpDown TransferAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TSource;
        private System.Windows.Forms.TextBox ITSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ITDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DestinationDepartment;
        private System.Windows.Forms.TextBox MRFStaffID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

