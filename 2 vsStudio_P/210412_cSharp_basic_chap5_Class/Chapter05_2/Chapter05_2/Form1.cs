using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter05_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "안녕하세요";

            int abc = 100;
            if (abc == 100)
            {
                button1.Enabled = false;
            }

            Button b = new Button();
            b.Text = "가나다";
            b.Location = new Point(61, 130);
            Controls.Add(b);

            List<int> iList = new List<int>();
            iList.Add(10);
            iList.Add(50);
            iList.Add(123);

            for (int i = 0; i < iList.Count; i++) {
                Console.WriteLine(iList[i]);
            }
            iList.Add(1000);
            //MessageBox.Show("iList : " + iList.Count+"개");

            List<string> sList = new List<string>();
            sList.Add("김길동");
            sList.Add("박치");
            sList.Add("서이콜");
            sList.Add("양우너");
            //MessageBox.Show(sList.Count+"명");
            sList.Remove("서이콜");

            string names = "";
            //string nList = string.Empty; == "";

            for (int i = 0; i < sList.Count; i++) {
                names += sList[i]+", ";
            }

            //MessageBox.Show(names);

            List<Button> bList = new List<Button>();
            //MessageBox.Show("절대값 :" + Math.Abs(-1000));

            Label l = new Label();
            l.Text = "절대값 :" + Math.Abs(-1000);
            l.Location = new Point(600, 30);
            Controls.Add(l);



            Product p = new Product(); // new Product(); 선언변수로 만든 거 = 인스턴스
            p.name = "감자";
            p.price = 1000;
            Product.count++;
            /*MessageBox.Show("제품명 : "+p.name);
            MessageBox.Show("제품가격 : "+p.price);
            MessageBox.Show("제품개수 : "+Product.count);*/

            Product p2 = new Product();
            p2.name = "고구마";
            p2.price = 5000;
            Product.count++;

            // 선언과 동시에 값을 지정
            Product p3 = new Product() { name = "파", price=50 };

            // 2~3번째 : 값 지정 
            Dog dj = new Dog("니니",17); // 생성시점에 기본값으로 초기화
            MessageBox.Show(dj.name+", "+dj.age);

            Dog abc2 = new Dog("꼬꼬", 0);
            MessageBox.Show("개의 수 : "+Dog.theNumberOfDog);

        }
    }
}
