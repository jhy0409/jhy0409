using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprehensiveCarManager
{
    interface IDBConnector
    {
        //protected 안 먹힘(8.0부터 된다고 함)
        void ConnectDB();
    }
}
