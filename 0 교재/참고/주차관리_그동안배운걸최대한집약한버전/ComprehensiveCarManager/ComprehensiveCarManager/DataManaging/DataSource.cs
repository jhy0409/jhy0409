using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveCarManager.DataManaging
{
    class DataSource : LogWriter
    {
        public enum DataBase
        {
            DEFAULT = -1, XML, JSON, MSSQL, MYSQL, ORACLE
        }

        //추상클래스 상속 받아서 구체적으로 구현해주기
        //static과 오버라이딩은 동시에 못 쓴다.
        public override void PrintLog(string contents, string name = "error")
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory");
            if (!di.Exists)
            {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter("ParkingHistory" + "\\" + name + ".txt", true))
            {
                writer.WriteLine(contents);
            }
        }
    }
}
