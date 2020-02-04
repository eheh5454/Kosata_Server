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


namespace RS232_echo_Renew
{
    public partial class Editini : Form
    {
        StreamReader sr;

        public Editini(string FileName)
        {
            InitializeComponent();
            sr = new StreamReader(FileName);
            TextBox.Text = sr.ReadToEnd();
        }

        //파일저장
        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //텍스트 파일열기
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default);

                //데이터 읽어오기
                sw.Write(TextBox.Text); //텍스트 모두 열기
                //파일 닫기
                sw.Close();             


            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {            
                //소켓 생성 
                TcpClient Socket = new TcpClient("127.0.0.1", 9000);

                //스트림 생성 
                NetworkStream ns = Socket.GetStream();
                StreamWriter sw = new StreamWriter(ns);

                while (true)
                {
                    string s = sr.ReadLine();                    
                    sw.WriteLine(s);
                    if (s == null) break;
                }                
                sw.Flush();

                //스트림 비우기
                sw.Close();
                ns.Close();
                Socket.Close();
            }
            catch (SocketException se)
            {
                TextBox.Text = string.Format("{0}", se);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
