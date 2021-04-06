using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문제 1. 사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성하시오.

            /*자(쥐)      축(소)    인(호랑이)
              묘(토끼)    진(용)    사(뱀)
              오(말)      미(양)    신(원숭이) 
              유(닭)      술(개)    해(돼지)*/

            int birthYear = int.Parse(Console.ReadLine());
            switch (birthYear % 12)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭");
                    break;
                case 2:
                    Console.WriteLine("개");
                    break;
                case 3:
                    Console.WriteLine("돼지");
                    break;

                case 4:
                    Console.WriteLine("쥐띠");
                    break;
                case 5:
                    Console.WriteLine("소띠");
                    break;
                case 6:
                    Console.WriteLine("호랑이띠");
                    break;

                case 7:
                    Console.WriteLine("토끼띠");
                    break;
                case 8:
                    Console.WriteLine("용띠");
                    break;
                case 9:
                    Console.WriteLine("뱀띠");
                    break;

                case 10:
                    Console.WriteLine("말띠");
                    break;
                case 11:
                    Console.WriteLine("양띠");
                    break;
                default:
                    break;
            }


            // 문제 2. 사용자에게 현재 월을 입력받아 계절을 출력하는 프로그램을 작성
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
                default:
                    Console.WriteLine(month+"는 잘못된 값입니다.");
                    break;
            }
        }
    }
}
