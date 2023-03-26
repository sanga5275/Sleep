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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 newForm = new Form3();
            new Form().Show();
            //this.Close();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int sum = 0;
            CheckBox[] cBox = {cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8, cb9, cb10 };
            for(int i =0; i < 10; i++)
            {
                if(cBox[i].Checked)
                  sum += 1;
            }
          
            if (sum >= 4)
                MessageBox.Show("4가지 이상 항목에 해당된 당신은 불면증 가능성이 높음!\n" +
                    "1~4 항목은 초기 불면증\n" + "5~8 항목은 수면유지의 장애\n" +
                    "9~10 항목은 우울증이 있을 때 흔히 나타나는 항목으로\n" +
                    "해당되는 사항이 있다고 생각될 시" +
                    " 전문가와의 상담을 추천함\n",
                    "불면증 조심!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (sum < 4)
                MessageBox.Show("4가지 미만 항목에 해당된 당신은 불면증 가능성이 낮음\n");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTimer.Text = "";
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Font = new Font("맑은 고딕", 9, FontStyle.Italic);
            lblTimer.ForeColor = Color.DarkBlue;
            lblTimer.Text = DateTime.Now.ToString();
        }
    }
}
