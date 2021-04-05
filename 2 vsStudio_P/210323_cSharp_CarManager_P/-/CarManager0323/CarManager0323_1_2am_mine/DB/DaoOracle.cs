using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.DB
{
    class DaoOracle
    {
        const string CONNECT_ERR = "DB 접속";
        const string DISCONNECT_ERR = "접속 해제";
        const string CREATE_TB_ERR = "테이블+시퀀스 생성";
        const string DROP_TB_ERR = "테이블+시퀀스 삭제";

        const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=c##scott;Password=1126;";

        /*const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=c##scott;Password=1126;";*/
        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        //소멸자, 종료시점
        ~DaoOracle()
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                Console.WriteLine("해제에러: " + e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                string query = "create table testTB (" +
                "id number not null, " +
                "name varchar(20) not null, " +
                "age number not null, " +
                "constraint pk_testTB_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seq_testTB_id " +
                    "increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }
        }

        public void errorMsg(string msg, OracleException e)
        {
            Console.WriteLine(msg + ": 에러 번호: " + e.Number);
            Console.WriteLine(msg + ": 에러 내용: " + e.Message);
        }

        public void makeTbCustomer()
        {
            try
            {
                string query = "CREATE TABLE customer_t (" +
                    "c_id       INT              NOT NULL," +
                    "c_name     VARCHAR2(10)     NOT NULL," +
                    "c_tel      VARCHAR2(20)     NOT NULL," +
                    "c_addr     VARCHAR2(50)     NOT NULL," +
                    "c_email    VARCHAR2(30)    NULL, " +
                    "CONSTRAINT CUSTOMER_T_PK PRIMARY KEY(c_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE customer_t_SEQ " +
                    "START WITH 1 INCREMENT BY 1";
                cmd.Connection = conn;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbCar()
        {
            try
            {
                string query = "CREATE TABLE car_t (" +
                    "car_id         INT             NOT NULL," +
                    "car_model      VARCHAR2(10)    NOT NULL," +
                    "car_price      NUMBER          NOT NULL," +
                    "car_color      VARCHAR2(10)    NOT NULL," +
                    "car_company    VARCHAR2(10)    NOT NULL," +
                    "car_year       VARCHAR2(20)    NOT NULL," +
                    "CONSTRAINT CAR_T_PK PRIMARY KEY(car_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE car_t_SEQ " +
                    "START WITH 1 INCREMENT BY 1";
                cmd.Connection = conn;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbSeller()
        {
            try
            {
                string query = "CREATE TABLE seller_t (" +
                    "se_id             INT             NOT NULL," +
                    "se_name           VARCHAR2(10)    NOT NULL," +
                    "se_tel            VARCHAR2(20)    NOT NULL," +
                    "se_email          VARCHAR2(20)    NULL," +
                    "se_jikwi          VARCHAR2(10)    NOT NULL," +
                    "se_office_name    VARCHAR2(20)    NOT NULL," +
                    "CONSTRAINT SELLER_T_PK PRIMARY KEY(se_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE seller_t_SEQ " +
                    "START WITH 1 INCREMENT BY 1";
                cmd.Connection = conn;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void makeTbDeal()
        {
            try
            {
                string query = "CREATE TABLE deal_t (" +
                    "d_id      INT             NOT NULL," +
                    "d_date    VARCHAR2(10)    NOT NULL," +
                    "se_id     INT             NOT NULL," +
                    "c_id      INT             NOT NULL," +
                    "car_id    INT             NOT NULL," +

                    "CONSTRAINT FK_deal_t_c_id_customer_t_c_id FOREIGN KEY(c_id) " +
                    "REFERENCES customer_t(c_id), " +

                    "CONSTRAINT FK_deal_t_car_id_car_t_car_id FOREIGN KEY(car_id) " +
                    "REFERENCES car_t(car_id), " +

                    "CONSTRAINT FK_deal_t_se_id_seller_t_se_id FOREIGN KEY(se_id) " +
                    "REFERENCES seller_t(se_id), " +

                    "CONSTRAINT DEAL_T_PK PRIMARY KEY(d_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE deal_t_SEQ " +
                    "START WITH 1 INCREMENT BY 1";
                cmd.Connection = conn;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void createAllTB()
        {
            makeTbCar();
            makeTbCustomer();
            makeTbSeller();
            makeTbDeal();
        }
        public void dropAllTB()
        {
            dropTable("deal_t", "deal_t_SEQ");
            dropTable("car_t", "car_t_SEQ");
            dropTable("customer_t", "customer_t_SEQ");
            dropTable("seller_t", "seller_t_SEQ");
        }
        public void dropTable()
        {
            try
            {
                string query = "drop table testTB";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence seq_testTB_id";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");

            }
            catch (OracleException e)
            {
                Console.WriteLine("에러: " + e.Message);
            }

        }

        public void dropTable(string tb, string seq)
        {
            try
            {
                string query = "drop table " + tb;
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence " + seq;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(DROP_TB_ERR,e);
            }
        }
    }
}
