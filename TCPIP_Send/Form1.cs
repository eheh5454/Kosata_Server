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
using System.Data.SqlClient;




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
        
        //udp서버를 실행할 쓰레드 
        Thread udp_thread;        
                
        //온습도 텍스트 박스 관리할 배열 
        TextBox[] boxes;

        //DB 행 개수를 가져올 변수 
        int count_id;

        //디비컨트롤 선언 
        DatabaseControl mydb = new DatabaseControl();

        int chart_x = 1;

        //내 IP PORT 주소 
        string MyPORT = "9000";
        string MyIP = null;

        //라지그 IP와 PORT주소 초기값 
        string Razig_IP = "192.168.0.119";
        string Razig_PORT_Move = "9001"; //움직임 제어용 포트 
        string Razig_PORT_TH = "9002"; //온습도 수신용 포트 

        //날짜와 시간, DB에 넣을 용도 
        string date = null;
        string time = null;

        //mjpg 스트리밍 주소 
        string stream_address = "http://192.168.0.119:8091/javascript_simple.html";

        bool connect = false;

        public Form1()
        {
            InitializeComponent();

            //온,습도를 표시할 텍스트박스를 배열로 만듬
            boxes = new TextBox[] { Box_Temp, Box_Hum };

            //udp서버 바로 시작 
            udp_thread = new Thread(UDP_Server);
            udp_thread.Start();

            //db 행 개수 측정 
            count_id = mydb.GetId();

            //DB가져와서 차트 세팅 
            SetChart();

            //라지그 IP,PORT 초기값 적용 
            BOX_razigIP.Text = Razig_IP;
            //BOX_razigPORT.Text = Razig_PORT;            
            
            //로컬 아이피 얻기 
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            string localIP;
            foreach (IPAddress ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    MyIP = localIP;
                }

            }
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

        //델리게이트 함수로 쓰레드에서 차트를 업데이트 
        delegate void UpdateChartCallback(string temp, string hum);
        private void UpdateChart(string temp, string hum)
        {
            if (this.Chart_TH.InvokeRequired)
            {
                UpdateChartCallback recv = new UpdateChartCallback(UpdateChart);
                this.Invoke(recv, new object[] { temp, hum  }); //Invoke를 실행해 아래 else구문을 실행하도록 한다. 
            }
            //아래 내용을 실행한다.
            else
            {
                string chart_x = date + "\r\n" + time;
                Chart_TH.Series["Temp"].Points.AddXY(chart_x, temp);
                Chart_TH.Series["Humidity"].Points.AddXY(chart_x, hum); 
                if(Chart_TH.Series["Temp"].Points.Count > 5)
                {                    
                    Chart_TH.Series["Temp"].Points.RemoveAt(0);
                    Chart_TH.Series["Humidity"].Points.RemoveAt(0);
                }
            }
        }

        //차트 초기세팅 
        private void SetChart()
        {
            if (count_id == 0)
                return;

            //for문 시작점과 끝점 
            int start, last;

            //db카운트 수에 따라서 start와 last 다르게 정의 
            if (count_id < 5)
            {
                start = 0;
                last = count_id-1;
            }                
            else
            {
                start = count_id - 5;
                last = count_id - 1;
            }

            //db에서 정보를 가져와 차트 세팅 
            for (; start <= last; start++) 
            {
                string date = mydb._GetStringDB(start.ToString(), "Date", "Razig_Date");
                string time = mydb._GetStringDB(start.ToString(), "Time", "Razig_Date");
                string temp = mydb._GetStringDB(start.ToString(), "Temp", "Razig_Date");
                string hum = mydb._GetStringDB(start.ToString(), "Hum", "Razig_Date");

                string chart_x = date + "\r\n" + time;

                Chart_TH.Series["Temp"].Points.AddXY(chart_x, temp);
                Chart_TH.Series["Humidity"].Points.AddXY(chart_x, hum);              
            }
            
        }

        //현재 날짜, 시간 정보 갱신 
        private void UpdateDate()
        {
            date = DateTime.Now.Year.ToString()+ "-" + DateTime.Now.Month.ToString() + "-"
                + DateTime.Now.Day.ToString();
            time = DateTime.Now.TimeOfDay.ToString().Substring(0,8);
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

                    if(dataFromClient.Substring(0,2) == "TS")
                    {
                        string temp_s = dataFromClient.Substring(2,5);
                        string hum_s = dataFromClient.Substring(7, 6);
                        UpdateDate();
                        mydb._ExcuteSql(string.Format("INSERT INTO Razig_Date (id, Date, Time, Temp, Hum) VALUES ({0},'{1}','{2}',{3},{4})", count_id++, date, time, temp_s, hum_s));
                        UpdateBox(temp_s, Box.Temp);
                        UpdateBox(hum_s, Box.Hum);
                        UpdateChart(temp_s, hum_s);                      
                        
                    }                    
                    
                }

            }
        }

        //라지그 키트와 연결하기
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
            //입력한 라지그 IP, PORT정보를 가져옴 
            Razig_IP = BOX_razigIP.Text;

            //스트리밍 주소 설정 
            stream_address = "http://" + Razig_IP + ":8091/javascript_simple.html";

            //웹 스트리밍 시작                 
            Web_mjpg_stream.Navigate(stream_address);                     

            //소켓 생성 
            Socket sock_local = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //설정한 라지그의 IP,PORT를 EndPoint로 설정 
            EndPoint epUDP = new IPEndPoint(IPAddress.Parse(Razig_IP), Int32.Parse(Razig_PORT_TH));
            
            //라지그에 내 IP와 PORT정보 전송 
            sock_local.SendTo(Encoding.Default.GetBytes("con" + MyIP + MyPORT), epUDP);

            //연결 상태로 변경 
            connect = true;
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
            if(connect)
            {
                //소켓 생성 
                Socket sock_local = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                //메시지를 전송할 타겟 EndPoint
                EndPoint epUDP = new IPEndPoint(IPAddress.Parse(Razig_IP), Int32.Parse(Razig_PORT_Move));

                //지정한 EndPoint로 메시지 전송(문자열->byte형식으로 인코딩)
                sock_local.SendTo(Encoding.Default.GetBytes(button), epUDP);
            }                    
