using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Sleep_Monitoring_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            //ComboBox
            foreach (var ports in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(ports);

            }
            comboBox1.Text = "Select Port";
            button1.Enabled = false;
            button2.Enabled = false; //포트 연결 전이니까 비활성화

            //차트 모양 세팅
            ChartSetting();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;//sender 이벤트 보내주는 곳
            mySerial = new SerialPort(cb.SelectedItem.ToString());
            mySerial.Open();
            mySerial.DataReceived += SPort_DataReceived;//데이터 받기

            lblTime.Text = "Connection Time : " + DateTime.Now.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
        }

        //시리얼 포트의 dataReceived 이벤트
        private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = mySerial.ReadLine();
            this.BeginInvoke((new Action(delegate { ShowValue(data); })));

        }

        //시리얼 포트로 받은 값을 보여주는 delegate 메소드
        private void ShowValue(string s)
        {
            int cnt = 0; //정수형이라고 내가 지정함
            int v = Int32.Parse(s);
            if (v == 1)
            {
                cnt += 1;

            }
            else if (v == 0)
            {
                cnt += 0;
            }

            //int v = Int32.Parse(s);
            if (int.TryParse(s, out v) == false)
                return;
            if (v < 0 || v > 140)
                return;

            //t1.Start();
            //t.Start();

        }

        private void ChartSetting()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySerial.Open();

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mySerial.Close();

            button1.Enabled = true;
            button2.Enabled = false;
            //재생버튼 클릭시 포트 연결되고 클릭한 버튼은 비활성화, 정지 버튼은 이와 반대로 설정
        }
    }
}
