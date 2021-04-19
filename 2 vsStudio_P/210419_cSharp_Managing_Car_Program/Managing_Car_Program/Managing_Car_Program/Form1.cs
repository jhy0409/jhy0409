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
        string msg = "주차공간 입력필요";
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
            writeLog("주차버튼 클릭");
            // 공간번호
            if (textBox1.Text.Trim() == "") //Trim 공백 제거 함수
            {
                msg = "주차공간 입력필요";
                MessageBox.Show(msg);
                writeLog(msg);
            }
            else if (textBox2.Text.Trim() == "")//차량번호 입력하지 않은 경우
            {
                msg = "차번호 입력필요";
                MessageBox.Show(msg);
                writeLog(msg);
            }
            else
            {
                try
                {
                    // 본격적으로 입력하는 작업

                    //참조변수 람다개념 ------------------------------------------------------------------------
                    ParkingCar car = DataManager.Cars.Single
                        ((x) => x.parkingSpot.ToString() == textBox1.Text); // Single : 일치하는거 하나 가져옴

                    if (car.carNumber.Trim() != "") // 이미 차 정보가 저장돼있음
                    {
                        msg = "해당 공간에는 이미 주차되어있습니다.";
                        MessageBox.Show(msg + " " + car.parkingSpot + "번 주차공간");
                        writeLog(msg + " " + car.parkingSpot + "번 주차공간");
                    }
                    else // 아직 차 정보가 없음
                    {
                        car.parkingSpot = int.Parse(textBox1.Text);
                        car.carNumber = textBox2.Text;
                        car.driverName = textBox3.Text;
                        car.phoneNumber = textBox4.Text;
                        car.parkingTime = DateTime.Now;

                        dataGridView2.DataSource = null; // <----------- 비운 다음
                        dataGridView2.DataSource = DataManager.Cars; // 다시 초기화
                        DataManager.Save();

                        string contens = $"주차공간 {textBox1.Text}에 {textBox2.Text}차를 주차함";
                        MessageBox.Show(contens);
                        writeLog(contens, DateTime.Now.ToString("yyyy_MM_dd"));
                    }
                }
                catch (Exception ex)
                {
                    string contents = $"주차할 수 없습니다. " + textBox1.Text;
                    MessageBox.Show(contents);
                    writeLog(contents);
                    writeLog(ex.Message);
                    writeLog(ex.StackTrace);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // 출차
        {
            writeLog("출차버튼 클릭");
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("주차공간 번호를 입력해주세요");
                return;
            }

            // Single없이 조회하고 해당하는 데이터 변경
            try
            {
                for (int i = 0; i < DataManager.Cars.Count; i++)
                {
                    if (DataManager.Cars[i].parkingSpot.ToString() == textBox1.Text)
                    {
                        if (DataManager.Cars[i].carNumber.Trim() == "")
                        {
                            msg = "주차된 차가 없습니다.";
                            MessageBox.Show(msg);
                            writeLog(msg);
                            break;
                        }
                        else
                        {
                            DataManager.Cars[i].carNumber = "";
                            DataManager.Cars[i].driverName = "";
                            DataManager.Cars[i].phoneNumber = "";
                            DataManager.Cars[i].parkingTime = DateTime.Now; //알아서 처리
                            string contents = $"주차공간 {textBox1.Text}에 {textBox2.Text}차량이 출차";
                            MessageBox.Show(contents);
                            writeLog(contents);
                            dataGridView2.DataSource = null; // 데이터 한번 지워주고
                            dataGridView2.DataSource = DataManager.Cars; // 다시 리셋
                            DataManager.Save();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeLog("출차 안 됨");
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e) // 조회
        {
            try
            {
                //writeLog("3번 버튼 클릭");
                //writeLog("3번 버튼 클릭",DateTime.Now.ToString("yyyy_MM_dd"));
                writeLog("조회버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
                int parkingSpot = int.Parse(textBox5.Text);
                string parkedCar = lookUpParkingFunction(parkingSpot);
                string contents = string.Empty;
                if (parkedCar.Trim() != "")
                {
                    contents = $"주차공간 {textBox5.Text}에 주차된 차는 {parkedCar}입니다.";
                }
                else
                {
                    contents = $"주차공간 {textBox5.Text}에 주차된 차가 없습니다.";
                }
                writeLog(contents);
                MessageBox.Show(contents);
            }
            catch (Exception ex)
            {
                MessageBox.Show("주차 공간 번호가 이상합니다." + textBox5.Text);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }

        private string lookUpParkingFunction(int parkingSpot) //조회하는 함수(연계 필요 데이터 식별)
        {
            try
            {
                // 공간 번호를 받는다, Single로 조회를 한다.(ver1)
                //ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot == parkingSpot);
                //string ParkedCarNumber = car.CarNumber;
                //return ParkedCarNumber;

                //ver2
                // foreach문으로 조회한다.(single이 어려울 경우)
                string ParkedCarNumber = "";
                foreach (var item in DataManager.Cars)
                {
                    if (item.parkingSpot == parkingSpot)
                        ParkedCarNumber = item.carNumber;
                }
                return ParkedCarNumber;
            }
            catch (Exception e)
            {
                throw;
            }
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar temp = dataGridView2.CurrentRow.DataBoundItem as ParkingCar;
                textBox1.Text = temp.parkingSpot.ToString();
                textBox2.Text = temp.carNumber;
                textBox3.Text = temp.driverName;
                textBox4.Text = temp.phoneNumber;
                //클릭해서 조회하고 싶은 경우
                textBox5.Text = temp.parkingSpot.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                writeLog(ex.Message);
                writeLog(ex.StackTrace);
            }
        }
    }
}
