using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descript_func
{
    public partial class Form1 : Form
    {
        MyMath myMath = new MyMath();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text);
            label1.Text = second_demension_sik(value) + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            introduceMyName(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = random_one_to_ten();
            MessageBox.Show("랜덤 숫자는 " + number + "이다.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hello();
        }

        // 매개변수가 있고 반환형이 있는 함수
        private int second_demension_sik(int x)
        {
            return (x * x) + (2 * x) + 1;
        }

        // 매개변수만 있는 함수
        private void introduceMyName(string name)
        {
            MessageBox.Show("이름은 " + name + " 입니다.");
        }

        // 반환형만 있는 함수
        private int random_one_to_ten()
        {
            return new Random().Next(10) + 1;
        }

        // 반환형과 매개변수가 없는 함수
        private void Hello()
        {
            MessageBox.Show("안녕");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // int.Parse 대신에 쓸 수 있는 것 1
            // 버튼 ctrl - drag XXX
            try
            {
                int num = int.Parse(textBox1.Text);
                MessageBox.Show("내가 입력한 숫자는 " + num);
            }
            catch (Exception ex)
            {
                MessageBox.Show("숫자로 적으세요");
                /*MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);*/
                printLog(ex.Message);
                printLog(ex.StackTrace);
                //throw; -> 프로그램 꺼짐
            }

            // int.Parse 대신에 쓸 수 있는 것 2
        }

        private void printLog(string contens)
        {
            DirectoryInfo di = new DirectoryInfo("Trace");
            if (di.Exists == false)
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter("Trace" + "\\" + "Log.txt"))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}]{contens}{".txt"}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // int.Parse 대신 쓸 수 있는 것2
            //int number;
            //bool result = int.TryParse(textBox1.Text, out number);

            bool result = int.TryParse(textBox1.Text, out int number); // ~2015 안됨
            // number(0,1)값 할당, true, false값 반환
            if (result == false)
            {
                MessageBox.Show("숫자사용");
            }
            else
            {
                MessageBox.Show("내가 입력한 숫자는 " + textBox1.Text);
            }
        }

        // 오버로딩, 매개변수 개수나 타입 ≠
        // 반환형만 있는 함수
        private int random_one_to_ten(int except)
        {
            int num = new Random().Next(3) + 1;
            while (num == except)
            {
                num = new Random().Next(10) + 1;
            }
            return num;
        }


        private int random_one_to_ten_except5()
        {
            int num = new Random().Next(10) + 1;
            while (num == 5)
            {
                num = new Random().Next(10) + 1;
            }
            return num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int except = 5;
            int num = random_one_to_ten(except);
            MessageBox.Show("5를 제외한 1~10사이의 수 " + num);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int except);
            label2.Text = "제외되는 숫자는 " + except;
            label3.Text = label2.Text + "를 제외한 숫자는 " + random_one_to_ten(except);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Circle c1 = new Circle();
            c1.r = 100;

            Circle c2 = new Circle();
            c2.r = 111; // 인스턴스 (멤버, 변수, 속성), 사용자 정의자료(Class)
            /*MessageBox.Show("원의 PI값은 " + Circle.PI + "입니다.");

            MessageBox.Show("c1의 둘레는 " + c1.doolle() + "입니다.");
            MessageBox.Show("c2의 둘레는 " + c2.doolle() + "입니다.");
            MessageBox.Show("c1의 넓이는 " + c1.area() + "입니다.");
            MessageBox.Show("c2의 넓이는 " + c2.area() + "입니다.");

            Circle.setPi(3.14);
            MessageBox.Show("원의 PI값은 " + Circle.getPi() + "입니다.");
            //MessageBox.Show("원의 PI값은 " + Circle.PI + "입니다.");

            MessageBox.Show("c1의 둘레는 " + c1.doolle() + "입니다.");
            MessageBox.Show("c2의 둘레는 " + c2.doolle() + "입니다.");
            MessageBox.Show("c1의 넓이는 " + c1.area() + "입니다.");
            MessageBox.Show("c2의 넓이는 " + c2.area() + "입니다.");*/

            Circle.showPi();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            // 1번
            int input = int.Parse(textBox1.Text);
            int end = int.Parse(textBox2.Text);
            MessageBox.Show($"{textBox1.Text}의 제곱 : {myMath.power(input)}");
            // 2번 모르겠 (재귀함수로?)

            // 3번
            string result = myMath.sumAll(input) + "";
            MessageBox.Show($"0부터 {textBox1.Text}까지의 합 : {result}");

            // 4번
            if (input > end)
            {
                MessageBox.Show("[안내]\n시작 값이 더 작습니다");
                return;
            }
            result = myMath.sumAll(input, end) + "";
            MessageBox.Show($"{textBox1.Text}부터 {textBox2.Text}까지의 합 : {result}");

        }

        /*private void button7_Click(object sender, EventArgs e)
        {
            //int except = 5;
            bool result = int.TryParse(textBox1.Text, out int numb);
            if (result == false)
            {
                MessageBox.Show("숫자 입력");
            }
            else
            {
                int num = random_one_to_ten(int.Parse(textBox1.Text));
                MessageBox.Show($"{int.Parse(textBox1.Text)}를 제외한 1~10사이의 수 " + num);
            }
        }*/
    }
}
