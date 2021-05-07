using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveCarManager.DataManaging
{

    class DataManager
    {
        public List<ParkingCar> Cars = new List<ParkingCar>();
        private DataManager instance; //싱글톤 패턴을 쓰는 이유는 인스턴스를 딱 한 번만 생성하기 위해서 쓴다.
        public DataSource dataSource = new DataSource(); //dataSource는 여기서 객체 생성하면 그 이후에는 또 생성할 일이 없다.
        //클래스 메소드로 써도 되지만 클래스 메소드는 오버라이딩이 안 된다.

        //다형성 이용
        public DataManager getInstance(int number=-1 ) 
        {
            if (instance == null)
            {
                switch ((DataSource.DataBase)number)
                {
                    case DataSource.DataBase.XML:
                        instance = new DataManager_xml();
                        break;
                    case DataSource.DataBase.JSON:
                        instance = new DataManager_json();
                        break;
                    case DataSource.DataBase.MSSQL:
                    case DataSource.DataBase.MYSQL:
                    case DataSource.DataBase.ORACLE:
                        instance = getInstance((DataSource.DataBase)number);
                        break;
                    default:
                        instance = new DataManager();
                        break;
                }
            }
            return instance;
        }

        public DataManager getInstance(DataSource.DataBase number)
        {
            return new DataManager_DB(number);
        }

        //DataManager의 자손 클래스에서 인스턴스 생성시(생성자 호출시)
        //DataManger의 생성자를 먼저 호출한다.
        //이 점 때문에 만약 여기서 Load 함수 호출하면, DataManager의 자손 클래스 인스턴스 생성시
        //Load를 두 번 호출 하는 문제가 있다.
        //따라서 여기선 아무것도 호출하지 않는다.
        public DataManager()
        {
        }

        //xml json mssql mysql oracle 다 이용하지 않을 거라면 내부 List가지고만 주차관리하기
        //이럴 경우 프로그램 끄면 다 리셋된다.
        public virtual void Load()
        {
            for (int i = 1; i <= 5; i++)
            {
                ParkingCar tempCar = new ParkingCar()
                {
                    parkingSpot = i,
                    carNumber = "",
                    driverName = "",
                    phoneNumber = "",
                    parkingTime = DateTime.Now
                };
                Cars.Add(tempCar);
            }
        }
        //주차, 출차시 호출
        //근데 만약 파일이나 db 저장이 아니라면 Form 안에서 이미 List에 대한 연산이 다 끝남(data.csv에 -1썼을 때)
        //따라서 여기서는 구체적으로 구현할 내용은 없음.
        public virtual void Save(ParkingCar car) { }


        //주차공간추가
        public virtual bool insertParkingSpot(int parkingCarNum) 
        {
            Cars.Add(new ParkingCar() { parkingSpot= Cars.Count+1});
            return true;
        }

        //DataManager를 상속받는 것 이외에는 이 함수를 만들거나 쓸 일이 없다.
        protected virtual void CreateFile() { }

    }
}
