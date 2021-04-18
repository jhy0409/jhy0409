using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateLamda
{
    public partial class Form1 : Form
    {
        delegate void TestDelegate();

        /* delegate 대리자
         * 함수의 변수화 (반환, 매개변수 x), 콜백함수(함수를 매개변수로 받음) 활용
         * 
         * 람다
         */
        public Form1()
        {
            InitializeComponent();

            Button button2 = new Button();
            button2.Text = "코드로 만든 버튼";
            button2.AutoSize = true;
            button2.Location = new Point(100, 100); // new Point = c#의 구조체

            button2.Size = new System.Drawing.Size(324, 30);
            button2.Location = new System.Drawing.Point(186, 150);

            button2.Click += Button2_Click; // +=에서 tabtab
            button2.Click += Button2_Click1;
            button2.TabStop = false;


            // 함수 별도로 만들기 싫을 때 delegate
            button2.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Test delegate");
            };

            // 람다
            button2.Click += (object sender, EventArgs e) => { MessageBox.Show("labmda");};

            Controls.Add(button2);
        }

        private void Button2_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("두번째 버튼을 클릭했음. (2)");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("두번째 버튼을 클릭했음");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDelegate a = Hello;

            // 무명함수
            TestDelegate b = delegate () 
                { MessageBox.Show("안녕 이름 1"); };

            // 람다 [delegate ()] == [() =>]
            TestDelegate c = () => { MessageBox.Show("안녕 이름 2"); };

            a();
            b();
            c();
            exCallBack(a);
        }

        private void Hello()
        {
            MessageBox.Show("안녕 이름 (Hello Method)");
        }

        private void exCallBack(TestDelegate t)
        {
            for (int i = 0; i < 3; i++)
            {
                t();
            }
        }
    }
}
