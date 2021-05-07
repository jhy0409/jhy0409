using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ComprehensiveCarManager.DataManaging
{
    class DataManager_xml : DataManager
    {
        public override void Load()
        {
            Cars.Clear();
            try
            {
                string carsOutput = File.ReadAllText(@"./Cars.xml");
                XElement carsXElement = XElement.Parse(carsOutput);
                foreach (var item in carsXElement.Descendants("car"))
                {
                    int tempParkingSpot = int.Parse(item.Element("parkingSpot").Value);
                    string tempCarNumber = item.Element("carNumber").Value;
                    string tempDriverName = item.Element("driverName").Value;
                    string tempPhoneNumber = item.Element("phoneNumber").Value;
                    DateTime tempParkingTime = item.Element("parkingTime").Value == "" ?
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
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                dataSource.PrintLog(ex.Message);
                dataSource.PrintLog(ex.StackTrace);

                //만약 파일이 없어서 여기로 진입한 경우라면
                CreateFile(); //파일을 다시 만들고
                Save(null); //그 파일을 저장한 다음
                Load(); //다시 불러들여본다.

                //단, Load 함수 자체가 잘못된거라면 이 코드는 무한루프에 빠진다.
            }
        }
        public override void Save(ParkingCar car)
        {
            string booksOutput = "";
            booksOutput += "<cars>\n"; //\n 대신에 Enviroment.NewLine 써도 됨
            if (Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{item.parkingSpot}</parkingSpot>\n";
                    booksOutput += $"   <carNumber>{item.carNumber}</carNumber>\n";
                    booksOutput += $"   <driverName>{item.driverName}</driverName>\n";
                    booksOutput += $"   <phoneNumber>{item.phoneNumber}</phoneNumber>\n";
                    booksOutput += $"   <parkingTime>{item.parkingTime}</parkingTime>\n";
                    booksOutput += "</car>\n";
                }
            }
            else //xml 파일에 아무 것도 없는 경우
            {
                for (int i = 1; i <= 5; i++)
                {
                    booksOutput += "<car>\n";
                    booksOutput += $"   <parkingSpot>{i}</parkingSpot>\n";
                    booksOutput += "   <carNumber></carNumber>\n";
                    booksOutput += "   <driverName></driverName>\n";
                    booksOutput += "   <phoneNumber></phoneNumber>\n";
                    booksOutput += "   <parkingTime></parkingTime>\n";
                    booksOutput += "</car>\n";
                }
            }
            booksOutput += "</cars>";
            File.WriteAllText(@"./Cars.xml", booksOutput);
        }

        //주차 공간 추가
        public override bool insertParkingSpot(int parkingSpotNum) 
        {
            try
            {
                ParkingCar checkSpot = Cars.Single((x) => x.parkingSpot == parkingSpotNum);
                if (checkSpot != null)
                {
                    System.Windows.Forms.MessageBox.Show("이미 존재하는 주차공간입니다.");
                    dataSource.PrintLog("이미 존재하는 주차공간입니다.");
                }
                return false;
            }
            catch (Exception)
            {
                //없다면 이리로 온다.
                Cars.Add(new ParkingCar() {parkingSpot=parkingSpotNum, carNumber="", driverName ="", phoneNumber ="", parkingTime=DateTime.Now});
                Save(null);
                Load();
                return true;
            }
        }

        protected override void CreateFile()
        {
            //Cars.xml 파일을 만들겁니다.

            string fileName = @"./Cars.xml";
            StreamWriter writer = File.CreateText(fileName); //파일이 없으면 해당 파일 생성
            writer.Dispose(); //메모리 해제
        }
    }
}
