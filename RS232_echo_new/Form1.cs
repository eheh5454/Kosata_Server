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
using System.IO.Ports;

namespace RS232_echo_new
{
    public enum Protocol
    {    
        RS232 = 0,
        TCPIP
        
    }

    public partial class Form1 : Form
    {
        //ini 읽고쓰기에 사용하는 함수 
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //ini파일에 사용할 변수들 
        public string com_str = null;
        public string parity_str = null;
        public int databit;
        public int stopbit;
        public int baudrate;

        //시작위치 
        private int location_x, location_y;

        string check_ps;

        private string recv_str = null;

        //ini파일 저장에 사용 
        string filepath = "c:\\Myini\\test.ini";

        public Form1()
        {            

            InitializeComponent();

            StringBuilder tmp = new StringBuilder();

            //ini를 읽을때마다 tmp에 저장된 값을 ini에 쓸 변수에 저장한다.       
            GetPrivateProfileString("Comport", "ComName", "COM3", tmp, tmp.Capacity, @filepath);
            com_str = tmp.ToString();

            GetPrivateProfileString("BaudRate", "Rate", "115200", tmp, tmp.Capacity, @filepath);
            baudrate = Int32.Parse(tmp.ToString());

            GetPrivateProfileString("Parity", "Value", "N", tmp, tmp.Capacity, @filepath);
            parity_str = tmp.ToString();

            GetPrivateProfileString("DataBit", "Bit", "8", tmp, tmp.Capacity, @filepath);
            databit = Int32.Parse(tmp.ToString());

            GetPrivateProfileString("StopBit", "Bit", "1", tmp, tmp.Capacity, @filepath);
            stopbit = Int32.Parse(tmp.ToString());

            GetPrivateProfileString("Location", "X", "100", tmp, tmp.Capacity, @filepath);
            location_x = Int32.Parse(tmp.ToString());

            GetPrivateProfileString("Location", "Y", "100", tmp, tmp.Capacity, @filepath);
            location_y = Int32.Parse(tmp.ToString());

            //불러온 값을 이용해 시작 위치를 설정             
            StartPosition = FormStartPosition.Manual;
            Location = new Point(location_x, location_y);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("RS232");
            listBox1.Items.Add("TCP/IP");            

            // 정회원이 기본 선택
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            protocol = (Protocol)listBox1.SelectedIndex;
            Send_Msg.Text = ((Protocol)listBox1.SelectedIndex).ToString();

        }

        private Protocol protocol;

        //send버튼 클릭시 포트로 내용 전송하고 샌드 메시지창 클리어
        private void Button1_Click(object sender, EventArgs e)
        {            
            if(serialPort1.IsOpen)
            {
                serialPort1.Write(Send_Msg.Text + "\r\n");
                Send_Msg.Clear();
            }            
        }

        private void PortSelect_Click(object sender, EventArgs e)
        {
            //ini에서 읽어온 초기값을 portselect에 적용시켜준다! 
            PortSelect.parity_str = parity_str;
            PortSelect.stopbit_str = stopbit.ToString();
            PortSelect.databit_str = databit.ToString();
            PortSelect.baudrate_str = baudrate.ToString();
            PortSelect.com_str = com_str;

            PortSelect ps = new PortSelect(); //포트 고르는 창을 생성             
            ps.ShowDialog(); //PortSelect창을 띄운다                    

            //portselect창이 어떻게 꺼지냐에 따라서 다른 실행 

            //cancel이면 Null을 넣어줌 
            if (ps.portinfo == null)
            {                
                PortInfo_Box.Text += "Null\r\n";
                check_ps = "Null";
            }                
            //Apply면 PortSelect에서 바꾼 값을 적용해준다.
            else
            {                
                PortInfo_Box.Text += ps.portinfo += "\t";                
                com_str = PortSelect.com_str;
                parity_str = PortSelect.parity_str;
                stopbit = Int32.Parse(PortSelect.stopbit_str);
                databit = Int32.Parse(PortSelect.databit_str);
                baudrate= Int32.Parse(PortSelect.baudrate_str);

                //포트가 이미 열린 상태면
                if (serialPort1.IsOpen)
                {                        
                    //기존 명령과 같으면 
                    if(check_ps == ps.portinfo)
                    {
                        PortInfo_Box.Text += "Already Open" + "\r\n";
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
                
                check_ps = ps.portinfo;

            }           
            

        }

        private void PortInfo_Box_TextChanged(object sender, EventArgs e)
        {

        }

        //Form1창을 닫을 때 실행되는 함수(디자인->이벤트에서 더블클릭해서 불러왔음) 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //항목 별로 변수에 저장된 값을 ini파일에 저장한다.
            WritePrivateProfileString("Comport", "ComName", com_str, @filepath);
            WritePrivateProfileString("BaudRate", "Rate", baudrate.ToString(), @filepath);
            WritePrivateProfileString("Parity", "Value", parity_str, @filepath);
            WritePrivateProfileString("DataBit", "Bit", databit.ToString(), @filepath);
            WritePrivateProfileString("StopBit", "Bit", stopbit.ToString(), @filepath);
            WritePrivateProfileString("Location", "X", location_x.ToString(), @filepath);
            WritePrivateProfileString("Location", "Y", location_y.ToString(), @filepath);
        }

        //string parity값을 enum형식으로 변환 
        private System.IO.Ports.Parity Parity_to_Serial(string parity)
        {
            System.IO.Ports.Parity result_parity = System.IO.Ports.Parity.None;
                                    
            if(parity == "Odd")
            {
                result_parity = System.IO.Ports.Parity.Odd;
            }
            else if(parity == "Even")
            {
                result_parity = System.IO.Ports.Parity.Even;
            } 

            return result_parity;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //int형 stopbit값을 enum형식으로 변환 
        private System.IO.Ports.StopBits StopBit_to_Serial(int stopbit)
        {
            System.IO.Ports.StopBits result_stopbit = System.IO.Ports.StopBits.One;

            if(stopbit == 2)
            {
                result_stopbit = System.IO.Ports.StopBits.Two;
            }
            return result_stopbit;
        }

        //포트에서 데이터를 받을 때 호출되는 이벤트 
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            recv_str = serialPort1.ReadExisting();
           
        }

        //인터벌은 밀리세컨드 단위(1000밀리세컨드 = 1초) 
        //리시브 버퍼에 메시지가 입력되면 리시브 메시지 박스를 업데이트 
        private void timer1_Tick(object sender, EventArgs e)
        {
            //리시브 버퍼가 비어있지않으면 리시브 메시지창을 업데이트하고 리시브 버퍼를 비운다.
            if (recv_str != null && recv_str.Length > 0)
            {
                Recv_Msg.Text += recv_str;
                recv_str = null;
            }
                
        }

        private void Send_Msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(Send_Msg.Text);
                Send_Msg.Clear();
            }
        }

        //포트 오픈 실행 
        private void SerialPortOpen()
        {
            try
            {
                //시리얼 포트에 내용 적용 
                serialPort1.PortName = com_str;
                serialPort1.Open();                
                //포트관련 설정 
                serialPort1.BaudRate = baudrate;
                serialPort1.Parity = Parity_to_Serial(parity_str);
                serialPort1.StopBits = StopBit_to_Serial(stopbit);
                serialPort1.DataBits = databit;                

                PortInfo_Box.Text += "Port Open" + "\r\n";                
                ErrorBox.Clear();
            }
            catch(Exception e)
            {
                ErrorBox.Text = string.Format("Error: {0}", e);
                PortInfo_Box.Text += "Error\r\n";
            }
            
        }
        
    }
}
