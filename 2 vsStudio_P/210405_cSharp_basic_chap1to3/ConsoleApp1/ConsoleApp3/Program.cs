using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inch입력받아 cm단위 구하는 코드쓰기
            // 1Inch = 2.54cm
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine("1. 인치 -> cm");
            Console.WriteLine(inch * 2.54 + "cm");
            Console.WriteLine(string.Format("{0}cm", inch * 2.54));
            string example = string.Format($"나이 : {0}, 키 : {1}, 이름 : {2}", 10, 190, "이름");
            Console.WriteLine($"{inch * 2.54}cm\n");

            // 킬로그램 단위 입력받아 파운드 단위를 구하는 코드 작성
            Console.WriteLine("2. kg -> pound");
            double pound = double.Parse(Console.ReadLine());
            Console.WriteLine(pound * 2.20462262 + "pound\n");

            // 원의 반지름 입력받아
            // 원의 둘레, 넓이 구하기
            Console.WriteLine("3. 반지름 입력 원의 둘레, 넓이 구하기");
            double r = double.Parse(Console.ReadLine());
            const double PI = 3.14;
            Console.WriteLine($"둘레: {r * PI * 2}");
            Console.WriteLine($"넓이: {r * r * PI}\n");

            // 4번문제
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            Console.WriteLine(one * (two % 10)); //첫번째 숫자 곱하기 두번째 숫자의 1의 자리
            Console.WriteLine(one * (two % 100) / 10); //첫번째 숫자 곱하기 두번째 숫자의 10의 자리
            Console.WriteLine(one * (two / 100)); //첫번째 숫자 곱하기 두번째 숫자의 100의 자리
            Console.WriteLine(one * two); //첫번째 숫자 곱하기 두번째 숫자

            Console.WriteLine("\n 문제Re");
            //string sOne = one.ToString();
            string sTwo = two.ToString();

            //첫번째 숫자 곱하기 두번째 숫자의 1의 자리
            Console.WriteLine(one * int.Parse(sTwo[2].ToString()));
            Console.WriteLine(one * (sTwo[1]-'0'));
            Console.WriteLine(one * (sTwo[0]-'0')); // 아스키코드 영,숫,특문일부
        }
    }
}
