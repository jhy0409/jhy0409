using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program
{
    public partial class Form1 : Form
    {
        // xml 마크업(태그)형식으로 데이터 저장 <속성명>속성값</속성명>

        // DataManager -> 인터페이스 or abstract
        // xml, json, db(oracle/mssql)
        public Form1()
        {
            InitializeComponent();
            //DataManager.Load();
            //List<ParkingCar> cars = new List<ParkingCar>();
            //cars.Add(new ParkingCar()
            //{   parkingSpot = 1,
            //    carNumber = "30고9999",
            //    driverName = "가나다",
            //    phoneNumber = "010-1234-5678",
            //    parkingTime = DateTime.Now
            //});

            //cars.Add(new ParkingCar());

            dataGridView2.DataSource = DataManager.Cars;
            textBox1.Text = DataManager.Cars[0].parkingSpot.ToString();
            textBox2.Text = DataManager.Cars[0].carNumber.ToString();
            textBox3.Text = DataManager.Cars[0].driverName.ToString();
            textBox4.Text = DataManager.Cars[0].phoneNumber.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = $"지금은 : {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}입니다.";
        }

        private void button1_Click(object sender, EventArgs e) // 주차
        {
            writeLog("1번버튼 클릭");
        }

        private void button2_Click(object sender, EventArgs e) // 출차
        {
            writeLog("2번버튼 클릭");
        }

        private void button3_Click(object sender, EventArgs e) // 조회
        {

            //writeLog("3번버튼 클릭");
            writeLog("3번버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
        }

        private void writeLog(string contents)
        {
            // int a = 1; // MessageBox.Show(a.ToString("00"));  // 01이라고 출력됨. 3자리이상 입력시 그대로 출력
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] " +
                $"{contents}";

            // 옛날것이 가장 위에 올라가는 방식 새로운 내용이 뒤에 추가 되어, 새내용 보려면 밑으로 내려가야함
            // listBox1.Items.Add(logContents);
            // 새로운 것이 가장 위에 올라가는 방식 새 내용이 가장 앞에 있음
            listBox1.Items.Insert(0, logContents); // 지정위치에 삽입
            //List<int> list = new List<int>();
            //list.Insert(0, 1);
            DataManager.printLog(logContents);
        }

        // writeLog 함수 오버로딩
        private void writeLog(string contents, string date)
        {
            // int a = 1; // MessageBox.Show(a.ToString("00"));  // 01이라고 출력됨. 3자리이상 입력시 그대로 출력
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}] " +
                $"{contents}";

            listBox1.Items.Insert(0, logContents); // 지정위치에 삽입
            DataManager.printLog(logContents, date);
        }
    }
}
