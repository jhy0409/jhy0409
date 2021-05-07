using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprehensiveCarManager.DataManaging
{
    class DataManager_DB : DataManager
    {
        private DBHelping.DBHelper dbh;
        private DataSet ds;
        public DataManager_DB(DataSource.DataBase ds)
        {
            selectDataBase(ds); //부모 생성자 호출 후에 호출할 것이다.
        }

        private void selectDataBase(DataSource.DataBase ds)
        {
            dbh = new DBHelping.DBHelper().getInstance(ds);
        }

        public override void Load()
        {
            try
            {
                //select 문으로 해당 테이블의 전체 데이터들을 가져옴
                ds = dbh.selectQuery();
                Cars.Clear(); //새로 조회할 때마다 Clear 해줘야 함
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    ParkingCar car = new ParkingCar();
                    car.parkingSpot = int.Parse(item["ParkingSpot"].ToString());
                    car.carNumber = item["CarNumber"].ToString();
                    car.driverName = item["DriverName"].ToString();
                    car.phoneNumber = item["PhoneNumber"].ToString();
                    car.parkingTime = item["ParkingTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());
                    Cars.Add(car); //그 데이터들을 Cars에 넣음
                }
                
            }
            catch (Exception exception)
            {
                dataSource.PrintLog(exception.Message);
                dataSource.PrintLog(exception.StackTrace);
            }
        }
        public override void Save(ParkingCar car)
        {
            try
            {
                //주차 or 출차로 인하여 상태가 변하였으므로 update문을 호출하여 db table에도 값이 바뀔 수 있도록 한다.
                dbh.updateQuery(car);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + Environment.NewLine + exception.StackTrace);
                dataSource.PrintLog(exception.Message + Environment.NewLine + exception.StackTrace);
            }
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
                return false; //single했는데 catch로 안 빠지면 어차피 주차공간이 있다는 것이다.
            }
            catch (Exception ex)
            {
                //없다면 이리로 온다.
                dbh.insertQuery(parkingSpotNum);
                Load();
                return true;
            }
        }

        protected override void CreateFile()
        {
        }
    }
}
