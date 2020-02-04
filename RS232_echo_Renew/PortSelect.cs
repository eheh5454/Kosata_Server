using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS232_echo_Renew
{
    using parity_enum = System.IO.Ports.Parity;
    using stopbit_enum = System.IO.Ports.StopBits;

    public partial class PortSelect : Form
    {
        //Form1으로 넘겨줄 static 변수들 
        public static string port = null;
        public static int baudrate;
        public static parity_enum parity;
        public static stopbit_enum stopbit;
        public static int databit;

        //cancel버튼으로 닫았는지 확인용 bool변수 
        public bool cancel = false;
          
        //연결된 포트를 찾아서 저장할 배열 변수 
        public string[] portnames;

        //보레이트 배열 변수 
        public int[] baudrates = { 1200, 2400, 4800, 9600, 19200, 115200 };

        //데이터비트 배열 변수 
        public int[] databits = { 7, 8 };       
        
        public PortSelect()
        {
            InitializeComponent();

            //시스템에 연결된 포트이름을 전부 가져옴 
            portnames = System.IO.Ports.SerialPort.GetPortNames();            

            //시스템에서 연결된 포트들을 전부 찾아서 변수에 저장한다. 
            for (int i = 0; i < portnames.Length; ++i)
            {
                PortBox.Items.Add(portnames[i]);
            }

            //보레이트 콤보박스에 요소 추가 
            for (int i = 0; i < baudrates.Length; ++i)
            {
                BaudRateBox.Items.Add(baudrates[i]);
            }            

            //패리티 콤보박스에 패리티 Enum형태를 전부 넣어줌 
            for (int i = 0; i < Enum.GetNames(typeof(parity_enum)).Length; ++i)
            {
                ParityBox.Items.Add(((parity_enum)i).ToString());
            }            

            //스탑비트 콤보박스에 스탑비트 Enum형태를 전부 넣어줌 
            for (int i = 0; i < Enum.GetNames(typeof(stopbit_enum)).Length; ++i)
            {
                StopBitBox.Items.Add(((stopbit_enum)i).ToString());
            }

            //데이터비트 콤보박스에 요소 추가 
            for (int i = 0; i < databits.Length; ++i) 
            {
                DataBitBox.Items.Add(databits[i]);
            }

            //콤보박스 초기값 설정 
            BaudRateBox.SelectedIndex = 3;
            ParityBox.SelectedIndex = 0;
            StopBitBox.SelectedIndex = 1;
            DataBitBox.SelectedIndex = 1;

        }
                

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            //콤보박스에서 선택한 항목들을 스태틱 변수에 저장 
            port = PortBox.Text;
            baudrate = Int32.Parse(BaudRateBox.Text);
            parity = (parity_enum)ParityBox.SelectedIndex;
            stopbit = (stopbit_enum)StopBitBox.SelectedIndex;
            databit = Int32.Parse(DataBitBox.Text);
            cancel = false;
        }

        //cancel버튼을 누르면 cancel을 true로 설정해 Form1이 알도록 함 
        private void CancleButton_Click(object sender, EventArgs e)
        {
            cancel = true;
        }
    }
}
