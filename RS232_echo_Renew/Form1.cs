using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace RS232_echo_Renew
{

    public partial class Form1 : Form
    {       
        
        private PortSelect ps;

        //통신을 위한 리시브 버퍼 
        private string recv_str = null;

        //중복 검사용 포트정보 
        private string before_ps;          

        IPEndPoint ep; //UDP통신에 사용될 EndPoint 

        Socket sock; //UDP통신에 사용될 소켓 

        Thread udp_thread; //UDP 쓰레드 

        Thread tcp_thread; //TCP 쓰레드

        public Form1()
        {
            InitializeComponent();
            ps = new PortSelect();

            tcp_thread = new Thread(TCPIP_Server);
            udp_thread = new Thread(UDP_Server);
        }
       
        //Send 버튼 
        private void SendButton_Click(object sender, EventArgs e)
        {
            //포트가 열려있으면 
            if (serialPort1.IsOpen)
            {                
                //포트에 메시지를 전송
                serialPort1.Write(SendMsgBox.Text + "\r\n");             
                SendMsgBox.Clear();

            }
        }

        //RecvMsg를 업데이트하는 delegate 함수 
        delegate void RecvMsgCallback(string s);//아래 함수를 콜백 함수로 설정 
        private void RecvMsg(string s)
        {
            //델리게이트 함수가 되어 다른 쓰레드에서 호출되면 메인 쓰레드에서 값을 바꿀 수 있다 
            //InvokeRequired는 다른 쓰레드에서 호출이 요구되는 경우를 뜻함 
            if(this.RecvMsgBox.InvokeRequired)
            {
                //콜백 함수로 현재 함수포인터를 넘겨서 생성
                RecvMsgCallback recv = new RecvMsgCallback(RecvMsg);
                this.Invoke(recv, new object[] { s }); //Invoke를 실행해 아래 else구문을 실행하도록 한다. 
            }
            //아래 내용을 실행한다.
            else
            {
                RecvMsgBox.Text += s;
                RecvMsgBox.Text += "\r\n";
            }
        }

        //StateMsg를 업데이트하는 delegate 함수 
        delegate void StateMsgCallback(string s);
        private void StateMsg(string s)
        {
            if(this.StateBox.InvokeRequired)
            {
                StateMsgCallback state = new StateMsgCallback(StateMsg);
                this.Invoke(state, new object[] { s });
            }
            else
            {
                StateBox.Text += s + "\r\n";
            }
        }

        //ChatBox를 업데이트하는 delegate 함수 
        delegate void ChatMsgCallback(string s);
        private void ChatMsg(string s)
        {
            if (this.ChatBox.InvokeRequired)
            {
                ChatMsgCallback chat = new ChatMsgCallback(ChatMsg);
                this.Invoke(chat, new object[] { s });
            }
            else
            {
                ChatBox.Text += s;
                ChatBox.Text += "\r\n";
            }
        }

        //시리얼포트에서 데이터를 받으면 호출됨(다른 쓰레드에서 실행) 
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            recv_str = serialPort1.ReadExisting(); //recv_str 버퍼에 시리얼포트에서 읽어온 값을 저장 
            RecvMsg(recv_str); //델리게이트 함수를 호출(메인 쓰레드에서) 
        }

        //포트 옵션 설정 버튼 
        private void button1_Click(object sender, EventArgs e)
        {            
            ps.ShowDialog();

            //포트 설정창을 cancel로 닫지 않으면 
            if (!ps.cancel)
            {
                //설정한 포트정보 표시 
                string portstring = string.Format("{0}:{1}{2}{3}{4} ",
                PortSelect.port, PortSelect.baudrate, PortSelect.parity.ToString().Substring(0, 1), (int)PortSelect.stopbit, PortSelect.databit);
                StateBox.Text += portstring;

                //포트가 이미 열린 상태면
                if (serialPort1.IsOpen)
                {
                    //기존 명령과 같으면 또 오픈하지않음
                    if (before_ps == portstring)
                    {
                        StateBox.Text += "Already Open" + "\r\n";
                    }
                    //다르면 기존 포트를 닫고 새롭게 오픈 
                    else
                    {
                        serialPort1.Close();
                        SerialPortOpen();
                    }
                }
                //열린 상태가 아니면 포트를 오픈 
                else
                {
                    SerialPortOpen();
                }
                //기존 명령에 현재 포트 정보를 갱신 
                before_ps = portstring;
            }                                         

        }

        //포트 오픈 
        private void SerialPortOpen()
        {           
            //try catch를 이용해 try에서 문제가 생기면 catch에서 Error창을 호출 
            try
            {          
                serialPort1.PortName = PortSelect.port;
                serialPort1.Open();
                serialPort1.Parity = PortSelect.parity;
                serialPort1.StopBits = PortSelect.stopbit;
                serialPort1.DataBits = PortSelect.databit;

                StateBox.Text += "Open Success \r\n";          
                
            }            
            //error메시지를 받아서 Error창을 생성 
            catch (Exception e)
            {
                StateBox.Text += "Error\r\n";
                Error error = new Error(string.Format("{0}", e));
                error.ShowDialog();
            }
        }

        //파일 열기 메뉴 
        private void OpenMenu_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if(dr == DialogResult.OK)
            {       
                
                Editini editini = new Editini(openFileDialog1.FileName);
                editini.ShowDialog();
            }
        }

        private void SendMsgBox_MouseClick(object sender, MouseEventArgs e)
        {            
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show();
            }
            
        }
        
        //폰트 크기 늘리기 
        private void FontSizeUp_Click(object sender, EventArgs e)
        {
            float current_size = SendMsgBox.Font.Size;
            current_size += 1.0f;
            SendMsgBox.Font = new Font(SendMsgBox.Font.Name, current_size,
                SendMsgBox.Font.Style, SendMsgBox.Font.Unit);
        }

        //폰트 크기 줄이기 
        private void FontSizeDown_Click(object sender, EventArgs e)
        {
            float current_size = SendMsgBox.Font.Size;
            current_size -= 1.0f;
            SendMsgBox.Font = new Font(SendMsgBox.Font.Name, current_size,
                SendMsgBox.Font.Style, SendMsgBox.Font.Unit);
        }

        //쓰레드함수-TCPIP서버 시작
        private void TCPIP_Server()
        {
            TcpListener listner = new TcpListener(IPAddress.Parse("127.0.0.1"), 9000);

            //서버 시작 
            listner.Start();
            
            StateMsg("Server Start.....");
            TcpClient clientSocket = listner.AcceptTcpClient(); //세션 구성, 클라와 연결
            StateMsg("Success!");

            //스트림 생성 
            NetworkStream ns = clientSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
                        
            while (true)
            {
                try
                {
                    //클라이언트에서 문자열 수신 
                    string rs = sr.ReadLine();

                    RecvMsg(rs);

                    //받은 문자열을 클라이언트에 재전송(에코)
                    sw.WriteLine(rs);
                    sw.Flush();
                }
                catch(Exception exp)
                {
                    Error error = new Error(string.Format("{0}", exp));
                }
               
                
            }
        }
        
        //TCPIP 서버 시작 
        private void ServerButton_Click(object sender, EventArgs e)
        {
            tcp_thread.Start();
        }

        //파일전송하기 
        private void FileSendButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {                
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);

                    //소켓 생성 
                    TcpClient Socket = new TcpClient("192.168.0.105", 9000);

                    //스트림 생성 
                    NetworkStream ns = Socket.GetStream();
                    StreamWriter sw = new StreamWriter(ns);

                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    string fi_string = "CMD00001" + fi.Name + ":" + fi.Length + ":";
                    sw.WriteLine(fi_string);                    

                    //라인 단위로 전송 
                    while (true)
                    {
                        //한줄 읽고 다음 줄로 넘김 
                        string s = sr.ReadLine();                        
                        sw.WriteLine(s);
                        //읽을게 없으면 브레이크 
                        if (s == null) break;
                    }                    
                    sw.Flush();                                    
                   
                    //스트림, 소켓 종료 
                    sw.Close();
                    ns.Close();
                    Socket.Close();
                }
                catch (SocketException se)
                {
                    Error error = new Error(string.Format("{0}", se));
                }
            }            
        }

        //파일 바이너리 전송 
        private void File_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();            

            if (dr == DialogResult.OK)
            {
                try
                {                    
                    FileStream fr = new FileStream(openFileDialog1.FileName, FileMode.Open);

                    //파일을 익기위한 byte형 버퍼 
                    byte[] buff = new byte[1024];
                    int fsize = 0; //읽어온 파일의 크기 

                    //소켓 생성 
                    TcpClient Socket = new TcpClient("127.0.0.1", 9000);

                    //스트림 생성 
                    NetworkStream ns = Socket.GetStream();
                    StreamWriter sw = new StreamWriter(ns);

                    //파일 정보 가져와서 cmd구성하는 string 생성
                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    string fi_string = "CMD00001" + fi.Name + ":" + fi.Length + ":";
                    sw.WriteLine(fi_string); //cmd 한줄로 전송 
                    //스트림 라이터 비우기 
                    sw.Flush();

                    //파일 스트림에서 버퍼로 내용 읽어오고 바로 전송 
                    while ((fsize = fr.Read(buff, 0, buff.Length)) > 0)
                    {
                        //읽어온 사이즈를 텍스트로 출력 
                        RecvMsgBox.Text += fsize + "\r\n";
                        //네트워크 스트림으로 byte형 버퍼에 내용을 담아서 전송 
                        ns.Write(buff, 0, buff.Length);
                        //네트워크 스트림 비우기 
                        ns.Flush();
                    }

                    //스트림, 소켓 종료
                    sw.Close();
                    fr.Close();
                    ns.Close();
                    Socket.Close();
                }
                catch (SocketException se)
                {
                    Error error = new Error(string.Format("{0}", se));
                }
            }
        }

        //쓰레드함수-UDP서버 시작
        private void UDP_Server()
        {
            while (true)
            {
                int recv = 0;
                byte[] buff = new byte[1024];

                //Read를 하기 위한 클라의 EndPoint, 0은 모든포트에 대한 감시이지만 이미 9000에 바인드 됨
                EndPoint repANY = new IPEndPoint(IPAddress.Any, 0);
                //위에서 지정한 EndPoint로 들어오는 정보를 수신한다.
                recv = sock.ReceiveFrom(buff, ref repANY);
                //수신한 길이가 0 이상이면 data를 받는다 
                if (recv > 0)
                {
                    string dataFromClient = Encoding.Default.GetString(buff,0,recv);
                    //받은 메시지 박스에 출력 
                    ChatMsg("other: "+ dataFromClient);                    
                    //스테이트 업데이트                     
                    StateMsg("Recv Chat");                    
                }
                                
            }
            
        }        

        //채팅 쓰레드 시작
        private void ChatButton_Click(object sender, EventArgs e)
        {                     
            //소켓을 바인드할 9000포트의 EndPoint 설정 
            ep = new IPEndPoint(IPAddress.Any, 9000);

            //UDP통신에 사용될 소켓 설정 
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //서버 소켓을 위에서 선언한 EndPoint에 바인드 
            sock.Bind(ep);
            
            StateMsg("Chat Start....."); //delegate함수로 변경 

            //쓰레드 시작             
            udp_thread.Start();            
            
        }

        //채팅 종료 버튼 
        private void ChatOffButton_Click(object sender, EventArgs e)
        {
            //쓰레드 종료하고 소켓 닫기 
            udp_thread.Abort();
            sock.Close();

            StateMsg("Chat Off....");
            ChatBox.Text = null;
        }

        //엔터로 채팅 전송(UDP)
        private void ChatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(udp_thread.IsAlive && e.KeyCode == Keys.Enter)
            {
                //소켓 생성 
                Socket sock_local = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                //메시지를 전송할 타겟 EndPoint
                EndPoint epUDP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9001);

                //채팅 박스의 마지막 줄
                int endline = ChatBox.Lines.Length - 1;

                //지정한 EndPoint로 메시지 전송(문자열->byte형식으로 인코딩)
                sock_local.SendTo(Encoding.Default.GetBytes(ChatBox.Lines[endline]), epUDP);
                
            }
        }
        

        //UDP방식으로 TCPIP연결을 요청하게 하는 CMD 전송 
        private void SendCmdButton_Click(object sender, EventArgs e)
        {
            if(!tcp_thread.IsAlive)
                tcp_thread.Start();
            //소켓 생성 
            Socket sock_local = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //메시지를 전송할 타겟 EndPoint
            EndPoint epUDP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9001);           

            //지정한 EndPoint로 메시지 전송(문자열->byte형식으로 인코딩)
            sock_local.SendTo(Encoding.Default.GetBytes("testcmd"), epUDP);
        }
    }
}
