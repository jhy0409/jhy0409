using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201217
{
    class This_Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            //---------- 1번 -----------
            //for (int i = 0; i < 100; i++)
            //{
            //    if ((i+1)%3==0)
            //    {
            //       sum += (i + 1);
            //    }

            //}
            //Console.WriteLine(sum);

            //---------- 2번 -----------

            //Console.Write("시간 입력");
            //int time = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{time/60}시간, {time%60}분");

            //---------- 3번 -----------

            // ///*
            // //***
            // /*****
            // *******

            //Console.Write("쌓을 층 입력: ");
            //int floor = int.Parse(Console.ReadLine());

            //for (int i = 0; i < floor; i++)
            //{
            //    for (int j = floor; j > i; j--) //j = 3
            //    {
            //        Console.Write("-");

            //    }
            //    for (int k = 0; k < (2 * i) + 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine(); //줄바꿈
            //}

            ////---------- 4번 -----------

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        Console.WriteLine($"{i+2} x {j+1} = {(i+2)*(j+1)}");
            //    }
            //}

            //---------- 5번 -----------
            //Console.Write("계절 입력: ");
            //int season = int.Parse(Console.ReadLine());
            //switch (season)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("겨울");
            //        break;

            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("봄");
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("여름");
            //        break;

            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("가을");
            //        break;

            //    default:
            //        Console.WriteLine("잘못된 입력");
            //        break;

            //}
            //---------- 6번 -----------
            //Console.Write("x값 입력: ");
            //int x = int.Parse(Console.ReadLine());

            //Console.Write("y값 입력: ");
            //int y = int.Parse(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine(2);
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine(3);
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine(4);
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}

            //---------- 7번 ★ ??? -----------


            //---------- 8번 ★ 다시 ----------

            /*  6   12    18
             1----7----19----37
             */

            int max = 1;
            int count = 0;
            Console.Write("임의의 숫자 입력");
            int num = int.Parse(Console.ReadLine());

            // n번째 벌집
            int i = 0;
            max = max + (6 * i);

            for (i = 0; i < max; i++)
            {
            }
            if (num < max)
            {
                Console.WriteLine($"{i + 1}번째 ?");

            }


        }
    }
}
