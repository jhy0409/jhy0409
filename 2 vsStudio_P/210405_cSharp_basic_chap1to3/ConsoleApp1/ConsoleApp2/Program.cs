using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본적으로 정수로 인식
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 / 2.0);
            Console.WriteLine(1.0 / 2);
            Console.WriteLine((double)1 / 2);

            // + - * / 나머지 연산자
            Console.WriteLine();
            Console.WriteLine(5 + 3);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 3);
            Console.WriteLine(5 / 3);
            Console.WriteLine(5 % 3);

            //연산 우선순위 사용자 지정 -> 괄호
            Console.WriteLine((5 + 3) * (5 - 2)); // *
            Console.WriteLine(5 + 3 * 5 - 2);     // **
            //원래 곱셈먼저** > (덧셈 뺄셈) 먼저 한 뒤 곱셈*

            // 문자 선택자
            Console.WriteLine("안녕하세요"[0]); // 안
            Console.WriteLine("안녕하세요"[4] + "\n"); // 요
            /*
            Console.WriteLine("안녕하세요"[5]); // Error!
            string insa = "안녕하세요";
            Console.WriteLine(insa.ElementAt<char>(0));
            */

            Console.WriteLine(Convert.ToString((int)"안녕하세요"[0], 16)); // 안
            Console.WriteLine('가' + '힣'); // 문자는 연산가능
            Console.WriteLine();

            Console.WriteLine(1 == 1);
            Console.WriteLine(1 != 1);

            bool result = true;
            bool result2 = false;
            Console.WriteLine("\n" + !result); // 논리 부정 연산자
            Console.WriteLine(!result2); // 논리 부정 연산자

            Console.WriteLine(string.Format("{0:#,0}", long.MaxValue));
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(1 + 1); // 기본적으로 숫자는 int로 인식, 소수점 : double

            int a = int.MaxValue;
            int b = int.MaxValue;
            Console.WriteLine(a + b); // overflow
            Console.WriteLine((long)a + b); // 정상적인 값 나옴, unsigned int 사용가능
            Console.WriteLine();

            uint c = int.MaxValue;
            uint d = int.MaxValue;
            Console.WriteLine(c + d);

            Console.WriteLine();
            Console.WriteLine(uint.MaxValue);

            int example = 100;
            Console.WriteLine(example++); // 100
            Console.WriteLine(++example); // 102

            int exex = 100;
            Console.WriteLine(exex); // ---------
            exex = exex + 1; // ---------

            exex = exex + 1; // --------- 
            Console.WriteLine(exex);
            Console.WriteLine();

            int conclusion = 100;
            // ++ 무조건 뒤에 붙이고 두줄로 나눠 쓰기
            conclusion++; // 1증가
            Console.WriteLine(conclusion); // 그 값 출력
            conclusion++;
            Console.WriteLine(conclusion);

            /*
            Console.Write("문자를 입력 : ");
            string input = Console.ReadLine();  // 입력받기
            Console.WriteLine("입력문자는 " + input + "이다");
            Console.WriteLine($"입력문자는 {input}이다");

            // 숫자 입력받기
            int number = int.Parse(Console.ReadLine()); //정수
            double num = double.Parse(Console.ReadLine()); //실수

            Console.WriteLine(number / num);
            */

            
            string line = "--------------------------------";



            // 1. Inch 입력받아 cm 단위 구하는 코드 작성
            Console.Write("\n\n1. 인치를 입력 : ");
            double inch = double.Parse(Console.ReadLine());
            double cmNum = inch * 2.54;
            Console.WriteLine($"{line}\n센티미터 환산 1inch = 2.54\n" +
                $"입력인치\t: {inch} inch\n" +
                $"cm환산\t\t: {cmNum} cm\n{line}\n");

            // 2. kg단위 입력 pound단위 구하는 코드
            Console.Write("\n\n2. kg를 pound로 : ");
            double kg = double.Parse(Console.ReadLine());
            double pound = kg * 2.20462262;
            Console.WriteLine($"{line}\n파운드 환산 1kg = 2.20462262pound\n" +
                $"입력kg\t\t: {kg} kg\n" +
                $"환산pound\t: {pound} pound\n{line}\n");


            // 3. 원 반지름 입력받아 원둘레 넓이 구하는 코드 작성
            Console.Write("\n\n3. 원 반지름 입력 : ");
            int circleR = int.Parse(Console.ReadLine());
            const double PI = 3.14;
            double oneDule = circleR * 2 * PI;
            double oneNulbi = circleR * circleR * PI;
            Console.WriteLine($"{line}\n- 원둘레 : {oneDule}\n" +
                $"- 원넓이 : {oneNulbi}\n{line}\n");

            // 4-1. 472 * 385 
            Console.Write("첫번째 수 : ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("두번째 수 : ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n4-1. {i} * {j}\n{line}");
            Console.WriteLine($"    {i}\t(1)\n × {j}\t(2)\n{line}");
            Console.WriteLine($"  {i * (j % 10)}\t(3)");        // 5
            Console.WriteLine($" {i * (j % 100 / 10)}\t(4)");   // 8
            Console.WriteLine($"{i * (j / 100)}\t(5)\n{line}"); // 3
            Console.WriteLine($"{i * j}\t(6)\n\n");



            // 4-2. 472 * 385 
            string str = j.ToString();
            int j0 = int.Parse(str[str.Length - 3].ToString());
            int j1 = int.Parse(str[str.Length - 2].ToString());
            int j2 = int.Parse(str[str.Length - 1].ToString());
            Console.WriteLine($"\n4-2. {i} * {j}\n{line}");
            Console.WriteLine($"    {i}\t(1)\n × {j}\t(2)\n{line}");
            Console.WriteLine($"  {i*j2}\t(3)");
            Console.WriteLine($" {i*j1}\t(4)");
            Console.WriteLine($"{i*j0}\t(5)\n{line}");
            Console.WriteLine($"{i*j}\t(6)");
        }
    }
}
