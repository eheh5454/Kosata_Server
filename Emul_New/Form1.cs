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

        //디비컨트롤 선언 
        DatabaseControl mydb = new DatabaseControl();

        int db_id = 0;

        public Form1()
        {
            InitializeComponent();
            
            //tcp쓰레드 시작 
            tcp_thread = new Thread(TCPIP_Server);
            tcp_thread.Start();

            //udp쓰레드 시작 
            udp_thread = new Thread(UDP_Server);
            udp_thread.Start();
            
            //db에 저장된 행 개수 가져오기 
            db_id = mydb.GetId();
           
            //listView 초기 세팅시작 
            listView_SQL.BeginUpdate();

            //listView의 뷰모드 변경 
            listView_SQL.View = View.Details;

            listView_SQL.Columns.Add("Id", 100, HorizontalAlignment.Left);
            listView_SQL.Columns.Add("Temp", 100, HorizontalAlignment.Left);
            listView_SQL.Columns.Add("Hum", 100, HorizontalAlignment.Left);
            listView_SQL.Columns.Add("Wind", 100, HorizontalAlignment.Left);

            //listView 세팅 끝 
            listView_SQL.EndUpdate(); 
            
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
            string temp_s = cmd.Substring(9, 2);
            string hum_s = cmd.Substring(12, 2);
            string wind_s = cmd.Substring(15, 3);

            date = cmd.Substring(0, 8);
            temp = Int32.Parse(cmd.Substring(9, 2));
            hum = Int32.Parse(cmd.Substring(12,2));
            wind = float.Parse(cmd.Substring(15, 3));

            UpdateMsg(string.Format("날짜:{0} 온도:{1}C 습도:{2}% 풍속:{3:F1}m/s",
                date, temp, hum, wind));           
            

            //db에 넣기 
            mydb._ExcuteSql(string.Format("INSERT INTO MyTable (Id,temp,hum,wind) VALUES ({0},{1},{2},{3})",db_id++,temp_s,hum_s,wind_s));

            UpdateListView(db_id, temp_s, hum_s, wind_s);
        }       

        //DB 내용 삭제 버튼 
        private void Button_DBdelete_Click(object sender, EventArgs e)
        {
            mydb.DeleteDB();
            db_id = 0;
            listView_SQL.Items.Clear();
            
        }

        //델리게이트함수 - 리스트뷰를 업데이트한다.
        delegate void UpdateListViewCallback(int id, string temp, string hum, string wind);
        private void UpdateListView(int id, string temp, string hum, string wind)
        {

            if (this.listView_SQL.InvokeRequired)
            {
                UpdateListViewCallback recv = new UpdateListViewCallback(UpdateListView);                
                this.Invoke(recv, new object[] { id,temp,hum,wind }); 
            }            
            else
            {               
                //리스트뷰 업데이트
                GetDBToListView();
            }            
        }

        //DB내용을 가져와 listView를 업데이트한다.
        private void GetDBToListView()
        {
            //리스트뷰를 클리어 
            listView_SQL.Items.Clear();

            //디비 행 개수만큼 반복 
            for (int i = 0; i < db_id; ++i)
            {
                //db에서 각 요소의 값을 string으로 가져온다
                string temp = mydb._GetStringDB(i.ToString(),"temp", "MyTable");
                string hum = mydb._GetStringDB(i.ToString(),"hum","MyTable");
                string wind = mydb._GetStringDB(i.ToString(),"wind", "MyTable");                

                //리스트뷰에 가져온 요소값들을 넣어준다.
                listView_SQL.BeginUpdate();                              

                ListViewItem lvi = new ListViewItem(i.ToString()); //키값을 넣어서 아이템 생성               
                lvi.SubItems.Add(temp); //아이템 요소들 넣기 
                lvi.SubItems.Add(hum);
                lvi.SubItems.Add(wind);

                listView_SQL.Items.Add(lvi);//아이템 요소들이 다 들어가면 아이템을 뷰에 넣는다.

                listView_SQL.EndUpdate();

            }
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
            DbCmd.CommandText = "delete from MyTable";
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
            DbCmd.CommandText = string.Format("select {1} from {2} where Id={0}", s1, s2, sdb);
            s3 = DbCmd.ExecuteScalar().ToString(); //select로 날아온 값을 string으로 받음 
            
            return s3;
        }

        //db에서 아이템 갯수를 반환(id=아이템갯수) 
        public int GetId()
        {
            int id = 0;

            //ExcuteScalar로 읽기 
            DbCmd.CommandText = string.Format("select COUNT(*) from MyTable");
            string s = DbCmd.ExecuteScalar().ToString();
            Int32.TryParse(s, out id);

            //리더로 읽기 
            return id;
        }

        
    }
}