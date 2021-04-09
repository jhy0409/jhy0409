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
            //1. 5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 출력하는 프로그램을 작성
            Console.WriteLine("1. 5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 출력하는 프로그램을 작성");
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1}번째 숫자 : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
            }
            Console.WriteLine($"{min}, {max}");




            //2. 아래의 규칙을 따르는 수열의 20번째 숫자를 프로그램을 만들어 찾으시오. (개미수열, 읽고말하기 수열)
            Console.WriteLine("\n2. 아래의 규칙을 따르는 수열의 20번째 숫자를 프로그램을 만들어 찾으시오.");
            string start = "1";
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i + 1) + "번째 수열\t : " + start);
                char number = start[0]; // 가리키는 문자
                int count = 0;          // 숫자의 갯수 
                string end = "";        // 문자 누적 변수

                // 입력한 수열을 읽음
                for (int j = 0; j < start.Length; j++)
                {
                    if (number == start[j])
                    {
                        count++;
                    }
                    else
                    {
                        // 1121 1에서 2로 넘어가는 시점 등
                        end = end + number + count; // 1이 2개
                        number = start[j];
                        count = 1;
                    }
                }
                end = end + number + count;
                start = end;
            }





            //3. 별찍기
            Console.WriteLine("\n3. 별찍기");
            int inputFloor = int.Parse(Console.ReadLine());
            int Flag = 0;
            int index = 0;
            if (inputFloor == 1)
                Console.Write("*");
            else
            {
                for (int i = 0; i < inputFloor * 2; i++)
                {
                    for (int j = 0; j < inputFloor; j++)
                    {
                        if (Flag % 2 == 0)
                            Console.Write("*");
                        else
                            Console.Write("-");
                        Flag++;

                    }
                    if (inputFloor % 2 == 0)
                        Flag++;
                    if (i % 2 == 0)
                    {
                        index++;
                        Console.WriteLine($"{index}번째 ---");
                    }

                    else
                        Console.WriteLine("");

                }
            }

            //4. 설탕배달 문제
            Console.WriteLine("\n4. 설탕배달 문제");
            Console.Write("설탕 포대kg 입력 : ");
            int totalSugar = int.Parse(Console.ReadLine());
            int podae = 0;
            bool a = true;
            while (true)
            {
                if (totalSugar % 5 == 0)
                {
                    podae += totalSugar / 5;
                    break;
                }
                totalSugar -= 3;
                podae++;

                if (totalSugar < 0)
                {
                    podae = -1;
                    break;
                }
            }
            Console.WriteLine(podae);
        }
    }
}
