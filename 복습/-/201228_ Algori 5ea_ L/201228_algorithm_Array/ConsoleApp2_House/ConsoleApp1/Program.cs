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
            //-------------- 1번문제 C# --------------
            /*1. 최대 최소 구하기
             *N개의 정수를 입력받고, 그 중에서 최댓값과 최솟값을 출력하시오.
             *예시
             *3을 입력하면 숫자를 3개 입력받고 그 중에서 최대 최소를 출력하기
             */

            Console.WriteLine("1번문제");
            Console.Write("★숫자 몇개(배열크기 지정)를 입력 받겠습니까? : ");
            int num = int.Parse(Console.ReadLine());
            int[] arr1 = new int[num];
            //int i = 0;



            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{i + 1}번째 배열의 값: ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            int max = arr1[0];
            int min = arr1[0];

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }

                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
            }
            Console.WriteLine($"최대값은 {max}이고, 최솟값은 {min}이다.");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i]==min)
                {
                    Console.Write($"최소값은 {i+1}번째, ");
                }

                if (arr1[i] == max)
                {
                    Console.Write($"최대값은 {i + 1}번째");
                }

            }


        }
    }
}

