using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TCPIP_Send
{
    public partial class Form1 : Form
    {
        NetworkStream ns;
        StreamWriter sw;
        TcpClient sock;
        bool connect = false;

        public Form1()
        {
            InitializeComponent();
        }

        //connect
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {   //소켓 생성 
                sock = new TcpClient("127.0.0.1", 9000);
                ns = sock.GetStream();
                sw = new StreamWriter(ns);
                connect = true;
            }
            catch(SocketException se)
            {
                ErrorBox.Text = string.Format("{0}", se);
            }
        }

        //quit
        private void button2_Click(object sender, EventArgs e)
        {
            if(connect)
            {
                sw.WriteLine("q");
                connect = false;                
                sw.Close();
                ns.Close();
                sock.Close();
            }
            
        }

        private void UP_Click(object sender, EventArgs e)
        {
            SendCmd("UP");
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            SendCmd("DOWN");

        }

        private void RIGHT_Click(object sender, EventArgs e)
        {
            SendCmd("RIGHT");
        }

        private void LEFT_Click(object sender, EventArgs e)
        {
            SendCmd("LEFT");
        }

        private void SendCmd(string button)
        {
            if(connect)
            {
                sw.WriteLine(button);
                sw.Flush();
            }
        }
    }
}
