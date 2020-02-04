namespace RS232_echo_new
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Send_Msg = new System.Windows.Forms.TextBox();
            this.Recv_Msg = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.Chat_send = new System.Windows.Forms.Label();
            this.Chat_recv = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Call_PortSelect = new System.Windows.Forms.Button();
            this.PortInfo_Box = new System.Windows.Forms.TextBox();
            this.Check_SerialPort = new System.Windows.Forms.TextBox();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "RS232",
            "TCP/IP"});
            this.listBox1.Location = new System.Drawing.Point(616, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 28);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Send_Msg
            // 
            this.Send_Msg.Location = new System.Drawing.Point(12, 23);
            this.Send_Msg.MaximumSize = new System.Drawing.Size(500, 150);
            this.Send_Msg.MinimumSize = new System.Drawing.Size(500, 150);
            this.Send_Msg.Multiline = true;
            this.Send_Msg.Name = "Send_Msg";
            this.Send_Msg.Size = new System.Drawing.Size(500, 150);
            this.Send_Msg.TabIndex = 2;
            this.Send_Msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Send_Msg_KeyDown);
            // 
            // Recv_Msg
            // 
            this.Recv_Msg.Location = new System.Drawing.Point(12, 207);
            this.Recv_Msg.MaximumSize = new System.Drawing.Size(500, 100);
            this.Recv_Msg.MinimumSize = new System.Drawing.Size(500, 150);
            this.Recv_Msg.Multiline = true;
            this.Recv_Msg.Name = "Recv_Msg";
            this.Recv_Msg.Size = new System.Drawing.Size(500, 150);
            this.Recv_Msg.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Silver;
            this.SendButton.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(535, 48);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(82, 42);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Chat_send
            // 
            this.Chat_send.AutoSize = true;
            this.Chat_send.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Chat_send.ForeColor = System.Drawing.Color.Snow;
            this.Chat_send.Location = new System.Drawing.Point(13, 5);
            this.Chat_send.Name = "Chat_send";
            this.Chat_send.Size = new System.Drawing.Size(86, 19);
            this.Chat_send.TabIndex = 5;
            this.Chat_send.Text = "Chat_Send";
            // 
            // Chat_recv
            // 
            this.Chat_recv.AutoSize = true;
            this.Chat_recv.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Chat_recv.ForeColor = System.Drawing.Color.Snow;
            this.Chat_recv.Location = new System.Drawing.Point(13, 185);
            this.Chat_recv.Name = "Chat_recv";
            this.Chat_recv.Size = new System.Drawing.Size(85, 19);
            this.Chat_recv.TabIndex = 6;
            this.Chat_recv.Text = "Chat_Recv";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Call_PortSelect
            // 
            this.Call_PortSelect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Call_PortSelect.ForeColor = System.Drawing.Color.Black;
            this.Call_PortSelect.Location = new System.Drawing.Point(535, 12);
            this.Call_PortSelect.Name = "Call_PortSelect";
            this.Call_PortSelect.Size = new System.Drawing.Size(75, 30);
            this.Call_PortSelect.TabIndex = 7;
            this.Call_PortSelect.Text = "Port";
            this.Call_PortSelect.UseVisualStyleBackColor = true;
            this.Call_PortSelect.Click += new System.EventHandler(this.PortSelect_Click);
            // 
            // PortInfo_Box
            // 
            this.PortInfo_Box.Location = new System.Drawing.Point(535, 207);
            this.PortInfo_Box.Multiline = true;
            this.PortInfo_Box.Name = "PortInfo_Box";
            this.PortInfo_Box.Size = new System.Drawing.Size(249, 231);
            this.PortInfo_Box.TabIndex = 8;
            this.PortInfo_Box.TextChanged += new System.EventHandler(this.PortInfo_Box_TextChanged);
            // 
            // Check_SerialPort
            // 
            this.Check_SerialPort.Location = new System.Drawing.Point(535, 167);
            this.Check_SerialPort.Name = "Check_SerialPort";
            this.Check_SerialPort.Size = new System.Drawing.Size(249, 21);
            this.Check_SerialPort.TabIndex = 9;
            this.Check_SerialPort.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(12, 397);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(500, 21);
            this.ErrorBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(533, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "state";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(537, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "PortInfo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.Check_SerialPort);
            this.Controls.Add(this.PortInfo_Box);
            this.Controls.Add(this.Call_PortSelect);
            this.Controls.Add(this.Chat_recv);
            this.Controls.Add(this.Chat_send);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.Recv_Msg);
            this.Controls.Add(this.Send_Msg);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Send_Msg;
        public System.Windows.Forms.TextBox Recv_Msg;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label Chat_send;
        private System.Windows.Forms.Label Chat_recv;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Call_PortSelect;
        private System.Windows.Forms.TextBox PortInfo_Box;
        private System.Windows.Forms.TextBox Check_SerialPort;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

