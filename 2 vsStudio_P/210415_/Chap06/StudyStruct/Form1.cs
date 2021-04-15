using Chap06;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyStruct
{
    public partial class Form1 : Form
    {
        Account a1;
        Account a2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 배열, 리스트 = 참조변수(포인터)
        {
            Account a1 = new Account(100, textBox1.Text);
            MessageBox.Show($"a1이름 : {a1.name}\na1돈 : {a1.myMoney}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a2 = a1;
            a2.name = textBox2.Text;
            a2.myMoney = 1234;
            MessageBox.Show($"a1이름 : {a1.name}\na1돈 : {a1.myMoney}");
            MessageBox.Show($"a2이름 : {a2.name}\na2돈 : {a2.myMoney}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int a);
            int.TryParse(textBox4.Text, out int b);
            swapFunction(a, b);
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("변경이 안됨");

            swapFunction(ref a, ref b);
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("변경 완료");

            /*int tempA = a;
            int tempB = b;
            swapFunction(tempB, tempA, out a, out b);
            textBox5.Text = a.ToString();
            textBox6.Text = b.ToString();
            MessageBox.Show("다시 변경 완료");*/
        }
        private void swapFunction(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void swapFunction(ref int a, ref int b) // 받아오는 변수의 값아닌 주소지 참조
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // out 키워드 (return과 유사)
        // 이 함수는 반환형은 없지만 
        // 2개의 변수값을 바꾼다. (out)
        private void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            // 다음위치 = 현재위치 + 현재속도
            rx = x + vx;
            ry = y + vy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox7.Text, out int x); // 위치
            int.TryParse(textBox8.Text, out int y);

            int.TryParse(textBox9.Text, out int vx);
            int.TryParse(textBox10.Text, out int vy);

            MessageBox.Show($"x = {x}, y = {y}"); // 속도
            NextPosition(x, y, vx, vy, out x, out y); // 값 재할당, 리턴 여러개
            MessageBox.Show($"x = {x}, y = {y}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // outExample(out int abc, out int def, out int hij);
            // MessageBox.Show(abc + def + hij + "");

            int abc;
            int def;
            int hij;
            outExample(out abc, out def, out hij);
            MessageBox.Show(abc + def + hij + "");

            foreach (var item in Controls)
            {
                //if(item is TextBox)
                //{
                //    (item as TextBox).Text = "인사돌";
                //}

                //if ((item is TextBox) != null)
                //    (item as TextBox).Text = "";

                var temp = item as TextBox; // 형변환, 체크되는지 확인
                if (temp != null)
                    temp.Text = "텍스트텍스트텍스트";
            }
        }

        private void outExample(out int a, out int b, out int c)
        {
            a = 100;
            b = 200;
            c = 300;
        }
    }
}
