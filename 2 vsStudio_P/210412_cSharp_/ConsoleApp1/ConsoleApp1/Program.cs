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
            Random r = new Random();
            // 숫자 순서 정렬 방법1
            int[] randomNumbers = new int[6];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = r.Next(1, 3);
            }
            Array.Sort(randomNumbers);

            int j = 0;
            foreach (var item in randomNumbers)
            {
                Console.Write($"{j + 1}번째 : {item}   ");
                j++;
            }

            // 버블정렬

        }

       
    }
}
