using Smile___Sunshine_Toy_System.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_System.Interface
{
    public partial class SocketService : Form
    {
        public SocketService()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void sendbut_Click(object sender, EventArgs e)
        {
            if (this.sendtext.Text != "")
            {
                SendMsg(this.sendtext.Text);
                this.sendtext.Text = "";
            }
        }

        private void createbut_Click(object sender, EventArgs e)
        {
            System.Threading.Thread myServer = new System.Threading.Thread(MySocket);
            myServer.IsBackground = true;
            myServer.Start();
        }

        private void SocketService_Load(object sender, EventArgs e)
        {
            var ip = IPAddress.Any.ToString();
            this.IPtext.Text = ip;
        }

        Dictionary<string, System.Net.Sockets.Socket> clientList = new Dictionary<string, System.Net.Sockets.Socket>();
        public void MySocket()
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPAddress iP = IPAddress.Parse(this.IPtext.Text);
            IPEndPoint endPoint = new IPEndPoint(iP, int.Parse(this.Porttext.Text));
            server.Bind(endPoint);
            server.Listen(20);
            this.messagetext.AppendText("The server has been successfully started! \r\n");
            while (true)
            {
                Socket connectClient = server.Accept();
                if (connectClient != null)
                {
                    string infor = connectClient.RemoteEndPoint.ToString();
                    clientList.Add(infor, connectClient);
                    this.messagetext.AppendText(infor + "entered the chat room! \r\n");
                    string msg = $"[{infor}]Successfully entered the chat room!";
                    SendMsg(msg);
                    Thread threadClient = new Thread(ReciveMsg);
                    threadClient.IsBackground = true;
                    threadClient.Start(connectClient);
                }
            }
        }

        public void ReciveMsg(object o)
        {
            Socket client = o as Socket;
            while (true)
            {
                try
                {
                    byte[] arrMsg = new byte[1024];
                    int length = client.Receive(arrMsg);
                    if (length > 0)
                    {
                        string recMsg = Encoding.UTF8.GetString(arrMsg, 0, length);
                        IPEndPoint endPoint = client.RemoteEndPoint as IPEndPoint;
                        this.messagetext.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}[{endPoint.Port.ToString()}]： {recMsg} \r\n");
                        SendMsg($"[{endPoint.Port.ToString()}]{recMsg}");
                    }
                }
                catch (Exception)
                {
                    client.Close();
                    clientList.Remove(client.RemoteEndPoint.ToString());
                }
            }

        }

        public void SendMsg(string str)
        {
            foreach (var item in clientList)
            {
                byte[] arrMsg = Encoding.UTF8.GetBytes(str);
                item.Value.Send(arrMsg);
            }
        }
    }
}