#endif
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //udp_thread.Abort();
            Application.ExitThread();
        }


        //사진 캡처하기 
        private void Button_capture_Click(object sender, EventArgs e)
        {
            if (!connect)
                return;
            //mjpg에서 스냅샷 저장 
            String url = "http://" + Razig_IP + ":8091/?action=snapshot";
            String fileName = "capture.png";
            if (!DownloadRemoteImageFile(url, fileName))
            {
                MessageBox.Show("Download Failed: " + url);
            }

            //bmp생성해서 Imagebox창 띄우기 
            Bitmap bmp = new Bitmap("capture.png");
            ImageBox imgbox = new ImageBox(bmp);
            imgbox.ShowDialog();
            imgbox.Close();
            bmp.Dispose();
            
           
        }

        //이미지 URL 파일로 저장하기 
        private bool DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            bool bImage = response.ContentType.StartsWith("image",
                StringComparison.OrdinalIgnoreCase);
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                bImage)
            {
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }
                
                
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button_Auto_Click(object sender, EventArgs e)
        {
            SendCmd("auto");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendCmd("passive");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SendCmd("time1218");
        }

        //시간 예약하기 
        private void Reserv_Click(object sender, EventArgs e)
        {
            string hour = Box_time.Text;
            string min = Box_min.Text;

            SendCmd("time" + hour + min);
        }
    }

    public class DatabaseControl
    {
        public SqlConnection DbConn = new SqlConnection();
        public SqlCommand DbCmd = new SqlCommand();

        public DatabaseControl() { _OpenDB(); }

        public void _OpenDB()
        {

            if (DbConn.State != ConnectionState.Open)
            {
                //테이블 속성에서 연결 문자열을 복사, \->\\로 바꿔줌 
                DbConn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\MyDB\\TransferDB.mdf;Integrated Security=True;Connect Timeout=30";

                DbConn.Open();

                DbCmd.Connection = DbConn;
            }

        }

        //db종료
        public void _CloseDB()
        {
            DbCmd.Dispose();
            DbConn.Dispose();
        }

        //db쿼리문 실행 
        public void _ExcuteSql(string sql)
        {
            DbCmd.CommandText = sql;
            DbCmd.ExecuteNonQuery();
        }

        //db내용 삭제 
        public void DeleteDB()
        {
            DbCmd.CommandText = "delete from Razig_Date";
            DbCmd.ExecuteNonQuery();
        }

        //원하는 요소를 Int값으로 반환 
        public int _GetIntDB(string s1, string s2, string sdb = "TB_COMMAND")
        {
            string s3;
            int n1;

            //쿼리문으로 데이터를 읽어옴 
            DbCmd.CommandText = string.Format("select {1} from {2} where Id={0}", s1, s2, sdb);
            s3 = DbCmd.ExecuteScalar().ToString(); //select로 날아온 값을 string으로 받음 
            if (s3 == "Ture") n1 = 1;
            else if (s3 == "False") n1 = 0;
            else Int32.TryParse(s3, out n1);
            return n1;
        }

        //원하는 요소를 string으로 반환 
        public string _GetStringDB(string s1, string s2, string sdb)
        {
            string s3;

            //쿼리문으로 데이터를 읽어옴 
            DbCmd.CommandText = string.Format("select {1} from {2} where id={0}", s1, s2, sdb);
            s3 = DbCmd.ExecuteScalar().ToString(); //select로 날아온 값을 string으로 받음 

            return s3;
        }

        //db에서 아이템 갯수를 반환(id=아이템갯수) 
        public int GetId()
        {
            int id = 0;

            //ExcuteScalar로 읽기 
            DbCmd.CommandText = string.Format("select COUNT(*) from Razig_Date");
            string s = DbCmd.ExecuteScalar().ToString();
            Int32.TryParse(s, out id);

            //리더로 읽기 
            return id;
        }


    }

}
