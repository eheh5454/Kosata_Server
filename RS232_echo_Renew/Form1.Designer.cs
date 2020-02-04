namespace RS232_echo_Renew
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
            this.SendMsgBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSizeUp = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSizeDown = new System.Windows.Forms.ToolStripMenuItem();
            this.RecvMsgBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TCP_ServerButton = new System.Windows.Forms.Button();
            this.FileSendButton = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ChatButton = new System.Windows.Forms.Button();
            this.ChatBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChatOffButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendMsgBox
            // 
            this.SendMsgBox.ContextMenuStrip = this.contextMenuStrip1;
            this.SendMsgBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SendMsgBox.Location = new System.Drawing.Point(12, 55);
            this.SendMsgBox.Multiline = true;
            this.SendMsgBox.Name = "SendMsgBox";
            this.SendMsgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SendMsgBox.Size = new System.Drawing.Size(445, 114);
            this.SendMsgBox.TabIndex = 0;
            this.SendMsgBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SendMsgBox_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.FontSizeUp,
            this.FontSizeDown});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 70);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveToolStripMenuItem.Text = "Font";
            // 
            // FontSizeUp
            // 
            this.FontSizeUp.Name = "FontSizeUp";
            this.FontSizeUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.FontSizeUp.Size = new System.Drawing.Size(191, 22);
            this.FontSizeUp.Text = "확대";
            this.FontSizeUp.Click += new System.EventHandler(this.FontSizeUp_Click);
            // 
            // FontSizeDown
            // 
            this.FontSizeDown.Name = "FontSizeDown";
            this.FontSizeDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.FontSizeDown.Size = new System.Drawing.Size(191, 22);
            this.FontSizeDown.Text = "축소";
            this.FontSizeDown.Click += new System.EventHandler(this.FontSizeDown_Click);
            // 
            // RecvMsgBox
            // 
            this.RecvMsgBox.Location = new System.Drawing.Point(12, 194);
            this.RecvMsgBox.Multiline = true;
            this.RecvMsgBox.Name = "RecvMsgBox";
            this.RecvMsgBox.ReadOnly = true;
            this.RecvMsgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecvMsgBox.Size = new System.Drawing.Size(445, 114);
            this.RecvMsgBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Salmon;
            this.SendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SendButton.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SendButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.SendButton.Location = new System.Drawing.Point(16, 48);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(111, 27);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "PortSetting";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StateBox
            // 
            this.StateBox.Location = new System.Drawing.Point(472, 181);
            this.StateBox.Multiline = true;
            this.StateBox.Name = "StateBox";
            this.StateBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StateBox.Size = new System.Drawing.Size(203, 155);
            this.StateBox.TabIndex = 4;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "SendMessage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "RecvMessage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(470, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "State";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenMenu
            // 
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.OpenMenu.Size = new System.Drawing.Size(145, 22);
            this.OpenMenu.Text = "Open";
            this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "ini파일(*.ini)|*.ini|PNG파일(*.png)|*.png|실행파일(.exe)|*.exe";
            this.openFileDialog1.InitialDirectory = "c:\\\\Myini";
            // 
            // TCP_ServerButton
            // 
            this.TCP_ServerButton.Location = new System.Drawing.Point(18, 35);
            this.TCP_ServerButton.Name = "TCP_ServerButton";
            this.TCP_ServerButton.Size = new System.Drawing.Size(110, 23);
            this.TCP_ServerButton.TabIndex = 9;
            this.TCP_ServerButton.Text = "ServerStart";
            this.TCP_ServerButton.UseVisualStyleBackColor = true;
            this.TCP_ServerButton.Click += new System.EventHandler(this.ServerButton_Click);
            // 
            // FileSendButton
            // 
            this.FileSendButton.Location = new System.Drawing.Point(472, 342);
            this.FileSendButton.Name = "FileSendButton";
            this.FileSendButton.Size = new System.Drawing.Size(108, 23);
            this.FileSendButton.TabIndex = 10;
            this.FileSendButton.Text = "FileSend";
            this.FileSendButton.UseVisualStyleBackColor = true;
            this.FileSendButton.Click += new System.EventHandler(this.FileSendButton_Click);
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(472, 371);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(108, 23);
            this.File.TabIndex = 11;
            this.File.Text = "FileSend_B";
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(473, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(153, 122);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.SendButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(145, 96);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RS232";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TCP_ServerButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(145, 96);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCP/IP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ChatOffButton);
            this.tabPage3.Controls.Add(this.ChatButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(145, 96);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UDP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ChatButton
            // 
            this.ChatButton.Location = new System.Drawing.Point(18, 22);
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.Size = new System.Drawing.Size(110, 23);
            this.ChatButton.TabIndex = 11;
            this.ChatButton.Text = "Chat_On";
            this.ChatButton.UseVisualStyleBackColor = true;
            this.ChatButton.Click += new System.EventHandler(this.ChatButton_Click);
            // 
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(12, 333);
            this.ChatBox.Multiline = true;
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatBox.Size = new System.Drawing.Size(444, 189);
            this.ChatBox.TabIndex = 13;
            this.ChatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chat";
            // 
            // ChatOffButton
            // 
            this.ChatOffButton.Location = new System.Drawing.Point(18, 51);
            this.ChatOffButton.Name = "ChatOffButton";
            this.ChatOffButton.Size = new System.Drawing.Size(110, 23);
            this.ChatOffButton.TabIndex = 12;
            this.ChatOffButton.Text = "Chat_Off";
            this.ChatOffButton.UseVisualStyleBackColor = true;
            this.ChatOffButton.Click += new System.EventHandler(this.ChatOffButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(696, 534);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.File);
            this.Controls.Add(this.FileSendButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.RecvMsgBox);
            this.Controls.Add(this.SendMsgBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SendMsgBox;
        private System.Windows.Forms.TextBox RecvMsgBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox StateBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontSizeUp;
        private System.Windows.Forms.ToolStripMenuItem FontSizeDown;
        private System.Windows.Forms.Button TCP_ServerButton;
        private System.Windows.Forms.Button FileSendButton;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ChatButton;
        private System.Windows.Forms.TextBox ChatBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChatOffButton;
    }
}

