namespace Smile___Sunshine_Toy_System.Interface
{
    partial class SocketService
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
            this.createbut = new System.Windows.Forms.Button();
            this.sendbut = new System.Windows.Forms.Button();
            this.sendtext = new System.Windows.Forms.TextBox();
            this.messagetext = new System.Windows.Forms.TextBox();
            this.Porttext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IPtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createbut
            // 
            this.createbut.Location = new System.Drawing.Point(549, 41);
            this.createbut.Name = "createbut";
            this.createbut.Size = new System.Drawing.Size(75, 24);
            this.createbut.TabIndex = 31;
            this.createbut.Text = "create";
            this.createbut.UseVisualStyleBackColor = true;
            this.createbut.Click += new System.EventHandler(this.createbut_Click);
            // 
            // sendbut
            // 
            this.sendbut.Location = new System.Drawing.Point(523, 362);
            this.sendbut.Name = "sendbut";
            this.sendbut.Size = new System.Drawing.Size(75, 39);
            this.sendbut.TabIndex = 30;
            this.sendbut.Text = "send";
            this.sendbut.UseVisualStyleBackColor = true;
            this.sendbut.Click += new System.EventHandler(this.sendbut_Click);
            // 
            // sendtext
            // 
            this.sendtext.Location = new System.Drawing.Point(179, 353);
            this.sendtext.Multiline = true;
            this.sendtext.Name = "sendtext";
            this.sendtext.Size = new System.Drawing.Size(299, 58);
            this.sendtext.TabIndex = 29;
            // 
            // messagetext
            // 
            this.messagetext.Location = new System.Drawing.Point(179, 89);
            this.messagetext.Multiline = true;
            this.messagetext.Name = "messagetext";
            this.messagetext.Size = new System.Drawing.Size(445, 245);
            this.messagetext.TabIndex = 28;
            // 
            // Porttext
            // 
            this.Porttext.Location = new System.Drawing.Point(436, 40);
            this.Porttext.Name = "Porttext";
            this.Porttext.Size = new System.Drawing.Size(90, 22);
            this.Porttext.TabIndex = 27;
            this.Porttext.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "Port";
            // 
            // IPtext
            // 
            this.IPtext.Location = new System.Drawing.Point(201, 43);
            this.IPtext.Name = "IPtext";
            this.IPtext.Size = new System.Drawing.Size(140, 22);
            this.IPtext.TabIndex = 25;
            this.IPtext.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "IP";
            // 
            // SocketService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createbut);
            this.Controls.Add(this.sendbut);
            this.Controls.Add(this.sendtext);
            this.Controls.Add(this.messagetext);
            this.Controls.Add(this.Porttext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPtext);
            this.Controls.Add(this.label1);
            this.Name = "SocketService";
            this.Text = "SocketService";
            this.Load += new System.EventHandler(this.SocketService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createbut;
        private System.Windows.Forms.Button sendbut;
        private System.Windows.Forms.TextBox sendtext;
        private System.Windows.Forms.TextBox messagetext;
        private System.Windows.Forms.TextBox Porttext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPtext;
        private System.Windows.Forms.Label label1;
    }
}