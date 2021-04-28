using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. 변수이름 입력 : ");
            string mkByonsu = Console.ReadLine();
            
            Console.Write("2. 변수생성 개수 : ");
            int makeHow = int.Parse(Console.ReadLine());
            string sum = "";
            string temp = "";
            for (int i = 0; i < makeHow; i++)
            {
                if (i == makeHow-1)
                {
                    temp = mkByonsu + (i + 1).ToString();
                    sum += temp;
                }
                else
                {
                    temp = mkByonsu + (i + 1).ToString() + ", ";
                    sum += temp;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
