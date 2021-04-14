using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGameTimer
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();
            number = new Random().Next(10) + 1;
            Console.WriteLine(number);
        }

        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time + "";
            if (time > 10)
            {
                label1.Text = "timeover";
                time = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int choiceNumber = int.Parse(textBox1.Text);
                //int choiceNumber = int.TryParse(textBox1.Text); // 유사한 동작

                if (choiceNumber == number)
                {
                    time = 0; // 타이머 리셋
                    MessageBox.Show("정답");
                    number = new Random().Next(10) + 1;
                    Console.WriteLine(number); // 정답값 다시 출력
                    label1.Text = "Finish";
                }
                else
                {
                    if (choiceNumber > number)
                    {
                        MessageBox.Show("선택한 숫자가 큽니다.");
                    }
                    else
                    {
                        MessageBox.Show("선택한 숫자가 작습니다.");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("숫자를 입력하세요");
                Console.WriteLine(ee.Message);
                Console.WriteLine(ee.StackTrace); // 주차관리 printError(), log Txt file
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int choiceNumber = int.Parse(textBox1.Text);
            int choiceNumber;
            bool result = int.TryParse(textBox1.Text, out choiceNumber); // 유사한 동작

            if (result == false)
            {
                MessageBox.Show("숫자를 입력하세요");
                return;
            }
            if (choiceNumber == number)
            {

                time = 0; // 타이머 리셋
                MessageBox.Show("정답");
                number = new Random().Next(10) + 1;
                Console.WriteLine(number); // 정답값 다시 출력
                label1.Text = "Finish";
            }
            else
            {
                if (choiceNumber > number)
                {
                    MessageBox.Show("선택한 숫자가 큽니다.");
                }
                else
                {
                    MessageBox.Show("선택한 숫자가 작습니다.");
                }
            }
        }
    }
}

