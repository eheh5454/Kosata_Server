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

namespace Emul_New
{
    public partial class Form1 : Form
    {
        string date; //날짜 
        float temp; //온도 
        float hum;  //습도 
        float wind; //풍속 

        //쓰레드 
        Thread udp_thread;
        Thread tcp_thread;

        public Form1()
        {
            InitializeComponent();
            
            //tcp쓰레드 시작 
            tcp_thread = new Thread(TCPIP_Server);
            tcp_thread.Start();

            //udp쓰레드 시작 
            udp_thread = new Thread(UDP_Server);
            udp_thread.Start();
        }

        //쓰레드 함수 - TCPIP서버 열기 
        private void TCPIP_Server()
        {
            TcpListener listner = new TcpListener(IPAddress.Parse("127.0.0.1"), 9000);
                       

            while (true)
            {
                try
                {
                    //서버 시작 
                    listner.Start();

                    TcpClient clientSocket = listner.AcceptTcpClient(); //세션 구성, 클라와 연결            

                    //스트림 생성 
                    NetworkStream ns = clientSocket.GetStream();
                    StreamReader sr = new StreamReader(ns);
                    StreamWriter sw = new StreamWriter(ns);

                    //클라이언트에서 문자열 수신 
                    string rs = sr.ReadLine();

                    GetCMD(rs);                   

                    //받은 문자열을 클라이언트에 재전송(에코)
                    sw.WriteLine("Receive Success!");
                    sw.Flush();

                    sr.Close();
                    sw.Close();
                    ns.Close();
                    listner.Stop();
                }
                catch (Exception exp)
                {                    
                    break;
                }
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
                    //받은 메시지 박스에 출력 
                    GetCMD(dataFromClient);
                    
                }

            }
        }

        //델리게이트 함수로 쓰레드에서 메시지박스를 업데이트 
        delegate void UpdateMsgCallback(string s);
        private void UpdateMsg(string s)
        {
            if (this.MsgBox.InvokeRequired)
            {
                UpdateMsgCallback recv = new UpdateMsgCallback(UpdateMsg);
                this.Invoke(recv, new object[] { s }); //Invoke를 실행해 아래 else구문을 실행하도록 한다. 
            }
            //아래 내용을 실행한다.
            else
            {
                MsgBox.Text += s;
                MsgBox.Text += "\r\n";
            }
        }

        //CMD->자료형으로 바꾸기 
        private void GetCMD(string cmd)
        {           
            date = cmd.Substring(0, 8);
            temp = Int32.Parse(cmd.Substring(9, 2));
            hum = Int32.Parse(cmd.Substring(12,2));
            wind = float.Parse(cmd.Substring(15, 3));

            UpdateMsg(string.Format("날짜:{0} 온도:{1}C 습도:{2}% 풍속:{3:F1}m/s",
                date, temp, hum, wind));
        }
    }
}
