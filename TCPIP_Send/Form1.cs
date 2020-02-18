//#define TCPIP
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
using System.Threading;


namespace TCPIP_Send
{
 
    public partial class Form1 : Form
    {
        //텍스트박스 배열을 구별할 Enum 자료형 
        enum Box
        {
            Temp,
            Hum
        }        
        
        Thread udp_thread;
        Thread tcp_thread;

        TextBox[] boxes;

        public Form1()
        {
            InitializeComponent();

            //온,습도를 표시할 텍스트박스를 배열로 만듬
            boxes = new TextBox[] { Box_Temp, Box_Hum };
            boxes[0].Text = "hello";

            udp_thread = new Thread(UDP_Server);
            udp_thread.Start();
        }

        //델리게이트 함수로 쓰레드에서 메시지박스를 업데이트 
        delegate void UpdateMsgCallback(string s, Box b);
        private void UpdateBox(string s, Box b)
        {
            if (this.Box_Temp.InvokeRequired)
            {
                UpdateMsgCallback recv = new UpdateMsgCallback(UpdateBox);
                this.Invoke(recv, new object[] { s, b }); //Invoke를 실행해 아래 else구문을 실행하도록 한다. 
            }
            //아래 내용을 실행한다.
            else
            {
                boxes[(int)b].Text = s;                     
            }
        }

        //쓰레드 함수 - UDP서버 열기 
        private void UDP_Server()
        {
            //udp소켓 생성 
            Socket udp_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //EndPoint 설정(IP와 Port)
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 9000);

            //소켓 바인드 
            udp_socket.Bind(ep);

            //수신 시작 
            while (true)
            {
                int recv = 0;
                byte[] buff = new byte[1024];

                //Read를 하기 위한 클라의 EndPoint, 0은 모든포트에 대한 감시이지만 이미 9000에 바인드 됨
                EndPoint repANY = new IPEndPoint(IPAddress.Any, 0);
                //위에서 지정한 EndPoint로 들어오는 정보를 수신한다.
                recv = udp_socket.ReceiveFrom(buff, ref repANY);
                //수신한 길이가 0 이상이면 data를 받는다 
                if (recv > 0)
                {
                    string dataFromClient = Encoding.Default.GetString(buff, 0, recv);
                    //UpdateBox(dataFromClient, Box.Temp);
                    char check = dataFromClient[0];

                    switch(check)
                    {
                        case 't':
                            UpdateBox(dataFromClient.Substring(1, 5), Box.Temp);
                            break;
                        case 'h':
                            UpdateBox(dataFromClient.Substring(1, 6), Box.Hum);
                            break;
                    }
                    
                }

            }
        }

        //connect
        private void ConnectButton_Click(object sender, EventArgs e)
        {
#if TCPIP
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
#else
            return;

#endif
        }

        //quit
        private void button2_Click(object sender, EventArgs e)
        {
#if TCPIP
            if(connect)
            {
                sw.WriteLine("q");
                connect = false;                
                sw.Close();
                ns.Close();
                sock.Close();
            }
#else
            SendCmd("close");
#endif

        }

        private void UP_Click(object sender, EventArgs e)
        {
            SendCmd("go");
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            SendCmd("back");

        }

        private void RIGHT_Click(object sender, EventArgs e)
        {
            SendCmd("right");
        }

        private void LEFT_Click(object sender, EventArgs e)
        {
            SendCmd("left");
        }

        private void SendCmd(string button)
        {
#if TCPIP
            if(connect)
            {
                sw.WriteLine(button);
                sw.Flush();
            }
#else
            ErrorBox.Text += button;
            //소켓 생성 
            Socket sock_local = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //메시지를 전송할 타겟 EndPoint
            EndPoint epUDP = new IPEndPoint(IPAddress.Parse("192.168.0.119"), 9001);           

            //지정한 EndPoint로 메시지 전송(문자열->byte형식으로 인코딩)
            sock_local.SendTo(Encoding.Default.GetBytes(button), epUDP);           
#endif
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            udp_thread.Abort();
        }
    }
}
