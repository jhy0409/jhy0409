using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveCarManager
{
    class ParkingCar : Car
    {
        public int parkingSpot { get; set; }
        //public string carNumber { get; set; } //Car를 확장시킨 클래스
        public string driverName { get; set; }
        public string phoneNumber { get; set; }
        public DateTime parkingTime { get; set; }
    }
}
