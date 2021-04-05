using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 운영체재별 개행 자동변환
            Console.Write("Write"+ Environment.NewLine); 
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.WriteLine("WriteLine");
            Console.Write("Write");
            Console.WriteLine("Write");
            Console.WriteLine("\"Write\"");

            //"\"Write\""를 보이게?
            Console.WriteLine("\n\n------------------");
            Console.WriteLine("\"\\\"Write\\\"\"");
        }
    }
}
