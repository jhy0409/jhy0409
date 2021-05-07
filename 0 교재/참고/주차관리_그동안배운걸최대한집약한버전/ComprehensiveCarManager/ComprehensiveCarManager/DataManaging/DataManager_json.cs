using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprehensiveCarManager.DataManaging
{
    class DataManager_json : DataManager
    {
        public override void Load()
        {
            try
            {
                string strCarValueJson = File.ReadAllText(@"./Cars.json");
                JObject jsonObjectCar = JObject.Parse(strCarValueJson);
                Cars = (from item in jsonObjectCar["cars"]["car"]
                        select new ParkingCar()
                        {
                            parkingSpot = int.Parse(item["parkingSpot"].ToString()),
                            carNumber = item["carNumber"].ToString().Replace("{", "").Replace("}", ""),
                            driverName = item["driverName"].ToString().Replace("{", "").Replace("}", ""),
                            phoneNumber = item["phoneNumber"].ToString().Replace("{", "").Replace("}", ""),
                            parkingTime = item["parkingTime"].ToString().Replace("{", "").Replace("}", "") == "" ? DateTime.Now : DateTime.Parse(item["parkingTime"].ToString())
                        }).ToList<ParkingCar>();
            }
            catch (Exception e)
            {
                MessageBox.Show("Cars 파일이 누락되었습니다!!!");
                MessageBox.Show(e.Message);
                dataSource.PrintLog(e.Message);
                dataSource.PrintLog(e.StackTrace);
                CreateFile(); //파일 새로 만들기
                Save(null); //db호출할 거 아니면 car객체를 굳이 넣을 일이 없다.
                Load();
            }
        }
        public override void Save(ParkingCar car)
        {
            var jCarArray = new JArray();
            if (Cars.Count > 0)
            {
                foreach (var item in Cars)
                {
                    var jCarobject = new JObject();
                    jCarobject.Add("parkingSpot", item.parkingSpot);
                    jCarobject.Add("carNumber", item.carNumber);
                    jCarobject.Add("driverName", item.driverName);
                    jCarobject.Add("phoneNumber", item.phoneNumber);
                    jCarobject.Add("parkingTime", item.parkingTime);
                    jCarArray.Add(jCarobject);
                }
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    var jCarobject = new JObject();
                    jCarobject.Add("parkingSpot", i);
                    jCarobject.Add("carNumber", "");
                    jCarobject.Add("driverName", "");
                    jCarobject.Add("phoneNumber", "");
                    jCarobject.Add("parkingTime", new DateTime());
                    jCarArray.Add(jCarobject);
                }
            }

            var jCarArrayobect = new JObject();
            jCarArrayobect.Add("car", jCarArray);
            var jCarsobect = new JObject();
            jCarsobect.Add("cars", jCarArrayobect);

            // 저장
            File.WriteAllText(@"./Cars.json", jCarsobect.ToString());
        }

        public override bool insertParkingSpot(int parkingSpotNum)
        {
            try
            {
                ParkingCar checkSpot = Cars.Single((x) => x.parkingSpot == parkingSpotNum);
                if (checkSpot != null)
                {
                    MessageBox.Show("이미 존재하는 주차공간입니다.");
                    dataSource.PrintLog("이미 존재하는 주차공간입니다.");
                }
                return false;
            }
            catch (Exception)
            {
                //없다면 이리로 온다.
                Cars.Add(new ParkingCar() { parkingSpot = parkingSpotNum, carNumber = "", driverName = "", phoneNumber = "", parkingTime = DateTime.Now });
                Save(null);
                Load();
                return true;
            }
        }

        protected override void CreateFile()
        {
            string fileName = @"./Cars.json";
            StreamWriter textWrite = File.CreateText(fileName); //파일이 없으면 자동으로 해당 파일을 생성한다.
            textWrite.Dispose(); //메모리 해제. using 키워드로도 할 수 있으나 파일생성만 할 것이므로 별 차이 없다. 로그 남길 때 using 키워드 이용함.
        }
    }
}
