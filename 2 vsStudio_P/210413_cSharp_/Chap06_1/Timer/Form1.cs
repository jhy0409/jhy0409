using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int cptNum;
        public Form1()
        {
            InitializeComponent();

            cptNum = new Random().Next(3) + 1;
        }

        int time = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = "프로그램 시작한 지 " + time + "초 입니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (time >= 16)
            {
                MessageBox.Show("제한시간 초과했습니다.");
                cptNum = new Random().Next(3) + 1;
                time = 0;
                textBox1.Text = "";
                return;
            }
            if (int.Parse(textBox1.Text) == cptNum )
            {
                MessageBox.Show("정답입니다.");
                cptNum = new Random().Next(3) + 1;
                textBox1.Text = "";
            }
            else if (int.Parse(textBox1.Text) > cptNum)
            {
                MessageBox.Show("입력 숫자가 더 큽니다.");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("입력 숫자가 더 작습니다.");
                textBox1.Text = "";
            }
        }
    }
}
