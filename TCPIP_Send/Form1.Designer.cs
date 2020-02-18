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
            this.UP = new System.Windows.Forms.Button();
            this.RIGHT = new System.Windows.Forms.Button();
            this.DOWN = new System.Windows.Forms.Button();
            this.LEFT = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_Temp = new System.Windows.Forms.TextBox();
            this.Box_Hum = new System.Windows.Forms.TextBox();
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
            this.UP.Location = new System.Drawing.Point(129, 106);
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
            this.RIGHT.Location = new System.Drawing.Point(245, 213);
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
            this.DOWN.Location = new System.Drawing.Point(129, 320);
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
            this.LEFT.Location = new System.Drawing.Point(13, 213);
            this.LEFT.Name = "LEFT";
            this.LEFT.Size = new System.Drawing.Size(110, 110);
            this.LEFT.TabIndex = 3;
            this.LEFT.UseVisualStyleBackColor = false;
            this.LEFT.Click += new System.EventHandler(this.LEFT_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(269, 15);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(86, 33);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(269, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(15, 434);
            this.ErrorBox.Multiline = true;
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(340, 44);
            this.ErrorBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "온도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "습도";
            // 
            // Box_Temp
            // 
            this.Box_Temp.Location = new System.Drawing.Point(15, 27);
            this.Box_Temp.Name = "Box_Temp";
            this.Box_Temp.Size = new System.Drawing.Size(100, 21);
            this.Box_Temp.TabIndex = 9;
            // 
            // Box_Hum
            // 
            this.Box_Hum.Location = new System.Drawing.Point(15, 76);
            this.Box_Hum.Name = "Box_Hum";
            this.Box_Hum.Size = new System.Drawing.Size(100, 21);
            this.Box_Hum.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(379, 480);
            this.Controls.Add(this.Box_Hum);
            this.Controls.Add(this.Box_Temp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.LEFT);
            this.Controls.Add(this.DOWN);
            this.Controls.Add(this.RIGHT);
            this.Controls.Add(this.UP);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UP;
        private System.Windows.Forms.Button RIGHT;
        private System.Windows.Forms.Button DOWN;
        private System.Windows.Forms.Button LEFT;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Box_Temp;
        private System.Windows.Forms.TextBox Box_Hum;
    }
}

