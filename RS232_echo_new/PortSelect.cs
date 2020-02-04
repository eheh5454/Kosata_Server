using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RS232_echo_new
{

    public partial class PortSelect : Form
    {         
        public string portinfo = null;
        public static string parity_str = null;
        public static string databit_str = null;
        public static string stopbit_str = null;
        public static string baudrate_str = null;
        public static string com_str = null;

        public string[] portname; //연결된 포트들의 이름을 저장하는 변수 

        public PortSelect()
        {
            InitializeComponent();                   

            //콤보 박스의 값들은 미리 설정한 static 변수값으로 초기화 
            Parity.Text = parity_str;
            DataBit.Text = databit_str;
            StopBit.Text = stopbit_str;
            BaudRate.Text = baudrate_str;
            PortBox.Text = com_str;

            //시스템에 연결도니 포트이름을 전부 가져옴 
            portname = System.IO.Ports.SerialPort.GetPortNames();

            //시스템에서 연결된 포트들을 전부 찾아서 변수에 저장한다. 
            for(int i=0;i<portname.Length;++i)
            {
                PortBox.Items.Add(portname[i]);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        //적용 버튼을 누르면 portinfo를 설정시켜준다. 
        private void Apply_portinfo_Click(object sender, EventArgs e)    
        {
            portinfo = string.Format("{0}:{1}{2}{3}{4}",
            PortBox.Text, BaudRate.Text, Parity.Text.Substring(0,1), DataBit.Text, StopBit.Text);
           
            //적용을 하면 Form1에서 부를 수 있도록 staic 변수값을 바꿔준다
            parity_str = Parity.Text;
            databit_str = DataBit.Text;
            stopbit_str = StopBit.Text;
            baudrate_str = BaudRate.Text;
            com_str = PortBox.Text;
            
        }

        //취소 버튼을 누르면 포트인포는 null값으로 초기화 시켜준다. 
        private void Cancle_Button_Click(object sender, EventArgs e)
        {
            portinfo = null;
        }

        private void PortBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PortSelect_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
