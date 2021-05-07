using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ComprehensiveCarManager.DBHelping
{
    class DBHelper_Oracle : DBHelper, IDBConnector, IDBCrud
    {
        //NUGET에서 ORACLE 검색해서 추가함
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=c##scott;Password=1126;";

        OracleCommand cmd = new OracleCommand();

        public override DataSet selectQuery()
        {
            try
            {
                ConnectDB();

                string sql = "SELECT * FROM CarManager order by parkingspot";
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand();
                oda.SelectCommand.Connection = OraConn;
                oda.SelectCommand.CommandText = sql;
                ds = new DataSet();
                oda.Fill(ds, "CarManager");

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
                cmd.Connection = OraConn;
                cmd.CommandText = $"INSERT INTO CARMANAGER (PARKINGSPOT) VALUES ('{parkingSpot}')";
                cmd.ExecuteNonQuery();
                OraConn.Close();
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
                cmd.Connection = OraConn;
                string sqlcommand = "Update CarManager set CarNumber = '', DriverName = '', PhoneNumber = '', ParkingTime = null where ParkingSpot = '" + car.parkingSpot + "'";

                if (car.carNumber != "") //주차
                {
                                                                                                                                                                            //SET PARKINGTIME = TO_DATE('2021-05-05 11:06:21', 'YYYY-MM-DD HH24:MI:SS') 
                    sqlcommand = $"Update CarManager set CarNumber = '{car.carNumber}', DriverName = '{car.driverName}', PhoneNumber = '{car.phoneNumber}', ParkingTime = TO_DATE('{car.parkingTime.ToString("yyyy-MM-dd HH:mm:ss")}', 'YYYY-MM-DD HH24:MI:SS') where ParkingSpot = '{car.parkingSpot}'";
                }
                cmd.CommandText = sqlcommand;
                cmd.ExecuteNonQuery();
                OraConn.Close();

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
                OraConn = new OracleConnection(ORADB);
                OraConn.Open();
                cmd = new OracleCommand();
            }
            catch (Exception e)
            {
                showDBError(e);
            }
        }
    }
}
