
namespace SimpleKVM
{
    partial class MainForm
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
            this.myAddressLabel = new System.Windows.Forms.Label();
            this.ServerAddressLabel = new System.Windows.Forms.Label();
            this.serverAddresstextBox = new System.Windows.Forms.TextBox();
            this.myAddressTextBox = new System.Windows.Forms.TextBox();
            this.serverStartButton = new System.Windows.Forms.Button();
            this.connectServerButton = new System.Windows.Forms.Button();
            this.functionEnableButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myAddressLabel
            // 
            this.myAddressLabel.AutoSize = true;
            this.myAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.myAddressLabel.Location = new System.Drawing.Point(28, 34);
            this.myAddressLabel.Name = "myAddressLabel";
            this.myAddressLabel.Size = new System.Drawing.Size(84, 31);
            this.myAddressLabel.TabIndex = 0;
            this.myAddressLabel.Text = "내 주소";
            // 
            // ServerAddressLabel
            // 
            this.ServerAddressLabel.AutoSize = true;
            this.ServerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ServerAddressLabel.Location = new System.Drawing.Point(28, 93);
            this.ServerAddressLabel.Name = "ServerAddressLabel";
            this.ServerAddressLabel.Size = new System.Drawing.Size(105, 31);
            this.ServerAddressLabel.TabIndex = 1;
            this.ServerAddressLabel.Text = "서버 주소";
            // 
            // serverAddresstextBox
            // 
            this.serverAddresstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.serverAddresstextBox.Location = new System.Drawing.Point(148, 90);
            this.serverAddresstextBox.Name = "serverAddresstextBox";
            this.serverAddresstextBox.Size = new System.Drawing.Size(302, 38);
            this.serverAddresstextBox.TabIndex = 2;
            // 
            // myAddressTextBox
            // 
            this.myAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.myAddressTextBox.Location = new System.Drawing.Point(148, 31);
            this.myAddressTextBox.Name = "myAddressTextBox";
            this.myAddressTextBox.ReadOnly = true;
            this.myAddressTextBox.Size = new System.Drawing.Size(302, 38);
            this.myAddressTextBox.TabIndex = 3;
            // 
            // serverStartButton
            // 
            this.serverStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.serverStartButton.Location = new System.Drawing.Point(471, 31);
            this.serverStartButton.Name = "serverStartButton";
            this.serverStartButton.Size = new System.Drawing.Size(138, 38);
            this.serverStartButton.TabIndex = 4;
            this.serverStartButton.Text = "서버 시작";
            this.serverStartButton.UseVisualStyleBackColor = true;
            this.serverStartButton.Click += new System.EventHandler(this.serverStartButton_Click);
            // 
            // connectServerButton
            // 
            this.connectServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.connectServerButton.Location = new System.Drawing.Point(471, 90);
            this.connectServerButton.Name = "connectServerButton";
            this.connectServerButton.Size = new System.Drawing.Size(138, 38);
            this.connectServerButton.TabIndex = 4;
            this.connectServerButton.Text = "서버 접속";
            this.connectServerButton.UseVisualStyleBackColor = true;
            this.connectServerButton.Click += new System.EventHandler(this.connectServerButton_Click);
            // 
            // functionEnableButton
            // 
            this.functionEnableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.functionEnableButton.Location = new System.Drawing.Point(34, 154);
            this.functionEnableButton.Name = "functionEnableButton";
            this.functionEnableButton.Size = new System.Drawing.Size(138, 38);
            this.functionEnableButton.TabIndex = 5;
            this.functionEnableButton.Text = "ON";
            this.functionEnableButton.UseVisualStyleBackColor = true;
            this.functionEnableButton.Click += new System.EventHandler(this.functionEnableButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox3.Location = new System.Drawing.Point(34, 214);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(575, 203);
            this.textBox3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 448);
            this.Controls.Add(this.functionEnableButton);
            this.Controls.Add(this.connectServerButton);
            this.Controls.Add(this.serverStartButton);
            this.Controls.Add(this.myAddressTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.serverAddresstextBox);
            this.Controls.Add(this.ServerAddressLabel);
            this.Controls.Add(this.myAddressLabel);
            this.Name = "MainForm";
            this.Text = "SimpleKVM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myAddressLabel;
        private System.Windows.Forms.Label ServerAddressLabel;
        private System.Windows.Forms.TextBox serverAddresstextBox;
        private System.Windows.Forms.TextBox myAddressTextBox;
        private System.Windows.Forms.Button serverStartButton;
        private System.Windows.Forms.Button connectServerButton;
        private System.Windows.Forms.Button functionEnableButton;
        private System.Windows.Forms.TextBox textBox3;
    }
}

