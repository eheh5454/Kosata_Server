namespace TCPIP_Send
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.UP = new System.Windows.Forms.Button();
            this.RIGHT = new System.Windows.Forms.Button();
            this.DOWN = new System.Windows.Forms.Button();
            this.LEFT = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_Temp = new System.Windows.Forms.TextBox();
            this.Box_Hum = new System.Windows.Forms.TextBox();
            this.Web_mjpg_stream = new System.Windows.Forms.WebBrowser();
            this.Chart_TH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BOX_razigIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_capture = new System.Windows.Forms.Button();
            this.Button_Auto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Box_time = new System.Windows.Forms.TextBox();
            this.Box_min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Reserv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_TH)).BeginInit();
            this.SuspendLayout();
            // 
            // UP
            // 
            this.UP.BackColor = System.Drawing.Color.PowderBlue;
            this.UP.FlatAppearance.BorderSize = 0;
            this.UP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.UP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UP.ForeColor = System.Drawing.Color.LightPink;
            this.UP.Image = ((System.Drawing.Image)(resources.GetObject("UP.Image")));
            this.UP.Location = new System.Drawing.Point(565, 281);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(110, 110);
            this.UP.TabIndex = 0;
            this.UP.UseVisualStyleBackColor = false;
            this.UP.Click += new System.EventHandler(this.UP_Click);
            // 
            // RIGHT
            // 
            this.RIGHT.BackColor = System.Drawing.Color.PowderBlue;
            this.RIGHT.FlatAppearance.BorderSize = 0;
            this.RIGHT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RIGHT.Image = ((System.Drawing.Image)(resources.GetObject("RIGHT.Image")));
            this.RIGHT.Location = new System.Drawing.Point(681, 388);
            this.RIGHT.Name = "RIGHT";
            this.RIGHT.Size = new System.Drawing.Size(110, 110);
            this.RIGHT.TabIndex = 1;
            this.RIGHT.UseVisualStyleBackColor = false;
            this.RIGHT.Click += new System.EventHandler(this.RIGHT_Click);
            // 
            // DOWN
            // 
            this.DOWN.BackColor = System.Drawing.Color.PowderBlue;
            this.DOWN.FlatAppearance.BorderSize = 0;
            this.DOWN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DOWN.Image = ((System.Drawing.Image)(resources.GetObject("DOWN.Image")));
            this.DOWN.Location = new System.Drawing.Point(565, 495);
            this.DOWN.Name = "DOWN";
            this.DOWN.Size = new System.Drawing.Size(110, 110);
            this.DOWN.TabIndex = 2;
            this.DOWN.UseVisualStyleBackColor = false;
            this.DOWN.Click += new System.EventHandler(this.DOWN_Click);
            // 
            // LEFT
            // 
            this.LEFT.BackColor = System.Drawing.Color.PowderBlue;
            this.LEFT.FlatAppearance.BorderSize = 0;
            this.LEFT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LEFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LEFT.Image = ((System.Drawing.Image)(resources.GetObject("LEFT.Image")));
            this.LEFT.Location = new System.Drawing.Point(449, 388);
            this.LEFT.Name = "LEFT";
            this.LEFT.Size = new System.Drawing.Size(110, 110);
            this.LEFT.TabIndex = 3;
            this.LEFT.UseVisualStyleBackColor = false;
            this.LEFT.Click += new System.EventHandler(this.LEFT_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConnectButton.Location = new System.Drawing.Point(274, 29);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(80, 26);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // STOP
            // 
            this.STOP.FlatAppearance.BorderSize = 0;
            this.STOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STOP.Image = ((System.Drawing.Image)(resources.GetObject("STOP.Image")));
            this.STOP.Location = new System.Drawing.Point(581, 403);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(80, 80);
            this.STOP.TabIndex = 5;
            this.STOP.UseVisualStyleBackColor = true;
            this.STOP.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "온도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "습도";
            // 
            // Box_Temp
            // 
            this.Box_Temp.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Box_Temp.Location = new System.Drawing.Point(15, 100);
            this.Box_Temp.Name = "Box_Temp";
            this.Box_Temp.Size = new System.Drawing.Size(130, 26);
            this.Box_Temp.TabIndex = 9;
            // 
            // Box_Hum
            // 
            this.Box_Hum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Box_Hum.Location = new System.Drawing.Point(15, 180);
            this.Box_Hum.Name = "Box_Hum";
            this.Box_Hum.Size = new System.Drawing.Size(130, 26);
            this.Box_Hum.TabIndex = 10;
            // 
            // Web_mjpg_stream
            // 
            this.Web_mjpg_stream.Location = new System.Drawing.Point(9, 281);
            this.Web_mjpg_stream.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web_mjpg_stream.Name = "Web_mjpg_stream";
            this.Web_mjpg_stream.ScrollBarsEnabled = false;
            this.Web_mjpg_stream.Size = new System.Drawing.Size(425, 330);
            this.Web_mjpg_stream.TabIndex = 11;
            this.Web_mjpg_stream.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Web_mjpg_stream_DocumentCompleted);
            // 
            // Chart_TH
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_TH.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_TH.Legends.Add(legend1);
            this.Chart_TH.Location = new System.Drawing.Point(200, 84);
            this.Chart_TH.Name = "Chart_TH";
            series1.ChartArea = "ChartArea1";
            series1.LabelBorderWidth = 2;
            series1.Legend = "Legend1";
            series1.Name = "Temp";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            this.Chart_TH.Series.Add(series1);
            this.Chart_TH.Series.Add(series2);
            this.Chart_TH.Size = new System.Drawing.Size(591, 191);
            this.Chart_TH.TabIndex = 12;
            this.Chart_TH.Text = "chart1";
            title1.Name = "Temp";
            title1.Text = "Temp and Humidity";
            this.Chart_TH.Titles.Add(title1);
            // 
            // BOX_razigIP
            // 
            this.BOX_razigIP.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BOX_razigIP.Location = new System.Drawing.Point(16, 29);
            this.BOX_razigIP.Name = "BOX_razigIP";
            this.BOX_razigIP.Size = new System.Drawing.Size(250, 26);
            this.BOX_razigIP.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Razig_IP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button_capture
            // 
            this.Button_capture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_capture.Location = new System.Drawing.Point(9, 251);
            this.Button_capture.Name = "Button_capture";
            this.Button_capture.Size = new System.Drawing.Size(75, 23);
            this.Button_capture.TabIndex = 17;
            this.Button_capture.Text = "Capture";
            this.Button_capture.UseVisualStyleBackColor = true;
            this.Button_capture.Click += new System.EventHandler(this.Button_capture_Click);
            // 
            // Button_Auto
            // 
            this.Button_Auto.Location = new System.Drawing.Point(713, 290);
            this.Button_Auto.Name = "Button_Auto";
            this.Button_Auto.Size = new System.Drawing.Size(75, 23);
            this.Button_Auto.TabIndex = 18;
            this.Button_Auto.Text = "Auto";
            this.Button_Auto.UseVisualStyleBackColor = true;
            this.Button_Auto.Click += new System.EventHandler(this.Button_Auto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Passive";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Box_time
            // 
            this.Box_time.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Box_time.Location = new System.Drawing.Point(516, 29);
            this.Box_time.Name = "Box_time";
            this.Box_time.Size = new System.Drawing.Size(48, 26);
            this.Box_time.TabIndex = 20;
            this.Box_time.Text = "00";
            this.Box_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Box_min
            // 
            this.Box_min.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Box_min.Location = new System.Drawing.Point(596, 29);
            this.Box_min.Name = "Box_min";
            this.Box_min.Size = new System.Drawing.Size(48, 26);
            this.Box_min.TabIndex = 21;
            this.Box_min.Text = "00";
            this.Box_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(513, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "시간예약";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(565, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "시";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(650, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "분";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Reserv
            // 
            this.Reserv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Reserv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reserv.Location = new System.Drawing.Point(681, 29);
            this.Reserv.Name = "Reserv";
            this.Reserv.Size = new System.Drawing.Size(80, 26);
            this.Reserv.TabIndex = 25;
            this.Reserv.Text = "예약";
            this.Reserv.UseVisualStyleBackColor = true;
            this.Reserv.Click += new System.EventHandler(this.Reserv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.Reserv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Box_min);
            this.Controls.Add(this.Box_time);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button_Auto);
            this.Controls.Add(this.Button_capture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BOX_razigIP);
            this.Controls.Add(this.Chart_TH);
            this.Controls.Add(this.Web_mjpg_stream);
            this.Controls.Add(this.Box_Hum);
            this.Controls.Add(this.Box_Temp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.LEFT);
            this.Controls.Add(this.DOWN);
            this.Controls.Add(this.RIGHT);
            this.Controls.Add(this.UP);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "A.T Famer 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_TH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Button RIGHT;
        private System.Windows.Forms.Button DOWN;
        private System.Windows.Forms.Button LEFT;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Box_Temp;
        private System.Windows.Forms.TextBox Box_Hum;
        private System.Windows.Forms.WebBrowser Web_mjpg_stream;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_TH;
        private System.Windows.Forms.TextBox BOX_razigIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_capture;
        private System.Windows.Forms.Button Button_Auto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Box_time;
        private System.Windows.Forms.TextBox Box_min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Reserv;
    }
}

