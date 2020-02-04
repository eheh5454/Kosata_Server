namespace RS232_echo_new
{
    partial class PortSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Parity = new System.Windows.Forms.ComboBox();
            this.DataBit = new System.Windows.Forms.ComboBox();
            this.StopBit = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.Apply_portinfo = new System.Windows.Forms.Button();
            this.Cancle_Button = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Parity
            // 
            this.Parity.FormattingEnabled = true;
            this.Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.Parity.Location = new System.Drawing.Point(17, 35);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(121, 20);
            this.Parity.TabIndex = 0;
            this.Parity.Text = "Parity";
            // 
            // DataBit
            // 
            this.DataBit.FormattingEnabled = true;
            this.DataBit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBit.Location = new System.Drawing.Point(172, 35);
            this.DataBit.Name = "DataBit";
            this.DataBit.Size = new System.Drawing.Size(121, 20);
            this.DataBit.TabIndex = 1;
            this.DataBit.Text = "DataBit";
            this.DataBit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StopBit
            // 
            this.StopBit.FormattingEnabled = true;
            this.StopBit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.StopBit.Location = new System.Drawing.Point(330, 35);
            this.StopBit.Name = "StopBit";
            this.StopBit.Size = new System.Drawing.Size(121, 20);
            this.StopBit.TabIndex = 2;
            this.StopBit.Text = "StopBit";
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "115200"});
            this.BaudRate.Location = new System.Drawing.Point(477, 35);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(121, 20);
            this.BaudRate.TabIndex = 3;
            this.BaudRate.Text = "BaudRate";
            // 
            // Apply_portinfo
            // 
            this.Apply_portinfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Apply_portinfo.Location = new System.Drawing.Point(416, 69);
            this.Apply_portinfo.Name = "Apply_portinfo";
            this.Apply_portinfo.Size = new System.Drawing.Size(101, 23);
            this.Apply_portinfo.TabIndex = 5;
            this.Apply_portinfo.Text = "Apply";
            this.Apply_portinfo.UseVisualStyleBackColor = true;
            this.Apply_portinfo.Click += new System.EventHandler(this.Apply_portinfo_Click);
            // 
            // Cancle_Button
            // 
            this.Cancle_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancle_Button.Location = new System.Drawing.Point(523, 69);
            this.Cancle_Button.Name = "Cancle_Button";
            this.Cancle_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancle_Button.TabIndex = 6;
            this.Cancle_Button.Text = "Cancle";
            this.Cancle_Button.UseVisualStyleBackColor = true;
            this.Cancle_Button.Click += new System.EventHandler(this.Cancle_Button_Click);
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(17, 85);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(121, 20);
            this.PortBox.TabIndex = 7;
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "DataBit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "StopBit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "BaudRate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "PORT";
            // 
            // PortSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 123);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.Cancle_Button);
            this.Controls.Add(this.Apply_portinfo);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.StopBit);
            this.Controls.Add(this.DataBit);
            this.Controls.Add(this.Parity);
            this.Name = "PortSelect";
            this.Text = "PortSelect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PortSelect_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Parity;
        private System.Windows.Forms.ComboBox DataBit;
        private System.Windows.Forms.ComboBox StopBit;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.Button Apply_portinfo;
        private System.Windows.Forms.Button Cancle_Button;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}