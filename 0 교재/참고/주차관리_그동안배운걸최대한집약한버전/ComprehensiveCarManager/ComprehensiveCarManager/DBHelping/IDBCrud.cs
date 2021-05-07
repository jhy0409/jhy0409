using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveCarManager
{
    interface IDBCrud
    {
        DataSet selectQuery();
        void insertQuery(int parkingSpot);
        void updateQuery(ParkingCar car);
    }
}
