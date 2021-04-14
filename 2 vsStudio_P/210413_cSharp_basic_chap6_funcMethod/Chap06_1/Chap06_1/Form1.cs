using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap06_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("함수결과 : " + f(int.Parse(textBox1.Text)));
            // 클래스, 조건문, 반복문, 함수
        }
        private int f(int x) // 함수
        {
            // int x 매개변수

            // 반환값
            return x * x + 2 * x + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 함수를 쓰지않고 해보기
            label1.Text = int.Parse(textBox2.Text) * int.Parse(textBox2.Text) + "";
            // label1.Text = (int.Parse(textBox2.Text)* int.Parse(textBox2.Text)).ToString();

            // 함수를 사용해서 해보기
            MessageBox.Show(power(textBox2.Text));
            string result = power(textBox2.Text);
            example(100, 5, 60);
            bs();
        }

        private string power(string inputNumber)
        {
            return "" + int.Parse(inputNumber) * int.Parse(inputNumber);
        }

        private void example(int a, int b, int c)
        {
            int d = a + b + c; //165
            d = d - a + c * b; // 165-100+300
            MessageBox.Show("d값은 "+d+" 입니다");
        }

        private void bs()
        {
            MessageBox.Show("ABCBSSS");
        }
    }
}
