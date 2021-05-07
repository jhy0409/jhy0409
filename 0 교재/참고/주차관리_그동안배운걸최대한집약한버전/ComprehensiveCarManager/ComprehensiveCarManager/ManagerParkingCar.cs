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

namespace ComprehensiveCarManager
{

    public partial class ManagerParkingCar : Form
    {
        const string NOWTIME_FULL_FORMAT = "yyyy/MM/dd HH:mm:ss";
        const string NOWTIME_YEAR_MONTH_DAY_FORMAT = "yyyy_MM_dd";
        const int USE_DEFAULT = -1;
        DataManaging.DataManager dm;
        public ManagerParkingCar()
        {
            InitializeComponent();
            showNowTime();
            dm = selectDataSource(); //DataManager 인스턴스 생성. 다형성에 의해서 상속된 클래스 중 하나를 가지고 인스턴스 생성함
            PrintLog("Test : " + dm.GetType());
            dm.Load(); //static 생성자를 이용하거나 혹은 그냥 생성자의 오버라이딩을 통해서도 Load를 간접호출이 가능은 하다. 
                       //하지만 그럴 경우 부모의 생성자를 반드시 한 번 더 호출하는 문제때문에 DB연결에서 에러가 생기는 것 같다. 그래서 그냥 직접 호출한다.

            if (dm.Cars.Count > 0) //cars에 아무 것도 없다면 cars를 datasource에 넣지 않는다.
            {

                dataGridView_ManageParkingCar.DataSource = dm.Cars;
                try
                {
                    textBox_parkingSpot.Text = dm.Cars[0].parkingSpot.ToString();
                    textBox_carNumber.Text = dm.Cars[0].carNumber;
                    textBox_driverName.Text = dm.Cars[0].driverName;
                    textBox_phoneNumber.Text = dm.Cars[0].phoneNumber;
                    textBox_selectedParkingSpot.Text = dm.Cars[0].parkingSpot.ToString();
                }
                catch (Exception ex)
                {
                    PrintLog(ex.Message);
                    PrintLog(ex.StackTrace);
                }
            }




        }
        //함수의 대원칙은 한 화면에 딱~ 보이는 것!!
        private DataManaging.DataManager selectDataSource()
        {
            int dataSource = readCsvFile();
            dm = new DataManaging.DataManager().getInstance(dataSource);
            return dm;
        }

        private int readCsvFile()
        {
            try
            {
                StreamReader sr = new StreamReader("data.csv", Encoding.GetEncoding("euc-kr"));
                int.TryParse(sr.ReadLine(), out int number);
                string s = sr.ReadLine();
                string[] temp = s.Split(',');        // Split() 메서드를 이용하여 ',' 구분하여 잘라냄
                return number;
            }
            catch (Exception e)
            {
                showError(e, "readCsvFile");
            }
            return USE_DEFAULT;
        }

        private void showError(string contents)
        {
            MessageBox.Show(contents);
            PrintLog(contents, DateTime.Now.ToString(NOWTIME_YEAR_MONTH_DAY_FORMAT));
        }
        private void showError(Exception e, string errorContents)
        {
            PrintLog(errorContents + e.Message);
            PrintLog(errorContents + e.StackTrace);
            MessageBox.Show(errorContents + e.Message);
            MessageBox.Show(errorContents + e.StackTrace);
        }


        private void showNowTime()
        {
            statusStringLabel_Timer.Text = "지금은 : "
                + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") +
                "입니다.";
        }
        private void timer_countTime_Tick(object sender, EventArgs e)
        {
            showNowTime();
        }

