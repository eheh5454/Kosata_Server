namespace RS232_echo_Renew
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
            this.ParityBox = new System.Windows.Forms.ComboBox();
            this.DataBitBox = new System.Windows.Forms.ComboBox();
            this.StopBitBox = new System.Windows.Forms.ComboBox();
            this.BaudRateBox = new System.Windows.Forms.ComboBox();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancleButton = new System.Windows.Forms.Button();
            this.Port_Label = new System.Windows.Forms.Label();
            this.BaudRate_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParityBox
            // 
            this.ParityBox.FormattingEnabled = true;
            this.ParityBox.Location = new System.Drawing.Point(293, 27);
            this.ParityBox.Name = "ParityBox";
            this.ParityBox.Size = new System.Drawing.Size(121, 20);
            this.ParityBox.TabIndex = 0;
            // 
            // DataBitBox
            // 
            this.DataBitBox.FormattingEnabled = true;
            this.DataBitBox.Location = new System.Drawing.Point(434, 27);
            this.DataBitBox.Name = "DataBitBox";
            this.DataBitBox.Size = new System.Drawing.Size(121, 20);
            this.DataBitBox.TabIndex = 1;
            // 
            // StopBitBox
            // 
            this.StopBitBox.FormattingEnabled = true;
            this.StopBitBox.Location = new System.Drawing.Point(574, 27);
            this.StopBitBox.Name = "StopBitBox";
            this.StopBitBox.Size = new System.Drawing.Size(121, 20);
            this.StopBitBox.TabIndex = 2;
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.FormattingEnabled = true;
            this.BaudRateBox.Location = new System.Drawing.Point(149, 27);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(121, 20);
            this.BaudRateBox.TabIndex = 3;
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(12, 27);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(121, 20);
            this.PortBox.TabIndex = 4;
            // 
            // ApplyButton
            // 
            this.ApplyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ApplyButton.Location = new System.Drawing.Point(539, 59);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 5;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancleButton
            // 
            this.CancleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancleButton.Location = new System.Drawing.Point(620, 59);
            this.CancleButton.Name = "CancleButton";
            this.CancleButton.Size = new System.Drawing.Size(75, 23);
            this.CancleButton.TabIndex = 6;
            this.CancleButton.Text = "Cancel";
            this.CancleButton.UseVisualStyleBackColor = true;
            this.CancleButton.Click += new System.EventHandler(this.CancleButton_Click);
            // 
            // Port_Label
            // 
            this.Port_Label.AutoSize = true;
            this.Port_Label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Port_Label.ForeColor = System.Drawing.Color.Black;
            this.Port_Label.Location = new System.Drawing.Point(13, 9);
            this.Port_Label.Name = "Port_Label";
            this.Port_Label.Size = new System.Drawing.Size(42, 12);
            this.Port_Label.TabIndex = 7;
            this.Port_Label.Text = "PORT";
            // 
            // BaudRate_Label
            // 
            this.BaudRate_Label.AutoSize = true;
            this.BaudRate_Label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BaudRate_Label.ForeColor = System.Drawing.Color.Black;
            this.BaudRate_Label.Location = new System.Drawing.Point(147, 9);
            this.BaudRate_Label.Name = "BaudRate_Label";
            this.BaudRate_Label.Size = new System.Drawing.Size(67, 12);
            this.BaudRate_Label.TabIndex = 8;
            this.BaudRate_Label.Text = "BaudRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Parity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(432, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "DataBit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(572, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "StopBit";
            // 
            // PortSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 104);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaudRate_Label);
            this.Controls.Add(this.Port_Label);
            this.Controls.Add(this.CancleButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.BaudRateBox);
            this.Controls.Add(this.StopBitBox);
            this.Controls.Add(this.DataBitBox);
            this.Controls.Add(this.ParityBox);
            this.Name = "PortSelect";
            this.Text = "PortSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ParityBox;
        private System.Windows.Forms.ComboBox DataBitBox;
        private System.Windows.Forms.ComboBox StopBitBox;
        private System.Windows.Forms.ComboBox BaudRateBox;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancleButton;
        private System.Windows.Forms.Label Port_Label;
        private System.Windows.Forms.Label BaudRate_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}