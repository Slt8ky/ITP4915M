namespace Smile___Sunshine_Toy_System.Interface
{
    partial class SocketClient
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
            this.linkbut = new System.Windows.Forms.Button();
            this.sendbut = new System.Windows.Forms.Button();
            this.sendtext = new System.Windows.Forms.TextBox();
            this.messagetext = new System.Windows.Forms.TextBox();
            this.Porttext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IPtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkbut
            // 
            this.linkbut.Location = new System.Drawing.Point(549, 40);
            this.linkbut.Name = "linkbut";
            this.linkbut.Size = new System.Drawing.Size(75, 24);
            this.linkbut.TabIndex = 23;
            this.linkbut.Text = "Link";
            this.linkbut.UseVisualStyleBackColor = true;
            this.linkbut.Click += new System.EventHandler(this.linkbut_Click);
            // 
            // sendbut
            // 
            this.sendbut.Location = new System.Drawing.Point(523, 362);
            this.sendbut.Name = "sendbut";
            this.sendbut.Size = new System.Drawing.Size(75, 39);
            this.sendbut.TabIndex = 22;
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
            this.sendtext.TabIndex = 21;
            // 
            // messagetext
            // 
            this.messagetext.Location = new System.Drawing.Point(179, 89);
            this.messagetext.Multiline = true;
            this.messagetext.Name = "messagetext";
            this.messagetext.Size = new System.Drawing.Size(445, 245);
            this.messagetext.TabIndex = 20;
            this.messagetext.TextChanged += new System.EventHandler(this.messagetext_TextChanged);
            // 
            // Porttext
            // 
            this.Porttext.Location = new System.Drawing.Point(436, 40);
            this.Porttext.Name = "Porttext";
            this.Porttext.Size = new System.Drawing.Size(90, 22);
            this.Porttext.TabIndex = 19;
            this.Porttext.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Port";
            // 
            // IPtext
            // 
            this.IPtext.Location = new System.Drawing.Point(201, 43);
            this.IPtext.Name = "IPtext";
            this.IPtext.Size = new System.Drawing.Size(140, 22);
            this.IPtext.TabIndex = 17;
            this.IPtext.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "IP";
            // 
            // SocketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkbut);
            this.Controls.Add(this.sendbut);
            this.Controls.Add(this.sendtext);
            this.Controls.Add(this.messagetext);
            this.Controls.Add(this.Porttext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPtext);
            this.Controls.Add(this.label1);
            this.Name = "SocketClient";
            this.Text = "SocketClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button linkbut;
        private System.Windows.Forms.Button sendbut;
        private System.Windows.Forms.TextBox sendtext;
        private System.Windows.Forms.TextBox messagetext;
        private System.Windows.Forms.TextBox Porttext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPtext;
        private System.Windows.Forms.Label label1;
    }
}