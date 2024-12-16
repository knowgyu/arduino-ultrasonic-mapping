using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servo
{
    public partial class Form1 : Form
    {
        private string rbuff = "";
        private TCanvas canvas = null;
        private string _dist = "", _deg = "";

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            if (canvas == null) canvas = new TCanvas(picDraw, -400, 400, 0, 500);
        }
        private void chkStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStart.Checked)
            {
                bool success = SPort.OpenPorts(serialPort1, Convert.ToInt32(txtPortNum.Text));
                if (!success)
                {
                    MessageBox.Show("시리얼포트를 열지 못했습니다");
                    chkStart.Checked = false;
                }
                else MessageBox.Show("연결되었습니다.");
            }
            else SPort.ClosePorts(serialPort1);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //수신버퍼읽기
            string tmp = SPort.Read(serialPort1);
            rbuff += tmp;
            if (rbuff.Length > 100)
            {
                rbuff = ""; return;
            }

            while (true)
            {
                // STX를 통해 rbuff 찾아 앞부분 뜯어내기
                int ipos = rbuff.IndexOf(SPort.sSTX());
                if (ipos < 0) break;
                rbuff = rbuff.Substring(ipos);

                // CR-LF 찾기.
                ipos = rbuff.IndexOf("\r\n");
                if (ipos < 0) break;
                string stwork = rbuff.Substring(0, ipos + 2);

                rbuff = rbuff.Substring(ipos + 2);

                ipos = stwork.IndexOf(SPort.sETX());
                if (ipos < 0) break;
                stwork = stwork.Substring(0, ipos);

                stwork = stwork.Substring(1);


                txtRcv.Text = stwork;

                char[] sep2 = new char[] { ':' };
                string[] str = stwork.Split(sep2);

                _dist += str[0] + ',';
                _deg += str[1] + ',';

            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            canvas.ClearDrawing(Color.White);
            for (int i = 1; i <= 10; i++)
            {
                canvas.DrawEllipse(Color.Blue, 0, 0, i, i); // 중앙에 점찍기
            }

            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            canvas.ClearDrawing(Color.White);
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canvas.DrawEllipse(Color.Red, 0, 200, 30, 30);
        }

        private void timer1_Tick(object sender, EventArgs e) // distance와 deg에 따라 Mapping
        {
            char[] sep = new char[] { ',' };
            string[] str1 = _dist.Split(sep);
            string[] str2 = _deg.Split(sep);
            double[] dist = new double[str1.Length - 1];
            double[] deg = new double[str2.Length - 1];

            for (int i = 0; i < str1.Length - 1; i++)
            {
                dist[i] = Convert.ToDouble(str1[i]);
                deg[i] = Convert.ToDouble(str2[i]);
            }

            if (dist.Average() >= 600 || deg.Average() <= 2) return;
            double distance = dist.Last(); txtDist.Text = distance.ToString();
            double degree = deg.Last(); txtDeg.Text = degree.ToString();
            degree = degree * Math.PI / 180;

            double xcen = distance * Math.Cos(degree), ycen = distance * Math.Sin(degree);
            canvas.DrawEllipse(Color.Black, -xcen, ycen, 3, 3);

        }
    }
}