        private void button_park_Click(object sender, EventArgs e)
        {
            PrintLog("주차 버튼 클릭", DateTime.Now.ToString(NOWTIME_YEAR_MONTH_DAY_FORMAT));

            //공간번호 
            if (textBox_parkingSpot.Text.Trim() == "") //Trim 공백 제거 함수
            {
                showError("주차공간을 입력하여 주세요.");
            }
            else if (textBox_carNumber.Text.Trim() == "") //차량 번호를 입력하지 않은 경우
            {
                showError("차번호를 입력해라");
            }
            else
            {
                try
                {
                    //참조변수와 람다개념을 알고 있는 경우!
                    ParkingCar car = dm.Cars.Single
                        ((x) => x.parkingSpot.ToString() == textBox_parkingSpot.Text);
                    if (car.carNumber.Trim() != "") //이미 차 정보가 저장되어있음
                    {
                        showError("해당 공간에는 이미 차 있어요." + textBox_parkingSpot.Text);
                    }
                    else //아직 차 정보가 없음
                    {
                        car.parkingSpot = int.Parse(textBox_parkingSpot.Text);
                        car.carNumber = textBox_carNumber.Text;
                        car.driverName = textBox_driverName.Text;
                        car.phoneNumber = textBox_phoneNumber.Text;
                        car.parkingTime = DateTime.Now;
                        dataGridView_ManageParkingCar.DataSource = null;
                        dataGridView_ManageParkingCar.DataSource = dm.Cars;

                        dm.Save(car);

                        string contents = $"주차 공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text}차를 주차함";
                        MessageBox.Show(contents);
                        PrintLog(contents, DateTime.Now.ToString(NOWTIME_YEAR_MONTH_DAY_FORMAT));

                        dataGridView_ManageParkingCar.ClearSelection(); //셀 선택 자체를 다 없앰
                                                                        //dataGridView_ManageParkingCar.Rows[int.Parse(textBox_parkingSpot.Text)-1].Selected = true; //행 전체 선택
                        int lastRow = dataGridView_ManageParkingCar.CurrentRow.Index;
                        dataGridView_ManageParkingCar.Rows[lastRow].Cells[0].Selected = true; //Row[n][0] 번째 즉 한 행의 가장 왼쪽에 있는 셀 1개 선택



                    }
                }
                catch (Exception ex)
                {
                    string contents = "주차 할 수 없습니다." + textBox_parkingSpot.Text;
                    showError(ex, contents);
                }
            }
        }


