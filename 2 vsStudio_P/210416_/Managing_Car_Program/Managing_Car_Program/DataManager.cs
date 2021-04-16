using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Managing_Car_Program
{
    class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();
        static DataManager()
        {
            Load();
        }
        public static void Load()
        {   /* <parkingSpot>1</parkingSpot>
               <carNumber>30고9484</carNumber>
               <driverName>이동준</driverName>
               <phoneNumber>010-2940-1613</phoneNumber>
               <parkingTime>2021-04-16 오전 11:40:58</parkingTime>
             */
            Cars.Clear(); 
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
                XElement carsxElement = XElement.Parse(carsOutput); 
                // XElement <속성명>데이터1</속성명>
                foreach (var item in carsxElement.Descendants("car"))
                {
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value);
                    string tempCarNumber = item.Element("carNumber").Value;
                    string tempDriverName = item.Element("driverName").Value;

                    string tempPhoneNumber = item.Element("phoneNumber").Value;
                    DateTime tempParkingTime = item.Element("parkingTime").Value == ""? 
                        DateTime.Now : DateTime.Parse(item.Element("parkingTime").Value);

                    ParkingCar tempCar = new ParkingCar()
                    {
                        parkingSpot = tempParkingSpot,
                        carNumber = tempCarNumber,
                        driverName = tempDriverName,
                        phoneNumber = tempPhoneNumber,
                        parkingTime = tempParkingTime
                    };
                    Cars.Add(tempCar);
                }
            }
            catch (Exception ex)
            { // 파일 없을 때 대응, 없으면 꺼짐
                System.Windows.Forms.MessageBox.Show(ex.Message);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                // 만약 파일이 없어서 여기로 진입한 경우
                CreateFile(); // 다시 만들고
                Save(); // 저장 후 
                Load(); // 불러들인다.

                // 단, Load 함수자체가 잘못됐다면 코드는 무한루프
            }
            //example();
        }

        private void example() { } // 생성시 메모리 올라감 (사용가능)
        private static void CreateFile() // 은닉 = 안보임
        {
            // Cars.xml파일 생성

            string fileName = @"./Cars.xml";
            StreamWriter writer = File.CreateText(fileName); // 파일 없을 시 해당파일 생성
            writer.Dispose(); // 메모리 해제

        }

        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<cars>\n"; // \n대신 Enviroment.NewLine 써도 됨

            if (Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{item.parkingSpot}</parkingSpot>";
                    booksOutput += $"   <carNumber>{item.carNumber}</carNumber>";
                    booksOutput += $"   <driverName>{item.driverName}</driverName>";
                    booksOutput += $"   <phoneNumber>{item.phoneNumber}</phoneNumber>";
                    booksOutput += $"   <parkingTime>{item.parkingTime}</parkingTime>";
                    booksOutput += "</car>\n";
                }
                
            }
            else // xml파일에 아무것도 없는 경우
            {
                for (int i = 0; i < 5; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{i}</parkingSpot>";
                    booksOutput += "   <carNumber></carNumber>";
                    booksOutput += "   <driverName></driverName>";
                    booksOutput += "   <phoneNumber></phoneNumber>";
                    booksOutput += "   <parkingTime></parkingTime>";
                    booksOutput += "</car>\n";
                }
            }
            booksOutput += "</cars>";
            File.WriteAllText(@"./cars.xml",booksOutput);
        }

        // protected 상속받은 자식 클래스만 함수 쓸수있음(private)


        // 두번째 파라미터 안넣으면 name에 parkingHistory 들어감
        public static void printLog(string contents, string name="parkingHistory")
        {
            DirectoryInfo di = new DirectoryInfo("parkingHistory");
            //if (di.Exists==false)
            if (!di.Exists)
            {
                di.Create(); // 폴더 만들기
            }

            // 앞에 @가 있으면
            // \를 한개만 적는다.

            // @가 없으면 \\ 두번 써야 \하나로 인식
            //using (StreamWriter writer = new StreamWriter(@"parkingHistory\parkingHistory.txt",true))

            //string directory = parkingHistory;
            //using (StreamWriter writer = new StreamWriter(directory+@"\"+name+ ".txt", true))
            using (StreamWriter writer = new StreamWriter(@"parkingHistory\"+name+ ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
