using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveCarManager.DBHelping
{
    class DBHelper_MsSQL : DBHelper, IDBConnector, IDBCrud //부모인 DBHelper에 본 인터페이스들이 이미 달려있어서 여기선 굳이 추가 안해줘도 오류는 발생 안하는 것 같음
    {
        public override DataSet selectQuery()
        {
            try
            {
                ConnectDB();
                //SQL 명령어 선언
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Msconn;
                cmd.CommandText = "SELECT * FROM CarManager";
                da = new SqlDataAdapter(cmd); //select 구문이 들어감
                ds = new DataSet();
                da.Fill(ds, "CarManager");
                Msconn.Close(); //연결 해제
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
                string sqlcommand = "Insert Into CarManager (ParkingSpot) values (@parameter1)";
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Msconn;
                cmd.CommandType = CommandType.Text;
                //Column 명은 별도의 파라메터 형태로 선언함
                //SQL Injection을 방지하고자 함(SQL Injection : 유효하지 않은 데이터를 이용한 공격) 예: +나 ' 기호를 이용한 공격
                cmd.Parameters.AddWithValue("@parameter1", parkingSpot);
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                Msconn.Close();
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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Msconn;
                cmd.CommandType = CommandType.Text;

                string sqlcommand;
                if (car.carNumber == "")
                {
                    sqlcommand = "Update CarManager set CarNumber = '', DriverName = '', PhoneNumber = '', ParkingTime = null where ParkingSpot = @p1";

                    cmd.Parameters.AddWithValue("@p1", car.parkingSpot);
                }
                else
                {
                    sqlcommand = "Update CarManager set CarNumber = @p1, DriverName = @p2, PhoneNumber = @p3, ParkingTime = @p4 where ParkingSpot = @p5";

                    cmd.Parameters.AddWithValue("@p1", car.carNumber);
                    cmd.Parameters.AddWithValue("@p2", car.driverName);
                    cmd.Parameters.AddWithValue("@p3", car.phoneNumber);
                    cmd.Parameters.AddWithValue("@p4", car.parkingTime.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@p5", car.parkingSpot); //제대로 된 숫자 입력하지 않으면 이 부분까지 코드가 실행되지도 못 하도록 짜여있음
                }

                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery(); //쿼리 실행
                Msconn.Close();
            }
            catch (Exception eee)
            {
                showDBError(eee);
            }

        }

        public override void ConnectDB()
        {
            try
            {
                Msconn.ConnectionString = string.Format("Data Source=({0}); " +
                        "Initial Catalog = {1};" +
                        "Integrated Security = {2};" +
                        "Timeout = 3"
                        , "local", "MYDB1", "SSPI");
                Msconn = new SqlConnection(Msconn.ConnectionString);
                Msconn.Open();
            }
            catch (Exception e)
            {
                showDBError(e);
            }
        }
    }
}
