using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mun_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //상근이 알람시계 문제: 45분 전에 알람이 미리 울리도록


            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m < 45)
            {
                h -= 1;
                m += 60;
                m -= 45;

                if (h < 0)
                {
                    h += 24;
                }

            }
            else
            {
                m -= 45;
            }
            Console.WriteLine(h + "시" + m + "분에 알람이 울립니다!");

        }
    }
}
