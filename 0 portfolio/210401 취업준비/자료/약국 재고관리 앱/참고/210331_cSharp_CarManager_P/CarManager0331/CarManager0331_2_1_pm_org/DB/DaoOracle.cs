using CarManager0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                errorMsg(CONNECT_ERR, e);
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
                //Console.WriteLine("해제에러: " + e.Message);
                errorMsg(DISCONNECT_ERR, e);
            }
        }

        public void createTable()
        {
            try
            {
                string query = "create table testTB (" +
                    "id number not null," +
                    "name varchar(20) not null," +
                    "age number not null," +
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
                errorMsg(CREATE_TB_ERR, e);
            }
        }

        public void errorMsg(string msg, OracleException e)
        {
            //Console.WriteLine(msg+": 에러 코드: "+e.ErrorCode.ToString());
            Console.WriteLine(msg + ": 에러 번호: " + e.Number);
            Console.WriteLine(msg + ": 에러 내용: " + e.Message);
        }

        public void makeTbCustomer()
        {
            try
            {
                string query = "CREATE TABLE customer_t (" +
                                "c_id INT NOT NULL," +
                                "c_name VARCHAR2(10) NOT NULL," +
                                "c_tel VARCHAR2(20) NOT NULL," +
                                "c_addr VARCHAR2(50) NOT NULL," +
                                "c_email VARCHAR2(30) NULL," +
                                "CONSTRAINT CUSTOMER_T_PK PRIMARY KEY(c_id))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE customer_t_SEQ " +
                    "START WITH 1 " +
                    "INCREMENT BY 1";
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
                    "car_year       VARCHAR2(20)    NOT NULL, " +
                    "CONSTRAINT CAR_T_PK PRIMARY KEY(car_id))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE car_t_SEQ " +
                    "START WITH 1 " +
                    "INCREMENT BY 1";
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
                    "se_office_name    VARCHAR2(20)    NOT NULL, " +
                    "CONSTRAINT SELLER_T_PK PRIMARY KEY(se_id))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE seller_t_SEQ " +
                    "START WITH 1 " +
                    "INCREMENT BY 1";
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
                    "car_id    INT             NOT NULL, " +
                    "CONSTRAINT " +
                    "FK_deal_t_c_id_customer_t_c_id FOREIGN KEY(c_id) " +
                    "REFERENCES customer_t(c_id), " +

                    "CONSTRAINT " +
                    "FK_deal_t_car_id_car_t_car_id FOREIGN KEY(car_id) " +
                    "REFERENCES car_t(car_id), " +

                    "CONSTRAINT " +
                    "FK_deal_t_se_id_seller_t_se_id FOREIGN KEY(se_id) " +
                    "REFERENCES seller_t(se_id), " +
                    "CONSTRAINT DEAL_T_PK PRIMARY KEY(d_id))";

                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE deal_t_SEQ " +
                    "START WITH 1 " +
                    "INCREMENT BY 1";
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
                //상수 변수로 관리
                errorMsg(DROP_TB_ERR, e);
            }
        }

        public void insertCar()
        {
            try
            {
                string sql = "insert into car_t values (car_t_SEQ.nextval, " +
                    "'그랜저', 40000000, '은색', '현대', '2021년')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                Console.WriteLine("Car 입력이 완료되었습니다.");
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }

        public void insertCar(Car car)
        {
            try
            {
                string sql = string.Format("insert into car_t values (car_t_SEQ.nextval, " +
                    "'{0}', {1}, '{2}', '{3}', '{4}')",
                    car.Model, car.Price, car.Color, car.Company, car.Year);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertCar()", e);
            }
        }



        public void insertSeller()
        {
            try
            {
                string sql = "insert into seller_t values (seller_t_SEQ.nextval, " +
                    "'김철수', '010-1111-1234', 'kim@hyundai.com', '대리', '동대구 영업소')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                Console.WriteLine("Seller 입력이 완료되었습니다.");
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller()", e);
            }
        }

        public void insertSeller(Seller sell)
        {
            try
            {
                string sql = string.Format("insert into seller_t " +
                    "values (seller_t_SEQ.nextval, " +
                    "'{0}','{1}','{2}','{3}','{4}')",
                    sell.Name, sell.Tel, sell.Email,
                    sell.Jikwi, sell.OfficeName);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errorMsg("insertSeller()", e);
            }
        }


        public void insertCustomer()
        {
            try
            {
                string sql = "insert into customer_t values (customer_t_SEQ.nextval, " +
                    "'김순자', '010-1133-1289', '대구시 동구 신천동', 'kimj@naver.com')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                Console.WriteLine("Customer 입력이 완료되었습니다.");
            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }


        public void insertCustomer(Customer cust)
        {
            try
            {
                string sql = string.Format("insert into customer_t values " +
                    "(customer_t_SEQ.nextval, " +
                    "'{0}','{1}','{2}','{3}')",
                    cust.Name, cust.Tel, cust.Addr, cust.Email);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                errorMsg("insertCustomer()", e);
            }
        }


        // ------------------------------------------- ★
        public void insertDeal()
        {
            try
            {
                string sql1 = "INSERT into deal_t (d_id, d_date, " +
                "se_id, c_id, car_id) " +
                "(select deal_t_SEQ.nextval, sysdate, " +
                "s.se_id, cu.c_id, ca.car_id " +
                "from seller_t s natural join customer_t cu " +
                "natural join car_t ca " +
                "where cu.c_name='김순자' and ca.car_model='그랜저' " +
                "and s.se_name='김철수')";
                cmd.Connection = conn;
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();

                Console.WriteLine("insertDeal() 입력이 완료되었습니다.");

            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }


        public void insertDeal(Deal deal)
        {
            try
            {
                string sql = string.Format("INSERT into deal_t " +
                "(d_id, d_date, se_id, c_id, car_id) " +
                "(select deal_t_SEQ.nextval, sysdate, " +
                "s.se_id, cu.c_id, ca.car_id " +
                "from seller_t s natural join customer_t cu " +
                "natural join car_t ca " +
                "where cu.c_name='{0}' and ca.car_model='{1}' " +
                "and s.se_name='{2}')",
                deal.Customer.Name,
                deal.Car.Model,
                deal.Seller.Name);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                Console.WriteLine("insertDeal() 입력이 완료되었습니다.");

            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
            }
        }



        public void insertDeal(Customer cust, Car car, Seller seller)
        {
            try
            {
                string sql = string.Format("INSERT into deal_t values " +
                    "(deal_t_SEQ.nextval, sysdate, " +
                    "(select se_id from seller_t where se_name = '{0}' " +
                    "and se_tel = '{1}'), " +
                    "(select car_id from car_t where car_model = '{2}' " +
                    "and car_price = {3}), " +
                    "(select c_id from customer_t where c_name = '{4}' " +
                    "and c_tel = '{5}'))",
                    seller.Name, seller.Tel,
                    car.Model, car.Price,
                    cust.Name, cust.Tel);

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                Console.WriteLine("insertDeal() 입력이 완료되었습니다.");

            }
            catch (OracleException e)
            {
                errorMsg("insertDeal()", e);
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
                //상수 변수로 관리
                errorMsg(DROP_TB_ERR, e);
            }
        }

        public List<DealResult> selectDeal()
        {
            List<DealResult> dResultList = new List<DealResult>();

            try
            {
                int count = 1;
                string query = "SELECT cu.c_name, ca.car_model, ca.car_price, " +
                    "se.se_name, d.d_date " +
                    "from deal_t d, car_t ca, customer_t cu, seller_t se " +
                    "where d.car_id = ca.car_id and d.c_id = cu.c_id " +
                    "and d.se_id = se.se_id";
                /* c# dataset으로도 읽어올 수 ㅇ*/
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("번호: " + count);
                        Console.WriteLine("고객명: " + reader["c_name"]);
                        Console.WriteLine("모델: " + reader["car_model"]);

                        string price = reader["car_price"].ToString();
                        double dPrice = Convert.ToDouble(price);
                        NumberFormatInfo numFormat = new CultureInfo("ko-KR", false).NumberFormat;
                        price = dPrice.ToString("c", numFormat);

                        Console.WriteLine("가격: " + price);
                        Console.WriteLine("판매자: " + reader["se_name"]);
                        Console.WriteLine("구매날짜: " + reader["d_date"]);
                        Console.WriteLine("-------------------------------");

                        DealResult dResult = new DealResult(count,
                            reader["c_name"].ToString(),
                            reader["car_model"].ToString(),
                            price,
                            reader["se_name"].ToString(),
                            reader["d_date"].ToString());
                        dResultList.Add(dResult);
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                    return null;
                }
                reader.Close();
            }
            catch (OracleException e)
            {
                errorMsg("selectDeal()", e);
            }
            return dResultList;
        }
    }
}
