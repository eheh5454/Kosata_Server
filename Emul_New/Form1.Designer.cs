namespace Emul_New
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
            this.MsgBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_SQL = new System.Windows.Forms.ListView();
            this.Button_DBdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MsgBox
            // 
            this.MsgBox.Location = new System.Drawing.Point(12, 28);
            this.MsgBox.Multiline = true;
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Size = new System.Drawing.Size(400, 200);
            this.MsgBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(13, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "SQL";
            // 
            // listView_SQL
            // 
            this.listView_SQL.HideSelection = false;
            this.listView_SQL.Location = new System.Drawing.Point(15, 260);
            this.listView_SQL.Name = "listView_SQL";
            this.listView_SQL.Size = new System.Drawing.Size(400, 150);
            this.listView_SQL.TabIndex = 5;
            this.listView_SQL.UseCompatibleStateImageBehavior = false;
            // 
            // Button_DBdelete
            // 
            this.Button_DBdelete.Location = new System.Drawing.Point(418, 28);
            this.Button_DBdelete.Name = "Button_DBdelete";
            this.Button_DBdelete.Size = new System.Drawing.Size(75, 23);
            this.Button_DBdelete.TabIndex = 6;
            this.Button_DBdelete.Text = "DB_Delete";
            this.Button_DBdelete.UseVisualStyleBackColor = true;
            this.Button_DBdelete.Click += new System.EventHandler(this.Button_DBdelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(503, 425);
            this.Controls.Add(this.Button_DBdelete);
            this.Controls.Add(this.listView_SQL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MsgBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MsgBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_SQL;
        private System.Windows.Forms.Button Button_DBdelete;
    }
}

