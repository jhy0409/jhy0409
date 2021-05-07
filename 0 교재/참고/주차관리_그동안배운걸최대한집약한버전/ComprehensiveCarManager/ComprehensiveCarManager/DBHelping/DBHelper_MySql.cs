using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ComprehensiveCarManager.DBHelping
{
    class DBHelper_MySql : DBHelper, IDBConnector, IDBCrud
    {
        //NUGET에서 MYSQL 검색해서 다운받음
        public override DataSet selectQuery()
        {
            try
            {
                //https://blog.jjin.dev/31
                //코드 참고하였다. DataSet을 리턴해주는 코드를 찾은것이다.
                //그냥 mysql 연결만 하고 단순히 쓰려면 더 쉬운 코드는 많다.
                //상속개념을 이용하니 단점은 한 번 만들어 둔 틀대로 코드를 맞추는 것이고
                //장점은 메인 부분을 더이상은 손을 안 대도 된다는 것이다.
                //물론 설계가 잘못되면 메인을 다시 뜯어야 한다 ㅜㅜ....
                ConnectDB();

                string sql = "SELECT * FROM CarManager";
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd = Myconn.CreateCommand();
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds, "CarManager");

                Myconn.Close();
            }
            catch (Exception e)
            {
                showDBError(e);
            }
            return ds;
        }
        
        public override void insertQuery(int parkingSpot)
        {

            try
            {
                ConnectDB();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO CarManager (ParkingSpot)  VALUES ('"+ parkingSpot + "')", Myconn);
                cmd.ExecuteNonQuery();
                Myconn.Close();
            }
            catch (Exception e)
            {
                showDBError(e);
            }
        }

        public override void updateQuery(ParkingCar car)
        {

            try
            {
                ConnectDB();

                MySqlCommand cmd = new MySqlCommand("",Myconn);
                string sqlcommand = "Update CarManager set CarNumber = '', DriverName = '', PhoneNumber = '', ParkingTime = null where ParkingSpot = '" + car.parkingSpot+"'";

                if(car.carNumber != "") //주차
                {
                    sqlcommand = $"Update CarManager set CarNumber = '{car.carNumber}', DriverName = '{car.driverName}', PhoneNumber = '{car.phoneNumber}', ParkingTime = '{car.parkingTime.ToString("yyyy-MM-dd HH:mm:ss.fff")}' where ParkingSpot = '{car.parkingSpot}'";
                }
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                Myconn.Close();
            }
            catch (Exception e)
            {

                showDBError(e);
            }
        }

        public override void ConnectDB()
        {
            try
            {
                string pwd = "1126";
                string strConn = "Server=localhost;Database=MYDB1;Uid=root;Pwd="+pwd+";Charset=utf8";
                Myconn = new MySqlConnection(strConn);
                Myconn.Open();
            }
            catch (Exception e)
            {
                showDBError(e);
            }
        }
    }
}
