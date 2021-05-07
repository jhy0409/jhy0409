using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveCarManager.DataManaging
{
    //추상클래스 활용하기
     abstract class LogWriter
    {
        public abstract void PrintLog(string contents, string name = "ParkingHistory");

    }
}
