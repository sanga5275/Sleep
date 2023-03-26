using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sleep_Monitoring_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("심박수 센서는 손가락 위에\n" +
                "가속도 센서는 침대 위 가지런히\n" +
                "준비가 끝났다면 시작버튼을 눌러주세요.\n", "사용설명서");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newForm = new Form2();   
            newForm.Show();
            //this.Close();
        }
    }
}
