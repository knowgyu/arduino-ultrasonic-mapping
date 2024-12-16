namespace servo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.lblPortNum = new System.Windows.Forms.Label();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.lblRcv = new System.Windows.Forms.Label();
            this.txtRcv = new System.Windows.Forms.TextBox();
            this.btnMap = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDist = new System.Windows.Forms.TextBox();
            this.lblDist = new System.Windows.Forms.Label();
            this.txtDeg = new System.Windows.Forms.TextBox();
            this.lblDeg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.Location = new System.Drawing.Point(14, 14);
            this.picDraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(800, 500);
            this.picDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            // 
            // lblPortNum
            // 
            this.lblPortNum.AutoSize = true;
            this.lblPortNum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPortNum.Location = new System.Drawing.Point(1007, 14);
            this.lblPortNum.Name = "lblPortNum";
            this.lblPortNum.Size = new System.Drawing.Size(110, 20);
            this.lblPortNum.TabIndex = 1;
            this.lblPortNum.Text = "포트번호 : ";
            // 
            // txtPortNum
            // 
            this.txtPortNum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPortNum.Location = new System.Drawing.Point(1123, 10);
            this.txtPortNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(69, 30);
            this.txtPortNum.TabIndex = 2;
            this.txtPortNum.Text = "5";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkStart.Location = new System.Drawing.Point(1011, 46);
            this.chkStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(118, 24);
            this.chkStart.TabIndex = 6;
            this.chkStart.Text = "통신 시작";
            this.chkStart.UseVisualStyleBackColor = true;
            this.chkStart.CheckedChanged += new System.EventHandler(this.chkStart_CheckedChanged);
            // 
            // lblRcv
            // 
            this.lblRcv.AutoSize = true;
            this.lblRcv.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRcv.Location = new System.Drawing.Point(993, 128);
            this.lblRcv.Name = "lblRcv";
            this.lblRcv.Size = new System.Drawing.Size(123, 20);
            this.lblRcv.TabIndex = 7;
            this.lblRcv.Text = "수신데이터 :";
            // 
            // txtRcv
            // 
            this.txtRcv.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRcv.Location = new System.Drawing.Point(1123, 124);
            this.txtRcv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRcv.Name = "txtRcv";
            this.txtRcv.Size = new System.Drawing.Size(109, 30);
            this.txtRcv.TabIndex = 8;
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(976, 339);
            this.btnMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(181, 58);
            this.btnMap.TabIndex = 9;
            this.btnMap.Text = "Mapping";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDist
            // 
            this.txtDist.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDist.Location = new System.Drawing.Point(1123, 178);
            this.txtDist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(109, 30);
            this.txtDist.TabIndex = 11;
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDist.Location = new System.Drawing.Point(1047, 181);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(70, 20);
            this.lblDist.TabIndex = 10;
            this.lblDist.Text = "거리 : ";
            // 
            // txtDeg
            // 
            this.txtDeg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDeg.Location = new System.Drawing.Point(1123, 232);
            this.txtDeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeg.Name = "txtDeg";
            this.txtDeg.Size = new System.Drawing.Size(109, 30);
            this.txtDeg.TabIndex = 13;
            // 
            // lblDeg
            // 
            this.lblDeg.AutoSize = true;
            this.lblDeg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDeg.Location = new System.Drawing.Point(1047, 235);
            this.lblDeg.Name = "lblDeg";
            this.lblDeg.Size = new System.Drawing.Size(70, 20);
            this.lblDeg.TabIndex = 12;
            this.lblDeg.Text = "각도 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1238, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "[cm]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(1238, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "[ º ]";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1175, 339);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(181, 58);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 488);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 58);
            this.button1.TabIndex = 18;
            this.button1.Text = "Mapping";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1466, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeg);
            this.Controls.Add(this.lblDeg);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.lblDist);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.txtRcv);
            this.Controls.Add(this.lblRcv);
            this.Controls.Add(this.chkStart);
            this.Controls.Add(this.txtPortNum);
            this.Controls.Add(this.lblPortNum);
            this.Controls.Add(this.picDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "아두이노 모니터링";
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.Label lblPortNum;
        private System.Windows.Forms.TextBox txtPortNum;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chkStart;
        private System.Windows.Forms.Label lblRcv;
        private System.Windows.Forms.TextBox txtRcv;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.TextBox txtDeg;
        private System.Windows.Forms.Label lblDeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button1;
    }
}