        private void button_exitCar_Click(object sender, EventArgs e)
        {
            PrintLog("출차 버튼 클릭", DateTime.Now.ToString(NOWTIME_YEAR_MONTH_DAY_FORMAT));

            if (textBox_parkingSpot.Text.Trim() == "")
            {
                showError("주차 공간 번호를 입력해주세요!");
                return;
            }
            int exitParkingSpot = 0;
            if(!int.TryParse(textBox_parkingSpot.Text, out exitParkingSpot) || exitParkingSpot<=0)
            {
                showError("주차 공간 " + textBox_parkingSpot.Text + " 은/는 유효하지 않습니다.");
                return;
            }
            //Single 없이 조회하고 해당하는 데이터 변경 
            try
            {
                for (int i = 0; i < dm.Cars.Count; i++)
                {
                    if (dm.Cars[i].parkingSpot.ToString() == textBox_parkingSpot.Text)
                    {
                        if (dm.Cars[i].carNumber.Trim() == "")
                        {
                            showError("아직 차 없음");
                            break;
                        }
                        else
                        {
                            dm.Cars[i].carNumber = "";
                            dm.Cars[i].driverName = "";
                            dm.Cars[i].phoneNumber = "";
                            dm.Cars[i].parkingTime = DateTime.Now;//알아서 처리
                            
                            dataGridView_ManageParkingCar.DataSource = null;
                            dataGridView_ManageParkingCar.DataSource = dm.Cars;

                            dm.Save(dm.Cars[i]);

                            string contents = $"주차공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text}차량 출차";
                            PrintLog(contents, DateTime.Now.ToString(NOWTIME_YEAR_MONTH_DAY_FORMAT));
                            MessageBox.Show(contents);
                            dataGridView_ManageParkingCar.ClearSelection(); //셀 선택 자체를 다 없앰
                                                                            //dataGridView_ManageParkingCar.Rows[int.Parse(textBox_parkingSpot.Text)-1].Selected = true; //행 전체 선택
                            int lastRow = dataGridView_ManageParkingCar.CurrentRow.Index;
                            dataGridView_ManageParkingCar.Rows[lastRow].Cells[0].Selected = true; //Row[n][0] 번째 즉 한 행의 가장 왼쪽에 있는 셀 1개 선택

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                showError(ex, "출차안됨");
            }

        }

        #region LogWriter
        //일상적인 것과 에러를 한 파일에 찍는 게 더 효율적일 수도 있다.
        //일단은 오버로딩을 활용해보기 위해서 일상적인 로그만 찍는 함수와 에러가 발생할 떄만
        //쓰는 함수를 구분함

        //에러메시지 찍고 화면엔 표시 안 함
        public void PrintLog(string contents)
        {
            string logContens = $"[{DateTime.Now.ToString(NOWTIME_FULL_FORMAT)}]" + $"{contents}";
            new DataManaging.DataSource().PrintLog(logContens); //DataSource객체를 여기서만 따로 생성해주는 이유는 DataManager 객체 생성 실패할 것을 대비함.
        }

        //일상적인 로그들 찍고 화면에 표시함 찍음.
        public void PrintLog(string contents, string fileName)
        {
            string logContens = $"[{DateTime.Now.ToString(NOWTIME_FULL_FORMAT)}]" + $"{contents}";
            listBox_History.Items.Insert(0, logContens);
            new DataManaging.DataSource().PrintLog(logContens, fileName); //여기서도 DataManager 객체 생성 실패를 대비하여 여기서 별도 생성함.
        }
        #endregion

        private void button_showCar_Click(object sender, EventArgs e)
        {
            try
            {
                PrintLog("조회버튼 클릭", DateTime.Now.ToString("yyyy_MM_dd"));
                int parkingSpot = int.Parse(textBox_selectedParkingSpot.Text);
                string parkedCar = lookUpParkingFunction(parkingSpot);
                string contents = string.Empty;
                if (parkedCar.Trim() != "")
                {
                    contents = $"주차공간 {textBox_selectedParkingSpot.Text}에 주차된 차는 {parkedCar}입니다.";
                }
                else
                {
                    contents = $"주차공간 {textBox_selectedParkingSpot.Text}에 주차된 차가 없습니다.";
                }
                PrintLog(contents, DateTime.Now.ToString("yyyy_MM_dd"));
                MessageBox.Show(contents);
            }
            catch (Exception ex)
            {
                showError(ex, "주차 공간 번호가 이상합니다." + textBox_selectedParkingSpot.Text);
            }

        }

        private string lookUpParkingFunction(int parkingSpot)
        {
            try
            {
                // 공간 번호를 받는다, Single로 조회를 한다.(ver1)
                //ParkingCar car = dm.Cars.Single((x) => x.ParkingSpot == parkingSpot);
                //string ParkedCarNumber = car.CarNumber;
                //return ParkedCarNumber;

                //ver2
                // foreach문으로 조회한다.(single이 어려울 경우)
                string ParkedCarNumber = "";
                foreach (var item in dm.Cars)
                {
                    if (item.parkingSpot == parkingSpot)
                        ParkedCarNumber = item.carNumber;
                }
                return ParkedCarNumber;

            }
            catch (Exception e)
            {
                showError(e, "검색이 안 됩니다. lookUpParkingFunction");
            }
            return string.Empty;
        }

        private void dataGridView_ManageParkingCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dm.Cars.Count <= 0) //CARS에 아무것도 없다면 셀을 클릭해도 의미가 없으므로 리턴시킴. 그리고 이거 없으면 오류 남
                return;

            try
            {
                ParkingCar temp = dataGridView_ManageParkingCar.CurrentRow.DataBoundItem as ParkingCar;
                textBox_parkingSpot.Text = temp.parkingSpot.ToString();
                textBox_carNumber.Text = temp.carNumber;
                textBox_driverName.Text = temp.driverName;
                textBox_phoneNumber.Text = temp.phoneNumber;
                //클릭해서 조회하고 싶은 경우
                textBox_selectedParkingSpot.Text = temp.parkingSpot.ToString();
            }
            catch (Exception ex)
            {
                showError(ex, "dataGridView_ManageParkingCar_CellClick");
            }
        }

        private void button_AllLookUp_Click(object sender, EventArgs e)
        {
            dataGridView_ManageParkingCar.DataSource = null;
            dm.Load();
            dataGridView_ManageParkingCar.DataSource = dm.Cars;

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (dm.insertParkingSpot(dm.Cars.Count + 1))
            {
                dataGridView_ManageParkingCar.DataSource = null;
                dataGridView_ManageParkingCar.DataSource = dm.Cars;
            }
            textBox_parkingSpot.Text = dm.Cars.Count.ToString();
            textBox_selectedParkingSpot.Text = dm.Cars.Count.ToString();
            dataGridView_ManageParkingCar.ClearSelection(); //셀 선택 자체를 다 없앰
            //dataGridView_ManageParkingCar.Rows[int.Parse(textBox_parkingSpot.Text)-1].Selected = true; //행 전체 선택
            int lastRow = dataGridView_ManageParkingCar.Rows.Count - 1;
            dataGridView_ManageParkingCar.Rows[lastRow].Cells[0].Selected = true; //Row[n][0] 번째 즉 한 행의 가장 왼쪽에 있는 셀 1개 선택
            //dataGridView_ManageParkingCar.Rows[lastRow].Selected = true; //행 전체 선택
            
            //데이터 그리드뷰 왼쪽에 보면 작은 화살표가 있는데 그 화살표까지 이동시키고 싶다면 CurrentCell을 변경시켜야 함
            dataGridView_ManageParkingCar.CurrentCell = dataGridView_ManageParkingCar.Rows[lastRow].Cells[0]; //셀을 클릭하는 것과 동일한 효과.



        }

    }
}