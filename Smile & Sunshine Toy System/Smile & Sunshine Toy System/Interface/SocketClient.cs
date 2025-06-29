using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_System.Interface
{
    public partial class SocketClient : Form
    {
        List<string> user;
        public SocketClient(List<string> user)
        {
            InitializeComponent();
            this.user = user;
        }

        private System.Net.Sockets.Socket socket;
        private void linkbut_Click(object sender, EventArgs e)
        {
            socket = new System.Net.Sockets.Socket(
                System.Net.Sockets.AddressFamily.InterNetwork,
                System.Net.Sockets.SocketType.Stream,
                System.Net.Sockets.ProtocolType.IP);
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(this.IPtext.Text);
            System.Net.IPEndPoint point = new System.Net.IPEndPoint(ip, int.Parse(this.Porttext.Text));
            socket.Connect(point);

            System.Threading.Thread thread = new System.Threading.Thread(ReciveMsg);
            thread.IsBackground = true;
            thread.Start(socket);
        }

        public void ReciveMsg(object o)
        {
            System.Net.Sockets.Socket client = o as System.Net.Sockets.Socket;
            while (true)
            {
                try
                {
                    byte[] arrList = new byte[1024];
                    int length = client.Receive(arrList);
                    this.messagetext.AppendText($"{DateTime.Now}：{Encoding.UTF8.GetString(arrList, 0, length)} \r\n");
                }
                catch (Exception)
                {
                    client.Close();
                }
            }
        }

        private void sendbut_Click(object sender, EventArgs e)
        {
            if (sendtext.Text != "")
            {
                byte[] arrMsg = Encoding.UTF8.GetBytes(user[1] + ": " + sendtext.Text);
                socket.Send(arrMsg);
            }
        }

        private void messagetext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
