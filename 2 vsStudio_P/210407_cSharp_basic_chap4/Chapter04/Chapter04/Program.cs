using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("인사" + 1);
            Console.WriteLine("인사" + 2);
            Console.WriteLine("인사" + 3);
            Console.WriteLine("인사" + 4);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("인사2-" + (i + 1));
                Console.WriteLine("안녕하세요"[0]);
                Console.WriteLine("안녕하세요"[1]);
                Console.WriteLine("안녕하세요"[2]);
                Console.WriteLine("안녕하세요"[3]);
            }

            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("안녕하세요"[i]);
            }
            Console.WriteLine();
            string name = "혁파하"; // string = char의 배열
            string[] names = { "김가나", "정가나", "임가나" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            // new키워드로 변수 크기만 잡는것
            // 아스키코드
            string[] Hperson = new string[10];
            for (int i = (int)'A'; i < (int)'z'; i++)
                Console.Write((char)i);
            Console.WriteLine("..");

            // 유니코드
            for (int i = (int)'가'; i <= (int)'힣'; i++)
            {
                if (i == '강')
                    break;

                if (i == (int)'힣')
                    i = (int)'가';
            }

            // 무한대로 도는 반복문 쓰기에 적합한 while
            while (false)
            {
                Console.WriteLine(new Random().Next(int.MaxValue));
                Thread.Sleep(100);
            }

            // for

            // do while

            // while

            // c#에서는 foreach

            while (false)
            {
                Console.WriteLine("도날드 덕");
            }

            do
            {
                Console.WriteLine("도날드 덕");
            } while (false);

            int count = 100;
            while (count < 100)
            {
                Console.WriteLine("카운트 값은" + count + "입니다.");
            }
            do
            {
                Console.WriteLine("do while count" + count);
            } while (count < 100);

            int sum = 0;
            int sum2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    sum += i;

                // continue 이용
                if (i % 2 != 0)
                    continue;
                sum2 += i;
            }
            Console.WriteLine($"sum1 : {sum}");
            Console.WriteLine($"sum2 : {sum2}");


            // foreach
            Console.WriteLine("\n\n [foreach문] 전체 3명 출력");
            int z = 0;
            foreach (var item in names) // 배열, 문자열 순차적 출력
            {
                Console.WriteLine($"{z + 1}. {item} is human");
                z++;
            }

            Console.WriteLine("\n\n [foreach] 첫번째 사람은 출력 안하려고 할 때");
            int countIndex = 0;
            z = 0;
            foreach (var item in names) // 배열, 문자열 순차적 출력
            {
                z++;
                if (countIndex == 0) // 첫번째 사람은 출력 안하려고 할 때
                {
                    countIndex++;
                    continue;
                }
                Console.WriteLine($"{z}. {item} is human");
            }

            /* 실습, foreach를 for문으로 바꾸기 */
            Console.WriteLine("\n\n [for] 첫번째 사람은 출력 안하려고 할 때");
            for (int i = 0; i < names.Length; i++)
            {
                if (i == 0)
                    continue;

                Console.WriteLine($"{i + 1}. {names[i]} is human");
            }

            Console.WriteLine("\n [문제] 별 찍기 - 수업");

            // ▷ 모양
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine($"i : {i}");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // ◁ 모양
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write("-");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // △

            /*
             sss*
             ss***
             s*****
             */
            Console.WriteLine("\n [문제] 별 찍기 - 피라미드");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // ◇

            Console.WriteLine("\n [문제] 별 찍기 - 다이아몬드");
            for (int i = 0; i < 4; i++)                 // △
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(",");
                }
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write("*");
                }

                if (i == 0 || i == 1)
                    Console.WriteLine($"\t\ti: {i}");
                if (i == 2)
                    Console.WriteLine($"\ti: {i}");
                if (i == 3)
                    Console.WriteLine($"\ti: {i} ----------------");
            }

            for (int i = 5; i > 0; i--)                 // ▽
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(",");
                }
                for (int k = 0; k < (2 * i) - 1; k++)
                {
                    Console.Write("*");
                }
                if (i >= 3 && i <= 5)
                    Console.WriteLine($"\ti: {i}");
                else
                    Console.WriteLine($"\t\ti: {i}");
            }




            Console.WriteLine("\n [문제풀이 - 쌤] 별 찍기 - 다이아몬드");
            // ◁ 모양 코드
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    Console.Write("-");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n [문제풀이 - 쌤] 별 찍기 - 피라미드");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("-");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 4; i > 0; i--)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("-");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            // goto문

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\n외부 반복문 " + i);
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문 " + j);
                    goto Example;
                }
            }

        Example:
            Console.WriteLine("goto");

            /*string teacher = Console.ReadLine();
            if (teacher == "물범")
                goto Example;*/



            // Touppere, ToLower
            string example = "exAmPle";
            Console.WriteLine("\n대소문자 변경\n" + example.ToUpper());
            Console.WriteLine(example.ToLower());
            Console.WriteLine(example + "\n");

            example = example.ToUpper(); // 이렇게 해야 원본 바뀜

            //Split
            string hakseng = "가나다,자차파,정청컹,임짐침";
            string[] hkseng_array = hakseng.Split(',');

            foreach (var item in hkseng_array)
            {
                Console.WriteLine(item + "은 이름이다.");
            }
            Console.WriteLine();


            //Join - split의 반대 (하나의 string변수로 뭉침)
            string guys2 = string.Join(",", hkseng_array);
            Console.WriteLine(guys2);

            //Trim - 문자열 양 옆의 공백제거
            string trim = "                         가 나 다라  마          ";
            Console.WriteLine("!" + trim + "!");
            Console.WriteLine("!" + trim.Trim() + "!");

        }
    }
}

