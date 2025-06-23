namespace Material_Requirement_Form
{
    partial class MaterialRequirementForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MRFPLevel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MRFMID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MRFRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MRFSpecification = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MRFDescriptions = new System.Windows.Forms.TextBox();
            this.MRPType = new System.Windows.Forms.ComboBox();
            this.MRDMAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MRPName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IsDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.MRPID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MRFDDate = new System.Windows.Forms.DateTimePicker();
            this.SubmitMRForm = new System.Windows.Forms.Button();
            this.ResetMRForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MRDMAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResetMRForm);
            this.groupBox1.Controls.Add(this.SubmitMRForm);
            this.groupBox1.Controls.Add(this.MRFDDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.MRFPLevel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MRFMID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MRFRemarks);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MRFSpecification);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MRFDescriptions);
            this.groupBox1.Controls.Add(this.MRPType);
            this.groupBox1.Controls.Add(this.MRDMAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MRPName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IsDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MRPID);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 687);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Requirement Form";
            // 
            // MRFPLevel
            // 
            this.MRFPLevel.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRFPLevel.FormattingEnabled = true;
            this.MRFPLevel.Items.AddRange(new object[] {
            "Normal",
            "Emergency"});
            this.MRFPLevel.Location = new System.Drawing.Point(196, 189);
            this.MRFPLevel.Name = "MRFPLevel";
            this.MRFPLevel.Size = new System.Drawing.Size(176, 28);
            this.MRFPLevel.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label10.Location = new System.Drawing.Point(71, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Priority Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label9.Location = new System.Drawing.Point(782, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "MaterialAmount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label8.Location = new System.Drawing.Point(452, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Material ID";
            // 
            // MRFMID
            // 
            this.MRFMID.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRFMID.Location = new System.Drawing.Point(555, 122);
            this.MRFMID.Name = "MRFMID";
            this.MRFMID.Size = new System.Drawing.Size(133, 27);
            this.MRFMID.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label7.Location = new System.Drawing.Point(71, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Remarks";
            // 
            // MRFRemarks
            // 
            this.MRFRemarks.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRFRemarks.Location = new System.Drawing.Point(73, 438);
            this.MRFRemarks.Multiline = true;
            this.MRFRemarks.Name = "MRFRemarks";
            this.MRFRemarks.Size = new System.Drawing.Size(1008, 133);
            this.MRFRemarks.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label6.Location = new System.Drawing.Point(695, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Specification";
            // 
            // MRFSpecification
            // 
            this.MRFSpecification.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRFSpecification.Location = new System.Drawing.Point(699, 269);
            this.MRFSpecification.Multiline = true;
            this.MRFSpecification.Name = "MRFSpecification";
            this.MRFSpecification.Size = new System.Drawing.Size(371, 112);
            this.MRFSpecification.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label5.Location = new System.Drawing.Point(72, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descriptions";
            // 
            // MRFDescriptions
            // 
            this.MRFDescriptions.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRFDescriptions.Location = new System.Drawing.Point(75, 268);
            this.MRFDescriptions.Multiline = true;
            this.MRFDescriptions.Name = "MRFDescriptions";
            this.MRFDescriptions.Size = new System.Drawing.Size(571, 112);
            this.MRFDescriptions.TabIndex = 15;
            // 
            // MRPType
            // 
            this.MRPType.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRPType.FormattingEnabled = true;
            this.MRPType.Items.AddRange(new object[] {
            "car",
            "Animals",
            "Construction toys",
            "Dolls",
            "Food-related toys"});
            this.MRPType.Location = new System.Drawing.Point(196, 121);
            this.MRPType.Name = "MRPType";
            this.MRPType.Size = new System.Drawing.Size(176, 28);
            this.MRPType.TabIndex = 14;
            // 
            // MRDMAmount
            // 
            this.MRDMAmount.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRDMAmount.Location = new System.Drawing.Point(916, 123);
            this.MRDMAmount.Name = "MRDMAmount";
            this.MRDMAmount.Size = new System.Drawing.Size(120, 27);
            this.MRDMAmount.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label3.Location = new System.Drawing.Point(71, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label4.Location = new System.Drawing.Point(782, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product Name";
            // 
            // MRPName
            // 
            this.MRPName.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRPName.Location = new System.Drawing.Point(916, 57);
            this.MRPName.Name = "MRPName";
            this.MRPName.Size = new System.Drawing.Size(117, 27);
            this.MRPName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.label2.Location = new System.Drawing.Point(452, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product ID";
            // 
            // IsDate
            // 
            this.IsDate.CalendarFont = new System.Drawing.Font("新細明體", 14F);
            this.IsDate.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.IsDate.Location = new System.Drawing.Point(196, 55);
            this.IsDate.Name = "IsDate";
            this.IsDate.Size = new System.Drawing.Size(200, 27);
            this.IsDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Issuance Date";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // MRPID
            // 
            this.MRPID.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRPID.Location = new System.Drawing.Point(555, 58);
            this.MRPID.Name = "MRPID";
            this.MRPID.Size = new System.Drawing.Size(133, 27);
            this.MRPID.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(452, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "DeliveryDate";
            // 
            // MRFDDate
            // 
            this.MRFDDate.CalendarFont = new System.Drawing.Font("新細明體", 14F);
            this.MRFDDate.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.MRFDDate.Location = new System.Drawing.Point(562, 197);
            this.MRFDDate.Name = "MRFDDate";
            this.MRFDDate.Size = new System.Drawing.Size(200, 27);
            this.MRFDDate.TabIndex = 28;
            // 
            // SubmitMRForm
            // 
            this.SubmitMRForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SubmitMRForm.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitMRForm.Location = new System.Drawing.Point(710, 605);
            this.SubmitMRForm.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitMRForm.Name = "SubmitMRForm";
            this.SubmitMRForm.Size = new System.Drawing.Size(167, 61);
            this.SubmitMRForm.TabIndex = 29;
            this.SubmitMRForm.Text = "Submit";
            this.SubmitMRForm.UseVisualStyleBackColor = false;
            this.SubmitMRForm.Click += new System.EventHandler(this.SubmitMRForm_Click);
            // 
            // ResetMRForm
            // 
            this.ResetMRForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResetMRForm.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetMRForm.Location = new System.Drawing.Point(903, 605);
            this.ResetMRForm.Margin = new System.Windows.Forms.Padding(2);
            this.ResetMRForm.Name = "ResetMRForm";
            this.ResetMRForm.Size = new System.Drawing.Size(167, 61);
            this.ResetMRForm.TabIndex = 30;
            this.ResetMRForm.TabStop = false;
            this.ResetMRForm.Text = "Reset ";
            this.ResetMRForm.UseVisualStyleBackColor = false;
            this.ResetMRForm.Click += new System.EventHandler(this.ResetMRForm_Click);
            // 
            // MaterialRequirementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.groupBox1);
            this.Name = "MaterialRequirementForm";
            this.Text = "Material Requirement Form";
            this.Load += new System.EventHandler(this.MaterialRequirementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MRDMAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MRPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker IsDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MRPName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MRPType;
        private System.Windows.Forms.NumericUpDown MRDMAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MRFRemarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MRFSpecification;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MRFDescriptions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MRFMID;
        private System.Windows.Forms.ComboBox MRFPLevel;
        private System.Windows.Forms.DateTimePicker MRFDDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ResetMRForm;
        private System.Windows.Forms.Button SubmitMRForm;
    }
}

