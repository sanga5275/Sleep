using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3조_역설계
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("심박수 센서는 손가락에\n" +
                "가속도 센서는 침대 위 가지런히\n" +
                "준비가 끝났다면 시작버튼을 눌러주세요.", "설명서");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newForm = new Form2();
            newForm.Show();
            this.Close();

        }
    }
}
