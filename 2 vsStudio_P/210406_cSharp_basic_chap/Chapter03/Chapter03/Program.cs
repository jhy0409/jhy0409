using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();  //if (name == "이름") 조건 없는거랑 동일, 무조건 실행
            //if (name == "이름")

            /*string name = Console.ReadLine();
            if (false)
            {
                Console.WriteLine($"{name}입니다.");
            }
            else
            {
                Console.WriteLine($"다른 이름입니다.");
            }*/

            int a = 100;
            if (a > 50)
            {
                Console.WriteLine("50초과 1");
                a = -100;
            }
            else
            {
                Console.WriteLine("50보다 작거나 같다 1");
            }


            a = 100;
            if (a > 50)
            {
                Console.WriteLine("50초과 2");
                a = -100;
            }
            if (a < 50)
            {
                Console.WriteLine("50보다 작거나 같다 2");
                Console.WriteLine("두 줄 이상일 때는 중괄호로 묶을 것 2");
            }

            /*Console.Write("숫자 입력 : ");
            int num1 = int.Parse(Console.ReadLine());
            string dab = ((num1 % 2 == 0) ? "짝수" : "홀수");
            Console.WriteLine(dab);

            // 실행은 되는데 비권장, 가독성 ↓
            // if (num1 % 2 == 0) Console.WriteLine("짝");
            // else Console.WriteLine("홀");
            if (num1 % 2 == 0)
                Console.WriteLine("짝");
            else
                Console.WriteLine("홀");*/


            // 조건문 중첩
            /*Console.Write("숫자 a입력 : ");
            int a = int.Parse(Console.ReadLine());*/
            if (a > 0)
            {
                Console.WriteLine("a의 값이 양수");
                if (a > 50)
                {
                    Console.WriteLine("a의 값이 50 초과");
                }
                else
                {
                    Console.WriteLine("a의 값이 50 작거나 같다");
                }
            }
            else
            {
                Console.WriteLine("a의 값이 음수");
                if (a > -50)
                {
                    Console.WriteLine("a의 값이 -50 초과");
                }
                else
                {
                    Console.WriteLine("a의 값이 -50 작거나 같다");
                }
            }


            int b = 100;
            if (b < 50)
            {
                Console.WriteLine("b는 50보다 작습니다.");
            }
            else if (b < 70)
            {
                Console.WriteLine("b는 70보다 작습니다.");
            }
            else if (b < 90)
            {
                Console.WriteLine("b는 90보다 작습니다.");
            }
            else
            {
                Console.WriteLine($"b의 값은 {b}입니다.");
            }


            string line = "--------------------------------";
            int dice = 8;
            Console.WriteLine($"{line}\n스위치 문\n{line}");
            switch (dice)
            {
                case 1:
                    Console.WriteLine("주사위: 1");
                    break;
                case 2:
                    Console.WriteLine("주사위: 2");
                    break;
                case 3:
                    //Console.WriteLine("주사위: 3");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("주사위: 4, 5, 6");
                    break;
                default:
                    Console.WriteLine("1,2,3,4,5,6 중 하나가 아님");
                    break;
            }



            Console.WriteLine($"\n{line}\nif else문\n{line}");

            if (dice == 1)
                Console.WriteLine("주사위: 1");
            else if (dice == 2)
                Console.WriteLine("주사위: 2");
            else if (dice == 3)
            { Console.WriteLine("주사위: 3"); }
            else if (dice == 4 || dice == 5 || dice == 6)
            {
                Console.WriteLine("주사위: 4, 5, 6");
            }
            else
            {
                Console.WriteLine("1,2,3,4,5,6 중 하나가 아님");
            }
            // 끝에 else는 안 넣어도 됨, 코드 꼬일 때도 ㅇ

            // 범위 지정하기
            int Keycm = 173;
            // 키가 170~180 : 애매함
            // if (170 <= Keycm < 180) 이렇게 적으면 X

            if (Keycm >= 170)
            {
                if (Keycm < 180)
                    Console.WriteLine("애매함");
            }


            if (Keycm >= 170 && Keycm < 180) // 논리곱, 하나라도 false면 다 false
                Console.WriteLine("애매함");

            if (Keycm < 100 || Keycm > 200) // 논리합, 하나라도 true면 다 T
                Console.WriteLine("개미거나 코끼리다.");

            if (Keycm >= 100 ^ Keycm >= 200) // XOR 형태만 봐두기, 배타적 or(exclusive or)
                Console.WriteLine("100");



            // 삼항연산자
            // 간단한 조건식은 한줄로 다 표현함
            // *, ** 같은코드
            int c = a % 2 == 0 ? -1 : 0; // *


            if (a % 2 == 0) // **
                c = -1;
            else
                c = 0;


            //string에 특정한 문장 or 글자가 있을 때

            string name2 = "이름2";
            if (name2.Contains("이"))
                Console.WriteLine("동태");

            if (name2.Contains("름"))
                Console.WriteLine("황태");

            // 문제 1. 사용자에게 태어난 년도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성하시오.
            Console.Write("태어난년도 입력 :");
            int sibiji = (int.Parse(Console.ReadLine())) % 12;

            /*자(쥐)      축(소)    인(호랑이)
              묘(토끼)    진(용)    사(뱀)
              오(말)      미(양)    신(원숭이) 
              유(닭)      술(개)    해(돼지)*/

            switch (sibiji)
            {
                case 0:
                    Console.WriteLine("원숭이");
                    break;
                case 1:
                    Console.WriteLine("닭띠");
                    break;
                case 2:
                    Console.WriteLine("개띠");
                    break;
                case 3:
                    Console.WriteLine("돼지띠");
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
                    Console.WriteLine("토끼");
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
            }


            // 문제 2. 사용자에게 현재 월을 입력받아 계절을 출력하는 프로그램을 작성
            /*Console.Write("1~12월 입력 : ");
            int monthNum = int.Parse(Console.ReadLine());
            switch (monthNum)
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
                    Console.WriteLine("범위값을 초과합니다 (1~12)");
                    break;
            }*/


            while (silHum())
            {

            }
        }

        static public bool silHum()
        {
            Console.Write("1~12월 입력 : ");
            int monthNum = int.Parse(Console.ReadLine());
            switch (monthNum)
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
                    Console.WriteLine("범위값을 초과합니다 (1~12)");
                    return true;
            }
            return false;
        }
    }
}
