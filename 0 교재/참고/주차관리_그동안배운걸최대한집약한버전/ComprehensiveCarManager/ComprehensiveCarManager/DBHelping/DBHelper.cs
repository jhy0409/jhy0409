using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveCarManager.DBHelping
{
    class DBHelper : IDBConnector, IDBCrud
    {
        //DBHelper를 상속받은 클래스들만 쓸 수 있는 변수들
        protected static SqlConnection Msconn = new SqlConnection();
        protected static MySqlConnection Myconn = new MySqlConnection();
        protected static SqlDataAdapter da;
        protected static DataSet ds;
        protected static OracleConnection OraConn = new OracleConnection();
        private DBHelper instance;
        public DBHelper getInstance(DataManaging.DataSource.DataBase dts)
        {
            if(instance == null)
            {
                switch (dts)
                {
                    case DataManaging.DataSource.DataBase.MSSQL:
                        instance = new DBHelper_MsSQL();
                        break;
                    case DataManaging.DataSource.DataBase.MYSQL:
                        instance = new DBHelper_MySql();
                        break;
                    case DataManaging.DataSource.DataBase.ORACLE:
                        instance = new DBHelper_Oracle();
                        break;
                }
            }
            return instance;
        }
        
        public void deleteQuery(int parkingSpot=-1)
        {

        }

        public virtual DataSet selectQuery()
        {
            return ds;
        }

        public virtual void insertQuery(int parkingSpot)
        {
        }

        public virtual void updateQuery(ParkingCar Car)
        {
        }

        public virtual void ConnectDB()
        {
        }
        //DBHelper를 상속받은 클래스들만 쓸 수 있는 메소드
        protected void showDBError(Exception e)
        {
            System.Windows.Forms.MessageBox.Show(e.Message);
            System.Windows.Forms.MessageBox.Show(e.StackTrace);
            printDBError(e);
        }

        private void printDBError(Exception e)
        {
            new DataManaging.DataSource().PrintLog(e.Message);
            new DataManaging.DataSource().PrintLog(e.StackTrace);
        }
    }
}
